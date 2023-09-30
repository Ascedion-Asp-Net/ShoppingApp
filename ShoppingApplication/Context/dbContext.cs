using Microsoft.EntityFrameworkCore;
using ShoppingApplication.Models;

namespace ShoppingApplication.Context
{

    public class dbContext:DbContext
    {
        public dbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Carts> Carts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Orders> Orders { get; set; }
    }
}
