using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public async Task<ClubPostLikes> AddClubPostLikeAsync(ClubPostLikes clubPostLike)
        {
            _context.ChangeTracker.Clear();
            await _context.ClubPostLikes.AddAsync(clubPostLike);
            await _context.SaveChangesAsync();
            return clubPostLike;
        }

        public async Task<List<ClubPostLikes>> GetAllClubPostLikesAsync()
        {
            return await _context.ClubPostLikes.AsNoTracking().Select(likes => likes).ToListAsync();
        }

        public async Task<ClubPostLikes> GetClubPostLikeAsync(ClubPostLikes clubPostLike)
        {
            return await _context.ClubPostLikes.FindAsync(clubPostLike);
        }

        public async Task<List<ClubPostLikes>> GetClubPostLikesByClubPostAsync(int clubPostId)
        {
            return await _context.ClubPostLikes.AsNoTracking().Where(like => like.ClubPostId == clubPostId).Select(like => like).ToListAsync();
        }

        public async Task<ClubPostLikes> GetClubPostLikesByIdAsync(int id)
        {
            return await _context.ClubPostLikes.FindAsync(id);
        }
    }
}
