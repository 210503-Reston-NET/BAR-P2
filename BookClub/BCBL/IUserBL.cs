
using System.Collections.Generic;
using System.Threading.Tasks;
using BCModel;


namespace BCBL
{
  public  interface IUserBL
    {
        public Task<User> AddUserAsync(User u);
        public Task<User> UpdateUserAsync(User u);
        public Task<User> GetUserByEmailAsync(string email);
        public Task<List<User>> GetAllUsersAsync();
    }
}
