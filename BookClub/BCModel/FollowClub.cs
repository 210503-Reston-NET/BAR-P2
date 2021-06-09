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

        public FollowClub(string follower, int clubID)
        {
            FollowerEmail = follower;
            ClubID = clubID;
        }

        public FollowClub(int id, string follower, int clubID)
        {
            Id = id;
            FollowerEmail = follower;
            ClubID = clubID;
        }
        public int Id { get; set; }
        public string FollowerEmail { get; set; }
        public int ClubID { get; set; }
    }
}
