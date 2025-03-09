using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

//add swagger 
builder.Services.AddAuthorization();
builder.Services.AddAuthentication();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();

builder.Services.AddSwaggerGen( options => {
    options.SwaggerDoc( "v1", new OpenApiInfo 
    { 
        Title = "Personal Finance Tracker API",
        Version = "v1",
        Description = "API documentation for the Personal Finance Tracker."
    }); 
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => {
        c.SwaggerEndpoint( "/swagger/v1/swagger.json", "Personal Finance Tracker API V1");
        c.RoutePrefix = string.Empty;
    });
}

app.UseAuthorization();
app.UseAuthentication();

app.MapControllers();

app.Run();

