using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCModel
{
    public class UserCommentLikes
    {
        public UserCommentLikes()
        {
        }

        public UserCommentLikes(int userCommentLikesId, bool like, bool dislike, int userCommentId, string userEmail, int userPostId)
        {
            UserCommentLikesId = userCommentLikesId;
            Like = like;
            Dislike = dislike;
            UserCommentId = userCommentId;
            UserEmail = userEmail;
            UserPostId = userPostId;
        }

        public UserCommentLikes(bool like, bool dislike, int userCommentId, string userEmail, int userPostId)
        {
            Like = like;
            Dislike = dislike;
            UserCommentId = userCommentId;
            UserEmail = userEmail;
            UserPostId = userPostId;
        }

        public int UserCommentLikesId { get; set; }
        public bool Like { get; set; }
        public bool Dislike { get; set; }
        [ForeignKey("UserComment")]
        public int UserCommentId { get; set; }
        public UserComment UserComment { get; set; }
        [ForeignKey("User")]
        public string UserEmail { get; set; }
        public User User { get; set; }
        [ForeignKey("UserPost")]
        public int UserPostId { get; set; }
        public UserPost UserPost { get; set; }
    }
}
