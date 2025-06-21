using System.Security.Cryptography.X509Certificates;

namespace BusinessObject
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public override string ToString()
        {
            return Name+ "\t" + Email + "\t" + Phone;
        }
    }
}
