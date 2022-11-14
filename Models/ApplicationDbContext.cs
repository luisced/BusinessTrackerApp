using Microsoft.EntityFrameworkCore;
namespace BusinessTracker.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Transaccion> Transacciones { get; set; }
        public DbSet<Comida> Comidas { get; set; }
    }
}