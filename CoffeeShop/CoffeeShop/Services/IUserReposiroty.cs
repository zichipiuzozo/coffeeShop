using System.Collections.Generic;
using CoffeeShop.API.Models;
namespace CoffeeShop.API.Services
{
    public interface IUserReposiroty
    {
        public List<Users> GetAllUser();
        public List<Users> GetUserByID(int id);
        public void Update();
        public void Delete();
    }
}
