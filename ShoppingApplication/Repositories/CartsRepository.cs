using ShoppingApplication.Context;
using ShoppingApplication.Interfaces;
using ShoppingApplication.Models;
using ShoppingApplication.Models.DTOs;

namespace ShoppingApplication.Repositories
{
    public class CartsRepository : IRepository<int, Carts>
    {

        private readonly dbContext _context;

        public CartsRepository(dbContext context)
        {
            _context = context;
        }

        public Carts Add(Carts item)
        {
            _context.carts.Add(item);
            _context.SaveChanges();
            return item;
        }

        public Carts Delete(int key)
        {
            var item = _context.carts.FirstOrDefault(p => p.CartId == key);
            if (item != null)
            {
                _context.carts.Remove(item);
                _context.SaveChanges();
                return item;
            }
            return null;
        }

        public Carts Get(int key)
        {
            return _context.carts.FirstOrDefault(p => p.CartId == key);
        }

        public List<Carts> GetAll()
        {
            return _context.carts.ToList();
        }

        public Carts Update(Carts item)
        {
            var cart = _context.carts.FirstOrDefault(c => c.CartId == item.CartId);
            if (cart != null)
            {
                cart.ProductId = item.ProductId;
                cart.Username = item.Username;
                cart.ProductQuntity = item.ProductQuntity;
               

                _context.carts.Update(cart);
                _context.SaveChanges();
                return cart;
            }
            return null;
        }
    }
}