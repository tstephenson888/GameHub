using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GameHub.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace GameHub.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
<<<<<<< Updated upstream

        // reference each of our models as DbSet objects - these have CRUD methods built in to them
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
=======
        // reference each of our models as DbSet - these have CRUD methods built into them
        public DbSet<GameHub.Models.Product> Product { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail > OrderDetails { get; set; }
>>>>>>> Stashed changes
        public DbSet<CartItem> CartItems { get; set; }
    }
}