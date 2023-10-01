using ShoppingApplication.Interfaces;
using ShoppingApplication.Models;
using ShoppingApplication.Models.DTOs;
using ShoppingApplication.Repositories;
using System.Security.Cryptography;
using System.Text;

namespace ShoppingApplication.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<int, User> _repository;
        private readonly ITokenService _tokenService;

        public UserService(IRepository<int, User> repository, ITokenService tokenService)
        {
            _repository = repository;
            _tokenService = tokenService;
        }


        public UserDTO Login(UserDTO userDTO)
        {
           
            /*  var user = _repository.Get(userDTO.UserId);*/
           /* if (user != null)
            {
                var dbPass = user.Password;
                HMACSHA512 hMACSHA512 = new HMACSHA512(user.Key);
                var userPass = hMACSHA512.ComputeHash(Encoding.UTF8.GetBytes(userDTO.Password));
                if (userPass.Length == dbPass.Length)
                {
                    for (int i = 0; i < dbPass.Length; i++)
                    {
                        if (userPass[i] != dbPass[i])
                            return null;
                    }
                    var loggedinUser = new UserDTO
                    {
                        Username = user.Username,
                        Token = _tokenService.GenerateToken(user.Username)
                    };
                    return loggedinUser;
                }
            }*/
            return null;
        }


        public UserDTO Register(UserDTO userDTO)
        {
            HMACSHA512 hMACSHA512 = new HMACSHA512();
            User user = new User();
            user.Username = userDTO.Username;
            user.Password = hMACSHA512.ComputeHash(Encoding.UTF8.GetBytes(userDTO.Password));

            user.Key = hMACSHA512.Key;
            _repository.Add(user);
            var regiteredUser = new UserDTO
            {
                Username = user.Username,
                Token = _tokenService.GenerateToken(user.Username)
            };
            return regiteredUser;
        }


    }
}
