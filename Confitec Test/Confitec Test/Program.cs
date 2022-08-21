using AutoMapper;
using Confitec.WebAPI.Aplication.Config;
using Confitec.WebAPI.Domain.Interfaces.Repository;
using Confitec.WebAPI.Infra.Data.Context;
using Confitec.WebAPI.Infra.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connection = builder.Configuration["SqlserverConnection:SqlserverConnectionString"];

builder.Services.AddDbContext<SQLServerContext>(options => options.UseSqlServer(connection));

IMapper mapper = MappingConfig.RegisterMaps().CreateMapper();

builder.Services.AddSingleton(mapper);
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<IEscolaridadeRepository, EscolaridadeRepository>();
builder.Services.AddScoped<IHistoricoEscolarRepository, HistoricoEscolarRepository>();

// Add services to the container.

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

app.UseAuthorization();

app.MapControllers();

app.Run();
