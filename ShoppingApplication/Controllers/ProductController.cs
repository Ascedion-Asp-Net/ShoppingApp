using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingApplication.Interfaces;
using ShoppingApplication.Models;

namespace ShoppingApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService) 
        { 
        _productService= productService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var product=_productService.GetProducts();
            if(product == null)
            {
                return NotFound("notFound");

            }
            return Ok(product);
        }
        [HttpPost]
        public ActionResult Post(Product product)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    var result = _productService.AddProduct(product);
                    return Created("", result);
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
                
            }
            return BadRequest(ModelState.Keys);
        }
        [HttpPut]
        public ActionResult Update(Product product)
        {
          try
            {
                var result = _productService.UpdateProduct(product);
                if(result==null)
                {
                    return NotFound();
                }
                return Ok(result);

            }catch (Exception ex) {
            return BadRequest(ex.Message);
            }
        }
       
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            try
            {
                var result = _productService.DeleteProduct(id);
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
