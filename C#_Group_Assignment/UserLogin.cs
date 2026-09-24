using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace C__Group_Assignment
{
    internal class UserLogin
    {
        public string[] Login(string username, string password)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
                {
                    con.Open();
                    const string query = @"SELECT TOP (1) UserID, Username, Role
                                           FROM Users
                                           WHERE (Username = @Username OR Email = @Username)
                                             AND Password = @Password;";

                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                return null;
                            }

                            return new[]
                            {
                                reader["UserID"].ToString(),
                                reader["Username"].ToString(),
                                reader["Role"].ToString()
                            };
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"An error occurred during login: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
   
        }

        public void redirect_user(string userID, string userName, string userRole)
        {
            string normalizedRole = (userRole ?? string.Empty).Trim();
            UserSession.Start(userID, userName, normalizedRole);

            switch (normalizedRole.ToUpperInvariant())
            {
                case "ADMIN":
                    new frmAdmin().Show();
                    break;
                case "MANAGER":
                    new frmManager().Show();
                    break;
                case "CHEF":
                    new frmChef().Show();
                    break;
                case "CUSTOMER":
                    new Customer(userID, userName, SetDateTime.CurrentDateTime, normalizedRole);
                    new frmCustomer().Show();
                    break;
                default:
                    UserSession.Clear();
                    MessageBox.Show("This account does not have a supported role.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }
    }
}
