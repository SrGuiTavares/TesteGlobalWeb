using AutoMapper;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System;
using TesteTecnico.Application.AutoMapper;
using TesteTecnico.Application.Interface;
using TesteTecnico.Application.Service;
using TesteTecnico.Application.ViewModel;
using TesteTecnico.Domain.Entites;
using TesteTecnico.Domain.Interface.Repository;
using TesteTecnico.Domain.Interface.Service;
using TesteTecnico.Domain.Service;
using TesteTecnico.Infra.Core.Context;
using TesteTecnico.Infra.Core.Repository;
using TesteTecnico.WebApi.Rest.Validators;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//AutoMapper e Dependecie Injection
var config = new MapperConfiguration(cfg =>
{
    cfg.AddProfile(new MappingProfiles());
});

IMapper mapper = config.CreateMapper();
builder.Services.AddSingleton(mapper);

builder.Services.AddScoped<IUsuarioAppService, UsuarioAppService>();

builder.Services.AddScoped<IUsuarioService, UsuarioService>();

builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();

builder.Services.AddScoped<IValidator<UsuarioViewModel>, UsuarioValidator>();

builder.Services.AddDbContext<AppDbContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "MyPolicy",
                      policy =>
                      {
                          policy.WithOrigins("http://localhost:4200")
                                                .AllowAnyHeader()
                                                .AllowAnyMethod();
                      });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("MyPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
