using BudgetVsActual.API;
using static Application.DependencyInjection;
using static BudgetVsActual.DependencyInjection;
using static EFCoreSQLServer.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

builder.Services
    .AddInfrastructure_DataAccessServices(connectionString)
    .AddInfrastructure_JWTTokens(builder.Configuration)
    .AddApplication()
    .AddPresentation(builder.Configuration);

var app = builder.Build();

//app.UseStatusCodePages(async statusCodeContext
//    => await Results.Problem(statusCode: statusCodeContext.HttpContext.Response.StatusCode)
//                 .ExecuteAsync(statusCodeContext.HttpContext));

EndPoints.Map(app);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();
