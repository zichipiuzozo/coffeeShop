using CoffeeShop.API.Models;
using CoffeeShop.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserReposiroty _userReposiroty;

        public UserController(IUserReposiroty userReposiroty)
        {
            _userReposiroty = userReposiroty;
        }
        [HttpGet]
        public IActionResult GetTheoTen()
        {
            try
            {
                return Ok(_userReposiroty.GetAllUser());
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpPost]
        public IActionResult CreateNew(Users us)
        {
            try
            {
                return Ok(_userReposiroty.createNewUser(us));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpGet("{id}")]
        public IActionResult GetTheoID(string id)
        {
            return Ok(_userReposiroty.GetUserByID(id));
        }
        [HttpPut("{id}")]
        public IActionResult Update(Users us)
        {
            return Ok(us);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            try
            {
                _userReposiroty.Delete(id);
                return Ok();
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
