using Livraria.Application.Interface;
using Livraria.Application.UseCase;
using Livraria.Domain.Interface;
using Livraria.Infra.Data;
using Livraria.Infra.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//Memory 
builder.Services.AddDbContext<LivrariaContext>(options =>
    options.UseInMemoryDatabase("TestDb"));



//Injecao de dendencia
builder.Services.AddScoped<ILivroRepository, LivroRepository>();
builder.Services.AddScoped<ILivroUseCase, LivroUseCase>();


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
