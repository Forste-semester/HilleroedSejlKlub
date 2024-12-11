using HillerødSejlKlub.Data;
using HillerødSejlKlub.Models;
using HillerødSejlKlub.Services;
using HilleroedSejlKlubLibrary.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddSingleton<BookingRepository>();
builder.Services.AddSingleton<UserRepository>();
builder.Services.AddSingleton<BoatRepository>();

builder.Logging.ClearProviders(); // Optional: clears default providers
builder.Logging.AddConsole();    // Logs to the console
builder.Logging.AddDebug();      // Logs to Visual Studio Debug output


public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Register EventRepository as a scoped service
        builder.Services.AddScoped<EventRepository>();
        builder.Services.AddScoped<UserRepository>();

        // Add Razor Pages
        builder.Services.AddRazorPages();

        var app = builder.Build();

        // Enable static file serving
        app.UseStaticFiles(); // This serves files from the wwwroot folder

        // Configure routing and authorization middleware
        app.UseRouting();
        app.UseAuthorization();

        // Map Razor Pages
        app.MapRazorPages();

        app.Run();
    }
}
