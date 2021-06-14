using System;
using System.Collections.Generic;
using BCModel;
using BCDL;

namespace BCBL
{
    public class UserPostLikesBL : IUserPostLikesBL
    {
        private readonly IUserPostLikesRepo _repo;
        public UserPostLikesBL(IUserPostLikesRepo repo)
        {
            _repo = repo;
        }

        public UserPostLikes AddUserPostLike(UserPostLikes userPostLike)
        {
            return _repo.AddUserPostLike(userPostLike);
        }

        public List<UserPostLikes> GetAllUserPostLikes()
        {
            return _repo.GetAllUserPostLikes();
        }

        public UserPostLikes GetUserPostLike(UserPostLikes userPostLike)
        {
            return _repo.GetUserPostLike(userPostLike);
        }

        public UserPostLikes GetUserPostLikesById(int id)
        {
            return _repo.GetUserPostLikesById(id);
        }

        public List<UserPostLikes> GetUserPostLikesByUserPost(int userPostId)
        {
            return _repo.GetUserPostLikesByUserPost(userPostId);
        }
    }
}
