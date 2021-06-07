using BCDL;
using BCModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCBL
{
    public class UserBL : IUserBL
    {
        private readonly IUserDL _userDL;
        public UserBL(IUserDL userDL) { this._userDL = userDL; }

        public User AddUser(User u)
        {
            return _userDL.AddUser(u);
        }

        public List<User> GetAllUsers()
        {
            return _userDL.GetAllUsers();
        }

        public User GetUserByEmail(string email)
        {
            return _userDL.GetUserByEmail(email);
        }

        public List<User> GetUsers()
        {
            return _userDL.GetAllUsers();
        }

        public User UpdateUser(User u)
        {
            return _userDL.UpdateUser(u);
        }
    }
}
