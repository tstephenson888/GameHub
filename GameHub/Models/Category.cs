using System.ComponentModel.DataAnnotations;

namespace GameHub.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Required]
        [MaxLength(50)]
<<<<<<< Updated upstream
        public string? Name { get; set; }

        // ref list of child Products
        public List<Product>? Products { get; set; }
=======
        public string? CategoryName { get; set; }

        // list of child products
        public List<Product>? Products
        {
            get; set;
        }
>>>>>>> Stashed changes
    }
}
