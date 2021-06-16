using BCModel;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BCDL
{
    public class UserRepo : IUserRepo
    {
        private readonly BookClubDBContext _context;

        public UserRepo(BookClubDBContext context)
        {
            this._context = context;
        }
        public async Task<User> AddUserAsync(User user)
        {
            _context.ChangeTracker.Clear();
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<User> GetUserByEmailAsync(string email)
        {
            return await _context.Users.AsNoTracking().FirstOrDefaultAsync(user => user.UserEmail == email);
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            return await _context.Users.AsNoTracking().Select(
              user => user
          ).ToListAsync();
        }

        public async Task<User> UpdateUserAsync(User u)
        {
            _context.Users.Update(u);
            await _context.SaveChangesAsync();

            return u;
        }
    }
}
