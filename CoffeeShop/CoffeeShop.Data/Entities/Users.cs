using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace CoffeeShop.Data.Entities
{
    public class Users
    {
        public Guid ID {  get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
        public string FullName { get; set; }
        public string LastLoginDate { get; set; }
        public List<Cart> Carts { get; set; }
        public List<Order> Orders { get; set; }
        public List<Transaction> Transactions { get; set; } 
    }
}
