using System.ComponentModel.DataAnnotations;

namespace GameHub.Models
{
    public class CartItem
    {
        public int CartItemId { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public string? CustomerId { get; set; }

        [Required]
        public int ProductId { get; set; }

<<<<<<< Updated upstream
        // parent ref to Product - every cartitem is for only 1 product
=======
>>>>>>> Stashed changes
        public Product? Product { get; set; }
    }
}
