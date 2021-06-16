using System;
using System.Collections.Generic;
using BCDL;
using BCModel;

namespace BCBL
{
    public class UserPostBL : IUserPostBL
    {

        private readonly IUserPostRepo _repo;
        public UserPostBL(IUserPostRepo repo)
        {
            _repo = repo;
        }

        public UserPost AddUserPost(UserPost userPost)
        {
            if (_repo.GetUserPostAsync(userPost) != null)
            {
                throw new Exception("User Post already exists");
            }
            return _repo.AddUserPostAsync(userPost);
        }

        public UserPost DeleteUserPost(UserPost userPost)
        {
            UserPost toBeDeleted = _repo.GetUserPostAsync(userPost);
            if (toBeDeleted != null)
            {
                return _repo.DeleteUserPostAsync(userPost);
            }
            throw new Exception("User Post does not exist");
        }

        public List<UserPost> GetAllUserPosts()
        {
            return _repo.GetAllUserPostsAsync();
        }

        public UserPost GetUserPost(UserPost userPost)
        {
            return _repo.GetUserPostAsync(userPost);
        }

        public UserPost GetUserPostById(int userPostId)
        {
            return _repo.GetUserPostByIdAsync(userPostId);
        }

        public List<UserPost> GetUserPostByUser(string userEmail)
        {
            return _repo.GetUserPostByUserAsync(userEmail);
        }

        public UserPost UpdateUserPost(UserPost userPost)
        {
            return _repo.UpdateUserPostAsync(userPost);
        }
    }
}
