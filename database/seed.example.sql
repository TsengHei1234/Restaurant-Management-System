/* Development-only sample data. Safe to run more than once. */

USE [RestaurantManagementSystem];
GO

IF NOT EXISTS (SELECT 1 FROM dbo.Users WHERE UserID = N'A001')
    INSERT dbo.Users (UserID, Username, Email, Password, Role, SecurityAnswer)
    VALUES (N'A001', N'admin_demo', N'admin@example.test', N'Demo123!', N'Admin', N'demo');

IF NOT EXISTS (SELECT 1 FROM dbo.Users WHERE UserID = N'M001')
    INSERT dbo.Users (UserID, Username, Email, Password, Role, SecurityAnswer)
    VALUES (N'M001', N'manager_demo', N'manager@example.test', N'Demo123!', N'Manager', N'demo');

IF NOT EXISTS (SELECT 1 FROM dbo.Users WHERE UserID = N'CH001')
    INSERT dbo.Users (UserID, Username, Email, Password, Role, SecurityAnswer)
    VALUES (N'CH001', N'chef_demo', N'chef@example.test', N'Demo123!', N'Chef', N'demo');

IF NOT EXISTS (SELECT 1 FROM dbo.Users WHERE UserID = N'C001')
    INSERT dbo.Users (UserID, Username, Email, Password, Role, SecurityAnswer)
    VALUES (N'C001', N'customer_demo', N'customer@example.test', N'Demo123!', N'Customer', N'demo');

IF NOT EXISTS (SELECT 1 FROM dbo.Customer WHERE CustomerID = N'C001')
    INSERT dbo.Customer (CustomerID, Username) VALUES (N'C001', N'customer_demo');
GO

IF NOT EXISTS (SELECT 1 FROM dbo.Food WHERE FoodID = N'F001')
    INSERT dbo.Food (FoodID, FoodName, FoodImage, Category, Price, FoodStatus)
    VALUES (N'F001', N'Aglio e Olio', N'aglioeolio', N'Italian', 18, N'Available');

IF NOT EXISTS (SELECT 1 FROM dbo.Food WHERE FoodID = N'F002')
    INSERT dbo.Food (FoodID, FoodName, FoodImage, Category, Price, FoodStatus)
    VALUES (N'F002', N'Chicken Katsu', N'chicken_katsu', N'Japanese', 22, N'Available');

IF NOT EXISTS (SELECT 1 FROM dbo.Food WHERE FoodID = N'F003')
    INSERT dbo.Food (FoodID, FoodName, FoodImage, Category, Price, FoodStatus)
    VALUES (N'F003', N'Beef Taco', N'taco', N'Mexican', 15, N'Available');

IF NOT EXISTS (SELECT 1 FROM dbo.Food WHERE FoodID = N'F004')
    INSERT dbo.Food (FoodID, FoodName, FoodImage, Category, Price, FoodStatus)
    VALUES (N'F004', N'Margherita Pizza', N'margheritapizza', N'Italian', 24, N'Available');
GO

IF NOT EXISTS (SELECT 1 FROM dbo.Ingredients WHERE IngredientID = N'I001')
    INSERT dbo.Ingredients (IngredientID, IngredientName, QuantityAvailable)
    VALUES (N'I001', N'Pasta', 100);

IF NOT EXISTS (SELECT 1 FROM dbo.Ingredients WHERE IngredientID = N'I002')
    INSERT dbo.Ingredients (IngredientID, IngredientName, QuantityAvailable)
    VALUES (N'I002', N'Chicken', 100);

IF NOT EXISTS (SELECT 1 FROM dbo.Ingredients WHERE IngredientID = N'I003')
    INSERT dbo.Ingredients (IngredientID, IngredientName, QuantityAvailable)
    VALUES (N'I003', N'Cheese', 100);
GO

IF NOT EXISTS (SELECT 1 FROM dbo.Storage WHERE StorageName = N'Dry Storage')
    INSERT dbo.Storage (StorageName, QuantityAvailable) VALUES (N'Dry Storage', 100);

IF NOT EXISTS (SELECT 1 FROM dbo.Storage WHERE StorageName = N'Cold Storage')
    INSERT dbo.Storage (StorageName, QuantityAvailable) VALUES (N'Cold Storage', 100);

IF NOT EXISTS (SELECT 1 FROM dbo.Storage WHERE StorageName = N'Pasta')
    INSERT dbo.Storage (StorageName, QuantityAvailable) VALUES (N'Pasta', 100);

IF NOT EXISTS (SELECT 1 FROM dbo.Storage WHERE StorageName = N'Chicken')
    INSERT dbo.Storage (StorageName, QuantityAvailable) VALUES (N'Chicken', 100);

IF NOT EXISTS (SELECT 1 FROM dbo.Storage WHERE StorageName = N'Cheese')
    INSERT dbo.Storage (StorageName, QuantityAvailable) VALUES (N'Cheese', 100);
GO

IF NOT EXISTS (SELECT 1 FROM dbo.FoodIngredients WHERE FoodID = N'F001' AND IngredientID = N'I001')
    INSERT dbo.FoodIngredients (FoodID, IngredientID, QuantityRequired) VALUES (N'F001', N'I001', 1);

IF NOT EXISTS (SELECT 1 FROM dbo.FoodIngredients WHERE FoodID = N'F002' AND IngredientID = N'I002')
    INSERT dbo.FoodIngredients (FoodID, IngredientID, QuantityRequired) VALUES (N'F002', N'I002', 1);

IF NOT EXISTS (SELECT 1 FROM dbo.FoodIngredients WHERE FoodID = N'F004' AND IngredientID = N'I003')
    INSERT dbo.FoodIngredients (FoodID, IngredientID, QuantityRequired) VALUES (N'F004', N'I003', 1);
GO
