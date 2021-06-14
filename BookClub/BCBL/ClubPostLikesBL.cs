using System;
using System.Collections.Generic;
using BCModel;
using BCDL;

namespace BCBL
{
    public class ClubPostLikesBL : IClubPostLikesBL
    {
        private readonly IClubPostLikesRepo _repo;
        public ClubPostLikesBL(IClubPostLikesRepo repo)
        {
            _repo = repo;
        }

        public ClubPostLikes AddClubPostLike(ClubPostLikes clubPostLike)
        {
            return _repo.AddClubPostLike(clubPostLike);
        }

        public List<ClubPostLikes> GetAllClubPostLikes()
        {
            return _repo.GetAllClubPostLikes();
        }

        public ClubPostLikes GetClubPostLike(ClubPostLikes clubPostLike)
        {
            return _repo.GetClubPostLike(clubPostLike);
        }

        public List<ClubPostLikes> GetClubPostLikesByClubPost(int clubPostId)
        {
            return _repo.GetClubPostLikesByClubPost(clubPostId);
        }

        public ClubPostLikes GetClubPostLikesById(int id)
        {
            return _repo.GetClubPostLikesById(id);
        }
    }
}
