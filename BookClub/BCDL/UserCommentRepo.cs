using System;
using System.Collections.Generic;
using System.Linq;
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

        public UserComment AddComment(UserComment comment)
        {
            _context.ChangeTracker.Clear();
            _context.UserComments.Add(comment);
            _context.SaveChanges();
            return comment;
        }

        public UserComment DeleteComment(UserComment comment)
        {
            UserComment toBeDeleted = _context.UserComments.First(com => com.UserCommentId == comment.UserCommentId);
            _context.UserComments.Remove(toBeDeleted);
            _context.SaveChanges();
            return comment;
        }

        public List<UserComment> GetAllComments()
        {
            return _context.UserComments.Select(comment => comment).ToList();
        }

        public UserComment GetComment(UserComment comment)
        {
            UserComment found = _context.UserComments.FirstOrDefault(com => com.UserEmail == comment.UserEmail && com.UserPostID == comment.UserPostID && com.Message == comment.Message);
            if (found == null)
            {
                return null;
            }
            return new UserComment(found.UserEmail, found.UserPostID, found.Message);
        }

        public UserComment GetCommentById(int commentID)
        {
            return _context.UserComments.Find(commentID);
        }

        public List<UserComment> GetCommentByUserPost(int userPostId)
        {
            return _context.UserComments.Where(com => com.UserPostID == userPostId).Select(com => com).ToList();
        }

        public UserComment UpdateComment(UserComment comment)
        {
            _context.UserComments.Update(comment);
            _context.SaveChanges();
            return comment;
        }
    }
}
