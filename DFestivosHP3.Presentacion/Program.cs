using DFestivosHP3.Aplicacion;
using DFestivosHP3.Core.Interfaces.Servicios;
using DFestivosHP3.Infraestructura.Repositorio.Contextos;
using DFestivosHP3.Infraestructura.Repositorio;
using Microsoft.EntityFrameworkCore;
using DFestivosHP3.Core.Interfaces.Repositorios;

var builder = WebApplication.CreateBuilder(args);

// Configura el contexto de base de datos
builder.Services.AddDbContext<DFestivosHP3Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexionSqlString")));

// Registra el repositorio
builder.Services.AddScoped<IFestivoRepositorio, FestivoRepositorio>();

// Registra el servicio
builder.Services.AddScoped<IFestivoServicio, FestivoServicio>();

// Agrega servicios de controladores
builder.Services.AddControllers();

// Configura Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configura el pipeline de middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();
app.UseAuthorization();
app.MapControllers();

app.Run();
