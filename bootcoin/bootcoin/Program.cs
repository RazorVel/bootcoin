using bootcoin.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<BootcoinDbContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("BootcoinConnectionString")));
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<BootcoinDbContext>();

builder.Services.AddControllersWithViews();
builder.Services.AddSession();
builder.Services.AddDistributedMemoryCache();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseSession();

app.UseAuthentication();
app.UseAuthorization();

//app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "Login",
    pattern: "Login/{action}",
    defaults: new { Controller = "Login", action = "Index" }
);

app.MapControllerRoute(
    name: "Register",
    pattern: "Register/{action}",
    defaults: new { Controller = "Register", action = "Index" }
);

app.MapControllerRoute(
    name: "Admin",
    pattern: "Admin/{action}",
    defaults: new { controller = "Admin", action = "Index" }
);

app.MapControllerRoute(
    name: "Trainee",
    pattern: "Trainee/{action}",
    defaults: new { controller = "Trainee", action = "Index" }
);

app.MapControllerRoute(
    name: "Debug",
    pattern: "Debug/{action}",
    defaults: new { controller = "Debug", action = "Index" }
);

app.MapControllerRoute(
    name: "Exception",
    pattern: "{controller}/{action}",
    defaults: new { controller = "Home", action = "Index" }
);

app.Run();
