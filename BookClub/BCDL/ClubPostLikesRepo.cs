using System;
using System.Collections.Generic;
using System.Linq;
using BCModel;
using Microsoft.EntityFrameworkCore;

namespace BCDL
{
    public class ClubPostLikesRepo : IClubPostLikesRepo
    {
        private readonly BookClubDBContext _context;
        public ClubPostLikesRepo(BookClubDBContext context)
        {
            _context = context;
        }

        public ClubPostLikes AddClubPostLike(ClubPostLikes clubPostLike)
        {
            _context.ChangeTracker.Clear();
            _context.ClubPostLikes.Add(clubPostLike);
            _context.SaveChanges();
            return clubPostLike;
        }

        public List<ClubPostLikes> GetAllClubPostLikes()
        {
            return _context.ClubPostLikes.Select(likes => likes).ToList();
        }

        public ClubPostLikes GetClubPostLike(ClubPostLikes clubPostLike)
        {
            return _context.ClubPostLikes.Find(clubPostLike);
        }

        public List<ClubPostLikes> GetClubPostLikesByClubPost(int clubPostId)
        {
            return _context.ClubPostLikes.Where(like => like.ClubPostId == clubPostId).Select(like => like).ToList();
        }

        public ClubPostLikes GetClubPostLikesById(int id)
        {
            return _context.ClubPostLikes.Find(id);
        }
    }
}
