using HillerødSejlKlub.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<BoatRepository>();

// Add services to the container.
builder.Services.AddRazorPages();

builder.Logging.ClearProviders(); // Optional: clears default providers
builder.Logging.AddConsole();    // Logs to the console
builder.Logging.AddDebug();      // Logs to Visual Studio Debug output

var app = builder.Build();

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
