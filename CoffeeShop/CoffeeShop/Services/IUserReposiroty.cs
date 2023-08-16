using System.Collections.Generic;
using CoffeeShop.API.Models;
namespace CoffeeShop.API.Services
{
    public interface IUserReposiroty
    {
        public List<Users> GetAllUser();
        public Users GetUserByID(string id);
        public Users createNewUser(Users us);
        public void Update(Users us);
        public void Delete(string id);
    }
}
