using AutoMapper;
using DemoTimer.Api.Data.Contexts;
using DemoTimer.Api.Data.IRepasitories;
using DemoTimer.Api.Data.Repasitories;
using DemoTimer.Api.Service.Interfaces;
using DemoTimer.Api.Service.Mappers;
using DemoTimer.Api.Service.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(MappingProfile));
builder.Services.AddScoped<ITimeService, TimeService>();
builder.Services.AddScoped(typeof(IRepasitory<>), typeof(Repasitory<>));

// Add AbbDbContext
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

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
