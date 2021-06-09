using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCModel;

namespace BCBL
{
    public interface IFollowClubBL
    {
        FollowClub AddFollowClub(FollowClub followClub);
        List<FollowClub> GetAllFollowClub();
        List<BookClub> GetFollowingByUser(string email);
        FollowClub DeleteFollowClub(int id);
        List<User> GetFollowersByClub(int id);
    }
}
