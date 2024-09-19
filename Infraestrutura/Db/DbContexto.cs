using Microsoft.EntityFrameworkCore;
using MinimalAPI.Dominio.Entidades;

namespace MinimalAPI.Infraestrutura.Db;


public class DbContexto : DbContext 
{
    public DbSet<Administrador> Administradores {get; set; } = default!;

    private readonly IConfiguration _configuracaoAppSettings;
    public DbContexto (IConfiguration configuracaoAppSettings)
    {
        _configuracaoAppSettings = configuracaoAppSettings;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var stringConexao = _configuracaoAppSettings.GetConnectionString("sqlserver")?.ToString();
        if (!string.IsNullOrEmpty(stringConexao))
        {
             optionsBuilder.UseSqlServer(stringConexao);
        }     
    }
}