using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessTracker.Models
{
    public class Transaccion
    {
        [Key]
        public int TransactionId {get; set;}

        [(TypeName = "nvchar(50)")]

        public string NameId {get; set;}

        [(TypeName = "nvachar(50)")]

        public Comida Name {get; set;}

        [(TypeName = "nvarchar(50)")]

        public double Amount {get; set;}

        [(TypeName = "nvachar(50)")]

        public string Description {get; set;}

        [(TypeName = "nvachar(10)")]

        public DateTime Date {get; set;} = DateTime.Now;
    }
}
