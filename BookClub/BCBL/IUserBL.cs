
using System.Collections.Generic;
using System.Threading.Tasks;
using BCModel;


namespace BCBL
{
  public  interface IUserBL
    {
        public Task<User> AddUserAsync(User user);
        public Task<User> UpdateUserAsync(User user);
        public Task<User> GetUserByEmailAsync(string email);
        public Task<List<User>> GetAllUsersAsync();
    }
}
