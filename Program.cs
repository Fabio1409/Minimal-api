using Microsoft.EntityFrameworkCore;
using minimal_api.InfraEstrutura.DB;
using minimal_api.Dominio.DTOs;
using minimal_api.InfraEstrutura.Interfaces;
using minimal_api.Dominio.Servicos;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IAdministradorServico, AdministradorServico>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configura serviços
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("mysql"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("mysql"))
    )
);

var app = builder.Build();


// Rotas
app.MapGet("/", () => "Hello World!");

app.MapPost("/login", ([FromBody] LoginDTO loginDTO, IAdministradorServico administradorServico) =>
{
    var adm = administradorServico.Login(loginDTO);
    if (adm != null)
    {
        return Results.Ok("Login com sucesso!");
    }
    return Results.Unauthorized();
});

app.UseSwagger();
app.UseSwaggerUI();

app.Run();

