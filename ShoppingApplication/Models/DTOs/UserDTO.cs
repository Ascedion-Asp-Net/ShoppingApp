namespace ShoppingApplication.Models.DTOs
{
    public class UserDTO
    {
        public int? UserId { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Token { get; set; }
        public string? Address { get; set; }
        public string? Phonenumber { get; set; }
    }
}
