using CoffeeShop.API.Models;
using CoffeeShop.API.Services;
using CoffeeShop.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CoffeeShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoffeeShopController : ControllerBase
    {
        private readonly IProductReponsitory _productReponsitory;
        public CoffeeShopController(IProductReponsitory productReponsitoty)
        {
            _productReponsitory = productReponsitoty;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_productReponsitory.GetAll());
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var data = _productReponsitory.GetById(id);
                if (data == null) 
                { 
                    return NotFound(); 
                }
                else
                {
                    return Ok(data);
                }
            }

            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, ProductVM product)
        {
            if(id != product.Id)
            {
                return BadRequest();
            }
            try
            {
                _productReponsitory.Update(product);
                return NoContent();
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id, ProductVM product)
        {
            try
            {
                _productReponsitory.Delete(id);
                return Ok();
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpPost]
        public IActionResult Add(Product product)
        {
            try
            {
                return Ok();
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
