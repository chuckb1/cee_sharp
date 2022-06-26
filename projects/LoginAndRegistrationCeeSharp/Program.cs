using Microsoft.EntityFrameworkCore;
using LoginAndRegistrationCeeSharp.Models;


var builder = WebApplication.CreateBuilder(args);

//add services to the container
builder.Services.AddHttpContextAccessor();
builder.Services.AddControllersWithViews();

builder.Services.AddSession();
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<MyContext>(options =>
{
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseSession();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
