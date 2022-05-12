using Microsoft.EntityFrameworkCore;
using Rental_House_Management_System.Data;
using Rental_House_Management_System.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddCors();

var connectionString = builder.Configuration.GetConnectionString("RetalHousesDatabase");


builder.Services.AddDbContext<RoomDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDbContext<CustomerDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<IRoomService, RoomService>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseCors(x => x.AllowAnyHeader().AllowAnyMethod().WithOrigins("https://localhost:44412"));



app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;

app.Run();
