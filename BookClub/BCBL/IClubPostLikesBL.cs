using System;
using System.Collections.Generic;
using BCModel;

namespace BCBL
{
    public interface IClubPostLikesBL
    {
        ClubPostLikes AddClubPostLike(ClubPostLikes clubPostLike);
        ClubPostLikes GetClubPostLike(ClubPostLikes clubPostLike);
        List<ClubPostLikes> GetAllClubPostLikes();
        List<ClubPostLikes> GetClubPostLikesByClubPost(int clubPostId);
        ClubPostLikes GetClubPostLikesById(int Id);
    }
}
