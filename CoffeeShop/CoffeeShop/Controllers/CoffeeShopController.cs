﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoffeeShopController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll(string id)
        {
            return Ok(new { id });
        }
    }
}