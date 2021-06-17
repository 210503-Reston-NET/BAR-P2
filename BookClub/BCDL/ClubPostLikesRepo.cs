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
            ClubPostLikes like = await _context.ClubPostLikes.AsNoTracking().FirstOrDefaultAsync(pst => pst.UserEmail == clubPostLike.UserEmail && pst.ClubPostId == clubPostLike.ClubPostId);
            
            // if this is a first time like
            if (like == null)
            {
                _context.ChangeTracker.Clear();
                await _context.ClubPostLikes.AddAsync(clubPostLike);
                ClubPost post = await _context.ClubPosts.AsNoTracking().FirstOrDefaultAsync(pst => pst.ClubPostId == clubPostLike.ClubPostId);
                if (clubPostLike.Like)
                {
                    post.TotalLike += 1;
                }
                else
                {
                    post.TotalDislike += 1;
                }
                _context.ClubPosts.Update(post);
                await _context.SaveChangesAsync();
                return clubPostLike;
            }
            // if this is a like that already exists
            else
            {
                _context.ChangeTracker.Clear();
                ClubPost post = await _context.ClubPosts.AsNoTracking().FirstOrDefaultAsync(pst => pst.ClubPostId == clubPostLike.ClubPostId);
                if (like.Like != clubPostLike.Like)
                {
                    if (like.Like)
                    {
                        post.TotalLike -= 1;
                        post.TotalDislike += 1;
                    }
                    else
                    {
                        post.TotalLike += 1;
                        post.TotalDislike -= 1;
                    }
                    like.Like = clubPostLike.Like;
                    like.Dislike = clubPostLike.Dislike;

                    _context.ClubPostLikes.Update(like);
                    _context.ClubPosts.Update(post);
                    await _context.SaveChangesAsync();
                }

                else
                {
                    if (like.Like)
                    {
                        post.TotalLike -= 1;
                    }
                    else
                    {
                        post.TotalDislike -= 1;
                    }
                    _context.ClubPostLikes.Remove(like);
                    _context.ClubPosts.Update(post);
                    await _context.SaveChangesAsync();
                }
                
            }
            
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
