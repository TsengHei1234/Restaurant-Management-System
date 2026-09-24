/*
    Restaurant Management System - reproducible LocalDB schema

    Run this script with sqlcmd or in SQL Server Management Studio.
    It creates the named database used by C#_Group_Assignment/App.config.
*/

USE [master];
GO

IF DB_ID(N'RestaurantManagementSystem') IS NULL
BEGIN
    CREATE DATABASE [RestaurantManagementSystem];
END;
GO

USE [RestaurantManagementSystem];
GO

IF OBJECT_ID(N'dbo.Users', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Users
    (
        UserID         nvarchar(50)  NOT NULL CONSTRAINT PK_Users PRIMARY KEY,
        Username       nvarchar(50)  NOT NULL,
        Email          nvarchar(100) NOT NULL,
        Password       nvarchar(100) NOT NULL,
        Role           nvarchar(20)  NOT NULL,
        SecurityAnswer nvarchar(100) NOT NULL,
        CONSTRAINT UQ_Users_Username UNIQUE (Username),
        CONSTRAINT UQ_Users_Email UNIQUE (Email),
        CONSTRAINT CK_Users_Role CHECK (Role IN (N'Admin', N'Manager', N'Chef', N'Customer'))
    );
END;
GO

IF OBJECT_ID(N'dbo.Customer', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Customer
    (
        CustomerID nvarchar(50) NOT NULL CONSTRAINT PK_Customer PRIMARY KEY,
        Username   nvarchar(50) NOT NULL
    );
END;
GO

IF OBJECT_ID(N'dbo.Food', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Food
    (
        FoodID     nvarchar(50)  NOT NULL CONSTRAINT PK_Food PRIMARY KEY,
        FoodName   nvarchar(100) NOT NULL,
        FoodImage  nvarchar(50)  NULL,
        Category   nvarchar(50)  NOT NULL,
        Price      int           NOT NULL,
        FoodStatus nvarchar(50)  NOT NULL,
        CONSTRAINT CK_Food_Price CHECK (Price >= 0)
    );
END;
GO

IF OBJECT_ID(N'dbo.Ingredients', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Ingredients
    (
        IngredientID        nvarchar(50)  NOT NULL CONSTRAINT PK_Ingredients PRIMARY KEY,
        IngredientName      nvarchar(100) NOT NULL,
        QuantityAvailable   int           NOT NULL,
        CONSTRAINT CK_Ingredients_Quantity CHECK (QuantityAvailable >= 0)
    );
END;
GO

IF OBJECT_ID(N'dbo.Storage', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Storage
    (
        StorageID        int IDENTITY(1, 1) NOT NULL CONSTRAINT PK_Storage PRIMARY KEY,
        StorageName      nvarchar(100)       NOT NULL,
        QuantityAvailable int                NOT NULL,
        CONSTRAINT CK_Storage_Quantity CHECK (QuantityAvailable >= 0)
    );
END;
GO

IF OBJECT_ID(N'dbo.Orders', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Orders
    (
        OrderID             nvarchar(50) NOT NULL CONSTRAINT PK_Orders PRIMARY KEY,
        CustomerID          nvarchar(50) NOT NULL,
        OrderDate           datetime     NOT NULL,
        OrderTable          nvarchar(50) NOT NULL,
        OrderStatus         nvarchar(50) NOT NULL,
        OrderPaid           nvarchar(50) NOT NULL,
        OrderTotalAmount    int          NOT NULL,
        OrderPaymentType    nvarchar(50) NULL,
        CONSTRAINT CK_Orders_Total CHECK (OrderTotalAmount >= 0)
    );
END;
GO

IF OBJECT_ID(N'dbo.OrderDetails', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.OrderDetails
    (
        OrderDetailsID     nvarchar(50) NOT NULL CONSTRAINT PK_OrderDetails PRIMARY KEY,
        OrderID            nvarchar(50) NOT NULL,
        FoodID             nvarchar(50) NOT NULL,
        ChefID             nvarchar(50) NULL,
        OrderDetailsDate   datetime     NOT NULL,
        OrderDetailsStatus nvarchar(50) NOT NULL,
        Quantity           int          NOT NULL,
        CONSTRAINT CK_OrderDetails_Quantity CHECK (Quantity > 0)
    );
END;
GO

IF OBJECT_ID(N'dbo.Reservation', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Reservation
    (
        ReservationID           nvarchar(50) NOT NULL CONSTRAINT PK_Reservation PRIMARY KEY,
        CustomerID              nvarchar(50) NOT NULL,
        ReservationDateTime     datetime     NOT NULL,
        ReservationPeopleAmount int          NOT NULL,
        ReservationType         nvarchar(50) NOT NULL,
        ReservationStatus       nvarchar(50) NOT NULL,
        ReservationVenue        nvarchar(50) NULL,
        ReservationFeedback     nvarchar(50) NOT NULL,
        CONSTRAINT CK_Reservation_People CHECK (ReservationPeopleAmount > 0)
    );
END;
GO

IF OBJECT_ID(N'dbo.Feedback', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Feedback
    (
        FeedbackID      nvarchar(50)  NOT NULL CONSTRAINT PK_Feedback PRIMARY KEY,
        CustomerID      nvarchar(50)  NOT NULL,
        OrderID         nvarchar(50)  NULL,
        ReservationID   nvarchar(50)  NULL,
        FeedbackType    nvarchar(50)  NOT NULL,
        FeedbackDateTime datetime     NOT NULL,
        FeedbackRating1 int           NOT NULL,
        FeedbackRating2 int           NOT NULL,
        FeedbackRating3 int           NOT NULL,
        FeedbackText    nvarchar(255) NULL,
        CONSTRAINT CK_Feedback_Rating1 CHECK (FeedbackRating1 BETWEEN 1 AND 5),
        CONSTRAINT CK_Feedback_Rating2 CHECK (FeedbackRating2 BETWEEN 1 AND 5),
        CONSTRAINT CK_Feedback_Rating3 CHECK (FeedbackRating3 BETWEEN 1 AND 5)
    );
END;
GO

IF OBJECT_ID(N'dbo.FoodIngredients', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.FoodIngredients
    (
        FoodID           nvarchar(50) NOT NULL,
        IngredientID     nvarchar(50) NOT NULL,
        QuantityRequired int          NOT NULL,
        CONSTRAINT PK_FoodIngredients PRIMARY KEY (FoodID, IngredientID),
        CONSTRAINT CK_FoodIngredients_Quantity CHECK (QuantityRequired > 0)
    );
END;
GO

IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = N'IX_Orders_Customer_Status' AND object_id = OBJECT_ID(N'dbo.Orders'))
    CREATE INDEX IX_Orders_Customer_Status ON dbo.Orders (CustomerID, OrderStatus, OrderDate);
GO

IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = N'IX_OrderDetails_Order' AND object_id = OBJECT_ID(N'dbo.OrderDetails'))
    CREATE INDEX IX_OrderDetails_Order ON dbo.OrderDetails (OrderID, OrderDetailsStatus);
GO

IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = N'IX_Reservation_Customer_Status' AND object_id = OBJECT_ID(N'dbo.Reservation'))
    CREATE INDEX IX_Reservation_Customer_Status ON dbo.Reservation (CustomerID, ReservationStatus, ReservationDateTime);
GO

