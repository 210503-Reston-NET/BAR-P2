using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCModel;

namespace BCDL
{
    public interface IFollowClubRepo
    {
        Task<FollowClub> AddFollowClubAsync(FollowClub followClub);
        Task<List<FollowClub>> GetAllFollowClubAsync();
        Task<List<BookClub>> GetFollowingByUserAsync(string email);
        Task<FollowClub> DeleteFollowClubAsync(int id);
        Task<List<User>> GetFollowersByClubAsync(int id);
        Task<bool> IsFollowingAsync(string followerEmail, int id);
        Task<FollowClub> DeleteFollowerByEmailsAsync(string followerEmail, int id);
    }
}
