using Newtonsoft.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddControllers();
builder.Services.AddMvc();


var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
  app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.MapControllers();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/");
app.MapControllerRoute(
    name: "default-api",
    pattern: "api/{controller=Home}/{action=Index}/{id?}"); // The pattern for return all API Controller request.
app.MapControllerRoute(
            name: "angular",
            pattern: "{*url}",
            defaults: new { controller = "FrontEnd", action = "Index" }); // The view that bootstraps Angular

app.Run();
