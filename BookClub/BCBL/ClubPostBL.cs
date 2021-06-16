using System;
using System.Collections.Generic;
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

        public ClubPost AddClubPost(ClubPost clubPost)
        {
            if (_repo.GetClubPostAsync(clubPost) != null)
            {
                throw new Exception("Club Post already exists");
            }
            return _repo.AddClubPostAsync(clubPost);
        }

        public ClubPost DeleteClubPost(ClubPost clubPost)
        {
            ClubPost toBeDeleted = _repo.GetClubPostAsync(clubPost);
            if (toBeDeleted != null)
            {
                return _repo.DeleteClubPostAsync(clubPost);
            }
            throw new Exception("Club Post does not exist");
        }

        public List<ClubPost> GetAllClubPosts()
        {
            return _repo.GetAllClubPostsAsync();
        }

        public ClubPost GetClubPost(ClubPost clubPost)
        {
            return _repo.GetClubPostAsync(clubPost);
        }

        public List<ClubPost> GetClubPostByBookClub(int bookClubId)
        {
            return _repo.GetClubPostByBookClubAsync(bookClubId);
        }

        public ClubPost GetClubPostById(int clubPostId)
        {
            return _repo.GetClubPostByIdAsync(clubPostId);
        }

        public ClubPost UpdateClubPost(ClubPost clubPost)
        {
            return _repo.UpdateClubPostAsync(clubPost);
        }
       public ClubPost LikeClubPost(ClubPost clubPost) { return _repo.LikeClubPostAsync(clubPost); }
       public ClubPost DislikeClubPost(ClubPost clubPost) { return _repo.DislikeClubPostAsync(clubPost); }

       
    }
}
