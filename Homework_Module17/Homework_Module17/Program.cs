var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(name: "default",
                       pattern: "{controller=User}/{action=Index}/{id?}");

app.Run();