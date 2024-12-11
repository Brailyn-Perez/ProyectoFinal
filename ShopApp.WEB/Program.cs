using Microsoft.EntityFrameworkCore;
using ShopApp.DAL.Context;
using ShopApp.DAL.Daos;
using ShopApp.DAL.Interfaces;

var builder = WebApplication.CreateBuilder(args);
// add context
builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("ShopApp")));

builder.Services.AddScoped<IDaoCategory, DaoCategory>();


// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
