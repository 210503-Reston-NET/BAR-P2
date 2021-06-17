using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BCModel;
using Microsoft.EntityFrameworkCore;

namespace BCDL
{
    public class UserPostLikesRepo : IUserPostLikesRepo
    {

        private readonly BookClubDBContext _context;
        public UserPostLikesRepo(BookClubDBContext context)
        {
            _context = context;
        }

        public async Task<UserPostLikes> AddUserPostLikeAsync(UserPostLikes userPostLike)
        {
            _context.ChangeTracker.Clear();
            UserPostLikes like = await _context.UserPostLikes.AsNoTracking().FirstOrDefaultAsync(pst => pst.UserEmail == userPostLike.UserEmail && pst.UserPostId == userPostLike.UserPostId);
            if (like == null)
            {
                _context.ChangeTracker.Clear();
                await _context.UserPostLikes.AddAsync(userPostLike);
                UserPost post = await _context.UserPosts.AsNoTracking().FirstOrDefaultAsync(pst => pst.UserPostId == userPostLike.UserPostId);
                if (userPostLike.Like)
                {
                    post.TotalLike += 1;
                }
                else
                {
                    post.TotalDislike += 1;
                }
                _context.UserPosts.Update(post);
                await _context.SaveChangesAsync();
                return userPostLike;
            }
            else
            {
                _context.ChangeTracker.Clear();
                UserPost post = await _context.UserPosts.AsNoTracking().FirstOrDefaultAsync(pst => pst.UserPostId == userPostLike.UserPostId);
                if (like.Like != userPostLike.Like)
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
                    like.Like = userPostLike.Like;
                    like.Dislike = userPostLike.Dislike;

                    _context.UserPostLikes.Update(like);
                    _context.UserPosts.Update(post);
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
                    _context.UserPostLikes.Remove(like);
                    _context.UserPosts.Update(post);
                    await _context.SaveChangesAsync();
                }

            }
            return userPostLike;
        }

        public async Task<List<UserPostLikes>> GetAllUserPostLikesAsync()
        {
            return await _context.UserPostLikes.AsNoTracking().Select(likes => likes).ToListAsync();
        }

        public async Task<UserPostLikes> GetUserPostLikesByIdAsync(int id)
        {
            return await _context.UserPostLikes.FindAsync(id);
        }

        public async Task<List<UserPostLikes>> GetUserPostLikesByUserPostAsync(int userPostId)
        {
            return await _context.UserPostLikes.AsNoTracking().Where(like => like.UserPostId == userPostId).Select(like => like).ToListAsync();
        }
    }
}
