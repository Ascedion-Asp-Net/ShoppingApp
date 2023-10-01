using ShoppingApplication.Models;
using ShoppingApplication.Models.DTOs;

namespace ShoppingApplication.Interfaces
{
    public interface IUserService
    {
        public UserDTO Login(UserDTO userDTO);
        public UserDTO Register(UserDTO userDTO);
    }
}
