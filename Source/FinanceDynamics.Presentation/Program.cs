using FinanceDynamics.Application.Factories;
using FinanceDynamics.Application.Interfaces;
using FinanceDynamics.Domain.Interfaces;
using FinanceDynamics.Domain.Services;
using FinanceDynamics.Domain.Validators;
using FinanceDynamics.Presentation.Components;
using MudBlazor;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

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

// Factories 
builder.Services.AddTransient<IExpenseFactory, ExpenseFactory>();
builder.Services.AddTransient<IIncomeFactory, IncomeFactory>();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();