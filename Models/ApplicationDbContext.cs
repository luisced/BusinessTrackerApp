using MySql.Data.MySqlClient;
using Microsoft.EntityFrameworkCore;
namespace BusinessTracker.Models
{
    public class ApplicationDbContext
    {
        public string ConnectionString { get; set; }
        public ApplicationDbContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }
        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
        public List<Comida> GetAllComida()
        {
            List<Comida> list = new List<Comida>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Comida", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Comida()
                        {
                            NameId = Convert.ToInt32(reader["NameId"]),
                            Name = reader.GetString("Name"),
                            Icon = reader.GetString("Icon"),
                            Type = reader.GetString("Type")
                        });
                    }
                }
            }
            return list;
        }
    }



    // public DbSet<Comida> Comidas { get; set; }
    // public DbSet<Transaccion> Transacciones { get; set; }
    // public class ApplicationDbContext : DbContext
    // {
    //     public ApplicationDbContext(DbContextOptions options) : base(options)
    //     {

    //     }

    //     public DbSet<Transaccion> Transacciones { get; set; }
    //     public DbSet<Comida> Comidas { get; set; }
    // }
}