using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace projekt_app.Models
{
    public class Category
    {
        // Server name: DESKTOP-CMMD1H6
        [Key]

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "Display order can only be between 1 and 100.")]
        public string DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
