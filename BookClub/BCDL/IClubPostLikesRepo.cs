using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BCModel;

namespace BCDL
{
    public interface IClubPostLikesRepo
    {
        Task<ClubPostLikes> AddClubPostLikeAsync(ClubPostLikes clubPostLike);
        Task<ClubPostLikes> GetClubPostLikeAsync(ClubPostLikes clubPostLike);
        Task<List<ClubPostLikes>> GetAllClubPostLikesAsync();
        Task<List<ClubPostLikes>> GetClubPostLikesByClubPostAsync(int clubPostId);
        Task<ClubPostLikes> GetClubPostLikesByIdAsync(int id);
    }
}
