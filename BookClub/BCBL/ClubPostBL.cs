using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BCDL;
using BCModel;

namespace BCBL
{
    public class ClubPostBL : IClubPostBL
    {
        private readonly IClubPostRepo _repo;
        public ClubPostBL(IClubPostRepo repo)
        {
            _repo = repo;
        }

        public async Task<ClubPost> AddClubPostAsync(ClubPost clubPost)
        {
            if (await _repo.GetClubPostAsync(clubPost) != null)
            {
                throw new Exception("Club Post already exists");
            }
            return await _repo.AddClubPostAsync(clubPost);
        }

        public async Task<ClubPost> DeleteClubPostAsync(ClubPost clubPost)
        {
            ClubPost toBeDeleted = await _repo.GetClubPostAsync(clubPost);
            if (toBeDeleted != null)
            {
                return await _repo.DeleteClubPostAsync(clubPost);
            }
            throw new Exception("Club Post does not exist");
        }

        public async Task<List<ClubPost>> GetAllClubPostsAsync()
        {
            return await _repo.GetAllClubPostsAsync();
        }

        public async Task<ClubPost> GetClubPostAsync(ClubPost clubPost)
        {
            return await _repo.GetClubPostAsync(clubPost);
        }

        public async Task<List<ClubPost>> GetClubPostByBookClubAsync(int bookClubId)
        {
            return await _repo.GetClubPostByBookClubAsync(bookClubId);
        }

        public async Task<ClubPost> GetClubPostByIdAsync(int clubPostId)
        {
            return await _repo.GetClubPostByIdAsync(clubPostId);
        }

        public async Task<ClubPost> UpdateClubPostAsync(ClubPost clubPost)
        {
            return await _repo.UpdateClubPostAsync(clubPost);
        }
       public async Task<ClubPost> LikeClubPostAsync(ClubPost clubPost) { return await _repo.LikeClubPostAsync(clubPost); }

       public async Task<ClubPost> DislikeClubPostAsync(ClubPost clubPost) { return await _repo.DislikeClubPostAsync(clubPost); }

       
    }
}
