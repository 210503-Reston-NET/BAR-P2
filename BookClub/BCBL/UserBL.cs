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
        private readonly IUserRepo _userRepo;
        public UserBL(IUserRepo userRepo) { this._userRepo = userRepo; }

        public User AddUser(User u)
        {
            return _userRepo.AddUser(u);
        }

        public List<User> GetAllUsers()
        {
            return _userRepo.GetAllUsers();
        }

        public User GetUserByEmail(string email)
        {
            return _userRepo.GetUserByEmail(email);
        }

        public List<User> GetUsers()
        {
            return _userRepo.GetAllUsers();
        }

        public User UpdateUser(User u)
        {
            return _userRepo.UpdateUser(u);
        }
    }
}
