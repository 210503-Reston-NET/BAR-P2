using System;
using System.Collections.Generic;
using BCModel;
using BCDL;
using System.Threading.Tasks;

namespace BCBL
{
    public class CommentLikesBL : ICommentLikeBL
    {
        private readonly ICommentLikesRepo _repo;
        public CommentLikesBL(ICommentLikesRepo repo)
        {
            _repo = repo;
        }

        public async Task<CommentLikes> AddCommentLikesAsync(CommentLikes commentLike)
        {
            return await _repo.AddCommentLikesAsync(commentLike);
        }

        public async Task<List<CommentLikes>> GetAllCommentLikesAsync()
        {
            return await _repo.GetAllCommentLikesAsync();
        }

        public async Task<CommentLikes> GetCommentLikeAsync(CommentLikes commentLike)
        {
            return await _repo.GetCommentLikeAsync(commentLike);
        }

        public async Task<List<CommentLikes>> GetCommentLikesByClubPostAsync(int clubPostId)
        {
            return await _repo.GetCommentLikesByClubPostAsync(clubPostId);
        }

        public async Task<CommentLikes> GetCommentLikesByIdAsync(int id)
        {
            return await _repo.GetCommentLikesByIdAsync(id);
        }

        public async Task<List<CommentLikes>> GetCommentLikesByUserPostAsync(int userPostId)
        {
            return await _repo.GetCommentLikesByUserPostAsync(userPostId);
        }
    }
}
