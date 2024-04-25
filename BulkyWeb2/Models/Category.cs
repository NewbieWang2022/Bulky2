using System.ComponentModel.DataAnnotations;

namespace BulkyWeb2.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        public int DisplayOrder { get; set; }

    }
}
