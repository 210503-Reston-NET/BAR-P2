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

        public async Task<User> AddUserAsync(User user)
        {
            return await _userRepo.AddUserAsync(user);
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            return await _userRepo.GetAllUsersAsync();
        }

        public async Task<User> GetUserByEmailAsync(string email)
        {
            return await _userRepo.GetUserByEmailAsync(email);
        }

        public async Task<List<User>> GetUsersAsync()
        {
            return await _userRepo.GetAllUsersAsync();
        }

        public async Task<User> UpdateUserAsync(User user)
        {
            return await _userRepo.UpdateUserAsync(user);
        }
    }
}
