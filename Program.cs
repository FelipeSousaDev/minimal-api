using Microsoft.EntityFrameworkCore;
using MinimalAPI.DTO;
using MinimalAPI.Infraestrutura.Db;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.AddDbContext<DbContexto>(options => {
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("sqlserver")
    );
});


app.MapGet("/", () => "Olá Mundo");
app.MapPost("/login", (LoginDTO loginDTO) => {
    if (loginDTO.Email == "adm@teste.com.br" && loginDTO.Senha == "123456")
        return Results.Ok("Login com sucesso");
    else
        return Results.Unauthorized();
    });

    app.Run();

