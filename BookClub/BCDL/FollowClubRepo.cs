using BCModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCDL
{
    public class FollowClubRepo : IFollowClubRepo
    {
        private readonly BookClubDBContext _context;

        public FollowClubRepo(BookClubDBContext context)
        {
            _context = context;
        }
        public async Task<FollowClub> AddFollowClubAsync(FollowClub followClub)
        {
            await _context.FollowClubs.AddAsync(followClub);
            await _context.SaveChangesAsync();
            return followClub;
        }

        public async Task<FollowClub> DeleteFollowClubAsync(int id)
        {
            FollowClub toBeDeleted = await _context.FollowClubs.AsNoTracking().FirstOrDefaultAsync(fc => fc.FollowClubId == id);
            if (toBeDeleted != null)
            {
                _context.FollowClubs.Remove(toBeDeleted);
                await _context.SaveChangesAsync();
            }
            return toBeDeleted;
        }

        public async Task<List<FollowClub>> GetAllFollowClubAsync()
        {
            return await _context.FollowClubs.AsNoTracking().Select(fc => fc).ToListAsync();
        }

        public async Task<List<BookClub>> GetFollowingByUserAsync(string email)
        {
            List<FollowClub> followClubs = await _context.FollowClubs.AsNoTracking().Where(fc => fc.FollowerEmail.Equals(email)).ToListAsync();
            List<BookClub> bookClubs = new List<BookClub>();
            BookClub bookClub;

            foreach(FollowClub follow in followClubs)
            {
                bookClub = await _context.BookClubs.AsNoTracking().FirstOrDefaultAsync(bc => bc.BookClubId == follow.BookClubId);
                bookClubs.Add(bookClub);
            }

            return bookClubs;
        }

        public async Task<List<User>> GetFollowersByClubAsync(int id)
        {
            List<FollowClub> followClubs = await _context.FollowClubs.AsNoTracking().Where(fc => fc.BookClubId == id).Select(bc => bc).ToListAsync();
            List<User> users = new List<User>();
            User user;

            foreach (FollowClub follow in followClubs)
            {
                user = await _context.Users.AsNoTracking().FirstOrDefaultAsync(usr => usr.UserEmail.Equals(follow.FollowerEmail));
                users.Add(user);
            }

            return users;
        }
    }
}
