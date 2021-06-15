using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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

        public FollowUser(string followerEmail, string userEmail)
        {
            FollowerEmail = followerEmail;
            UserEmail = userEmail;
        }

        public FollowUser(int followUserId, string followerEmail, string userEmail)
        {
            FollowUserId = followUserId;
            FollowerEmail = followerEmail;
            UserEmail = userEmail;
        }

        public int FollowUserId { get; set; }
        public string FollowerEmail { get; set; }
        [ForeignKey("User")]
        public string UserEmail { get; set; }
        public User User { get; set; }
    }
}
