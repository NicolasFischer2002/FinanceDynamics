-- Entity Framework Core Scaffold to generate the corresponding classes 
-- (Database-First Approach). This will automatically create the entities 
-- and DbContext based on the database tables.

-- The database is configured to exit along with the .exe.
-- The command must be executed within the Infrastructure project Terminal.
-- dotnet ef dbcontext scaffold "Data Source=C:\\Full Database Path\\FinanceDynamics.db" Microsoft.EntityFrameworkCore.Sqlite -o Models --context FinanceDbContext --context-dir Context --no-onconfiguring

-- To recreate the database and classes generated via EF, you need to delete the 
-- database file - FinanceDynamics.db - delete the Models folder, delete the Context folder, 
-- comment out the "services.AddDbContext<FinanceDbContext>" section in program.cs, run the 
-- program to generate the database again, and then run the "scaffold" command.

-- Database creation scripts --

CREATE TABLE Clientes (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    nome TEXT NOT NULL,
    email TEXT NOT NULL,
    idade INTEGER,
    data_cadastro TEXT DEFAULT CURRENT_TIMESTAMP
);