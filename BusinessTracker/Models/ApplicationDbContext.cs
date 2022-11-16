using Microsoft.EntityFrameworkCore;
namespace BusinessTracker.Models
{
    public class ApplicationDbContext: DbContext
    {
        public  ApplicationDbContext(DbContextOptions options): base(options)
        {
            
        }
        public DbSet<Transaction> Transactions{get; set;} 

        public DbSet<Food> Foods{get; set;} 

    }
}