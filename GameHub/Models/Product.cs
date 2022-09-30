using System.ComponentModel.DataAnnotations;

namespace GameHub.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        // validation rules go directly above the property they check
        [MinLength (2, ErrorMessage = "Hey!  This is way too short!")]
        [MaxLength (100)]
        [Required]
        public string? Name { get; set; }

        [Range(0.01, 999999)]
        public decimal? Price { get; set; }

        public string? Photo { get; set; }

        // FK for Category
        public int CategoryId { get; set; }

        // ref to parent model
        public Category? Category { get; set; }

        // ref to child model - 1 product can be in many cartitems
        public List<CartItem>? CartItems { get; set; }

        // ref to 2nd child model - 1 product can be in many orderdetails (bought many times)
        public List<OrderDetail>? OrderDetails { get; set; }

        public int ReleaseYear { get; set; }

    }
}
