using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BCModel;

namespace BCDL
{
    public interface IClubPostRepo
    {
        Task<ClubPost> AddClubPostAsync(ClubPost clubPost);
        Task<List<ClubPost>> GetAllClubPostsAsync();
        Task<List<ClubPost>> GetClubPostByBookClubAsync(int bookClubId);
        Task<ClubPost> GetClubPostByIdAsync(int clubPostId);
        Task<ClubPost> DeleteClubPostAsync(ClubPost clubPost);
        Task<ClubPost> UpdateClubPostAsync(ClubPost clubPost);
        Task<ClubPost> LikeClubPostAsync(ClubPost clubPost);
        Task<ClubPost> DislikeClubPostAsync(ClubPost clubPost);
    }
}
