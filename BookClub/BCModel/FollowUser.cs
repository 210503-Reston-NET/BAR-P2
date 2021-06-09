using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCModel
{
    public class FollowUser
    {
        public FollowUser()
        {
        }

        public FollowUser(string follower, string followed)
        {
            FollowerEmail = follower;
            FollowedEmail = followed;
        }

        public FollowUser(int id, string follower, string followed)
        {
            Id = id;
            FollowerEmail = follower;
            FollowedEmail = followed;
        }

        public int Id { get; set; }
        public string FollowerEmail { get; set; }
        public string FollowedEmail { get; set; }
    }
}
