using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using BlazorServerTestIis.Data;
using MudBlazor.Services;
using BlazorServerTestIis.Application.Queries;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddMudServices();

// Connect to the DB with EF Core
var connectionString = builder.Configuration.GetConnectionString("HukarConnection");
builder.Services.AddDbContextFactory<RobotContext>(
    options => options.UseSqlServer(connectionString)
);


// Add MediatR
builder.Services.AddMediatR(typeof(Program));

var app = builder.Build();

// Reset database for testing
using var serviceScope = app.Services.CreateScope();
var robotContext = serviceScope.ServiceProvider.GetService<RobotContext>();
if(robotContext is not null)
{
    Console.WriteLine("database reinitialized");
    await robotContext.Database.EnsureDeletedAsync();
    await robotContext.Database.EnsureCreatedAsync();
}


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseCountMiddleware();

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();


app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.MapRobot();

app.Run();

