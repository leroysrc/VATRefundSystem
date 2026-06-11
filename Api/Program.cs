var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
<<<<<<< HEAD
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
=======
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
>>>>>>> e4d2c5a59179ffe0f67be027942cac019c50ea65

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
<<<<<<< HEAD
    app.MapOpenApi();
=======
    app.UseSwagger();
    app.UseSwaggerUI();
>>>>>>> e4d2c5a59179ffe0f67be027942cac019c50ea65
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
<<<<<<< HEAD
.WithName("GetWeatherForecast");
=======
.WithName("GetWeatherForecast")
.WithOpenApi();
>>>>>>> e4d2c5a59179ffe0f67be027942cac019c50ea65

app.Run();

internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
