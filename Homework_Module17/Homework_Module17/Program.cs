using Homework_Module17.Models;
using Homework_Module17.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(name: "default",
                       pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();