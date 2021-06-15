using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCModel
{
    public class UserPostLikes
    {
        public UserPostLikes()
        {
        }

        public UserPostLikes(int userPostLikesId, bool like, bool dislike, int userPostId, string userEmail)
        {
            UserPostLikesId = userPostLikesId;
            Like = like;
            Dislike = dislike;
            UserPostId = userPostId;
            UserEmail = userEmail;
        }

        public UserPostLikes(bool like, bool dislike, int userPostId, string userEmail)
        {
            Like = like;
            Dislike = dislike;
            UserPostId = userPostId;
            UserEmail = userEmail;
        }

        public int UserPostLikesId { get; set; }
        public bool Like { get; set; }
        public bool Dislike { get; set; }
        [ForeignKey("UserPost")]
        public int UserPostId { get; set; }
        [ForeignKey("User")]
        public string UserEmail { get; set; }
    }
}
