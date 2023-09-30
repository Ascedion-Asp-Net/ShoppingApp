using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ShoppingApplication.Context;
using ShoppingApplication.Interfaces;
using ShoppingApplication.Models;

namespace ShoppingApplication.Repository
{

    public class UserRepository : IRepository<int, User>
    {
        private readonly dbContext _context;

        public UserRepository(dbContext context) {
            _context = context;
        }
        public User Add(User item)
        {
           _context.Users.Add(item);
            _context.SaveChanges();
            return item;
        }

        public User Delete(int key)
        {
            var user = _context.Users.FirstOrDefault(u=>u.UserId == key);
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
                return user;
            }
            return null;
        }

        public User Get(int key)
        {
            return _context.Users.FirstOrDefault(u => u.UserId == key);
        }

        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public User Update(User item)
        {
            var user = _context.Users.FirstOrDefault(u => u.UserId == item.UserId);
            if (user != null)
            {
                _context.Users.Update(user);
                _context.SaveChanges();
                return user;
            }
            return null;
        }
    }
}
