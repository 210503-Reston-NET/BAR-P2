using System;
using System.Collections.Generic;
using System.Linq;
using BCModel;

namespace BCDL
{
    public class UserPostRepo : IUserPostRepo
    {

        private BookClubDBContext _context;
        public UserPostRepo(BookClubDBContext context)
        {
            _context = context;
        }

        public UserPost AddUserPost(UserPost userPost)
        {
            _context.ChangeTracker.Clear();
            _context.UserPosts.Add(userPost);
            _context.SaveChanges();
            return userPost;
        }

        public UserPost DeleteUserPost(UserPost userPost)
        {
            UserPost toBeDeleted = _context.UserPosts.First(up => up.Id == userPost.Id);
            _context.UserPosts.Remove(toBeDeleted);
            _context.SaveChanges();
            return userPost;
        }

        public List<UserPost> GetAllUserPosts()
        {
            return _context.UserPosts.Select(userPost => userPost).ToList();
        }

        public UserPost GetUserPost(UserPost userPost)
        {
            UserPost found = _context.UserPosts.FirstOrDefault(up => up.Email == userPost.Email && up.Post == userPost.Post && up.TotalLike == userPost.TotalLike && up.TotalDislike == userPost.TotalDislike);
            if (found == null)
            {
                return null;
            }
            return new UserPost(found.Email, found.Post, found.TotalLike, found.TotalDislike);
        }

        public UserPost GetUserPostById(int userPostId)
        {
            return _context.UserPosts.Find(userPostId);
        }

        public List<UserPost> GetUserPostByUser(string userEmail)
        {
            return _context.UserPosts.Where(up => up.Email == userEmail).Select(up => up).ToList();
        }

        public UserPost UpdateUserPost(UserPost userPost)
        {
            _context.UserPosts.Update(userPost);
            _context.SaveChanges();
            return userPost;
        }
    }
}
