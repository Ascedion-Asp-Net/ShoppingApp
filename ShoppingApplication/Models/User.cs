using System.ComponentModel.DataAnnotations;

namespace ShoppingApplication.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Username { get; set; }
        public byte[]? Password { get; set; }
        public byte[]? Key { get; set; }
        public string Address { get; set; }
        public string Phonenumber { get; set; }
    }
}
