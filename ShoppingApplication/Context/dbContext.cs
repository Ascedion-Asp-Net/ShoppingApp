using Microsoft.EntityFrameworkCore;
using ShoppingApplication.Models;

namespace ShoppingApplication.Context
{

    public class dbContext : DbContext
    {
        public dbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> users { get; set; }

        public DbSet<Product> products { get; set; }
        public DbSet<Carts> carts { get; set; }
        public DbSet<Orders> orders { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 11, ProductName = "car", ProductPrice = 1000000, ProductQuantity = 2, ProductImage = "image", ProductType = "vechical", ProductStatus = true });
           
        } 

    }



    }


