using System;
using System.Collections.Generic;
using BCModel;
using BCDL;
using System.Threading.Tasks;

namespace BCBL
{
    public class UserCommentLikesBL : IUserCommentLikeBL
    {
        private readonly IUserCommentLikesRepo _repo;
        public UserCommentLikesBL(IUserCommentLikesRepo repo)
        {
            _repo = repo;
        }

        public async Task<UserCommentLikes> AddCommentLikesAsync(UserCommentLikes commentLike)
        {
            return await _repo.AddCommentLikesAsync(commentLike);
        }

        public async Task<List<UserCommentLikes>> GetAllCommentLikesAsync()
        {
            return await _repo.GetAllCommentLikesAsync();
        }

        public async Task<UserCommentLikes> GetCommentLikeAsync(UserCommentLikes commentLike)
        {
            return await _repo.GetCommentLikeAsync(commentLike);
        }

        public async Task<UserCommentLikes> GetCommentLikesByIdAsync(int id)
        {
            return await _repo.GetCommentLikesByIdAsync(id);
        }

        public async Task<List<UserCommentLikes>> GetCommentLikesByUserPostAsync(int userPostId)
        {
            return await _repo.GetCommentLikesByUserPostAsync(userPostId);
        }
    }
}
