using BCModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BCDL
{
   public interface IUserRepo
    {
        public Task<User> AddUserAsync(User user);
        public Task<User> UpdateUserAsync(User user);
        public Task<User> GetUserByEmailAsync(string email);
        public Task<List<User>> GetAllUsersAsync();
    }
}
