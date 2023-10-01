using ShoppingApplication.Interfaces;
using ShoppingApplication.Models;

namespace ShoppingApplication.Services
{
    public class CartsService : ICartsService
    {
 
        private readonly IRepository<int, Carts> _repository;

        public CartsService(IRepository<int,Carts> repository) 
        {
            _repository = repository;
        }
        public Carts AddCarts(Carts carts)
        {
            return _repository.Add(carts);
        }

        public Carts DeleteCarts(int id)
        {
           return (_repository.Delete(id));
        }

        public List<Carts> GetCarts()
        {
           return _repository.GetAll();
        }

        public Carts UpdateCarts(Carts carts)
        {
           return _repository.Update(carts);
        }
    }
}
