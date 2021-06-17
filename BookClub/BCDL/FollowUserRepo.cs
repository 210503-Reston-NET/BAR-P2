using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCModel;
using Microsoft.EntityFrameworkCore;

namespace BCDL
{
    public class FollowUserRepo : IFollowUserRepo
    {
        private readonly BookClubDBContext _context;

        public FollowUserRepo(BookClubDBContext context)
        {
            _context = context;
        }
        public async Task<FollowUser> AddFollowUserAsync(FollowUser followClub)
        {
            await _context.FollowUsers.AddAsync(followClub);
            await _context.SaveChangesAsync();
            return followClub;
        }

        public async Task<FollowUser> DeleteFollowUserAsync(int id)
        {
            FollowUser toBeDeleted = await _context.FollowUsers.AsNoTracking().FirstOrDefaultAsync(fc => fc.FollowUserId == id);
            if (toBeDeleted != null)
            {
                _context.FollowUsers.Remove(toBeDeleted);
                await _context.SaveChangesAsync();
            }
            return toBeDeleted;
        }

        public async Task<FollowUser> DeleteFollowerByEmailsAsync(string followerEmail, string followedEmail)
        {
            FollowUser toBeDeleted = await _context.FollowUsers.AsNoTracking().FirstOrDefaultAsync(fl => fl.FollowerEmail == followerEmail && fl.UserEmail == followedEmail);
            if (toBeDeleted != null)
            {
                _context.FollowUsers.Remove(toBeDeleted);
                await _context.SaveChangesAsync();
            }
            return toBeDeleted;
        }

        public async Task<List<FollowUser>> GetAllFollowUserAsync()
        {
            return await _context.FollowUsers.AsNoTracking().Select(fc => fc).ToListAsync();
        }

        public async Task<List<User>> GetFollowingByUserAsync(string email)
        {
            List<FollowUser> followUsers = await _context.FollowUsers.AsNoTracking().Where(fc => fc.FollowerEmail.Equals(email)).ToListAsync();
            List<User> users = new List<User>();
            User user;

            foreach (FollowUser follow in followUsers)
            {
                user = await _context.Users.AsNoTracking().FirstOrDefaultAsync(usr => usr.UserEmail == follow.UserEmail);
                users.Add(user);
            }

            return users;
        }

        public async Task<bool> IsFollowingAsync(string followerEmail, string followedEmail)
        {
            bool following = false;
            FollowUser followUser = await _context.FollowUsers.AsNoTracking().FirstOrDefaultAsync(fl => fl.FollowerEmail == followerEmail && fl.UserEmail == followedEmail);
            if (followUser != null) following = true;

            return following;
        }

        public async Task<List<User>> GetFollowersByUserAsync(string email)
        {
            List<FollowUser> followUsers = await _context.FollowUsers.AsNoTracking().Where(fc => fc.UserEmail.Equals(email)).ToListAsync();
            List<User> users = new List<User>();
            User user;

            foreach (FollowUser follow in followUsers)
            {
                user = await _context.Users.AsNoTracking().FirstOrDefaultAsync(usr => usr.UserEmail.Equals(follow.FollowerEmail));
                users.Add(user);
            }

            return users;
        }
    }
}
