using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace C__Group_Assignment.Manager
{
    internal sealed class FoodRecord
    {
        public string FoodID { get; set; }
        public string FoodName { get; set; }
        public string FoodImage { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public string FoodStatus { get; set; }
    }

    internal sealed class ReservationRecord
    {
        public string ReservationID { get; set; }
        public string CustomerID { get; set; }
        public DateTime ReservationDateTime { get; set; }
        public int PeopleAmount { get; set; }
        public string ReservationType { get; set; }
        public string Venue { get; set; }
        public string Status { get; set; }
        public string Feedback { get; set; }
    }

    internal sealed class ManagerService
    {
        private readonly string connectionString;

        public ManagerService()
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["myCS"];
            if (settings == null || string.IsNullOrWhiteSpace(settings.ConnectionString))
            {
                throw new InvalidOperationException("The myCS database connection is not configured.");
            }
            connectionString = settings.ConnectionString;
        }

        public DataTable LoadFoods()
        {
            return Fill(@"SELECT FoodID, FoodName, FoodImage, Category, Price, FoodStatus
                          FROM Food ORDER BY FoodName;");
        }

        public FoodRecord GetFood(string foodID)
        {
            const string query = @"SELECT FoodID, FoodName, FoodImage, Category, Price, FoodStatus
                                   FROM Food WHERE FoodID = @FoodID;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@FoodID", SqlDbType.NVarChar, 50).Value = foodID;
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (!reader.Read()) return null;
                    return new FoodRecord
                    {
                        FoodID = reader.GetString(0),
                        FoodName = reader.GetString(1),
                        FoodImage = reader.IsDBNull(2) ? null : reader.GetString(2),
                        Category = reader.GetString(3),
                        Price = Convert.ToDecimal(reader["Price"]),
                        FoodStatus = reader.GetString(5)
                    };
                }
            }
        }

        public string AddFood(FoodRecord food)
        {
            ValidateFood(food);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction(IsolationLevel.Serializable))
                {
                    EnsureFoodNameUnique(connection, transaction, food.FoodName, null);
                    string foodID = NextID(connection, transaction, "Food", "FoodID", "F");
                    const string insert = @"INSERT INTO Food
                        (FoodID, FoodName, FoodImage, Category, Price, FoodStatus)
                        VALUES (@FoodID, @FoodName, @FoodImage, @Category, @Price, @FoodStatus);";
                    using (SqlCommand command = CreateFoodCommand(insert, connection, transaction, food))
                    {
                        command.Parameters.Add("@FoodID", SqlDbType.NVarChar, 50).Value = foodID;
                        command.ExecuteNonQuery();
                    }
                    transaction.Commit();
                    return foodID;
                }
            }
        }

        public void UpdateFood(string foodID, FoodRecord food)
        {
            ValidateFood(food);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction(IsolationLevel.Serializable))
                {
                    EnsureFoodNameUnique(connection, transaction, food.FoodName, foodID);
                    const string update = @"UPDATE Food SET FoodName=@FoodName, FoodImage=@FoodImage,
                        Category=@Category, Price=@Price, FoodStatus=@FoodStatus WHERE FoodID=@FoodID;";
                    using (SqlCommand command = CreateFoodCommand(update, connection, transaction, food))
                    {
                        command.Parameters.Add("@FoodID", SqlDbType.NVarChar, 50).Value = foodID;
                        if (command.ExecuteNonQuery() != 1)
                            throw new InvalidOperationException("The selected menu item no longer exists.");
                    }
                    transaction.Commit();
                }
            }
        }

        public void DeleteFood(string foodID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction(IsolationLevel.Serializable))
                {
                    using (SqlCommand history = new SqlCommand("SELECT COUNT(*) FROM OrderDetails WHERE FoodID=@FoodID;", connection, transaction))
                    {
                        history.Parameters.Add("@FoodID", SqlDbType.NVarChar, 50).Value = foodID;
                        if (Convert.ToInt32(history.ExecuteScalar()) > 0)
                            throw new InvalidOperationException("This item has order history. Mark it Unavailable instead of deleting it.");
                    }
                    using (SqlCommand links = new SqlCommand("DELETE FROM FoodIngredients WHERE FoodID=@FoodID;", connection, transaction))
                    {
                        links.Parameters.Add("@FoodID", SqlDbType.NVarChar, 50).Value = foodID;
                        links.ExecuteNonQuery();
                    }
                    using (SqlCommand delete = new SqlCommand("DELETE FROM Food WHERE FoodID=@FoodID;", connection, transaction))
                    {
                        delete.Parameters.Add("@FoodID", SqlDbType.NVarChar, 50).Value = foodID;
                        if (delete.ExecuteNonQuery() != 1)
                            throw new InvalidOperationException("The selected menu item no longer exists.");
                    }
                    transaction.Commit();
                }
            }
        }

        public DataTable LoadReservations()
        {
            return Fill(@"SELECT ReservationID, CustomerID, ReservationDateTime,
                          ReservationPeopleAmount, ReservationType, ReservationVenue,
                          ReservationStatus, ReservationFeedback
                          FROM Reservation ORDER BY ReservationDateTime DESC;");
        }

        public ReservationRecord GetReservation(string reservationID)
        {
            const string query = @"SELECT ReservationID, CustomerID, ReservationDateTime,
                ReservationPeopleAmount, ReservationType, ReservationVenue,
                ReservationStatus, ReservationFeedback
                FROM Reservation WHERE ReservationID=@ReservationID;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@ReservationID", SqlDbType.NVarChar, 50).Value = reservationID;
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (!reader.Read()) return null;
                    return new ReservationRecord
                    {
                        ReservationID = reader.GetString(0), CustomerID = reader.GetString(1),
                        ReservationDateTime = reader.GetDateTime(2), PeopleAmount = reader.GetInt32(3),
                        ReservationType = reader.GetString(4), Venue = reader.IsDBNull(5) ? null : reader.GetString(5),
                        Status = reader.GetString(6), Feedback = reader.GetString(7)
                    };
                }
            }
        }

        public string AddReservation(ReservationRecord reservation)
        {
            ValidateReservation(reservation);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction(IsolationLevel.Serializable))
                {
                    EnsureCustomer(connection, transaction, reservation.CustomerID);
                    EnsureVenueAvailable(connection, transaction, reservation.ReservationDateTime, reservation.Venue, null);
                    string reservationID = NextID(connection, transaction, "Reservation", "ReservationID", "R");
                    const string insert = @"INSERT INTO Reservation
                        (ReservationID, CustomerID, ReservationDateTime, ReservationPeopleAmount,
                         ReservationType, ReservationStatus, ReservationVenue, ReservationFeedback)
                        VALUES (@ReservationID, @CustomerID, @DateTime, @People, @Type,
                                @Status, @Venue, @Feedback);";
                    using (SqlCommand command = CreateReservationCommand(insert, connection, transaction, reservation))
                    {
                        command.Parameters.Add("@ReservationID", SqlDbType.NVarChar, 50).Value = reservationID;
                        command.ExecuteNonQuery();
                    }
                    transaction.Commit();
                    return reservationID;
                }
            }
        }

        public void UpdateReservation(string reservationID, ReservationRecord reservation)
        {
            ValidateReservation(reservation);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction(IsolationLevel.Serializable))
                {
                    EnsureCustomer(connection, transaction, reservation.CustomerID);
                    EnsureVenueAvailable(connection, transaction, reservation.ReservationDateTime, reservation.Venue, reservationID);
                    const string update = @"UPDATE Reservation SET CustomerID=@CustomerID,
                        ReservationDateTime=@DateTime, ReservationPeopleAmount=@People,
                        ReservationType=@Type, ReservationStatus=@Status,
                        ReservationVenue=@Venue, ReservationFeedback=@Feedback
                        WHERE ReservationID=@ReservationID;";
                    using (SqlCommand command = CreateReservationCommand(update, connection, transaction, reservation))
                    {
                        command.Parameters.Add("@ReservationID", SqlDbType.NVarChar, 50).Value = reservationID;
                        if (command.ExecuteNonQuery() != 1)
                            throw new InvalidOperationException("The selected reservation no longer exists.");
                    }
                    transaction.Commit();
                }
            }
        }

        public bool RejectReservation(string reservationID)
        {
            const string query = @"UPDATE Reservation SET ReservationStatus='Rejected'
                                   WHERE ReservationID=@ReservationID AND ReservationStatus<>'Completed';";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@ReservationID", SqlDbType.NVarChar, 50).Value = reservationID;
                connection.Open();
                return command.ExecuteNonQuery() == 1;
            }
        }

        public DataTable LoadReservationReport() { return LoadReservations(); }

        private DataTable Fill(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        private static SqlCommand CreateFoodCommand(string query, SqlConnection connection, SqlTransaction transaction, FoodRecord food)
        {
            SqlCommand command = new SqlCommand(query, connection, transaction);
            command.Parameters.Add("@FoodName", SqlDbType.NVarChar, 100).Value = food.FoodName.Trim();
            command.Parameters.Add("@FoodImage", SqlDbType.NVarChar, 50).Value = (object)food.FoodImage ?? DBNull.Value;
            command.Parameters.Add("@Category", SqlDbType.NVarChar, 50).Value = food.Category.Trim();
            command.Parameters.Add("@Price", SqlDbType.Int).Value = decimal.ToInt32(food.Price);
            command.Parameters.Add("@FoodStatus", SqlDbType.NVarChar, 50).Value = food.FoodStatus;
            return command;
        }

        private static SqlCommand CreateReservationCommand(string query, SqlConnection connection, SqlTransaction transaction, ReservationRecord reservation)
        {
            SqlCommand command = new SqlCommand(query, connection, transaction);
            command.Parameters.Add("@CustomerID", SqlDbType.NVarChar, 50).Value = reservation.CustomerID.Trim();
            command.Parameters.Add("@DateTime", SqlDbType.DateTime).Value = reservation.ReservationDateTime;
            command.Parameters.Add("@People", SqlDbType.Int).Value = reservation.PeopleAmount;
            command.Parameters.Add("@Type", SqlDbType.NVarChar, 50).Value = reservation.ReservationType;
            command.Parameters.Add("@Status", SqlDbType.NVarChar, 50).Value = reservation.Status;
            command.Parameters.Add("@Venue", SqlDbType.NVarChar, 50).Value = reservation.Venue;
            command.Parameters.Add("@Feedback", SqlDbType.NVarChar, 50).Value = reservation.Feedback;
            return command;
        }

        private static void ValidateFood(FoodRecord food)
        {
            if (food == null || string.IsNullOrWhiteSpace(food.FoodName) || string.IsNullOrWhiteSpace(food.Category))
                throw new InvalidOperationException("Item name and category are required.");
            if (food.Price < 0 || food.Price != decimal.Truncate(food.Price))
                throw new InvalidOperationException("Price must be a non-negative whole number.");
            if (food.FoodStatus != "Available" && food.FoodStatus != "Unavailable")
                throw new InvalidOperationException("Choose whether the item is Available or Unavailable.");
        }

        private static void ValidateReservation(ReservationRecord reservation)
        {
            if (reservation == null || string.IsNullOrWhiteSpace(reservation.CustomerID) ||
                string.IsNullOrWhiteSpace(reservation.ReservationType) || string.IsNullOrWhiteSpace(reservation.Venue))
                throw new InvalidOperationException("Customer, type, and venue are required.");
            if (reservation.PeopleAmount <= 0)
                throw new InvalidOperationException("The number of guests must be greater than zero.");
        }

        private static void EnsureFoodNameUnique(SqlConnection connection, SqlTransaction transaction, string name, string excludedID)
        {
            const string query = @"SELECT COUNT(*) FROM Food WITH (UPDLOCK, HOLDLOCK)
                WHERE FoodName=@FoodName AND (@ExcludedID IS NULL OR FoodID<>@ExcludedID);";
            using (SqlCommand command = new SqlCommand(query, connection, transaction))
            {
                command.Parameters.Add("@FoodName", SqlDbType.NVarChar, 100).Value = name.Trim();
                command.Parameters.Add("@ExcludedID", SqlDbType.NVarChar, 50).Value = (object)excludedID ?? DBNull.Value;
                if (Convert.ToInt32(command.ExecuteScalar()) > 0)
                    throw new InvalidOperationException("A menu item with this name already exists.");
            }
        }

        private static void EnsureCustomer(SqlConnection connection, SqlTransaction transaction, string customerID)
        {
            using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Customer WHERE CustomerID=@CustomerID;", connection, transaction))
            {
                command.Parameters.Add("@CustomerID", SqlDbType.NVarChar, 50).Value = customerID.Trim();
                if (Convert.ToInt32(command.ExecuteScalar()) != 1)
                    throw new InvalidOperationException("The customer ID does not exist.");
            }
        }

        private static void EnsureVenueAvailable(SqlConnection connection, SqlTransaction transaction, DateTime dateTime, string venue, string excludedID)
        {
            const string query = @"SELECT COUNT(*) FROM Reservation WITH (UPDLOCK, HOLDLOCK)
                WHERE ReservationDateTime=@DateTime AND ReservationVenue=@Venue
                  AND ReservationStatus<>'Rejected'
                  AND (@ExcludedID IS NULL OR ReservationID<>@ExcludedID);";
            using (SqlCommand command = new SqlCommand(query, connection, transaction))
            {
                command.Parameters.Add("@DateTime", SqlDbType.DateTime).Value = dateTime;
                command.Parameters.Add("@Venue", SqlDbType.NVarChar, 50).Value = venue;
                command.Parameters.Add("@ExcludedID", SqlDbType.NVarChar, 50).Value = (object)excludedID ?? DBNull.Value;
                if (Convert.ToInt32(command.ExecuteScalar()) > 0)
                    throw new InvalidOperationException("The venue is already occupied at that time.");
            }
        }

        private static string NextID(SqlConnection connection, SqlTransaction transaction, string table, string column, string prefix)
        {
            string query = $@"SELECT ISNULL(MAX(TRY_CONVERT(int, SUBSTRING([{column}], 2, 20))), 0)
                              FROM [{table}] WITH (UPDLOCK, HOLDLOCK)
                              WHERE [{column}] LIKE @Prefix + '%';";
            using (SqlCommand command = new SqlCommand(query, connection, transaction))
            {
                command.Parameters.Add("@Prefix", SqlDbType.NVarChar, 10).Value = prefix;
                int next = Convert.ToInt32(command.ExecuteScalar()) + 1;
                return prefix + next.ToString("D3");
            }
        }
    }
}
