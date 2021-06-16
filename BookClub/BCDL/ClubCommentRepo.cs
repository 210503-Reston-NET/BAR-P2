using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCModel;

namespace BCDL
{
    public class ClubCommentRepo : IClubCommentRepo
    {
        private readonly BookClubDBContext _context;
        public ClubCommentRepo(BookClubDBContext context)
        {
            _context = context;
        }

        public ClubComment AddComment(ClubComment comment)
        {
            _context.ChangeTracker.Clear();
            _context.ClubComments.Add(comment);
            _context.SaveChanges();

            return comment;
        }

        public ClubComment DeleteComment(int id)
        {
            _context.ChangeTracker.Clear();
            ClubComment toBeDeleted = _context.ClubComments.FirstOrDefault(cm => cm.ClubPostID == id);
            _context.ClubComments.Remove(toBeDeleted);
            _context.SaveChanges();

            return toBeDeleted;
        }

        public List<ClubComment> GetAllComments()
        {
            _context.ChangeTracker.Clear();
            return _context.ClubComments.Select(cm => cm).ToList();
        }

        public ClubComment GetComment(ClubComment comment)
        {
            _context.ChangeTracker.Clear();
            return _context.ClubComments.FirstOrDefault(cm=> cm.UserEmail.Equals(comment.UserEmail) && cm.ClubPostID == comment.ClubPostID && cm.Message.Equals(comment.Message));
        }

        public ClubComment GetCommentById(int commentID)
        {
            _context.ChangeTracker.Clear();
            return _context.ClubComments.FirstOrDefault(cm => cm.ClubCommentId == commentID);
        }

        public List<ClubComment> GetCommentByClubId(int clubID)
        {
            _context.ChangeTracker.Clear();
            return _context.ClubComments.Where(cm => cm.ClubPostID == clubID).Select(cm => cm).ToList();
        }

        public ClubComment UpdateComment(ClubComment comment)
        {
            _context.ChangeTracker.Clear();
            _context.ClubComments.Update(comment);
            _context.SaveChanges();
            return comment;
        }
    }
}
