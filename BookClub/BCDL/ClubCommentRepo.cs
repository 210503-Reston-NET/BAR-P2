using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCModel;
using Microsoft.EntityFrameworkCore;

namespace BCDL
{
    public class ClubCommentRepo : IClubCommentRepo
    {
        private readonly BookClubDBContext _context;
        public ClubCommentRepo(BookClubDBContext context)
        {
            _context = context;
        }

        public async Task<ClubComment> AddCommentAsync(ClubComment comment)
        {
            _context.ChangeTracker.Clear();
            await _context.ClubComments.AddAsync(comment);
            await _context.SaveChangesAsync();

            return comment;
        }

        public async Task<ClubComment> DeleteCommentAsync(int id)
        {
            _context.ChangeTracker.Clear();
            ClubComment toBeDeleted = await _context.ClubComments.FirstOrDefaultAsync(cm => cm.ClubPostID == id);
            _context.ClubComments.Remove(toBeDeleted);
            await _context.SaveChangesAsync();

            return toBeDeleted;
        }

        public async Task<List<ClubComment>> GetAllCommentsAsync()
        {
            _context.ChangeTracker.Clear();
            return await _context.ClubComments.AsNoTracking().Select(cm => cm).ToListAsync();
        }

        public async Task<ClubComment> GetCommentAsync(ClubComment comment)
        {
            _context.ChangeTracker.Clear();
            return await _context.ClubComments.AsNoTracking().FirstOrDefaultAsync(cm=> cm.UserEmail.Equals(comment.UserEmail) && cm.ClubPostID == comment.ClubPostID && cm.Message.Equals(comment.Message));
        }

        public async Task<ClubComment> GetCommentByIdAsync(int commentID)
        {
            _context.ChangeTracker.Clear();
            return await _context.ClubComments.AsNoTracking().FirstOrDefaultAsync(cm => cm.ClubCommentId == commentID);
        }

        public async Task<List<ClubComment>> GetCommentByClubIdAsync(int clubID)
        {
            _context.ChangeTracker.Clear();
            return await _context.ClubComments.AsNoTracking().Where(cm => cm.ClubPostID == clubID).Select(cm => cm).ToListAsync();
        }

        public async Task<ClubComment> UpdateCommentAsync(ClubComment comment)
        {
            _context.ChangeTracker.Clear();
            _context.ClubComments.Update(comment);
            await _context.SaveChangesAsync();
            return comment;
        }
    }
}
