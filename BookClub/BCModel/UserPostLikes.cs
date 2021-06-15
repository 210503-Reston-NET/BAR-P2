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

        public UserPostLikes(int id, bool like, bool dislike, int userPostId, string userEmail)
        {
            Id = id;
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

        public int Id { get; set; }
        public bool Like { get; set; }
        public bool Dislike { get; set; }
        public int UserPostId { get; set; }
        public string UserEmail { get; set; }
    }
}
