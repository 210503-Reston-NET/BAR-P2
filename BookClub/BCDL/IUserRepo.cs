using BCModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BCDL
{
   public interface IUserRepo
    {
        public Task<User> AddUserAsync(User u);
        public Task<User> UpdateUserAsync(User u);
        public Task<User> GetUserByEmailAsync(string email);
        public Task<List<User>> GetAllUsersAsync();
    }
}
