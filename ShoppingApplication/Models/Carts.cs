using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingApplication.Models
{
    public class Carts
    {
        [Key]
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public int ProductQuntity { get; set; }
        public int? UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
    }
}
