using ShoppingApplication.Models;

namespace ShoppingApplication.Interfaces
{
    public interface IOrderService
    {
        List<Orders> OrdersList();
        Orders DeleteOrders(int key);
        Orders AddOreders(Orders orders);
        Orders UpdateOrders(Orders orders);
    }
}
