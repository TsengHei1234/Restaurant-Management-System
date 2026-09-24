# Local database setup

The application uses SQL Server LocalDB and connects to the named database `RestaurantManagementSystem`. The database files are intentionally not stored in Git.

From this repository's root, create the schema and optional development data with:

```powershell
sqlcmd -S "(LocalDB)\MSSQLLocalDB" -E -b -i ".\database\schema.sql"
sqlcmd -S "(LocalDB)\MSSQLLocalDB" -E -b -i ".\database\seed.example.sql"
```

The sample accounts all use the development-only password `Demo123!`:

| Role | Username |
| --- | --- |
| Admin | `admin_demo` |
| Manager | `manager_demo` |
| Chef | `chef_demo` |
| Customer | `customer_demo` |

Do not reuse these sample credentials outside local development.
