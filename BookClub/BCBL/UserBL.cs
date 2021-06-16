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
            return _userRepo.AddUserAsync(u);
        }

        public List<User> GetAllUsers()
        {
            return _userRepo.GetAllUsersAsync();
        }

        public User GetUserByEmail(string email)
        {
            return _userRepo.GetUserByEmailAsync(email);
        }

        public List<User> GetUsers()
        {
            return _userRepo.GetAllUsersAsync();
        }

        public User UpdateUser(User u)
        {
            return _userRepo.UpdateUserAsync(u);
        }
    }
}
