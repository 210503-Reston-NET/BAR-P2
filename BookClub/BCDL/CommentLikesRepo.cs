using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BCModel;
using Microsoft.EntityFrameworkCore;

namespace BCDL
{
    public class CommentLikesRepo : ICommentLikesRepo
    {
        private readonly BookClubDBContext _context;
        public CommentLikesRepo(BookClubDBContext context)
        {
            _context = context;
        }

        public async Task<CommentLikes> AddCommentLikesAsync(CommentLikes commentLike)
        {
            _context.ChangeTracker.Clear();
            await _context.CommentLikes.AddAsync(commentLike);
            await _context.SaveChangesAsync();
            return commentLike;
        }

        public async Task<List<CommentLikes>> GetAllCommentLikesAsync()
        {
            return await _context.CommentLikes.AsNoTracking().Select(likes => likes).ToListAsync();
        }

        public async Task<List<CommentLikes>> GetCommentLikesByUserPostAsync(int userPostId)
        {
            return await _context.CommentLikes.AsNoTracking().Where(like => like.UserPostId == userPostId).Select(like => like).ToListAsync();
        }

        public async Task<List<CommentLikes>> GetCommentLikesByClubPostAsync(int clubPostId)
        {
            return await _context.CommentLikes.AsNoTracking().Where(like => like.ClubPostId == clubPostId).Select(like => like).ToListAsync();
        }

        public async Task<CommentLikes> GetCommentLikeAsync(CommentLikes commentLike)
        {
            return await _context.CommentLikes.FindAsync(commentLike);
        }

        public async Task<CommentLikes> GetCommentLikesByIdAsync(int id)
        {
            return await _context.CommentLikes.FindAsync(id);
        }
    }
}
