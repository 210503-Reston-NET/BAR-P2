using System;
using System.Collections.Generic;
using System.Linq;
using BCModel;

namespace BCDL
{
    public class UserPostLikesRepo : IUserPostLikesRepo
    {

        private readonly BookClubDBContext _context;
        public UserPostLikesRepo(BookClubDBContext context)
        {
            _context = context;
        }

        public UserPostLikes AddUserPostLike(UserPostLikes userPostLike)
        {
            _context.ChangeTracker.Clear();
            _context.UserPostLikes.Add(userPostLike);
            _context.SaveChanges();
            return userPostLike;
        }

        public List<UserPostLikes> GetAllUserPostLikes()
        {
            return _context.UserPostLikes.Select(likes => likes).ToList();
        }

        public UserPostLikes GetUserPostLike(UserPostLikes userPostLike)
        {
            return _context.UserPostLikes.Find(userPostLike);
        }

        public UserPostLikes GetUserPostLikesById(int id)
        {
            return _context.UserPostLikes.Find(id);
        }

        public List<UserPostLikes> GetUserPostLikesByUserPost(int userPostId)
        {
            return _context.UserPostLikes.Where(like => like.UserPostId == userPostId).Select(like => like).ToList();
        }
    }
}
