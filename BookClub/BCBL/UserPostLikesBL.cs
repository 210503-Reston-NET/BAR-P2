using System;
using System.Collections.Generic;
using BCModel;
using BCDL;
using System.Threading.Tasks;

namespace BCBL
{
    public class UserPostLikesBL : IUserPostLikesBL
    {
        private readonly IUserPostLikesRepo _repo;
        public UserPostLikesBL(IUserPostLikesRepo repo)
        {
            _repo = repo;
        }

        public async Task<UserPostLikes> AddUserPostLikeAsync(UserPostLikes userPostLike)
        {
            return await _repo.AddUserPostLikeAsync(userPostLike);
        }

        public async Task<List<UserPostLikes>> GetAllUserPostLikesAsync()
        {
            return await _repo.GetAllUserPostLikesAsync();
        }

        public async Task<UserPostLikes> GetUserPostLikesByIdAsync(int id)
        {
            return await _repo.GetUserPostLikesByIdAsync(id);
        }

        public async Task<List<UserPostLikes>> GetUserPostLikesByUserPostAsync(int userPostId)
        {
            return await _repo.GetUserPostLikesByUserPostAsync(userPostId);
        }
    }
}
