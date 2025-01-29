using AulaRazorPages.Web.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.Services.AddDbContext<MoviesContext>(options =>
{
    options.UseInMemoryDatabase("MyFirstApp");
});

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.UseHttpsRedirection();

app.UseRouting();

app.MapRazorPages();

app.Run();
