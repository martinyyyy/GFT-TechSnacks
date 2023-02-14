using Steeltoe.Discovery.Client;
using Steeltoe.Extensions.Configuration.ConfigServer;

var builder = WebApplication.CreateBuilder(args);

//Use Config Server for configuration
builder.AddConfigServer();

// Service Discovery
builder.Services.AddDiscoveryClient(builder.Configuration);

// Add Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.MapGet("/", () => $"Hello TechSnacks Konstanz!! Enjoy a {builder.Configuration["drink"]} with us!");

// Add Swagger UI
app.UseSwagger().UseSwaggerUI();


app.Run();