using System;
using System.Collections.Generic;
using System.Linq;
using BCModel;

namespace BCDL
{
    public class UserCommentLikesRepo : IUserCommentLikesRepo
    {
        private readonly BookClubDBContext _context;
        public UserCommentLikesRepo(BookClubDBContext context)
        {
            _context = context;
        }

        public UserCommentLikes AddCommentLikes(UserCommentLikes commentLike)
        {
            _context.ChangeTracker.Clear();
            _context.UserCommentLikes.Add(commentLike);
            _context.SaveChanges();
            return commentLike;
        }

        public List<UserCommentLikes> GetAllCommentLikes()
        {
            return _context.UserCommentLikes.Select(likes => likes).ToList();
        }

        public List<UserCommentLikes> GetCommentLikesByUserPost(int userPostId)
        {
            return _context.UserCommentLikes.Where(like => like.UserPostId == userPostId).Select(like => like).ToList();
        }

        public UserCommentLikes GetCommentLike(UserCommentLikes commentLike)
        {
            return _context.UserCommentLikes.Find(commentLike);
        }

        public UserCommentLikes GetCommentLikesById(int id)
        {
            return _context.UserCommentLikes.Find(id);
        }
    }
}
