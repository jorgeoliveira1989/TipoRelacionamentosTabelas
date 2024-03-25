using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using TipoRelacionamentosTabelas.Models;

namespace TipoRelacionamentosTabelas.Data
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext>options): base(options)
        {
            
        }

        public DbSet<casaModel> Casas { get; set; }
        public DbSet<moradaModel> Moradas { get; set; }
        public DbSet<MoradorModel> Moradores { get; set; }

    }
}
