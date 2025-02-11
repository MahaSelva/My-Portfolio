var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Enable serving of static files
app.UseStaticFiles();

// Fallback to serve "index.html" if no route matches
app.MapFallbackToFile("index.html");

// Run the application
app.Run();
