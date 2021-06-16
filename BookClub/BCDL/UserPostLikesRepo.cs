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
            UserPostLikes like = _context.UserPostLikes.FirstOrDefault(pst => pst.UserEmail == userPostLike.UserEmail && pst.UserPostId == userPostLike.UserPostId);
            if (like == null)
            {
                _context.ChangeTracker.Clear();
                _context.UserPostLikes.Add(userPostLike);
                UserPost post = _context.UserPosts.FirstOrDefault(pst => pst.UserPostId == userPostLike.UserPostId);
                if (userPostLike.Like)
                {
                    post.TotalLike += 1;
                }
                else
                {
                    post.TotalDislike += 1;
                }
                _context.UserPosts.Update(post);
                _context.SaveChanges();
                return userPostLike;
            }
            else
            {
                _context.ChangeTracker.Clear();
                UserPost post = _context.UserPosts.FirstOrDefault(pst => pst.UserPostId == userPostLike.UserPostId);
                if (like.Like != userPostLike.Like)
                {
                    if (like.Like)
                    {
                        post.TotalLike -= 1;
                        post.TotalDislike += 1;
                    }
                    else
                    {
                        post.TotalLike += 1;
                        post.TotalDislike -= 1;
                    }
                    like.Like = userPostLike.Like;
                    like.Dislike = userPostLike.Dislike;

                }
                _context.UserPostLikes.Update(like);
                _context.UserPosts.Update(post);
                _context.SaveChanges();
            }

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
