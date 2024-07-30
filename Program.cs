var builder = WebApplication.CreateBuilder(args);

//minimum support for the MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// middleware for the accessing staticfiles

app.UseStaticFiles(); 

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();
