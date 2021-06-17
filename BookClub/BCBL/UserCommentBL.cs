using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BCDL;
using BCModel;

namespace BCBL
{
    public class UserCommentBL : IUserCommentBL
    {
        private readonly IUserCommentRepo _repo;
        public UserCommentBL(IUserCommentRepo repo)
        {
            _repo = repo;
        }

        public async Task<UserComment> AddCommentAsync(UserComment comment)
        {
            if (await _repo.GetCommentAsync(comment) != null)
            {
                throw new Exception("Comment already exists");
            }
            return await _repo.AddCommentAsync(comment);
        }

        public async Task<UserComment> DeleteCommentAsync(UserComment comment)
        {
            UserComment toBeDeleted = await _repo.GetCommentAsync(comment);
            if (toBeDeleted != null)
            {
                return await _repo.DeleteCommentAsync(comment);
            }
            throw new Exception("Comment does not exist");
        }

        public async Task<List<UserComment>> GetAllCommentsAsync()
        {
            return await _repo.GetAllCommentsAsync();
        }

        public async Task<UserComment> GetCommentAsync(UserComment comment)
        {
            return await _repo.GetCommentAsync(comment);
        }

        public async Task<UserComment> GetCommentByIdAsync(int commentID)
        {
            return await _repo.GetCommentByIdAsync(commentID);
        }

        public async Task<List<UserComment>> GetUserPostCommentsAsync(int userPostId)
        {
            return await _repo.GetCommentByUserPostAsync(userPostId);
        }

        public async Task<UserComment> UpdateCommentAsync(UserComment comment)
        {
            return await _repo.UpdateCommentAsync(comment);
        }
    }
}