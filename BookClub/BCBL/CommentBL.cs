using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BCDL;
using BCModel;

namespace BCBL
{
    public class CommentBL : ICommentBL
    {
        private readonly ICommentRepo _repo;
        public CommentBL(ICommentRepo repo)
        {
            _repo = repo;
        }

        public async Task<Comment> AddCommentAsync(Comment comment)
        {
            if (await _repo.GetCommentAsync(comment) != null)
            {
                throw new Exception("Comment already exists");
            }
            return await _repo.AddCommentAsync(comment);
        }

        public async Task<Comment> DeleteCommentAsync(Comment comment)
        {
            Comment toBeDeleted = await _repo.GetCommentAsync(comment);
            if (toBeDeleted != null)
            {
                return await _repo.DeleteCommentAsync(comment);
            }
            throw new Exception("Comment does not exist");
        }

        public async Task<List<Comment>> GetAllCommentsAsync()
        {
            return await _repo.GetAllCommentsAsync();
        }

        public async Task<List<Comment>> GetClubPostCommentsAsync(int clubPostId)
        {
            return await _repo.GetCommentByClubPostAsync(clubPostId);
        }

        public async Task<Comment> GetCommentAsync(Comment comment)
        {
            return await _repo.GetCommentAsync(comment);
        }

        public async Task<Comment> GetCommentByIdAsync(int commentID)
        {
            return await _repo.GetCommentByIdAsync(commentID);
        }

        public async Task<List<Comment>> GetUserPostCommentsAsync(int userPostId)
        {
            return await _repo.GetCommentByUserPostAsync(userPostId);
        }

        public async Task<Comment> UpdateCommentAsync(Comment comment)
        {
            return await _repo.UpdateCommentAsync(comment);
        }
    }
}
