using ShoppingApplication.Models;

namespace ShoppingApplication.Interfaces
{
    public interface ICartsService
    {
        List<Carts> GetCarts();
        Carts DeleteCarts(int id);
        Carts UpdateCarts(Carts carts);
        Carts AddCarts(Carts carts);
    }
}
