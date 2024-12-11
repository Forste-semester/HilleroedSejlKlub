using HillerødSejlKlub.Data;
using HillerødSejlKlub.Models;
using HillerødSejlKlub.Services;
using HilleroedSejlKlubLibrary.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<BoatRepository>();

// Add services to the container.
builder.Services.AddRazorPages();

builder.Logging.ClearProviders(); // Optional: clears default providers
builder.Logging.AddConsole();    // Logs to the console
builder.Logging.AddDebug();      // Logs to Visual Studio Debug output

var app = builder.Build();

// Lav en ny båd
var boatCollection = app.Services.GetRequiredService<BoatRepository>();
boatCollection.AddBoat(new Boat("Testbåd", "Yamaha X-200", BoatType.Motorbåd, 20, 2021, "BT1234", new DieselEngine("Bladt Diesel X-200", 40, FuelType.DIESEL), "/images/motorbaad.jpg"));


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
