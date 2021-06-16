using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BCModel;

namespace BCDL
{
    public interface ICommentLikesRepo
    {
        Task<CommentLikes> AddCommentLikesAsync(CommentLikes commentLike);
        Task<CommentLikes> GetCommentLikeAsync(CommentLikes commentLike);
        Task<List<CommentLikes>> GetAllCommentLikesAsync();
        Task<List<CommentLikes>> GetCommentLikesByUserPostAsync(int userPostId);
        Task<List<CommentLikes>> GetCommentLikesByClubPostAsync(int clubPostId);
        Task<CommentLikes> GetCommentLikesByIdAsync(int Id);
    }
}
