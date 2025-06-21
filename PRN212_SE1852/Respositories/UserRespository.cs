using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using DataAccessLayer;

namespace Respositories
{
    public class UserRespository : IUserRespository
    {
        public List<User> GetAllUsers()
        {
            UserDAO userDAO = new UserDAO();
            userDAO.IntitializeDataset();
            return userDAO.GetAllUsers();
        }


    }
}
