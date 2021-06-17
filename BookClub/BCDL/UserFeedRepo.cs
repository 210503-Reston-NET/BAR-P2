using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCModel;
using Microsoft.EntityFrameworkCore;

namespace BCDL
{
    public class UserFeedRepo : IUserFeedRepo
    {
        private readonly BookClubDBContext _context;

        public UserFeedRepo(BookClubDBContext context)
        {
            _context = context;
        }

        public async Task<List<UserFeed>> GetuserFeedAsync(string email)
        {
            List<UserFeed> feed = new List<UserFeed>();
            List<FollowUser> followUsers = await _context.FollowUsers.AsNoTracking().Where(fl => fl.FollowerEmail.Equals(email)).Select(fl => fl).ToListAsync();
            List<FollowClub> followClubs = await _context.FollowClubs.AsNoTracking().Where(fl => fl.FollowerEmail.Equals(email)).Select(fl => fl).ToListAsync();
            List<UserPost> userPosts;
            List<ClubPost> clubPosts;
            BookClub bookClub;

            foreach(FollowUser followUser in followUsers)
            {
                userPosts = await _context.UserPosts.AsNoTracking().Where(pst => pst.UserEmail.Equals(followUser.UserEmail) || pst.UserEmail.Equals(email)).Select(pst => pst).ToListAsync();

                foreach(UserPost userPost in userPosts)
                {
                    feed.Add(new UserFeed(userPost.Post, userPost.UserEmail, "", 0, userPost.UserPostId, 0, userPost.TotalLike, userPost.TotalDislike, userPost.Date));
                }
            }

            foreach(FollowClub followClub in followClubs)
            {
                clubPosts = await _context.ClubPosts.AsNoTracking().Where(pst => pst.BookClubId == followClub.BookClubId).Select(pst => pst).ToListAsync();

                foreach(ClubPost clubPost in clubPosts)
                {
                    feed.Add(new UserFeed(clubPost.Post, clubPost.UserEmail, "", clubPost.BookClubId, 0, clubPost.ClubPostId, clubPost.TotalLike, clubPost.TotalDislike, clubPost.Date));
                }
            }

            foreach(UserFeed fd in feed)
            {
                bookClub = await _context.BookClubs.AsNoTracking().FirstOrDefaultAsync(bc => bc.BookClubId == fd.BookClubID);

                if (bookClub != null)
                {
                    fd.BookClub = bookClub.Name;
                }
            }

            feed.Sort(delegate (UserFeed y, UserFeed x)
            {
                return x.Date.CompareTo(y.Date);
            });

            return feed;
        }
    }
}
