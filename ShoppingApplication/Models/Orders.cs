using System;
using System.ComponentModel.DataAnnotations;

namespace ShoppingApplication.Models
{
    public class Orders
    {
        [Key]
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public double ProductQuantity { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
