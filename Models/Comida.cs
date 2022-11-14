using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MySql.Data.MySqlClient;

namespace BusinessTracker.Models
{
    public class Comida
    {
        // [Key]
        public int NameId { get; set; }

        // [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; } = "N/A";

        // [Column(TypeName = "nvarchar(2)")]
        public string Icon { get; set; } = "";

        // [Column(TypeName = "nvarchar(50)")]
        public string Type { get; set; } = "Outcome";


    }
}
