using BusinessObject;

namespace DataAccessLayer
{
    public class UserDAO
    {
        static List<User> users = new List<User>();

        public void IntitializeDataset()
        {
            users.Add(new User() { Name = "Huy", Phone = "88888888", Email = "huy8@gmail.com" });
            users.Add(new User() { Name = "Hanh", Phone = "99999999", Email = "hanh9@gamil.com" });
            users.Add(new User() { Name = "Hieu", Phone = "77777777", Email = "hieu7@gmail.com" });
            users.Add(new User() { Name = "Anh", Phone = "66666666", Email = "anh6@gmail.com" });
        }
        public List<User> GetAllUsers()
        {
            
            return users;
        }
    }
}
