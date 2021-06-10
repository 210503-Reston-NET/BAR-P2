using System;
using System.Collections.Generic;
using System.Linq;
using BCModel;
using Microsoft.EntityFrameworkCore;

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
            _context.ChangeTracker.Clear();
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
            Comment found = _context.Comments.FirstOrDefault(com => com.Email == comment.Email && com.UserPostID == comment.UserPostID && com.ClubPostID == comment.ClubPostID && com.Message == comment.Message);
            if (found == null)
            {
                return null;
            }
            return new Comment(found.Email, found.UserPostID, found.ClubPostID, found.Message);
        }

        public List<Comment> GetCommentByClubPost(int clubPostId)
        {
           return _context.Comments.Where(com => com.ClubPostID == clubPostId).Select(com => com).ToList();
        }

        public Comment GetCommentById(int commentID)
        {
            return _context.Comments.Find(commentID);
        }

        public List<Comment> GetCommentByUserPost(int userPostId)
        {
            return _context.Comments.Where(com => com.UserPostID == userPostId).Select(com => com).ToList();
        }

        public Comment UpdateComment(Comment comment)
        {
            _context.Comments.Update(comment);
            _context.SaveChanges();
            return comment;
        }
    }
}
