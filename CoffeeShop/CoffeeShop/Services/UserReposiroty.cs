using CoffeeShop.API.Models;
using CoffeeShop.Data.EF;
using System.Collections.Generic;

namespace CoffeeShop.API.Services
{
    public class UserReposiroty : IUserReposiroty
    {
        private readonly CoffeeShopDBContext _context;

        public UserReposiroty(CoffeeShopDBContext context) 
        {
            _context = context;
        }
        public void Delete()
        {
            throw new System.NotImplementedException();
        }

        public List<Users> GetAllUser()
        {
            throw new System.NotImplementedException();
        }

        public void Update()
        {
            throw new System.NotImplementedException();
        }

        public List<Users> GetUserByID(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
