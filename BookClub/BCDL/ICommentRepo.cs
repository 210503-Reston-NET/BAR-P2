using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BCModel;

namespace BCDL
{
    public interface ICommentRepo
    {
        Task<Comment> AddCommentAsync(Comment comment);
        Task<Comment> GetCommentAsync(Comment comment);
        Task<Comment> GetCommentByIdAsync(int commentID);
        Task<List<Comment>> GetCommentByUserPostAsync(int userPostId);
        Task<List<Comment>> GetCommentByClubPostAsync(int clubPostId);
        Task<List<Comment>> GetAllCommentsAsync();
        Task<Comment> DeleteCommentAsync(Comment comment);
        Task<Comment> UpdateCommentAsync(Comment comment);
    }
}
