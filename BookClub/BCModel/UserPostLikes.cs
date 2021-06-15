using System;
using System.Collections.Generic;
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
        public int UserPostId { get; set; }
        public string UserEmail { get; set; }
    }
}
