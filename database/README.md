# Database

The repository includes the demonstration SQL Server LocalDB database used by the application:

- `C#_Group_Assignment/Database.mdf`
- `C#_Group_Assignment/Database_log.ldf`

The application resolves `Database.mdf` from the project directory and attaches it to `(LocalDB)\MSSQLLocalDB` as `RestaurantManagementSystem`. The database contains demonstration data only. `schema.sql` and `seed.example.sql` are also retained as readable, reproducible definitions of the database structure and sample records.

The sample accounts all use the development-only password `Demo123!`:

| Role | Username |
| --- | --- |
| Admin | `admin_demo` |
| Manager | `manager_demo` |
| Chef | `chef_demo` |
| Customer | `customer_demo` |

These credentials are public demonstration credentials. Do not reuse the password for a real account or production system.
