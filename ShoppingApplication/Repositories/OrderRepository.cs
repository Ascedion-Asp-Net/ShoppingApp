using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ShoppingApplication.Context;
using ShoppingApplication.Interfaces;
using ShoppingApplication.Models;

namespace ShoppingApplication.Repositories
{
    public class OrderRepository : IRepository<int, Orders>
    {
        private readonly dbContext _context;

        public OrderRepository(dbContext context) { _context = context; }
        public Orders Add(Orders item)
        {
           _context.orders.Add(item);
            _context.SaveChanges();
            return item;
        }

        public Orders Delete(int key)
        {
           var item = _context.orders.FirstOrDefault(o=>o.OrderId == key);
            if (item != null)
            {
                _context.orders.Remove(item);
                _context.SaveChanges();
                    
                return item;
            }
            return null;
        }

        public Orders Get(int key)
        {
            return _context.orders.FirstOrDefault(o => o.OrderId == key);
        }

        public List<Orders> GetAll()
        {
           return _context.orders.ToList();
        }

        public Orders Update(Orders item)
        {
            var orderdata = _context.orders.FirstOrDefault(o => o.OrderId == item.OrderId);
            if (orderdata != null)
            {
                orderdata.UserName = item.UserName;
                orderdata.ProductId = item.ProductId;
                orderdata.ProductQuantity = item.ProductQuantity;
                orderdata.OrderDate = item.OrderDate;

                _context.orders.Update(orderdata);
                _context.SaveChanges(true);

                

                return orderdata;
            }
            return null;
        }
    }
}
