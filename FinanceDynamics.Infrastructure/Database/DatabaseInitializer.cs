using FinanceDynamics.Infrastructure.Interfaces;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Configuration;

namespace FinanceDynamics.Infrastructure.Database
{
    public class DatabaseInitializer : IDatabaseInitializer
    {
        private readonly IConfiguration _configuration;

        public DatabaseInitializer(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void InitializeDatabase()
        {
            // Reads the DatabaseSettings section of the configuration file.
            var dbSettings = _configuration.GetSection("DatabaseSettings").Get<DatabaseSettings>();
            if (dbSettings == null)
            {
                Console.WriteLine("Configurações do banco de dados não foram encontradas.");
                return;
            }

            // Mount the paths.
            string databaseFolder = dbSettings.DatabaseFolder;
            string databaseFile = Path.Combine(databaseFolder, dbSettings.DatabaseFileName);
            string sqlFile = dbSettings.SqlFilePath;

            // Ensures the bank folder exists.
            if (!Directory.Exists(databaseFolder))
            {
                Directory.CreateDirectory(databaseFolder);
                Console.WriteLine($"Pasta '{databaseFolder}' criada.");
            }

            // Creates the database if it does not already exist.
            if (!File.Exists(databaseFile))
            {
                Console.WriteLine("Criando banco de dados...");

                using (var connection = new SqliteConnection($"Data Source={databaseFile}"))
                {
                    connection.Open();

                    if (File.Exists(sqlFile))
                    {
                        string sqlScript = File.ReadAllText(sqlFile);
                        using (var command = connection.CreateCommand())
                        {
                            command.CommandText = sqlScript;
                            command.ExecuteNonQuery();
                        }

                        Console.WriteLine("Banco de dados criado com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Arquivo SQL não encontrado!");
                    }
                }
            }
            else
            {
                Console.WriteLine("Banco de dados já existe.");
            }
        }
    }
}