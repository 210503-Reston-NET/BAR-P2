using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCModel;

namespace BCBL
{
    public interface IFollowUserBL
    {
        Task<FollowUser> AddFollowUserAsync(FollowUser followUser);
        Task<List<FollowUser>> GetAllFollowUserAsync();
        Task<List<User>> GetFollowingByUserAsync(string email);
        Task<List<User>> GetFollowersByUserAsync(string email);
        Task<FollowUser> DeleteFollowUserAsync(int id);
        Task<bool> IsFollowingAsync(string followerEmail, string followedEmail);
        Task<FollowUser> DeleteFollowerByEmailsAsync(string followerEmail, string followedEmail);
    }
}
