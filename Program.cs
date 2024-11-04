using Microsoft.EntityFrameworkCore;
using my_app.Context;
using my_app.Converter;
using my_app.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<LocationContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<ILocationService, LocationService>();
builder.Services.AddScoped<ILocationConverter, abcLocationConverter>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserConverter,UserConverter >();
builder.Services.AddHttpClient<IWeatherForecastAdaptor, WeatherForecastAdaptor>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
