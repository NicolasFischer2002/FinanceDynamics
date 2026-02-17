using FinanceDynamics.Application.Factories;
using FinanceDynamics.Application.Interfaces;
using FinanceDynamics.Application.Services;
using FinanceDynamics.Domain.Interfaces;
using FinanceDynamics.Domain.Services;
using FinanceDynamics.Domain.Validators;
using FinanceDynamics.Infrastructure.Data;
using FinanceDynamics.Infrastructure.Repositories;
using FinanceDynamics.Presentation.Components;
using Microsoft.EntityFrameworkCore;
using MudBlazor;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);


// EF Core
//var connectionString = builder.Configuration.GetConnectionString("Default");
//    builder.Services.AddDbContext<FinanceDbContext>(options =>
//    options.UseSqlite(connectionString));

var dbFileName = "FinanceDynamics.db";
var dbRelativeFolder = "Database";
var dbPath = Path.Combine(AppContext.BaseDirectory, dbRelativeFolder, dbFileName);

var configured = builder.Configuration.GetConnectionString("Default");

if (!string.IsNullOrWhiteSpace(configured) && !configured.Contains("Data Source="))
{
    builder.Services.AddDbContext<FinanceDbContext>(options =>
        options.UseSqlite(configured));
}
else
{
    var conn = $"Data Source={dbPath}";
    builder.Services.AddDbContext<FinanceDbContext>(options =>
        options.UseSqlite(conn));
}

// Add MudBlazor services
builder.Services.AddMudServices(config =>
{
    config.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.BottomLeft;

    config.SnackbarConfiguration.PreventDuplicates = false;
    config.SnackbarConfiguration.NewestOnTop = false;
    config.SnackbarConfiguration.ShowCloseIcon = true;
    config.SnackbarConfiguration.VisibleStateDuration = 5000;
    config.SnackbarConfiguration.HideTransitionDuration = 350;
    config.SnackbarConfiguration.ShowTransitionDuration = 350;
    config.SnackbarConfiguration.SnackbarVariant = Variant.Text;
    config.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.TopEnd;
});


builder.Services.AddTransient(
    typeof(IValidateTransactionCategoryAndSubcategory<,>),
    typeof(TransactionCategoryValidator<,>)
);

// Services
builder.Services.AddTransient<ITransactionCategoryService, TransactionCategoryService>();
builder.Services.AddTransient<ITransactionSubcategoryService, TransactionSubcategoryService>();
builder.Services.AddTransient<ITransactionReceiptService, TransactionReceiptService>();

// Factories 
builder.Services.AddTransient<IExpenseFactory, ExpenseFactory>();
builder.Services.AddTransient<IIncomeFactory, IncomeFactory>();

// Repositories
builder.Services.AddTransient<IIncomeRepository, IncomeRepository>();
builder.Services.AddTransient<IExpenseRepository, ExpenseRepository>();
builder.Services.AddTransient<IFinancialStatement, FinancialStatementRepository>();
builder.Services.AddTransient<ITransactionReceiptRepository, TransactionReceiptRepository>();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddSingleton<DateRangeState>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();