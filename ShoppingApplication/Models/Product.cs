using System.ComponentModel.DataAnnotations;

namespace ShoppingApplication.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }

        public double ProductQuantity { get; set; }
        public string? ProductImage { get; set; }
        public string ProductType { get; set; }
        public bool ProductStatus { get; set; }
    }
}
