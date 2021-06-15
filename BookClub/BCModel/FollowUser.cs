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

        public FollowUser(string followerEmail, string followedEmail)
        {
            FollowerEmail = followerEmail;
            FollowedEmail = followedEmail;
        }

        public FollowUser(int followUserId, string followerEmail, string followedEmail)
        {
            FollowUserId = followUserId;
            FollowerEmail = followerEmail;
            FollowedEmail = followedEmail;
        }

        public int FollowUserId { get; set; }
        public string FollowerEmail { get; set; }
        public string FollowedEmail { get; set; }
    }
}
