using ShoppingApplication.Context;
using ShoppingApplication.Interfaces;
using ShoppingApplication.Models;

namespace ShoppingApplication.Repositories
{
    public class ProductRepository : IRepository<int, Product>
    {
        private readonly dbContext _context;

        public ProductRepository(dbContext context) { _context = context; }

        public Product Add(Product item)
        {
            _context.products.Add(item);
            _context.SaveChanges();
            return item;
        }

        public Product Delete(int key)
        {
            var item = _context.products.FirstOrDefault(p => p.ProductId == key);
            if (item != null)
            {
                _context.products.Remove(item);
                _context.SaveChanges();
                return item;
            }
            return null;
        }

        public Product Get(int key)
        {
            return _context.products.FirstOrDefault(p => p.ProductId == key);

        }

        public List<Product> GetAll()
        {
            return _context.products.ToList();
        }

        public Product Update(Product item)
        {
            var product = Get(item.ProductId);
            if (product != null)
            {
                _context.products.Update(product);
                _context.SaveChanges();
                return product;
            }
            return item;
        }
    }
}


