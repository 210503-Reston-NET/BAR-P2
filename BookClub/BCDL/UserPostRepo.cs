using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BCModel;
using Microsoft.EntityFrameworkCore;

namespace BCDL
{
    public class UserPostRepo : IUserPostRepo
    {

        private readonly BookClubDBContext _context;
        public UserPostRepo(BookClubDBContext context)
        {
            _context = context;
        }

        public async Task<UserPost> AddUserPostAsync(UserPost userPost)
        {
            _context.ChangeTracker.Clear();
            userPost.Date = DateTime.Now;
            await _context.UserPosts.AddAsync(userPost);
            await _context.SaveChangesAsync();
            return userPost;
        }

        public async Task<UserPost> DeleteUserPostAsync(UserPost userPost)
        {
            UserPost toBeDeleted = await _context.UserPosts.AsNoTracking().FirstAsync(up => up.UserPostId == userPost.UserPostId);
            _context.UserPosts.Remove(toBeDeleted);
            await _context.SaveChangesAsync();
            return userPost;
        }

        public async Task<List<UserPost>> GetAllUserPostsAsync()
        {
            return await _context.UserPosts.AsNoTracking().Select(userPost => userPost).ToListAsync();
        }

        public async Task<UserPost> GetUserPostAsync(UserPost userPost)
        {
            UserPost found = await _context.UserPosts.AsNoTracking().FirstOrDefaultAsync(up => up.UserEmail == userPost.UserEmail && up.Post == userPost.Post && up.TotalLike == userPost.TotalLike && up.TotalDislike == userPost.TotalDislike && up.Date == userPost.Date);
            if (found == null)
            {
                return null;
            }
            return new UserPost(found.UserEmail, found.Post, found.TotalLike, found.TotalDislike, found.Date);
        }

        public async Task<UserPost> GetUserPostByIdAsync(int userPostId)
        {
            return await _context.UserPosts.FindAsync(userPostId);
        }

        public async Task<List<UserPost>> GetUserPostByUserAsync(string userEmail)
        {
            List<UserPost> userPosts = await _context.UserPosts.AsNoTracking().Where(up => up.UserEmail == userEmail).Select(up => up).ToListAsync();
            userPosts.Sort(delegate (UserPost y, UserPost x)
            {
                return x.Date.CompareTo(y.Date);
            });

            return userPosts;
        }

        public async Task<UserPost> UpdateUserPostAsync(UserPost userPost)
        {
            _context.UserPosts.Update(userPost);
            await _context.SaveChangesAsync();
            return userPost;
        }
    }
}
