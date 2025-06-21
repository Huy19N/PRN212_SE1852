using BusinessObject;
using DataAccessLayer;

namespace Respositories
{
    public interface IUserRespository
    {
        List<User> GetAllUsers();

    }
}
