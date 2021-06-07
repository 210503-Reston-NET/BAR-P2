
using System.Collections.Generic;
using BCModel;


namespace BCBL
{
  public  interface IUserBL
    {
        public User AddUser(User u);
        public User UpdateUser(User u);
        public User GetUserByEmail(string email);

        public List<User> GetAllUsers();
    }
}
