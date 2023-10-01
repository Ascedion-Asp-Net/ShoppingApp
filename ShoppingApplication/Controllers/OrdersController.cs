using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ShoppingApplication.Interfaces;
using ShoppingApplication.Models;
using ShoppingApplication.Services;

namespace ShoppingApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderServie;

        public OrdersController(IOrderService orderService) 
        { 
            _orderServie = orderService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var ordersdata = _orderServie.OrdersList();
            if(ordersdata == null)
            {
                return NotFound();
            }
            return Ok(ordersdata);

        }
        [HttpPost]
        public ActionResult Post(Orders ordersdata) {
            return null;
        }
        [HttpDelete] public IActionResult Delete(int id)
        {
            try
            {
                var result = _orderServie.DeleteOrders(id);
                if (result == null)
                    return NotFound();
                return Ok(result);  
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        public ActionResult Put(int id)
        {
            try
            {
                var result = _orderServie.DeleteOrders(id);
                if (result == null)
                    return NotFound();
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
       
    }
}
