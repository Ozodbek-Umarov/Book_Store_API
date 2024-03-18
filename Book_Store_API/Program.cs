using Application.Common;
using Application.Validators;
using AutoMapper;
using Domain.Entities;
using FluentValidation;
using Infrastructures;
using Infrastructures.Inrerfaces;
using Infrastructures.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("LocalDB")));

builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();

//add AutoMapper
var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new AutoMapperProfile());
});

builder.Services.AddSingleton(mapperConfig.CreateMapper());
builder.Services.AddScoped<IValidator<Author>, AuthorValidator>();
builder.Services.AddScoped<IValidator<Janr>, JanrValidator>();
builder.Services.AddScoped<IValidator<Book>, BookValidator>();

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
