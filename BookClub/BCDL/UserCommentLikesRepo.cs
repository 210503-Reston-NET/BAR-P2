using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BCModel;
using Microsoft.EntityFrameworkCore;

namespace BCDL
{
    public class UserCommentLikesRepo : IUserCommentLikesRepo
    {
        private readonly BookClubDBContext _context;
        public UserCommentLikesRepo(BookClubDBContext context)
        {
            _context = context;
        }

        public async Task<UserCommentLikes> AddCommentLikesAsync(UserCommentLikes commentLike)
        {
            _context.ChangeTracker.Clear();
            await _context.UserCommentLikes.AddAsync(commentLike);
            await _context.SaveChangesAsync();
            return commentLike;
        }

        public async Task<List<UserCommentLikes>> GetAllCommentLikesAsync()
        {
            return await _context.UserCommentLikes.AsNoTracking().Select(likes => likes).ToListAsync();
        }

        public async Task<List<UserCommentLikes>> GetCommentLikesByUserPostAsync(int userPostId)
        {
            return await _context.UserCommentLikes.AsNoTracking().Where(like => like.UserPostId == userPostId).Select(like => like).ToListAsync();
        }

        public async Task<UserCommentLikes> GetCommentLikeAsync(UserCommentLikes commentLike)
        {
            return await _context.UserCommentLikes.FindAsync(commentLike);
        }

        public async Task<UserCommentLikes> GetCommentLikesByIdAsync(int id)
        {
            return await _context.UserCommentLikes.FindAsync(id);
        }
    }
}
