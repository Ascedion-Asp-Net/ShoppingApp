using ShoppingApplication.Interfaces;
using ShoppingApplication.Models;

namespace ShoppingApplication.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository<int, Product> _repository;

        public ProductService(IRepository<int,Product> repository)
        {
            _repository = repository;
        }
        public Product AddProduct(Product product)
        {
           return _repository.Add(product);
        }

        public Product DeleteProduct(int id)
        {
            return _repository.Delete(id);
        }

        public List<Product> GetProducts()
        {
           return _repository.GetAll();
        }

        public Product UpdateProduct(Product product)
        {
            var productdata = _repository.Get(product.ProductId);
            if (productdata != null) 
            {
                productdata.ProductName = product.ProductName;
                productdata.ProductPrice = product.ProductPrice;
                productdata.ProductQuantity = product.ProductQuantity;
                productdata.ProductImage = product.ProductImage;
                productdata.ProductType = product.ProductType;
                productdata.ProductStatus = product.ProductStatus;
                return _repository.Update(productdata);
            }
            return null;
        }
    }
}
