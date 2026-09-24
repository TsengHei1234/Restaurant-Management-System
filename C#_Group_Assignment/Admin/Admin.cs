using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace C__Group_Assignment.Admin
{
    internal sealed class AdminUserData
    {
        public string UserID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string SecurityAnswer { get; set; }
    }

    internal static class AdminUserInput
    {
        public static string Validate(AdminUserData user, string expectedRole, string idPattern, string idExample)
        {
            if (user == null ||
                string.IsNullOrWhiteSpace(user.UserID) ||
                string.IsNullOrWhiteSpace(user.Username) ||
                string.IsNullOrWhiteSpace(user.Email) ||
                string.IsNullOrWhiteSpace(user.Password) ||
                string.IsNullOrWhiteSpace(user.SecurityAnswer))
            {
                return "Please fill in all fields.";
            }

            if (!Regex.IsMatch(user.UserID.Trim(), idPattern, RegexOptions.IgnoreCase))
            {
                return $"The user ID must use the format {idExample}.";
            }

            if (!string.Equals(user.Role, expectedRole, StringComparison.OrdinalIgnoreCase))
            {
                return $"The role must be {expectedRole}.";
            }

            try
            {
                MailAddress address = new MailAddress(user.Email.Trim());
                if (!string.Equals(address.Address, user.Email.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    return "Please enter a valid email address.";
                }
            }
            catch (FormatException)
            {
                return "Please enter a valid email address.";
            }

            return null;
        }

        public static AdminUserData Normalize(AdminUserData user, string expectedRole)
        {
            user.UserID = user.UserID.Trim().ToUpperInvariant();
            user.Username = user.Username.Trim();
            user.Email = user.Email.Trim();
            user.Role = expectedRole;
            user.SecurityAnswer = user.SecurityAnswer.Trim();
            return user;
        }
    }

    internal sealed class AdminUserService
    {
        private readonly string connectionString;

        public AdminUserService()
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["myCS"];
            if (settings == null || string.IsNullOrWhiteSpace(settings.ConnectionString))
            {
                throw new InvalidOperationException("The myCS database connection is not configured.");
            }

            connectionString = settings.ConnectionString;
        }

        public DataTable LoadUsers(string role)
        {
            const string query = @"SELECT UserID, Username, Email, Password, Role, SecurityAnswer
                                   FROM Users
                                   WHERE Role = @Role
                                   ORDER BY UserID;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.Add("@Role", SqlDbType.NVarChar, 20).Value = role;
                DataTable users = new DataTable();
                adapter.Fill(users);
                return users;
            }
        }

        public void InsertUser(AdminUserData user)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction(IsolationLevel.Serializable))
                {
                    EnsureUnique(connection, transaction, user, null);

                    const string insertUser = @"INSERT INTO Users
                                                (UserID, Username, Email, Password, Role, SecurityAnswer)
                                                VALUES
                                                (@UserID, @Username, @Email, @Password, @Role, @SecurityAnswer);";
                    using (SqlCommand command = CreateUserCommand(insertUser, connection, transaction, user))
                    {
                        command.ExecuteNonQuery();
                    }

                    if (string.Equals(user.Role, "Customer", StringComparison.OrdinalIgnoreCase))
                    {
                        const string insertCustomer = @"INSERT INTO Customer (CustomerID, Username)
                                                        VALUES (@CustomerID, @Username);";
                        using (SqlCommand command = new SqlCommand(insertCustomer, connection, transaction))
                        {
                            command.Parameters.Add("@CustomerID", SqlDbType.NVarChar, 50).Value = user.UserID;
                            command.Parameters.Add("@Username", SqlDbType.NVarChar, 50).Value = user.Username;
                            command.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                }
            }
        }

        public void UpdateUser(string originalUserID, AdminUserData user)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction(IsolationLevel.Serializable))
                {
                    EnsureUserExists(connection, transaction, originalUserID, user.Role);
                    EnsureUnique(connection, transaction, user, originalUserID);

                    const string updateUser = @"UPDATE Users
                                                SET UserID = @UserID,
                                                    Username = @Username,
                                                    Email = @Email,
                                                    Password = @Password,
                                                    Role = @Role,
                                                    SecurityAnswer = @SecurityAnswer
                                                WHERE UserID = @OriginalUserID;";
                    using (SqlCommand command = CreateUserCommand(updateUser, connection, transaction, user))
                    {
                        command.Parameters.Add("@OriginalUserID", SqlDbType.NVarChar, 50).Value = originalUserID;
                        command.ExecuteNonQuery();
                    }

                    if (string.Equals(user.Role, "Customer", StringComparison.OrdinalIgnoreCase))
                    {
                        SynchronizeCustomerIdentity(connection, transaction, originalUserID, user);
                    }
                    else if (string.Equals(user.Role, "Chef", StringComparison.OrdinalIgnoreCase) &&
                             !string.Equals(originalUserID, user.UserID, StringComparison.OrdinalIgnoreCase))
                    {
                        ExecuteIdentityUpdate(connection, transaction, "OrderDetails", "ChefID", originalUserID, user.UserID);
                    }

                    transaction.Commit();
                }
            }
        }

        public bool DeleteUser(string userID, string role)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction(IsolationLevel.Serializable))
                {
                    if (!UserExists(connection, transaction, userID, role))
                    {
                        transaction.Rollback();
                        return false;
                    }

                    if (string.Equals(role, "Customer", StringComparison.OrdinalIgnoreCase))
                    {
                        if (CustomerHasHistory(connection, transaction, userID))
                        {
                            throw new InvalidOperationException("This customer has order, reservation, or feedback history and cannot be deleted safely.");
                        }

                        using (SqlCommand command = new SqlCommand("DELETE FROM Customer WHERE CustomerID = @UserID;", connection, transaction))
                        {
                            command.Parameters.Add("@UserID", SqlDbType.NVarChar, 50).Value = userID;
                            command.ExecuteNonQuery();
                        }
                    }
                    else if (string.Equals(role, "Chef", StringComparison.OrdinalIgnoreCase) && ChefHasHistory(connection, transaction, userID))
                    {
                        throw new InvalidOperationException("This chef has order history and cannot be deleted safely.");
                    }

                    using (SqlCommand command = new SqlCommand("DELETE FROM Users WHERE UserID = @UserID AND Role = @Role;", connection, transaction))
                    {
                        command.Parameters.Add("@UserID", SqlDbType.NVarChar, 50).Value = userID;
                        command.Parameters.Add("@Role", SqlDbType.NVarChar, 20).Value = role;
                        bool deleted = command.ExecuteNonQuery() == 1;
                        transaction.Commit();
                        return deleted;
                    }
                }
            }
        }

        private static SqlCommand CreateUserCommand(string query, SqlConnection connection, SqlTransaction transaction, AdminUserData user)
        {
            SqlCommand command = new SqlCommand(query, connection, transaction);
            command.Parameters.Add("@UserID", SqlDbType.NVarChar, 50).Value = user.UserID;
            command.Parameters.Add("@Username", SqlDbType.NVarChar, 50).Value = user.Username;
            command.Parameters.Add("@Email", SqlDbType.NVarChar, 100).Value = user.Email;
            command.Parameters.Add("@Password", SqlDbType.NVarChar, 100).Value = user.Password;
            command.Parameters.Add("@Role", SqlDbType.NVarChar, 20).Value = user.Role;
            command.Parameters.Add("@SecurityAnswer", SqlDbType.NVarChar, 100).Value = user.SecurityAnswer;
            return command;
        }

        private static void EnsureUnique(SqlConnection connection, SqlTransaction transaction, AdminUserData user, string originalUserID)
        {
            const string query = @"SELECT COUNT(*)
                                   FROM Users WITH (UPDLOCK, HOLDLOCK)
                                   WHERE (UserID = @UserID OR Username = @Username OR Email = @Email)
                                     AND (@OriginalUserID IS NULL OR UserID <> @OriginalUserID);";
            using (SqlCommand command = new SqlCommand(query, connection, transaction))
            {
                command.Parameters.Add("@UserID", SqlDbType.NVarChar, 50).Value = user.UserID;
                command.Parameters.Add("@Username", SqlDbType.NVarChar, 50).Value = user.Username;
                command.Parameters.Add("@Email", SqlDbType.NVarChar, 100).Value = user.Email;
                command.Parameters.Add("@OriginalUserID", SqlDbType.NVarChar, 50).Value = (object)originalUserID ?? DBNull.Value;
                if (Convert.ToInt32(command.ExecuteScalar()) > 0)
                {
                    throw new InvalidOperationException("The user ID, username, or email is already in use.");
                }
            }
        }

        private static void EnsureUserExists(SqlConnection connection, SqlTransaction transaction, string userID, string role)
        {
            if (!UserExists(connection, transaction, userID, role))
            {
                throw new InvalidOperationException($"No {role} account with user ID {userID} was found.");
            }
        }

        private static bool UserExists(SqlConnection connection, SqlTransaction transaction, string userID, string role)
        {
            const string query = "SELECT COUNT(*) FROM Users WHERE UserID = @UserID AND Role = @Role;";
            using (SqlCommand command = new SqlCommand(query, connection, transaction))
            {
                command.Parameters.Add("@UserID", SqlDbType.NVarChar, 50).Value = userID;
                command.Parameters.Add("@Role", SqlDbType.NVarChar, 20).Value = role;
                return Convert.ToInt32(command.ExecuteScalar()) == 1;
            }
        }

        private static void SynchronizeCustomerIdentity(SqlConnection connection, SqlTransaction transaction, string originalUserID, AdminUserData user)
        {
            const string synchronizeCustomer = @"IF EXISTS (SELECT 1 FROM Customer WHERE CustomerID = @OriginalUserID)
                                                     UPDATE Customer
                                                     SET CustomerID = @UserID, Username = @Username
                                                     WHERE CustomerID = @OriginalUserID;
                                                 ELSE
                                                     INSERT Customer (CustomerID, Username)
                                                     VALUES (@UserID, @Username);";
            using (SqlCommand command = new SqlCommand(synchronizeCustomer, connection, transaction))
            {
                command.Parameters.Add("@OriginalUserID", SqlDbType.NVarChar, 50).Value = originalUserID;
                command.Parameters.Add("@UserID", SqlDbType.NVarChar, 50).Value = user.UserID;
                command.Parameters.Add("@Username", SqlDbType.NVarChar, 50).Value = user.Username;
                command.ExecuteNonQuery();
            }

            if (!string.Equals(originalUserID, user.UserID, StringComparison.OrdinalIgnoreCase))
            {
                ExecuteIdentityUpdate(connection, transaction, "Orders", "CustomerID", originalUserID, user.UserID);
                ExecuteIdentityUpdate(connection, transaction, "Reservation", "CustomerID", originalUserID, user.UserID);
                ExecuteIdentityUpdate(connection, transaction, "Feedback", "CustomerID", originalUserID, user.UserID);
            }
        }

        private static void ExecuteIdentityUpdate(SqlConnection connection, SqlTransaction transaction, string table, string column, string oldValue, string newValue)
        {
            string query = $"UPDATE [{table}] SET [{column}] = @NewValue WHERE [{column}] = @OldValue;";
            using (SqlCommand command = new SqlCommand(query, connection, transaction))
            {
                command.Parameters.Add("@NewValue", SqlDbType.NVarChar, 50).Value = newValue;
                command.Parameters.Add("@OldValue", SqlDbType.NVarChar, 50).Value = oldValue;
                command.ExecuteNonQuery();
            }
        }

        private static bool CustomerHasHistory(SqlConnection connection, SqlTransaction transaction, string customerID)
        {
            const string query = @"SELECT
                                       (SELECT COUNT(*) FROM Orders WHERE CustomerID = @CustomerID) +
                                       (SELECT COUNT(*) FROM Reservation WHERE CustomerID = @CustomerID) +
                                       (SELECT COUNT(*) FROM Feedback WHERE CustomerID = @CustomerID);";
            using (SqlCommand command = new SqlCommand(query, connection, transaction))
            {
                command.Parameters.Add("@CustomerID", SqlDbType.NVarChar, 50).Value = customerID;
                return Convert.ToInt32(command.ExecuteScalar()) > 0;
            }
        }

        private static bool ChefHasHistory(SqlConnection connection, SqlTransaction transaction, string chefID)
        {
            using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM OrderDetails WHERE ChefID = @ChefID;", connection, transaction))
            {
                command.Parameters.Add("@ChefID", SqlDbType.NVarChar, 50).Value = chefID;
                return Convert.ToInt32(command.ExecuteScalar()) > 0;
            }
        }
    }
}
