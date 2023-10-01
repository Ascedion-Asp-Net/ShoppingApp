using ShoppingApplication.Models;

namespace ShoppingApplication.Interfaces
{
    public interface IProductService
    {
        List<Product> GetProducts();
        Product DeleteProduct(int id);
        Product AddProduct(Product product);
        Product UpdateProduct(Product product);
    }
}
