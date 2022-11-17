using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
namespace BusinessTracker.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Por favor seleccione un platillo")]
        public int FoodId { get; set; }
        public Food? Food { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "El monto debe ser mayor a 0")]
        public int Amount { get; set; }

        [Column(TypeName = "nvarchar(75)")]
        public string? Note { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;

        [NotMapped]
        public string? FoodTitleWithIcon
        {
            get
            {
                return Food == null ? "" : Food.Icon + " " + Food.Title;
            }
        }

        [NotMapped]
        public string? FormattedAmount
        {

            get
            {
                return ((Food == null || Food.Type == "Gasto") ? "- " : "+ ") + String.Format(CultureInfo.CreateSpecificCulture("en-US"), "{0:C0}", Amount);

            }
        }

    }
}
