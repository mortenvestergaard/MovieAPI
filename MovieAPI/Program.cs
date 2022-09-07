﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovieAPI.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<MovieAPIContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MovieAPIContext") ?? throw new InvalidOperationException("Connection string 'MovieAPIContext' not found.")));

// Add services to the container.

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "cors",
                      policy =>
                      {
                          policy.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
                      });
});

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

app.UseCors("cors");
app.UseHttpsRedirection();


app.UseAuthorization();

app.MapControllers();

app.Run();
