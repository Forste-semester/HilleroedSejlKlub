
using HillerødSejlKlub.Services; // Ensure this namespace is included for EventRepository

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
