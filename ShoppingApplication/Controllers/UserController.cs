using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingApplication.Interfaces;
using ShoppingApplication.Models.DTOs;
using ShoppingApplication.Models;
using System.Security.Cryptography;
using System.Text;

namespace ShoppingApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService=userService;
        }

        [HttpPost("Login")]
        public ActionResult Login(UserDTO userDTO)
        {
            var result = _userService.Login(userDTO);
            if (result == null)
            {
                return Unauthorized();
            }
            return Ok(result);
        }
        [HttpPost("Register")]
        public ActionResult Register(UserDTO userDTO)
        {
            var registerdata = new User();
            registerdata.Username = userDTO.Username;
            HMACSHA512 hMACSHA512 = new HMACSHA512();
            registerdata.Password = hMACSHA512.ComputeHash(Encoding.UTF8.GetBytes(userDTO.Password));
           



            var result = _userService.Register(userDTO);
           
            if (result == null)
            {
                return BadRequest();
            }
            return Ok(result);
        }

    }
}
