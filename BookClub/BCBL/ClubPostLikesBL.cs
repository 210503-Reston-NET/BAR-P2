using System;
using System.Collections.Generic;
using BCModel;
using BCDL;
using System.Threading.Tasks;

namespace BCBL
{
    public class ClubPostLikesBL : IClubPostLikesBL
    {
        private readonly IClubPostLikesRepo _repo;
        public ClubPostLikesBL(IClubPostLikesRepo repo)
        {
            _repo = repo;
        }

        public async Task<ClubPostLikes> AddClubPostLikeAsync(ClubPostLikes clubPostLike)
        {
            return await _repo.AddClubPostLikeAsync(clubPostLike);
        }

        public async Task<List<ClubPostLikes>> GetAllClubPostLikesAsync()
        {
            return await _repo.GetAllClubPostLikesAsync();
        }

        public async Task<ClubPostLikes> GetClubPostLikeAsync(ClubPostLikes clubPostLike)
        {
            return await _repo.GetClubPostLikeAsync(clubPostLike);
        }

        public async Task<List<ClubPostLikes>> GetClubPostLikesByClubPostAsync(int clubPostId)
        {
            return await _repo.GetClubPostLikesByClubPostAsync(clubPostId);
        }

        public async Task<ClubPostLikes> GetClubPostLikesByIdAsync(int id)
        {
            return await _repo.GetClubPostLikesByIdAsync(id);
        }
    }
}
