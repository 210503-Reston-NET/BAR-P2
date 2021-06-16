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
            return _repo.AddClubPostLikeAsync(clubPostLike);
        }

        public List<ClubPostLikes> GetAllClubPostLikes()
        {
            return _repo.GetAllClubPostLikesAsync();
        }

        public ClubPostLikes GetClubPostLike(ClubPostLikes clubPostLike)
        {
            return _repo.GetClubPostLikeAsync(clubPostLike);
        }

        public List<ClubPostLikes> GetClubPostLikesByClubPost(int clubPostId)
        {
            return _repo.GetClubPostLikesByClubPostAsync(clubPostId);
        }

        public ClubPostLikes GetClubPostLikesById(int id)
        {
            return _repo.GetClubPostLikesByIdAsync(id);
        }
    }
}
