using System.Text.Json.Serialization;
using budget_api.Middleware;
using budget_api.Repositories;
using budget_api.Services;
using Microsoft.AspNetCore.HttpOverrides;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// 1. Production CORS Policy (Crucial if accessed by a web or mobile client)
builder.Services.AddCors(options =>
{
    options.AddPolicy("ProductionCors", policy =>
    {
        // Replace with your actual frontend URL(s) when deployed
        policy.WithOrigins("https://your-frontend-domain.com") 
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

// 2. Health Checks (Essential for cloud platforms to monitor container readiness)
builder.Services.AddHealthChecks();

// Add services to the container.
builder.Services.AddSingleton<ITransactionRepository, TransactionRepository>();
builder.Services.AddScoped<ITransactionService, TransactionService>();

builder.Services
    .AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.Converters.Add(
            new JsonStringEnumConverter());
    });
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference("/docs");
}
else
{
    // 3. Forwarded Headers for Cloud Hosting (Cloud Run, GKE, etc.)
    // Cloud infrastructure terminates SSL at the load balancer. 
    // This ensures .NET knows the original request was HTTPS.
    app.UseForwardedHeaders(new ForwardedHeadersOptions
    {
        ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
    });
    
    app.UseHsts();
}

app.UseMiddleware<ExceptionHandlingMiddleware>();

// Apply CORS before routing and authorization
app.UseCors("ProductionCors");

app.UseHttpsRedirection();

app.UseAuthorization();

// 4. Map the Health Check endpoint
app.MapHealthChecks("/health");

app.MapControllers();

app.Run();