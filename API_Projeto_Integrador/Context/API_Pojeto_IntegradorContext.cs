using API_Projeto_Integrador.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Projeto_Integrador.Context;

public class API_Pojeto_IntegradorContext : DbContext
{
    // Contrutor que contém as configurações do db
    public API_Pojeto_IntegradorContext(DbContextOptions<API_Pojeto_IntegradorContext> options) : base(options)
    {
            
    }

    // Mapeamento de objetos relacionais
    public DbSet<Empreendimento>? Empreendimentos { get;  set; }
    public DbSet<Endereco>? Enderecos { get; set; }
    public DbSet<Lojista>? Lojistas { get; set; }
    public DbSet<Registro>? Registros { get; set; }
    public DbSet<Tipo_Empreendimento>? tipo_Empreendimentos { get; set; }
    public DbSet<Tipo_Registro>? tipo_Registros { get; set; }
    public DbSet<Usuario>? Usuarios { get; set; }
}
