using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace BusinessTracker.Models
{
    public class Transaction
    {
        //Se define propiedad para clave con valor unico
        [Key]
        public int TransactionId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Por favor selecciones una categoría.")]

        //Se definen propiedades
        [Column(TypeName = "nvarchar(50)")]

        public int FoodId { get; set; }
        public Food? Food { get; set; } = new Food();

        [Range(1, int.MaxValue, ErrorMessage = "El monto debe ser mayor a 0.")]
        public double Amount { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string? Description { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;
        [NotMapped]
        public string? FoodWithIcon
        {
            get
            {
                return Food == null ? "" : Food.Icon + " " + Food.Name;
            }
        }
    }
}
