using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BCModel;
using Microsoft.EntityFrameworkCore;

namespace BCDL
{
    public class ClubPostRepo : IClubPostRepo
    {
        private readonly BookClubDBContext _context;

        public ClubPostRepo(BookClubDBContext context)
        {
            _context = context;
        }

        public async Task<ClubPost> AddClubPostAsync(ClubPost clubPost)
        {
            _context.ChangeTracker.Clear();
            clubPost.Date = DateTime.Now;
            await _context.ClubPosts.AddAsync(clubPost);
            await _context.SaveChangesAsync();
            return clubPost;
        }

        public async Task<ClubPost> DeleteClubPostAsync(ClubPost clubPost)
        {
            ClubPost toBeDeleted = await _context.ClubPosts.AsNoTracking().FirstAsync(cp => cp.ClubPostId == clubPost.ClubPostId);
            _context.ClubPosts.Remove(toBeDeleted);
            await _context.SaveChangesAsync();
            return clubPost;
        }

        public async Task<List<ClubPost>> GetAllClubPostsAsync()
        {
            return await _context.ClubPosts.AsNoTracking().Select(clubPost => clubPost).ToListAsync();
        }

        public async Task<ClubPost> GetClubPostByIdAsync(int clubPostId)
        {
            return await _context.ClubPosts.FindAsync(clubPostId);
        }

        public async Task<ClubPost> UpdateClubPostAsync(ClubPost clubPost)
        {
            _context.ClubPosts.Update(clubPost);
            await _context.SaveChangesAsync();
            return clubPost;
        }

        public async Task<List<ClubPost>> GetClubPostByBookClubAsync(int bookClubId)
        {
            return await _context.ClubPosts.AsNoTracking().Where(cp => cp.BookClubId == bookClubId).Select(cp => cp).ToListAsync();
        }

        public async Task<ClubPost> LikeClubPostAsync(ClubPost clubPost)
        {
            ClubPost old = await _context.ClubPosts.AsNoTracking().FirstOrDefaultAsync(cp => cp.ClubPostId == clubPost.ClubPostId);
            old.TotalLike = old.TotalDislike + 1;
            _context.ClubPosts.Update(old);
            await _context.SaveChangesAsync();
            return old;
        }

        public async Task<ClubPost> DislikeClubPostAsync(ClubPost clubPost)
        {
            ClubPost old = await _context.ClubPosts.AsNoTracking().FirstOrDefaultAsync(cp => cp.ClubPostId == clubPost.ClubPostId);
            int x = old.TotalDislike - 1;
            if (x < 0) { x = 0; }
            old.TotalLike = x;
            _context.ClubPosts.Update(old);
            await _context.SaveChangesAsync();
            return old;
        }
    }
}
