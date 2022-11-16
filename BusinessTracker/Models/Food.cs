using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessTracker.Models
{
    public class Food
    {
        [Key]
        public int FoodId { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [Required(ErrorMessage = "Es necesario un nombre.")]
        public string Name { get; set; } = "";

        [Column(TypeName = "nvarchar(2)")]
        public string Icon { get; set; } = "";

        [Column(TypeName = "nvarchar(50)")]
        public string Type { get; set; } = "Outcome";

        [NotMapped]
        public string? NameWithIcon
        {
            get
            {
                return this.Icon + " " + this.Name;
            }
        }

    }
}
