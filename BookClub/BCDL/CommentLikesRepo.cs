using System;
using System.Collections.Generic;
using System.Linq;
using BCModel;

namespace BCDL
{
    public class CommentLikesRepo : ICommentLikesRepo
    {
        private readonly BookClubDBContext _context;
        public CommentLikesRepo(BookClubDBContext context)
        {
            _context = context;
        }

        public CommentLikes AddCommentLikes(CommentLikes commentLike)
        {
            _context.ChangeTracker.Clear();
            _context.CommentLikes.Add(commentLike);
            _context.SaveChanges();
            return commentLike;
        }

        public List<CommentLikes> GetAllCommentLikes()
        {
            return _context.CommentLikes.Select(likes => likes).ToList();
        }

        public List<CommentLikes> GetCommentLikesByUserPost(int userPostId)
        {
            return _context.CommentLikes.Where(like => like.UserPostId == userPostId).Select(like => like).ToList();
        }

        public List<CommentLikes> GetCommentLikesByClubPost(int clubPostId)
        {
            return _context.CommentLikes.Where(like => like.ClubPostId == clubPostId).Select(like => like).ToList();
        }

        public CommentLikes GetCommentLike(CommentLikes commentLike)
        {
            return _context.CommentLikes.Find(commentLike);
        }

        public CommentLikes GetCommentLikesById(int id)
        {
            return _context.CommentLikes.Find(id);
        }
    }
}
