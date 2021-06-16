using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BCModel;
using Microsoft.EntityFrameworkCore;

namespace BCDL
{
    public class CommentRepo : ICommentRepo
    {
        private readonly BookClubDBContext _context;
        public CommentRepo(BookClubDBContext context)
        {
            _context = context;
        }

        public async Task<Comment> AddCommentAsync(Comment comment)
        {
            _context.ChangeTracker.Clear();
            await _context.Comments.AddAsync(comment);
            await _context.SaveChangesAsync();
            return comment;
        }

        public async Task<Comment> DeleteCommentAsync(Comment comment)
        {
            Comment toBeDeleted = await _context.Comments.AsNoTracking().FirstAsync(com => com.CommentId == comment.CommentId);
            _context.Comments.Remove(toBeDeleted);
            await _context.SaveChangesAsync();
            return comment;
        }

        public async Task<List<Comment>> GetAllCommentsAsync()
        {
            return await _context.Comments.AsNoTracking().Select(comment => comment).ToListAsync();
        }

        public async Task<Comment> GetCommentAsync(Comment comment)
        {
            Comment found = await _context.Comments.AsNoTracking().FirstOrDefaultAsync(com => com.UserEmail == comment.UserEmail && com.UserPostID == comment.UserPostID && com.ClubPostID == comment.ClubPostID && com.Message == comment.Message);
            if (found == null)
            {
                return null;
            }
            return new Comment(found.UserEmail, found.UserPostID, found.ClubPostID, found.Message);
        }

        public async Task<List<Comment>> GetCommentByClubPostAsync(int clubPostId)
        {
           return await _context.Comments.AsNoTracking().Where(com => com.ClubPostID == clubPostId).Select(com => com).ToListAsync();
        }

        public async Task<Comment> GetCommentByIdAsync(int commentID)
        {
            return await _context.Comments.FindAsync(commentID);
        }

        public async Task<List<Comment>> GetCommentByUserPostAsync(int userPostId)
        {
            return await _context.Comments.AsNoTracking().Where(com => com.UserPostID == userPostId).Select(com => com).ToListAsync();
        }

        public async Task<Comment> UpdateCommentAsync(Comment comment)
        {
            _context.Comments.Update(comment);
            await _context.SaveChangesAsync();
            return comment;
        }
    }
}
