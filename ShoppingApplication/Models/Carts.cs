using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingApplication.Models
{
    public class Carts
    {
        [Key]
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public string Username { get; set; }
        public int ProductQuntity { get; set; }
     
        [ForeignKey("Username")]
        public User User { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
    }
}
