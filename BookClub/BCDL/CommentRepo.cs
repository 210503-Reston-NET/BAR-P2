using System;
using System.Collections.Generic;
using System.Linq;
using BCModel;

namespace BCDL
{
    public class CommentRepo : ICommentRepo
    {
        private BookClubDBContext _context;
        public CommentRepo(BookClubDBContext context)
        {
            _context = context;
        }

        public Comment AddComment(Comment comment)
        {
            _context.Comments.Add(comment);
            _context.SaveChanges();
            return comment;
        }

        public Comment DeleteComment(Comment comment)
        {
            Comment toBeDeleted = _context.Comments.First(com => com.Id == comment.Id);
            _context.Comments.Remove(toBeDeleted);
            _context.SaveChanges();
            return comment;
        }

        public List<Comment> GetAllComments()
        {
            return _context.Comments.Select(comment => comment).ToList();
        }

        public Comment GetComment(Comment comment)
        {
            Comment found = _context.Comments.FirstOrDefault(com => com.User.Email == comment.User.Email && com.UserPost.Id == comment.UserPost.Id && com.ClubPost.Id == comment.ClubPost.Id && com.Message == comment.Message);
            if (found == null)
            {
                return null;
            }
            return new Comment(found.User, found.UserPost, found.ClubPost, found.Message);
        }

        public Comment GetCommentById(int commentID)
        {
            return _context.Comments.Find(commentID);
        }

        public Comment UpdateComment(Comment comment)
        {
            _context.Comments.Update(comment);
            _context.SaveChanges();
            return comment;
        }
    }
}
