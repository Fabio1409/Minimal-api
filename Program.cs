var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/login", (MinimalApi.Dominio.DTOs.LoginDTO loginDTO) =>
{
    // Implement your login logic here
    if (loginDTO.Email == "admin@teste.com" && loginDTO.Senha == "acesso@123")
    {
        return Results.Ok("Login com sucesso!");
    }
    return Results.Unauthorized();
});

app.Run();




