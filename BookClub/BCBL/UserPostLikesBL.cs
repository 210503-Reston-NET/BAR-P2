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
            return _repo.AddUserPostLikeAsync(userPostLike);
        }

        public List<UserPostLikes> GetAllUserPostLikes()
        {
            return _repo.GetAllUserPostLikesAsync();
        }

        public UserPostLikes GetUserPostLike(UserPostLikes userPostLike)
        {
            return _repo.GetUserPostLikeAsync(userPostLike);
        }

        public UserPostLikes GetUserPostLikesById(int id)
        {
            return _repo.GetUserPostLikesByIdAsync(id);
        }

        public List<UserPostLikes> GetUserPostLikesByUserPost(int userPostId)
        {
            return _repo.GetUserPostLikesByUserPostAsync(userPostId);
        }
    }
}
