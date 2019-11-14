
using FrotaPim.Domain.Entidades;
using Microsoft.EntityFrameworkCore;

namespace FrotaPim.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Cargo> cargo {get; set;}
    }
}