using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using Respositories;

namespace Services
{
    public class UserServices : IUserService
    {
        private readonly IUserRespository _userService;

        public UserServices()
        {
            _userService = new UserRespository();
        }
        public List<User> GetAllUser()
        {
            return _userService.GetAllUsers();
        }
      
    }
}
