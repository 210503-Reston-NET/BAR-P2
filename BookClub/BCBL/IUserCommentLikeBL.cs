using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BCModel;

namespace BCBL
{
    public interface IUserCommentLikeBL
    {
        Task<UserCommentLikes> AddCommentLikesAsync(UserCommentLikes commentLike);
        Task<UserCommentLikes> GetCommentLikeAsync(UserCommentLikes commentLike);
        Task<List<UserCommentLikes>> GetAllCommentLikesAsync();
        Task<List<UserCommentLikes>> GetCommentLikesByUserPostAsync(int userPostId);
        Task<UserCommentLikes> GetCommentLikesByIdAsync(int id);
    }
}
