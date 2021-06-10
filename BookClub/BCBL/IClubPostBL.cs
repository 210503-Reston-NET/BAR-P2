using System;
using System.Collections.Generic;
using BCModel;

namespace BCBL
{
    public interface IClubPostBL
    {
        ClubPost AddClubPost(ClubPost clubPost);
        ClubPost GetClubPost(ClubPost clubPost);
        List<ClubPost> GetClubPostByBookClub(int bookClubId);
        ClubPost GetClubPostById(int clubPostId);
        List<ClubPost> GetAllClubPosts();
        ClubPost DeleteClubPost(ClubPost clubPost);
        ClubPost UpdateClubPost(ClubPost clubPost);
    }
}
