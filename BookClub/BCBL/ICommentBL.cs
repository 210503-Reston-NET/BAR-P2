using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BCModel;

namespace BCBL
{
    public interface ICommentBL
    {
        Task<Comment> AddCommentAsync(Comment comment);
        Task<Comment> GetCommentAsync(Comment comment);
        Task<Comment> GetCommentByIdAsync(int commentID);
        Task<List<Comment>> GetUserPostCommentsAsync(int userPostId);
        Task<List<Comment>> GetClubPostCommentsAsync(int clubPostId);
        Task<List<Comment>> GetAllCommentsAsync();
        Task<Comment> DeleteCommentAsync(Comment comment);
        Task<Comment> UpdateCommentAsync(Comment comment);
    }
}
