using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BCModel;

namespace BCBL
{
    public interface IClubPostBL
    {
        Task<ClubPost> AddClubPostAsync(ClubPost clubPost);
        Task<ClubPost> GetClubPostAsync(ClubPost clubPost);
        Task<List<ClubPost>> GetClubPostByBookClubAsync(int bookClubId);
        Task<ClubPost> GetClubPostByIdAsync(int clubPostId);
        Task<List<ClubPost>> GetAllClubPostsAsync();
        Task<ClubPost> DeleteClubPostAsync(ClubPost clubPost);
        Task<ClubPost> UpdateClubPostAsync(ClubPost clubPost);
        Task<ClubPost> LikeClubPostAsync(ClubPost clubPost);
        Task<ClubPost> DislikeClubPostAsync(ClubPost clubPost);
    }
}
