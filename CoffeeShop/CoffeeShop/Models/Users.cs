﻿using System;

namespace CoffeeShop.API.Models
{
    public class Users
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
        public string FullName { get; set; }
    }
}
