using MiniBank.Application.Configurations;
using MiniBank.Infrastructure.Configurations;
using MiniBank.Presantion.Configurations;
using Serilog;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;
// Add services to the container.
builder.Services
    .AddApplicationLayer()
    .AddDataLayer(configuration)
    .AddPresetantionLayer();

builder.Services.ConfigureSerilog(configuration);
builder.Host.UseSerilog();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
