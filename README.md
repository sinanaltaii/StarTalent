## Genereate hexagondb Postgressql with EF Core

* Remove Sql provider
* Install Postgres provider 
```Package Manager Console
Scaffold-DbContext "Host=localhost;Database=postgres;Username=postgres;Password=!QAZxsw2" -Provider Npgsql.EntityFrameworkCore.PostgreSQL -OutputDir Models -Context StarDbContext -ContextDir DataContext
```

## Remove all migrations including initial_create

1. First revert to clean state were no migrations were created
```Package Manager Console
Update-Database 0
```

2. Remove all migrations by running command below, giving no argument will remove 
   the latest migration and its corrosponding files
```Package Manager Console
Remove-Migration -Project src\Star.Data
```

Note:
USE Add-Migration when adding code to `OnModelCreating()` in order to get that code to the database.

