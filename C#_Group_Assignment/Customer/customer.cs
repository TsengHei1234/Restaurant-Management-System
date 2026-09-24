using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace C__Group_Assignment
{
    class Customer
    {
        public Customer()
        {

        }

        public Customer(string customerID, string customerName, DateTime dateTime, string Role)
        {
            CustomerID = customerID;
            CustomerName = customerName;
            CurrentDateTime = dateTime;
            
        }

        public static string CustomerID { get; set; }

        public static string CustomerName { get; set; }

        public static DateTime CurrentDateTime { get; set; }

        public static string CustomerDineInMethod { get; set; } = "Idle"; // Walk-In or Reservation

        public static string CustomerOrderTable { get; set; } = "None";//walk in table //venue for reservation is Hall

        public static string ReservationID { get; set; }    // only for reservation

        public static string CustomerReservationType { get; set; } // only for reservation for Graduation etc


        // Check Existing Orders Or Reservation

        public string HasExistingOrderOrReservation()   // start customer form check if got existing order a not
        {
            bool ExistingOrder = false;
            bool ExistingReservation = false;

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            string orderQuery = @"Select COUNT(*) From Orders 
                                  Where CustomerID = @CustomerID And OrderDate = @CurrentDateTime And OrderStatus = 'Ongoing'";

            SqlCommand checkExistingOrdercmd = new SqlCommand(orderQuery, con);
            checkExistingOrdercmd.Parameters.AddWithValue("@CustomerID", CustomerID);
            checkExistingOrdercmd.Parameters.AddWithValue("@CurrentDateTime", CurrentDateTime);
            int orderCount = Convert.ToInt32(checkExistingOrdercmd.ExecuteScalar());
            if (orderCount > 0)
            {
                ExistingOrder = true;
            }

            string reservationQuery = @"Select COUNT(*) From Reservation
                                        Where CustomerID = @CustomerID And ReservationDateTime = @CurrentDateTime And ReservationStatus = 'Ongoing'";

            SqlCommand checkExistingReservationcmd = new SqlCommand(reservationQuery, con);
            checkExistingReservationcmd.Parameters.AddWithValue("@CustomerID", CustomerID);
            checkExistingReservationcmd.Parameters.AddWithValue("@CurrentDateTime", CurrentDateTime);
            int reservationCount = Convert.ToInt32(checkExistingReservationcmd.ExecuteScalar());
            if (reservationCount > 0)
            {
                ExistingReservation = true;
            }
            con.Close();

            if (ExistingReservation && ExistingOrder)
            {
                return "Reservation";
            }
            else if (ExistingOrder && !ExistingReservation)
            {
                return "WalkIn";
            }
            else
            {
                return null;
            }
        }

        public void ReadOngoingOrderDetails()   // Check Ongoing Existing Detals for Order Table
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            string query = @"Select OrderTable From Orders 
                             Where CustomerID = @CustomerID
                             And OrderDate = @CurrentDate 
                             And OrderStatus = 'Ongoing'";

            SqlCommand readOrderDetailscmd = new SqlCommand(query, con);
            readOrderDetailscmd.Parameters.AddWithValue("@CustomerID", CustomerID);
            readOrderDetailscmd.Parameters.AddWithValue("@CurrentDate", CurrentDateTime);

            SqlDataReader reader = readOrderDetailscmd.ExecuteReader();
            if (reader.Read())
            {
                CustomerOrderTable = reader["OrderTable"].ToString();
                CustomerDineInMethod = "Walk-In";
            }

            con.Close();
        }

        public void ReadOngoingReservation()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            string query = @"Select ReservationID, ReservationType, ReservationVenue From Reservation
                             Where CustomerID = @CustomerID
                             And ReservationDateTime = @CurrentDateTime 
                             And ReservationStatus = 'Ongoing'";

            SqlCommand readReservationDetailscmd = new SqlCommand(query, con);
            readReservationDetailscmd.Parameters.AddWithValue("@CustomerID", CustomerID);
            readReservationDetailscmd.Parameters.AddWithValue("@CurrentDateTime", CurrentDateTime);

            SqlDataReader reader = readReservationDetailscmd.ExecuteReader();
            if (reader.Read())
            {
                ReservationID = reader["ReservationID"].ToString();
                CustomerReservationType = reader["ReservationType"].ToString();
                CustomerOrderTable = reader["ReservationVenue"].ToString();
                CustomerDineInMethod = "Reservation";
            }
            con.Close();
        }

        // Dine-In Method Page

        public List<DateTime> LoadReservationDates()    //Load Reservation Dates
        {
            List<DateTime> reservationDates = new List<DateTime>();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            string query = @"SELECT ReservationDateTime FROM Reservation
                             WHERE CustomerID = @CustomerID AND ReservationDateTime = @CurrentDateTime AND ReservationStatus = 'Successful'";

            SqlCommand LoadReservationDatescmd = new SqlCommand(query, con);
            LoadReservationDatescmd.Parameters.AddWithValue("@CustomerID", CustomerID);
            LoadReservationDatescmd.Parameters.AddWithValue("@CurrentDateTime", CurrentDateTime);

            SqlDataReader reader = LoadReservationDatescmd.ExecuteReader();
            while (reader.Read())
            {
                DateTime reservationDate = reader.GetDateTime(0);
                reservationDates.Add(reservationDate);
            }
            con.Close();
            return reservationDates;
        }

        public DataRow LoadReservationDetails(DateTime selectedDate)    // Load Reservation Details
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            string query = @"Select ReservationID, ReservationType, ReservationPeopleAmount, ReservationVenue
                             From Reservation
                             Where CustomerID = @CustomerID And ReservationStatus = 'Successful' And ReservationDateTime = @SelectedDate";

            SqlCommand reservationDetailscmd = new SqlCommand(query, con);
            reservationDetailscmd.Parameters.AddWithValue("@CustomerID", CustomerID);
            reservationDetailscmd.Parameters.AddWithValue("@SelectedDate", selectedDate);

            DataTable reservationDetailsTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(reservationDetailscmd);
            adapter.Fill(reservationDetailsTable);

            if (reservationDetailsTable.Rows.Count > 0)
            {
                return reservationDetailsTable.Rows[0];
            }
            else
            {
                return null;
            }
        }

        public List<string> GetOccupiedTables()
        {
            List<string> occupiedTables = new List<string>();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            string query = @"SELECT OrderTable FROM Orders 
                            WHERE OrderDate = @CurrentDateTime AND OrderStatus = 'Ongoing'";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@CurrentDateTime", CurrentDateTime);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                occupiedTables.Add(reader["OrderTable"].ToString());
            }

            con.Close();
            return occupiedTables;
        }


        // View Menu Form

        public DataTable LoadFood()     // frmMenu
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            DataTable FoodTable = new DataTable();

            string loadFoodQuery = "SELECT FoodID, FoodName, Category, Price, ISNULL(FoodImage, '') AS FoodImage FROM Food";
            SqlCommand foodcmd = new SqlCommand(loadFoodQuery, con);
            SqlDataAdapter adapter = new SqlDataAdapter(foodcmd);

            adapter.Fill(FoodTable);

            con.Close();
            return FoodTable;
        }

        public bool CheckFoodAvailable(string FoodID)   //frmMenu load ucFood to check if available or sold out
        {
            bool OrderAvailable = true;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            string checkIngredientQuery = @"
                SELECT Ingredients.QuantityAvailable, FoodIngredients.QuantityRequired
                FROM FoodIngredients
                JOIN Ingredients ON FoodIngredients.IngredientID = Ingredients.IngredientID
                WHERE FoodIngredients.FoodID = @FoodID";

            SqlCommand checkIngredientcmd = new SqlCommand(checkIngredientQuery, con);
            checkIngredientcmd.Parameters.AddWithValue("@FoodID", FoodID);

            SqlDataReader IngredientReader = checkIngredientcmd.ExecuteReader();
            while (IngredientReader.Read())
            {
                int QuantityAvailable = Convert.ToInt32(IngredientReader["QuantityAvailable"]);
                int QuantityRequired = Convert.ToInt32(IngredientReader["QuantityRequired"]);

                if (QuantityAvailable < QuantityRequired)
                {
                    OrderAvailable = false;
                    break;
                }
            }

            con.Close();
            return OrderAvailable;
        }

        public void DeductIngredients(string orderID) //when ucOrder_Load, deduct ingredients
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            var ingredientQuantityRequired = new List<(string IngredientID, int QuantityRequired)>();

            SqlCommand deductIngredientscmd = new SqlCommand("Select IngredientID, QuantityRequired FROM FoodIngredients Where FoodID = @FoodID", con);
            deductIngredientscmd.Parameters.AddWithValue("@FoodID", orderID);

            SqlDataReader reader = deductIngredientscmd.ExecuteReader();
            while (reader.Read())
            {
                string IngredientID = reader["IngredientID"].ToString();
                int QuantityRequired = Convert.ToInt32(reader["QuantityRequired"]);
                ingredientQuantityRequired.Add((IngredientID, QuantityRequired));
            }
            reader.Close();

            foreach (var ingredient in ingredientQuantityRequired)
            {
                SqlCommand updateDeductIngredientcmd = new SqlCommand("Update Ingredients SET QuantityAvailable = QuantityAvailable - @QuantityRequired Where IngredientID = @IngredientID", con);
                updateDeductIngredientcmd.Parameters.AddWithValue("@QuantityRequired", ingredient.QuantityRequired);
                updateDeductIngredientcmd.Parameters.AddWithValue("@IngredientID", ingredient.IngredientID);
                updateDeductIngredientcmd.ExecuteNonQuery();
            }

            con.Close();
        }

        public void DeductIngredients(string orderID, int quantityChange) // when ucOrder Amount add, deduct Ingredient
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            var ingredientQuantityRequired = new List<(string IngredientID, int QuantityRequired)>();

            SqlCommand deductIngredientscmd = new SqlCommand("Select IngredientID, QuantityRequired FROM FoodIngredients Where FoodID = @FoodID", con);
            deductIngredientscmd.Parameters.AddWithValue("@FoodID", orderID);

            SqlDataReader reader = deductIngredientscmd.ExecuteReader();
            while (reader.Read())
            {
                string IngredientID = reader["IngredientID"].ToString();
                int QuantityRequired = Convert.ToInt32(reader["QuantityRequired"]) * quantityChange;
                ingredientQuantityRequired.Add((IngredientID, QuantityRequired));
            }
            reader.Close();

            foreach (var ingredient in ingredientQuantityRequired)
            {
                SqlCommand updateDeductIngredientcmd = new SqlCommand("Update Ingredients SET QuantityAvailable = QuantityAvailable - @QuantityRequired Where IngredientID = @IngredientID", con);
                updateDeductIngredientcmd.Parameters.AddWithValue("@QuantityRequired", ingredient.QuantityRequired);
                updateDeductIngredientcmd.Parameters.AddWithValue("@IngredientID", ingredient.IngredientID);
                updateDeductIngredientcmd.ExecuteNonQuery();
            }

            con.Close();
        }

        public void RestoreIngredients(string orderID, int quantityChange)  // when ucOrder Amount deduct, add back Ingredient
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            var ingredientQuantityRequired = new List<(string IngredientID, int QuantityRequired)>();

            SqlCommand restoreIngredientscmd = new SqlCommand("Select IngredientID, QuantityRequired From FoodIngredients Where FoodID = @FoodID", con);
            restoreIngredientscmd.Parameters.AddWithValue("@FoodID", orderID);

            SqlDataReader reader = restoreIngredientscmd.ExecuteReader();
            while (reader.Read())
            {
                string IngredientID = reader["IngredientID"].ToString();
                int QuantityRequired = Convert.ToInt32(reader["QuantityRequired"].ToString()) * quantityChange;
                ingredientQuantityRequired.Add((IngredientID, QuantityRequired));
            }
            reader.Close();

            foreach (var ingredient in ingredientQuantityRequired)
            {
                SqlCommand updateRestoreIngredientscmd = new SqlCommand("Update Ingredients SET QuantityAvailable = QuantityAvailable + @QuantityRequired Where IngredientID = @IngredientID", con);
                updateRestoreIngredientscmd.Parameters.AddWithValue("@QuantityRequired", ingredient.QuantityRequired);
                updateRestoreIngredientscmd.Parameters.AddWithValue("@IngredientID", ingredient.IngredientID);
                updateRestoreIngredientscmd.ExecuteNonQuery();
            }

            con.Close();
        }

        public int CalculateMaxQuantity(string orderID)     // Calculate Max numOrder for ucOrder
        {
            int MaxQuantity = int.MaxValue;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            string query = @"
                SELECT Ingredients.IngredientID, Ingredients.QuantityAvailable, FoodIngredients.QuantityRequired
                FROM FoodIngredients
                JOIN Ingredients ON FoodIngredients.IngredientID = Ingredients.IngredientID
                WHERE FoodIngredients.FoodID = @FoodID";

            SqlCommand calculateMaxQuantitycmd = new SqlCommand(query, con);
            calculateMaxQuantitycmd.Parameters.AddWithValue("@FoodID", orderID);

            SqlDataReader reader = calculateMaxQuantitycmd.ExecuteReader();
            while (reader.Read())
            {
                int QuantityAvailable = Convert.ToInt32(reader["QuantityAvailable"]);
                int QuantityRequired = Convert.ToInt32(reader["QuantityRequired"]);

                int AvailableQuantity = QuantityAvailable / QuantityRequired;
                MaxQuantity = Math.Min(MaxQuantity, AvailableQuantity);
            }
            reader.Close();
            con.Close();
            return MaxQuantity;
        }

        public string UpdateOrdersTable(int orderTotalAmount)   //Update Order Table after order now
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            string newOrderID = GetNextId(con, "Orders", "OrderID", "O");

            SqlCommand updateOrdersTablecmd = new SqlCommand("Insert INTO Orders (OrderID, CustomerID, OrderDate, OrderTable, OrderStatus, OrderPaid, OrderTotalAmount) Values (@OrderID, @CustomerID, @OrderDate, @OrderTable, @OrderStatus, @OrderPaid, @OrderTotalAmount)", con);
            updateOrdersTablecmd.Parameters.AddWithValue("@OrderID", newOrderID);
            updateOrdersTablecmd.Parameters.AddWithValue("@CustomerID", CustomerID);
            updateOrdersTablecmd.Parameters.AddWithValue("@OrderDate", CurrentDateTime);
            updateOrdersTablecmd.Parameters.AddWithValue("@OrderTable", CustomerOrderTable);
            updateOrdersTablecmd.Parameters.AddWithValue("@OrderStatus", "Ongoing");
            updateOrdersTablecmd.Parameters.AddWithValue("@OrderPaid", "Unpaid");
            updateOrdersTablecmd.Parameters.AddWithValue("@OrderTotalAmount", orderTotalAmount);
            updateOrdersTablecmd.ExecuteNonQuery();

            con.Close();
            return newOrderID;
        }

        public void UpdateOrderDetailsTable(string newOrderID, string FoodID, int orderAmount)  // Update Food and foodamount after "order now"
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            string newOrderDetailsID = GetNextId(con, "OrderDetails", "OrderDetailsID", "OD");

            SqlCommand updateOrderDetailsTablecmd = new SqlCommand("Insert INTO OrderDetails (OrderDetailsID, OrderID, FoodID, OrderDetailsDate, OrderDetailsStatus, Quantity) Values (@OrderDetailsID, @OrderID, @FoodID, @OrderDetailsDate, @OrderDetailsStatus, @Quantity)", con);
            updateOrderDetailsTablecmd.Parameters.AddWithValue("@OrderDetailsID", newOrderDetailsID);
            updateOrderDetailsTablecmd.Parameters.AddWithValue("@OrderID", newOrderID);
            updateOrderDetailsTablecmd.Parameters.AddWithValue("@FoodID", FoodID);
            updateOrderDetailsTablecmd.Parameters.AddWithValue("@OrderDetailsDate", CurrentDateTime);
            updateOrderDetailsTablecmd.Parameters.AddWithValue("@OrderDetailsStatus", "Pending");
            updateOrderDetailsTablecmd.Parameters.AddWithValue("@Quantity", orderAmount);
            updateOrderDetailsTablecmd.ExecuteNonQuery();

            con.Close();
        }

        public void UpdateReservationTable(string ReservationStatus)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand updateReservationStatuscmd = new SqlCommand("Update Reservation Set ReservationStatus = @ReservationStatus Where ReservationID = @ReservationID AND CustomerID = @CustomerID AND ReservationDateTime = @ReservationDateTime", con);
            updateReservationStatuscmd.Parameters.AddWithValue("@ReservationStatus", ReservationStatus);
            updateReservationStatuscmd.Parameters.AddWithValue("@ReservationID", ReservationID);
            updateReservationStatuscmd.Parameters.AddWithValue("@CustomerID", CustomerID);
            updateReservationStatuscmd.Parameters.AddWithValue("@ReservationDateTime", CurrentDateTime);
            updateReservationStatuscmd.ExecuteNonQuery();

            con.Close();
        }

        // VIEW MENU 

        public DataTable LoadOrder()     // frmViewOrder Load
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            DataTable combinedOrderTable = new DataTable();

            try
            {
                con.Open();

                SqlCommand getOrderIDs = new SqlCommand("Select orderID From Orders Where CustomerID = @CustomerID AND OrderDate = @OrderDate AND OrderStatus = 'Ongoing' AND OrderTable = @OrderTable", con);
                getOrderIDs.Parameters.AddWithValue("@CustomerID", CustomerID);
                getOrderIDs.Parameters.AddWithValue("@OrderDate", CurrentDateTime);
                getOrderIDs.Parameters.AddWithValue("@OrderTable", CustomerOrderTable);

                SqlDataAdapter orderIDsAdapter = new SqlDataAdapter(getOrderIDs);
                DataTable orderIDsTable = new DataTable();
                orderIDsAdapter.Fill(orderIDsTable);

                if (orderIDsTable.Rows.Count == 0)
                {
                    return null;
                }

                combinedOrderTable.Columns.Add("FoodID", typeof(string));
                combinedOrderTable.Columns.Add("FoodName", typeof(string));
                combinedOrderTable.Columns.Add("Quantity", typeof(int));
                combinedOrderTable.Columns.Add("OrderDetailsStatus", typeof(string));
                combinedOrderTable.Columns.Add("FoodImage", typeof(string));
                combinedOrderTable.Columns.Add("TotalPrice", typeof(int));

                foreach (DataRow orderIDRow in orderIDsTable.Rows)
                {
                    string orderID = orderIDRow["orderID"].ToString();

                    string loadOrderQuery = @"Select od.FoodID, f.FoodName, od.Quantity, od.OrderDetailsStatus, f.FoodImage, f.Price * od.Quantity AS TotalPrice
                                     From
                                      OrderDetails od
                                     JOIN                    
                                      Food f ON od.FoodID = f.FoodID
                                     WHERE
                                      od.OrderID = @OrderID;";

                    SqlCommand orderCmd = new SqlCommand(loadOrderQuery, con);
                    orderCmd.Parameters.AddWithValue("@OrderID", orderID);
                    SqlDataAdapter adapter = new SqlDataAdapter(orderCmd);

                    DataTable orderTable = new DataTable();
                    adapter.Fill(orderTable);

                    combinedOrderTable.Merge(orderTable);
                }

                return combinedOrderTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public void CompleteOrdersTable(string PaymentType) //update table after customer pays $$
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            string updateQuery = @"UPDATE Orders
                                SET OrderPaid = 'Paid', OrderPaymentType = @OrderPaymentType
                                WHERE CustomerID = @CustomerID AND OrderDate = @OrderDate AND OrderTable = @OrderTable";

            SqlCommand updateCmd = new SqlCommand(updateQuery, con);
            updateCmd.Parameters.AddWithValue("@OrderPaymentType", PaymentType);
            updateCmd.Parameters.AddWithValue("@CustomerID", CustomerID);
            updateCmd.Parameters.AddWithValue("@OrderDate", CurrentDateTime);
            updateCmd.Parameters.AddWithValue("@OrderTable", CustomerOrderTable);
            updateCmd.ExecuteNonQuery();

            con.Close();
        }

        // Make Reservation Form

        public void InsertReservation(DateTime ReservationDateTime, int ReservationPeopleAmount, string ReservationType)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            string newReservationID = GetNextId(con, "Reservation", "ReservationID", "R");

            string query = @"INSERT INTO Reservation (ReservationID, CustomerID, ReservationDateTime, ReservationPeopleAmount, ReservationType, ReservationStatus, ReservationFeedback)
                             VALUES (@ReservationID, @CustomerID, @ReservationDateTime, @ReservationPeopleAmount, @ReservationType, @ReservationStatus, @ReservationFeedback)";

            SqlCommand insertReservationCmd = new SqlCommand(query, con);
            insertReservationCmd.Parameters.AddWithValue("@ReservationID", newReservationID);
            insertReservationCmd.Parameters.AddWithValue("@CustomerID", CustomerID);
            insertReservationCmd.Parameters.AddWithValue("@ReservationDateTime", ReservationDateTime);
            insertReservationCmd.Parameters.AddWithValue("@ReservationPeopleAmount", ReservationPeopleAmount);
            insertReservationCmd.Parameters.AddWithValue("@ReservationType", ReservationType);
            insertReservationCmd.Parameters.AddWithValue("@ReservationStatus", "Pending");
            insertReservationCmd.Parameters.AddWithValue("@ReservationFeedback", "Pending");
            insertReservationCmd.ExecuteNonQuery();

            con.Close();
        }

        // Reservation Feedback Form

        public List<DateTime> LoadPendingReservationFeedback()
        {
            List<DateTime> reservationDates = new List<DateTime>();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            string query = @"Select ReservationDateTime From Reservation
                             Where CustomerID = @CustomerID And ReservationStatus = 'Completed' And ReservationFeedback = 'Pending'";

            SqlCommand LoadReservationDatesCmd = new SqlCommand(query, con);
            LoadReservationDatesCmd.Parameters.AddWithValue("@CustomerID", CustomerID);

            SqlDataReader reader = LoadReservationDatesCmd.ExecuteReader();
            while (reader.Read())
            {
                DateTime reservationDate = reader.GetDateTime(0);
                reservationDates.Add(reservationDate);
            }
            con.Close();
            return reservationDates;
        }

        public DataRow LoadCompletedReservationDetails(DateTime selectedDate)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            string query = @"Select ReservationID, ReservationType, ReservationPeopleAmount, ReservationVenue
                             From Reservation
                             Where CustomerID = @CustomerID And ReservationDateTime = @selectedDate And ReservationStatus = 'Completed' And ReservationFeedback = 'Pending'";

            SqlCommand reservationDetailscmd = new SqlCommand(query, con);
            reservationDetailscmd.Parameters.AddWithValue("@CustomerID", CustomerID);
            reservationDetailscmd.Parameters.AddWithValue("@selectedDate", selectedDate);

            DataTable reservationDetailsTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(reservationDetailscmd);
            adapter.Fill(reservationDetailsTable);

            if (reservationDetailsTable.Rows.Count > 0)
            {
                return reservationDetailsTable.Rows[0];
            }
            else
            {
                return null;
            }
        }

        public void SaveFeedbackDetails(string ReservationID, int Rating1, int Rating2, int Rating3, string RatingText)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            string newFeedbackID = GetNextId(con, "Feedback", "FeedbackID", "F");

            string query = @"INSERT INTO Feedback (FeedbackID, CustomerID, ReservationID, FeedbackType, FeedbackDateTime, FeedbackRating1, FeedbackRating2, FeedbackRating3, FeedbackText)
                             VALUES (@FeedbackID, @CustomerID, @ReservationID, @FeedbackType, @FeedbackDateTime, @FeedbackRating1, @FeedbackRating2, @FeedbackRating3, @FeedbackText)";

            SqlCommand insertReservationCmd = new SqlCommand(query, con);
            insertReservationCmd.Parameters.AddWithValue("@FeedbackID", newFeedbackID);
            insertReservationCmd.Parameters.AddWithValue("@CustomerID", CustomerID);
            insertReservationCmd.Parameters.AddWithValue("@ReservationID", ReservationID);
            insertReservationCmd.Parameters.AddWithValue("@FeedbackType", "Reservation");
            insertReservationCmd.Parameters.AddWithValue("@FeedbackDateTime", CurrentDateTime);
            insertReservationCmd.Parameters.AddWithValue("@FeedbackRating1", Rating1);
            insertReservationCmd.Parameters.AddWithValue("@FeedbackRating2", Rating2);
            insertReservationCmd.Parameters.AddWithValue("@FeedbackRating3", Rating3);
            insertReservationCmd.Parameters.AddWithValue("@FeedbackText", RatingText);

            insertReservationCmd.ExecuteNonQuery();

            con.Close();
        }

        public void UpdateReservationStatus(string ReservationID)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            string query = @"Update Reservation SET ReservationFeedback = 'Completed' Where ReservationID = @ReservationID And CustomerID = @CustomerID";

            SqlCommand insertReservationCmd = new SqlCommand(query, con);
            insertReservationCmd.Parameters.AddWithValue("@CustomerID", CustomerID);
            insertReservationCmd.Parameters.AddWithValue("@ReservationID", ReservationID);
            insertReservationCmd.ExecuteNonQuery();

            con.Close();
        }

        // frmMenuFeedback

        public List<(string OrderID, DateTime OrderDate)> LoadPendingMenuFeedback()
        {
            List<(string OrderID, DateTime OrderDate)> orders = new List<(string OrderID, DateTime OrderDate)>();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            string query = @"SELECT OrderID, OrderDate 
                             FROM Orders
                             WHERE CustomerID = @CustomerID 
                             AND OrderStatus = 'Completed' 
                             AND OrderID NOT IN (SELECT OrderID FROM Feedback WHERE FeedbackType = 'Menu')";

            SqlCommand loadOrderDatesCmd = new SqlCommand(query, con);
            loadOrderDatesCmd.Parameters.AddWithValue("@CustomerID", CustomerID);

            SqlDataReader reader = loadOrderDatesCmd.ExecuteReader();
            while (reader.Read())
            {
                string orderID = reader.GetString(0);
                DateTime orderDate = reader.GetDateTime(1);
                orders.Add((orderID, orderDate));
            }
            con.Close();
            return orders;
        }

        public string LoadCompletedOrderDetails(string OrderID, DateTime selectedDate)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            string query = @"SELECT OrderTable
                             FROM Orders
                             WHERE CustomerID = @CustomerID 
                             AND OrderDate = @selectedDate 
                             AND OrderID = @OrderID
                             AND OrderStatus = 'Completed'
                             AND OrderID NOT IN (SELECT OrderID FROM Feedback WHERE FeedbackType = 'Menu')";

            SqlCommand loadOrderDetailsCmd = new SqlCommand(query, con);
            loadOrderDetailsCmd.Parameters.AddWithValue("@CustomerID", CustomerID);
            loadOrderDetailsCmd.Parameters.AddWithValue("@selectedDate", selectedDate);
            loadOrderDetailsCmd.Parameters.AddWithValue("@OrderID", OrderID);
            string orderTable = loadOrderDetailsCmd.ExecuteScalar().ToString();

            con.Close();
            return orderTable;
        }

        public List<string> LoadOrderFoodItems(string OrderID)
        {
            List<string> foodItems = new List<string>();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            try
            {
                con.Open();

                string query = @"SELECT Food.FoodName 
                         FROM OrderDetails 
                         JOIN Food ON OrderDetails.FoodID = Food.FoodID 
                         WHERE OrderDetails.OrderID = @OrderID";

                SqlCommand loadFoodItemsCmd = new SqlCommand(query, con);
                loadFoodItemsCmd.Parameters.AddWithValue("@OrderID", OrderID);

                SqlDataReader reader = loadFoodItemsCmd.ExecuteReader();
                while (reader.Read())
                {
                    string foodItem = reader.GetString(0);
                    foodItems.Add(foodItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return foodItems;
        }

        public void SaveMenuFeedbackDetails(string OrderID, int FeedbackRating1, int FeedbackRating2, int FeedbackRating3, string feedbackText)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            string newFeedbackID = GetNextId(con, "Feedback", "FeedbackID", "F");

            string query = @"INSERT INTO Feedback (FeedbackID, CustomerID, OrderID, FeedbackDateTime, FeedbackRating1, FeedbackRating2, FeedbackRating3, FeedbackText, FeedbackType)
                             VALUES (@FeedbackID, @CustomerID, @OrderID, @FeedbackDateTime, @FeedbackRating1, @FeedbackRating2, @FeedbackRating3, @feedbackText, 'Menu')";

            SqlCommand saveFeedbackCmd = new SqlCommand(query, con);
            saveFeedbackCmd.Parameters.AddWithValue("@FeedbackID", newFeedbackID);
            saveFeedbackCmd.Parameters.AddWithValue("@CustomerID", CustomerID);
            saveFeedbackCmd.Parameters.AddWithValue("@OrderID", OrderID);
            saveFeedbackCmd.Parameters.AddWithValue("@FeedbackDateTime", CurrentDateTime);
            saveFeedbackCmd.Parameters.AddWithValue("@FeedbackRating1", FeedbackRating1);
            saveFeedbackCmd.Parameters.AddWithValue("@FeedbackRating2", FeedbackRating2);
            saveFeedbackCmd.Parameters.AddWithValue("@FeedbackRating3", FeedbackRating3);
            saveFeedbackCmd.Parameters.AddWithValue("@feedbackText", feedbackText);

            saveFeedbackCmd.ExecuteNonQuery();
            con.Close();
        }

        private static string GetNextId(SqlConnection connection, string tableName, string idColumn, string prefix)
        {
            string query = $@"SELECT ISNULL(MAX(TRY_CONVERT(int, SUBSTRING([{idColumn}], {prefix.Length + 1}, 20))), 0) + 1
                              FROM [{tableName}]";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                int nextNumber = Convert.ToInt32(command.ExecuteScalar());
                return $"{prefix}{nextNumber:D3}";
            }
        }
    }
}
