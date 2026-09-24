using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace C__Group_Assignment.Chef
{
    internal sealed class ChefService
    {
        private readonly string connectionString;

        public ChefService()
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["myCS"];
            if (settings == null || string.IsNullOrWhiteSpace(settings.ConnectionString))
            {
                throw new InvalidOperationException("The myCS database connection is not configured.");
            }

            connectionString = settings.ConnectionString;
        }

        public DataTable SearchIngredients(string searchText)
        {
            const string query = @"SELECT IngredientID, IngredientName, QuantityAvailable
                                   FROM Ingredients
                                   WHERE IngredientName LIKE @SearchText
                                   ORDER BY IngredientName;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.Add("@SearchText", SqlDbType.NVarChar, 100).Value = "%" + (searchText ?? string.Empty).Trim() + "%";
                DataTable ingredients = new DataTable();
                adapter.Fill(ingredients);
                return ingredients;
            }
        }

        public DataTable LoadLowInventory(int threshold)
        {
            const string query = @"SELECT IngredientName, QuantityAvailable
                                   FROM Ingredients
                                   WHERE QuantityAvailable < @Threshold
                                   ORDER BY QuantityAvailable, IngredientName;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.Add("@Threshold", SqlDbType.Int).Value = threshold;
                DataTable ingredients = new DataTable();
                adapter.Fill(ingredients);
                return ingredients;
            }
        }

        public void TransferFromStorage(string ingredientName, int quantity)
        {
            ValidateQuantityAndName(ingredientName, quantity);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction(IsolationLevel.Serializable))
                {
                    int storageQuantity = ReadQuantity(connection, transaction, "Storage", "StorageName", ingredientName);
                    ReadQuantity(connection, transaction, "Ingredients", "IngredientName", ingredientName);

                    if (storageQuantity < quantity)
                    {
                        throw new InvalidOperationException("The storage quantity is too low for this transfer.");
                    }

                    UpdateQuantity(connection, transaction, "Storage", "StorageName", ingredientName, -quantity);
                    UpdateQuantity(connection, transaction, "Ingredients", "IngredientName", ingredientName, quantity);
                    transaction.Commit();
                }
            }
        }

        public void ReturnToStorage(string ingredientName, int quantity)
        {
            ValidateQuantityAndName(ingredientName, quantity);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction(IsolationLevel.Serializable))
                {
                    int ingredientQuantity = ReadQuantity(connection, transaction, "Ingredients", "IngredientName", ingredientName);
                    ReadQuantity(connection, transaction, "Storage", "StorageName", ingredientName);

                    if (ingredientQuantity < quantity)
                    {
                        throw new InvalidOperationException("The ingredient quantity is too low for this return.");
                    }

                    UpdateQuantity(connection, transaction, "Ingredients", "IngredientName", ingredientName, -quantity);
                    UpdateQuantity(connection, transaction, "Storage", "StorageName", ingredientName, quantity);
                    transaction.Commit();
                }
            }
        }

        public DataTable LoadStorage(string searchText)
        {
            const string query = @"SELECT StorageID, StorageName, QuantityAvailable
                                   FROM Storage
                                   WHERE StorageName LIKE @SearchText
                                   ORDER BY StorageName;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.Add("@SearchText", SqlDbType.NVarChar, 100).Value = "%" + (searchText ?? string.Empty).Trim() + "%";
                DataTable storage = new DataTable();
                adapter.Fill(storage);
                return storage;
            }
        }

        public int RestockStorage(string storageName, int quantity)
        {
            ValidateQuantityAndName(storageName, quantity);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction(IsolationLevel.Serializable))
                {
                    int currentQuantity = ReadQuantity(connection, transaction, "Storage", "StorageName", storageName);
                    UpdateQuantity(connection, transaction, "Storage", "StorageName", storageName, quantity);
                    transaction.Commit();
                    return checked(currentQuantity + quantity);
                }
            }
        }

        public DataTable LoadActiveOrderDetails(string chefID)
        {
            if (string.IsNullOrWhiteSpace(chefID))
            {
                throw new InvalidOperationException("A Chef session is required to load orders.");
            }

            const string query = @"SELECT od.OrderDetailsID,
                                          od.OrderID,
                                          o.OrderTable,
                                          o.OrderDate,
                                          CASE WHEN EXISTS
                                          (
                                              SELECT 1
                                              FROM Reservation r
                                              WHERE r.CustomerID = o.CustomerID
                                                AND r.ReservationVenue = o.OrderTable
                                          ) THEN 'Reservation' ELSE 'Walk-In' END AS OrderType,
                                          f.FoodName,
                                          f.FoodImage,
                                          od.Quantity,
                                          od.OrderDetailsStatus
                                   FROM OrderDetails od
                                   INNER JOIN Orders o ON od.OrderID = o.OrderID
                                   INNER JOIN Food f ON od.FoodID = f.FoodID
                                   WHERE o.OrderPaid = 'Paid'
                                     AND o.OrderStatus <> 'Completed'
                                     AND
                                     (
                                         od.OrderDetailsStatus = 'Pending'
                                         OR (od.OrderDetailsStatus = 'In Progress' AND od.ChefID = @ChefID)
                                     )
                                   ORDER BY o.OrderDate, od.OrderID, od.OrderDetailsID;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.Add("@ChefID", SqlDbType.NVarChar, 50).Value = chefID;
                DataTable orders = new DataTable();
                adapter.Fill(orders);
                return orders;
            }
        }

        public bool StartOrderDetail(string orderDetailsID, string chefID)
        {
            const string query = @"UPDATE od
                                   SET od.OrderDetailsStatus = 'In Progress', od.ChefID = @ChefID
                                   FROM OrderDetails od
                                   INNER JOIN Orders o ON od.OrderID = o.OrderID
                                   WHERE od.OrderDetailsID = @OrderDetailsID
                                     AND od.OrderDetailsStatus = 'Pending'
                                     AND o.OrderPaid = 'Paid'
                                     AND o.OrderStatus <> 'Completed';";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@ChefID", SqlDbType.NVarChar, 50).Value = chefID;
                command.Parameters.Add("@OrderDetailsID", SqlDbType.NVarChar, 50).Value = orderDetailsID;
                connection.Open();
                return command.ExecuteNonQuery() == 1;
            }
        }

        public bool CompleteOrderDetail(string orderDetailsID, string chefID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction(IsolationLevel.Serializable))
                {
                    const string completeDetail = @"UPDATE od
                                                    SET od.OrderDetailsStatus = 'Completed'
                                                    FROM OrderDetails od
                                                    INNER JOIN Orders o ON od.OrderID = o.OrderID
                                                    WHERE od.OrderDetailsID = @OrderDetailsID
                                                      AND od.ChefID = @ChefID
                                                      AND od.OrderDetailsStatus = 'In Progress'
                                                      AND o.OrderPaid = 'Paid';";
                    using (SqlCommand command = new SqlCommand(completeDetail, connection, transaction))
                    {
                        command.Parameters.Add("@OrderDetailsID", SqlDbType.NVarChar, 50).Value = orderDetailsID;
                        command.Parameters.Add("@ChefID", SqlDbType.NVarChar, 50).Value = chefID;
                        if (command.ExecuteNonQuery() != 1)
                        {
                            transaction.Rollback();
                            return false;
                        }
                    }

                    string orderID;
                    using (SqlCommand command = new SqlCommand("SELECT OrderID FROM OrderDetails WHERE OrderDetailsID = @OrderDetailsID;", connection, transaction))
                    {
                        command.Parameters.Add("@OrderDetailsID", SqlDbType.NVarChar, 50).Value = orderDetailsID;
                        orderID = Convert.ToString(command.ExecuteScalar());
                    }

                    const string finalizeOrder = @"UPDATE Orders
                                                   SET OrderStatus = 'Completed'
                                                   WHERE OrderID = @OrderID
                                                     AND NOT EXISTS
                                                     (
                                                         SELECT 1
                                                         FROM OrderDetails
                                                         WHERE OrderID = @OrderID
                                                           AND OrderDetailsStatus <> 'Completed'
                                                     );";
                    using (SqlCommand command = new SqlCommand(finalizeOrder, connection, transaction))
                    {
                        command.Parameters.Add("@OrderID", SqlDbType.NVarChar, 50).Value = orderID;
                        command.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return true;
                }
            }
        }

        private static void ValidateQuantityAndName(string itemName, int quantity)
        {
            if (string.IsNullOrWhiteSpace(itemName))
            {
                throw new InvalidOperationException("Please select an ingredient or storage item.");
            }
            if (quantity <= 0)
            {
                throw new InvalidOperationException("Quantity must be greater than zero.");
            }
        }

        private static int ReadQuantity(SqlConnection connection, SqlTransaction transaction, string table, string nameColumn, string name)
        {
            string query = $"SELECT QuantityAvailable FROM [{table}] WITH (UPDLOCK, HOLDLOCK) WHERE [{nameColumn}] = @Name;";
            using (SqlCommand command = new SqlCommand(query, connection, transaction))
            {
                command.Parameters.Add("@Name", SqlDbType.NVarChar, 100).Value = name;
                object result = command.ExecuteScalar();
                if (result == null)
                {
                    throw new InvalidOperationException($"{name} was not found in {table}.");
                }
                return Convert.ToInt32(result);
            }
        }

        private static void UpdateQuantity(SqlConnection connection, SqlTransaction transaction, string table, string nameColumn, string name, int change)
        {
            string query = $"UPDATE [{table}] SET QuantityAvailable = QuantityAvailable + @Change WHERE [{nameColumn}] = @Name;";
            using (SqlCommand command = new SqlCommand(query, connection, transaction))
            {
                command.Parameters.Add("@Change", SqlDbType.Int).Value = change;
                command.Parameters.Add("@Name", SqlDbType.NVarChar, 100).Value = name;
                if (command.ExecuteNonQuery() != 1)
                {
                    throw new InvalidOperationException($"Unable to update {name} in {table}.");
                }
            }
        }
    }
}
