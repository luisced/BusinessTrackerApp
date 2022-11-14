using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessTracker.Models
{
    public class Transaccion
    {
        //Se define propiedad para clave con valor unico
        [Key]
        public int TransactionId { get; set; }

        //Se definen propiedades

        public string NameId { get; set; }
        public Comida Name { get; set; }

        [Column(TypeName = "nvarchar(50)")]

        public double Amount { get; set; }

        [Column(TypeName = "nvarchar(50)")]

        public string? Description { get; set; }

        //Se define propiedad de fecha con formato año, mes, dia
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-mm-dd}", ApplyFormatInEditMode = true)]

        //Se crea propiedad de fecha con valor default
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
