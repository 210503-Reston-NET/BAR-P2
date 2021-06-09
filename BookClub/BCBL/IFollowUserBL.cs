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
        FollowUser AddFollowUser(FollowUser followClub);
        List<FollowUser> GetAllFollowUser();
        List<User> GetFollowingByUser(string email);
        List<User> GetFollowersByUser(string email);
        FollowUser DeleteFollowUser(int id);
    }
}
