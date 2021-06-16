using BCModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCDL;

namespace BCBL
{
    public class ClubCommentBL : IClubCommentBL
    {
        private IClubCommentRepo _repo;
        public ClubCommentBL(IClubCommentRepo repo)
        {
            _repo = repo;
        }

        public async Task<ClubComment> AddCommentAsync(ClubComment comment)
        {
            return await _repo.AddCommentAsync(comment);
        }

        public async Task<ClubComment> DeleteCommentAsync(int id)
        {
            return await _repo.DeleteCommentAsync(id);
        }

        public async Task<List<ClubComment>> GetAllCommentsAsync()
        {
            return await _repo.GetAllCommentsAsync();
        }

        public async Task<ClubComment> GetCommentAsync(ClubComment comment)
        {
            return await _repo.GetCommentAsync(comment);
        }

        public async Task<List<ClubComment>> GetCommentByClubIdAsync(int ClubId)
        {
            return await _repo.GetCommentByClubIdAsync(ClubId);
        }

        public async Task<ClubComment> GetCommentByIdAsync(int commentID)
        {
            return await _repo.GetCommentByIdAsync(commentID);
        }

        public async Task<ClubComment> UpdateCommentAsync(ClubComment comment)
        {
            return await _repo.UpdateCommentAsync(comment);
        }
    }
}
