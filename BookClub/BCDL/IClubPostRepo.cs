using System;
using System.Collections.Generic;
using BCModel;

namespace BCDL
{
    public interface IClubPostRepo
    {
        ClubPost AddClubPost(ClubPost clubPost);
        ClubPost GetClubPost(ClubPost clubPost);
        List<ClubPost> GetAllClubPosts();
        ClubPost GetClubPostById(int clubPostId);
        ClubPost DeleteClubPost(ClubPost clubPost);
        ClubPost UpdateClubPost(ClubPost clubPost);
    }
}
