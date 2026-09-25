# Restaurant Management System

Restaurant Management System is a Windows desktop application that connects customer ordering and reservations with administrative, menu-management, and kitchen workflows. It provides one shared system for customers, administrators, managers, and chefs.

## Project scope

This repository contains the integrated version of a collaborative university group project. The application supports four role-based experiences backed by a shared SQL Server LocalDB database.

## Features

### Customer

- Create an account and sign in.
- Browse available menu items and place dine-in orders.
- Select a payment method and review order status.
- Make reservations and view their status.
- Submit menu and reservation feedback.

### Administrator

- Create, update, and remove Customer, Chef, and Manager accounts.
- View customer feedback.
- Review paid-order sales information.
- Protect account and transaction history from unsafe deletion.

### Manager

- Add and update menu items, including images, categories, prices, and availability.
- Remove menu items that have no order history.
- Create, update, and reject reservations.
- Prevent conflicting reservations for the same venue and time.
- View reservation reports.

### Chef

- View paid orders that are ready for preparation.
- Claim orders, track work in progress, and complete order items.
- Update an order only when assigned to it.
- Transfer stock between storage and active ingredient inventory.
- View low-stock information and restock storage items.

## How it works

1. A user signs in and is routed to the interface for their role.
2. Customers browse the menu, place orders, make payments, or submit reservations.
3. Paid order items become available to chefs for preparation.
4. Chefs claim and complete order items while monitoring ingredient stock.
5. Managers maintain menu availability and handle reservations.
6. Administrators maintain user accounts and review feedback and sales information.

## Technologies

- C#
- .NET Framework 4.7.2
- Windows Forms
- ADO.NET
- SQL Server Express LocalDB
- Visual Studio/MSBuild

## Project structure

```text
C#_Group_Assignment/      Windows Forms application and project-local database
|-- Admin/                Administrator forms and account-management logic
|-- Chef/                 Kitchen order and inventory workflows
|-- Customer/             Customer ordering, reservation, and feedback workflows
|-- Manager/              Menu and reservation-management workflows
|-- Resources/            Application images and interface assets
|-- Database.mdf          Demonstration LocalDB database
`-- App.config            LocalDB connection configuration

database/
|-- schema.sql            Reproducible database schema
|-- seed.example.sql      Demonstration records and accounts
`-- README.md             Database details
```

## Requirements

- Windows
- Visual Studio 2022 with .NET desktop development support
- .NET Framework 4.7.2 targeting pack
- SQL Server Express LocalDB

## Compile and run

1. Clone or download the repository.
2. Open `C#_Group_Assignment.sln` in Visual Studio 2022.
3. Select the `C#_Group_Assignment` startup project if Visual Studio does not select it automatically.
4. Build the solution.
5. Start the application.

The included `Database.mdf` is resolved from the project directory and automatically attached to `(LocalDB)\MSSQLLocalDB` as `RestaurantManagementSystem`. No separate database import is required for the included demonstration setup.

## Demo accounts

All demonstration accounts use the password `Demo123!`.

| Role | Username |
| --- | --- |
| Administrator | `admin_demo` |
| Manager | `manager_demo` |
| Chef | `chef_demo` |
| Customer | `customer_demo` |

These are public demonstration credentials and must not be reused for a real account or production system.

## Database

The tracked MDF/LDF files contain demonstration data only. The SQL files in [`database`](database/) provide readable definitions of the schema and seed data. Because the application writes directly to the included database, normal testing can change the local database files.

## Verification

The integrated application has been verified with:

- A clean Debug rebuild using Visual Studio 2022 MSBuild with zero warnings and zero errors.
- SQL Server database integrity and demo-data checks.
- Successful authentication for all four demonstration roles.
- Successful creation of the primary role forms and integrated designer resources.
- Database-backed checks for administrator account operations, manager menu and reservation operations, chef order processing, and inventory transfers.

## Current limitations

- The application targets Windows and the .NET Framework rather than modern cross-platform .NET.
- The project does not include an automated unit or integration test suite.
- Final visual and interactive UI behaviour should be checked manually when running the application.
- Authentication uses plaintext demonstration passwords and is not intended as a production security model.
