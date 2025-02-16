using FinanceDynamics.Application.Factories;
using FinanceDynamics.Application.Interfaces;
using FinanceDynamics.Domain.Entities;
using FinanceDynamics.Domain.Interfaces;
using FinanceDynamics.Domain.Services;
using FinanceDynamics.Infrastructure.Context;
using FinanceDynamics.Infrastructure.Database;
using FinanceDynamics.Infrastructure.Interfaces;
using FinanceDynamics.Infrastructure.Mappers;
using FinanceDynamics.Infrastructure.Repositories;
using FinanceDynamics.Presentation.GUI;
using FinanceDynamics.Presentation.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = CreateHostBuilder(args).Build();

// Initialize the database if it does not exist.
using (var scope = host.Services.CreateScope())
{
    var databaseInitializer = scope.ServiceProvider.GetRequiredService<IDatabaseInitializer>();
    databaseInitializer.InitializeDatabase();
}

try
{
    var graphicalUserInterface = host.Services.GetRequiredService<IGraphicalUserInterface>();
    graphicalUserInterface.InitializeGUI();

    var app = host.Services.GetRequiredService<IStartApp>();
    await app.Run();
}
catch (Exception error)
{
    var graphicalUserInterface = host.Services.GetRequiredService<IGraphicalUserInterface>();
    graphicalUserInterface.SetErrorAppearance();

    Console.WriteLine("\n");
    Console.WriteLine($"{error.Message}");
}
finally
{
    var graphicalUserInterface = host.Services.GetRequiredService<IGraphicalUserInterface>();
    graphicalUserInterface.SetSuccessAppearance();

    Console.WriteLine("\n");
    Console.WriteLine("Aplicação finalizada.");
    Console.ReadLine();
}

static IHostBuilder CreateHostBuilder(string[] args) =>
    Host.CreateDefaultBuilder(args)
        .ConfigureServices((context, services) =>
        {
            // DatabaseInitializer
            services.AddSingleton<IDatabaseInitializer, DatabaseInitializer>();

            // Get the connection string from appsettings.json.
            var connectionString = context.Configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<FinanceDbContext>(options =>
                options.UseSqlite(connectionString));

            // Factories
            services.AddScoped<IContactFactory, ContactFactory>();
            services.AddScoped<IStandardCurrencyFactory, StandardCurrencyFactory>();
            services.AddScoped<IPasswordFactory, PasswordFactory>();
            services.AddScoped<IUserFactory, UserFactory>();
            services.AddScoped<ISubcategoryFactory, SubcategoryFactory>();
            services.AddScoped<ITransactionCategoryFactory, TransactionCategoryFactory>();
            services.AddScoped<INameAndDescriptionFactory, NameAndDescriptionFactory>();
            services.AddScoped<ITransactionalMethodFactory, TransactionalMethodFactory>();
            services.AddScoped<ICurrencyFactory, CurrencyFactory>();
            services.AddScoped<IInstallmentFactory, InstallmentFactory>();
            services.AddScoped<ITransactionFileFactory, TransactionFileFactory>();
            services.AddScoped<IRevenueFactory, RevenueFactory>();
            services.AddScoped<IExpenseFactory, ExpenseFactory>();
            services.AddScoped<IFixedIncomeFinancialInstitutionFactory, FixedIncomeFinancialInstitutionFactory>();
            services.AddScoped<IVariableIncomeFinancialInstitutionFactory, VariableIncomeFinancialInstitutionFactory>();
            services.AddScoped<ICDBFactory, CDBFactory>();
            services.AddScoped<IShareFactory, ShareFactory>();

            // Services
            services.AddScoped<IContactValidator, ContactValidator>();
            services.AddScoped<IStandardCurrencyValidator, StandardCurrencyValidator>();
            services.AddScoped<IPasswordValidator, PasswordValidator>();
            services.AddScoped<IPersonValidator, PersonValidator>();
            services.AddScoped<ITransactionCategoryValidator, TransactionCategoryValidator>();
            services.AddScoped<INameAndDescriptionValidator, NameAndDescriptionValidator>();
            services.AddScoped<IPasswordRulesProvider, PasswordRulesProvider>();
            services.AddScoped<ICurrencyValidator, CurrencyValidator>();
            services.AddScoped<IInstallmentValidator, InstallmentValidator>();
            services.AddScoped<ITransactionFileValidator, TransactionFileValidator>();
            services.AddScoped<ITransactionValidator, TransactionValidator>();
            services.AddScoped<IInvestmentValidator, InvestmentValidator>();
            services.AddScoped<IFinancialInstitutionValidator, FinancialInstitutionValidator>();
            services.AddScoped<ICDBValidator, CDBValidator>();
            services.AddScoped<IShareCalculate, ShareCalculate>();
            services.AddScoped<IShareValidator, ShareValidator>();

            // Repositories
            services.AddScoped<ICurrencyRepository, CurrencyRepository>();
            services.AddScoped<IMapper<Currency, CurrencyMapper>, CurrencyMapper>();

            // GUI
            services.AddTransient<IStartApp, StartApp>();
            services.AddTransient<IGraphicalUserInterface, GraphicalUserInterface>();
            services.AddTransient<IStart, Start>();
            services.AddTransient<ITextGraphicalUserInterface, TextGraphicalUserInterface>();
        });