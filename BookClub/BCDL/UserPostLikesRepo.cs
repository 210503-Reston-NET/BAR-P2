using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BCModel;
using Microsoft.EntityFrameworkCore;

namespace BCDL
{
    public class UserPostLikesRepo : IUserPostLikesRepo
    {

        private readonly BookClubDBContext _context;
        public UserPostLikesRepo(BookClubDBContext context)
        {
            _context = context;
        }

        public async Task<UserPostLikes> AddUserPostLikeAsync(UserPostLikes userPostLike)
        {
            _context.ChangeTracker.Clear();
            await _context.UserPostLikes.AddAsync(userPostLike);
            await _context.SaveChangesAsync();
            return userPostLike;
        }

        public async Task<List<UserPostLikes>> GetAllUserPostLikesAsync()
        {
            return await _context.UserPostLikes.AsNoTracking().Select(likes => likes).ToListAsync();
        }

        public async Task<UserPostLikes> GetUserPostLikeAsync(UserPostLikes userPostLike)
        {
            return await _context.UserPostLikes.FindAsync(userPostLike);
        }

        public async Task<UserPostLikes> GetUserPostLikesByIdAsync(int id)
        {
            return await _context.UserPostLikes.FindAsync(id);
        }

        public async Task<List<UserPostLikes>> GetUserPostLikesByUserPostAsync(int userPostId)
        {
            return await _context.UserPostLikes.AsNoTracking().Where(like => like.UserPostId == userPostId).Select(like => like).ToListAsync();
        }
    }
}
