using ShoppingApplication.Interfaces;
using ShoppingApplication.Models;

namespace ShoppingApplication.Services
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<int, Orders> _repository;

        public OrderService(IRepository<int,Orders> repository) { _repository = repository; }
       

        public Orders AddOreders(Orders orders)
        {
           return _repository.Add(orders);
        }

        public Orders DeleteOrders(int key)
        {
            return (_repository.Delete(key));
        }

        public List<Orders> OrdersList()
        {
            return _repository.GetAll();
        }

        public Orders UpdateOrders(Orders orders)
        {
           return _repository.Update(orders);
        }


    }
}
