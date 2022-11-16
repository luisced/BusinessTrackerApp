using Microsoft.EntityFrameworkCore;
namespace BusinessTracker.Models
{
    public class ApplicationDbContext
    {
        [Key]
        public int FoodId { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; } = "N/A";

        [Column(TypeName = "nvarchar(2)")]
        public string Icon { get; set; } = "";

        [Column(TypeName = "nvarchar(50)")]
        public string Type { get; set; } = "Outcome";


    }
}