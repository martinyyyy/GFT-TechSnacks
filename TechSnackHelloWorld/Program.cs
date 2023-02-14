using Steeltoe.Discovery.Client;
using Steeltoe.Extensions.Configuration.ConfigServer;

var builder = WebApplication.CreateBuilder(args);

//Use Config Server for configuration
builder.AddConfigServer();

// Service Discovery
builder.Services.AddDiscoveryClient(builder.Configuration);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.MapGet("/", () => "Hello TechSnacks Konstanz!!");
app.UseSwagger().UseSwaggerUI();


app.Run();