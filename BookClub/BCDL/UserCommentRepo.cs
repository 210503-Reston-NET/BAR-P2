using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BCModel;
using Microsoft.EntityFrameworkCore;

namespace BCDL
{
    public class UserCommentRepo : IUserCommentRepo
    {
        private readonly BookClubDBContext _context;
        public UserCommentRepo(BookClubDBContext context)
        {
            _context = context;
        }

        public async Task<UserComment> AddCommentAsync(UserComment comment)
        {
            _context.ChangeTracker.Clear();
            await _context.UserComments.AddAsync(comment);
            await _context.SaveChangesAsync();
            return comment;
        }

        public async Task<UserComment> DeleteCommentAsync(UserComment comment)
        {
            UserComment toBeDeleted = await _context.UserComments.AsNoTracking().FirstAsync(com => com.UserCommentId == comment.UserCommentId);
            _context.UserComments.Remove(toBeDeleted);
            await _context.SaveChangesAsync();
            return comment;
        }

        public async Task<List<UserComment>> GetAllCommentsAsync()
        {
            return await _context.UserComments.AsNoTracking().Select(comment => comment).ToListAsync();
        }

        public async Task<UserComment> GetCommentAsync(UserComment comment)
        {
            UserComment found = await _context.UserComments.AsNoTracking().FirstOrDefaultAsync(com => com.UserEmail == comment.UserEmail && com.UserPostID == comment.UserPostID && com.Message == comment.Message);
            if (found == null)
            {
                return null;
            }
            return new UserComment(found.UserEmail, found.UserPostID, found.Message);
        }

        public async Task<UserComment> GetCommentByIdAsync(int commentID)
        {
            return await _context.UserComments.FindAsync(commentID);
        }

        public async Task<List<UserComment>> GetCommentByUserPostAsync(int userPostId)
        {
            return await _context.UserComments.AsNoTracking().Where(com => com.UserPostID == userPostId).Select(com => com).ToListAsync();
        }

        public async Task<UserComment> UpdateCommentAsync(UserComment comment)
        {
            _context.UserComments.Update(comment);
            await _context.SaveChangesAsync();
            return comment;
        }
    }
}
