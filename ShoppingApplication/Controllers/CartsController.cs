using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingApplication.Interfaces;
using ShoppingApplication.Models;

namespace ShoppingApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartsController : ControllerBase
    {
        private readonly ICartsService _cartsService;

        public CartsController(ICartsService cartsService) 
        {
            _cartsService=cartsService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var cartsdata=_cartsService.GetCarts();
            if (cartsdata == null)
            {
                return NotFound();
            }
            return Ok(cartsdata);
        }
        [HttpPost]
        public ActionResult Post(Carts carts)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    var result = _cartsService.AddCarts(carts);
                    return Created("", result);
                }catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }

            }
            return BadRequest(ModelState.Keys);

        }
        [HttpPut]
        public ActionResult Put(Carts carts)
        {
            return null;
        }


        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                var result = _cartsService.DeleteCarts(id);
                if (result == null)
                    return NotFound();
                return Ok(result);
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
