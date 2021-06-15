using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCModel
{
    public class FollowClub
    {
        public FollowClub()
        {
        }

        public FollowClub(string followerEmail, int bookClubId)
        {
            FollowerEmail = followerEmail;
            BookClubId = bookClubId;
        }

        public FollowClub(int followClubId, string followerEmail, int bookClubId)
        {
            FollowClubId = followClubId;
            FollowerEmail = followerEmail;
            BookClubId = bookClubId;
        }
        public int FollowClubId { get; set; }
        public string FollowerEmail { get; set; }
        public int BookClubId { get; set; }
    }
}
