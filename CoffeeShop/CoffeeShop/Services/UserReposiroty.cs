using CoffeeShop.API.Models;
using CoffeeShop.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CoffeeShop.API.Services
{
    public class UserReposiroty : IUserReposiroty
    {
        private readonly CoffeeShopDBContext _context;

        public UserReposiroty(CoffeeShopDBContext context) 
        {
            _context = context;
        }
        public void Delete(string id)
        {
            var _users = _context.Users.SingleOrDefault(u => u.ID == Guid.Parse(id));
            if (_users != null)
            {
                _context.Remove(_users);
            }
        }

        public List<Users> GetAllUser()
        {
            var _users = _context.Users.Select(u => new Models.Users
            {
                UserName = u.UserName,
                Password = u.Password,
                DOB = u.DOB,
                Email = u.Email,
                PhoneNumber = u.PhoneNumber,
                FullName = u.FullName
            });
            return _users.ToList();
        }

        public void Update(Users us)
        {
            var _users = _context.Users.SingleOrDefault(u => u.ID == us.Id);
            if(_users != null) {
               _users.UserName = us.UserName;
                _users.Password = us.Password;
                _users.DOB = us.DOB;
                _users.Email = us.Email;
                _users.PhoneNumber = us.PhoneNumber;
                _users.FullName = us.FullName;
            }
            //_context.SaveChanges(); 
        }

        public Users GetUserByID(string id)
        {
            var _userbyId = _context.Users.SingleOrDefault(u=>u.ID==Guid.Parse(id));
            if (_userbyId != null)
            {
                return new Users
                {
                    UserName = _userbyId.UserName,
                    Password = _userbyId.Password,
                    DOB = _userbyId.DOB,
                    Email = _userbyId.Email,
                    PhoneNumber = _userbyId.PhoneNumber,
                    FullName = _userbyId.FullName
                };
            } else
                return null;
            
        }

        public Users createNewUser(Users us)
        {
            var _user = new Users { 
                Id=Guid.NewGuid(),
                UserName = us.UserName,
                Password = us.Password,
                DOB = us.DOB,
                Email = us.Email,
                PhoneNumber = us.PhoneNumber,
                FullName = us.FullName,
            };
            _context.Add(_user);
            _context.SaveChanges();
            return new Users
            {
                UserName = _user.UserName,
                Password = _user.Password,
                DOB = _user.DOB,
                Email = _user.Email,
                PhoneNumber = _user.PhoneNumber,
                FullName = _user.FullName,
            };
        }
    }
}
