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
        List<ClubPost> GetClubPostByBookClub(int bookClubId);
        ClubPost GetClubPostById(int clubPostId);
        ClubPost DeleteClubPost(ClubPost clubPost);
        ClubPost UpdateClubPost(ClubPost clubPost);

        ClubPost LikeClubPost(ClubPost clubPost);
        ClubPost DislikeClubPost(ClubPost clubPost);
    }
}
