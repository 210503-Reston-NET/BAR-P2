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
            if (_repo.GetUserPost(userPost) != null)
            {
                throw new Exception("User Post already exists");
            }
            return _repo.AddUserPost(userPost);
        }

        public UserPost DeleteUserPost(UserPost userPost)
        {
            UserPost toBeDeleted = _repo.GetUserPost(userPost);
            if (toBeDeleted != null)
            {
                return _repo.DeleteUserPost(userPost);
            }
            throw new Exception("User Post does not exist");
        }

        public List<UserPost> GetAllUserPosts()
        {
            return _repo.GetAllUserPosts();
        }

        public UserPost GetUserPost(UserPost userPost)
        {
            return _repo.GetUserPost(userPost);
        }

        public UserPost GetUserPostById(int userPostId)
        {
            return _repo.GetUserPostById(userPostId);
        }

        public List<UserPost> GetUserPostByUser(string userEmail)
        {
            return _repo.GetUserPostByUser(userEmail);
        }

        public UserPost UpdateUserPost(UserPost userPost)
        {
            return _repo.UpdateUserPost(userPost);
        }
    }
}
