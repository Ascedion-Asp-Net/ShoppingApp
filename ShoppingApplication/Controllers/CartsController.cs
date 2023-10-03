using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingApplication.Interfaces;
using ShoppingApplication.Models;
using ShoppingApplication.Models.DTOs;

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
        public ActionResult Post(CartsDTO carts)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    var cartdata=new Carts();
                    cartdata.CartId = carts.CartId;
                    cartdata.ProductId = carts.ProductId;
                    cartdata.ProductQuntity= carts.ProductQuntity;
                    cartdata.Username = carts.UserName;

                    var result = _cartsService.AddCarts(cartdata);
                    return Created("", result);
                }catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }

            }
            return BadRequest(ModelState.Keys);

        }
        [HttpPut]
        public ActionResult Put(CartsDTO carts)
        {
            try
            {
                var cartdata = new Carts();
                cartdata.CartId = carts.CartId;
                cartdata.ProductId = carts.ProductId;
                cartdata.ProductQuntity = carts.ProductQuntity;
                cartdata.Username = carts.UserName;

                var result = _cartsService.UpdateCarts(cartdata);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            
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
