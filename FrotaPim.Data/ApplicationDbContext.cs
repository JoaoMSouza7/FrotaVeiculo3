
using FrotaPim.Domain.Entidades;
using Microsoft.EntityFrameworkCore;

namespace FrotaPim.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Cargo> cargo { get; set; }
        public DbSet<Carro> carro { get; set; }
        public DbSet<ContasAPagar> contasAPagar { get; set; }
        public DbSet<Endereco> endereco { get; set; }
        public DbSet<Estoque> estoque { get; set; }
        public DbSet<Manutencao> manutencao { get; set; }
        public DbSet<Multa> multas { get; set; }
        public DbSet<Pessoa> pessoa { get; set; }
        public DbSet<Seguro> seguro { get; set; }

    }
}