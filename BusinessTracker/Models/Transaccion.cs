using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessTracker.Models
{
    public class Transaccion
    {
        [Key]
        public int TransactionId { get; set; }

        [Column(TypeName = "nvarchar(50)")]

        public string NameId { get; set; } = "N/A";

        [Column(TypeName = "nvarchar(50)")]

        public Comida Name { get; set; } = new Comida();

        [Column(TypeName = "nvarchar(50)")]

        public double Amount { get; set; }

        [Column(TypeName = "nvarchar(50)")]

        public string Description { get; set; } = "N/A";

        [Column(TypeName = "nvarchar(10)")]

        public DateTime Date { get; set; } = DateTime.Now;
    }
}
