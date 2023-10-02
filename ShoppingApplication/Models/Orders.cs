using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingApplication.Models
{
    public class Orders
    {
        [Key]
        public int OrderId { get; set; }
        public string UserName { get; set; }
        public int ProductId { get; set; }
        public double ProductQuantity { get; set; }
        public DateTime OrderDate { get; set; }

        [ForeignKey("UserName")]
        public User User { get; set; }
        [ForeignKey("ProductId")]
        public Product  Product { get; set; }
    }
}
