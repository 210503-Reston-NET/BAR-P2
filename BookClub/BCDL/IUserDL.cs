using BCModel;
using System.Collections.Generic;


namespace BCDL
{
   public interface IUserDL
    {
        public User AddUser(User u);
        public User UpdateUser(User u);
        public User GetUserByEmail(string email);

        public List<User> GetAllUsers();
    }
}
