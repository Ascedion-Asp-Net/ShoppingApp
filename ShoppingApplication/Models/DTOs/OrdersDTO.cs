namespace ShoppingApplication.Models.DTOs
{
    public class OrdersDTO
    {
        public int OrderId { get; set; }
        public string UserName { get; set; }
        public int ProductId { get; set; }
        public double ProductQuantity { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
