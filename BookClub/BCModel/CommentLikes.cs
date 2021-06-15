using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCModel
{
    public class CommentLikes
    {
        public CommentLikes()
        {
        }

        public CommentLikes(int commentLikesId, bool like, bool dislike, int commentId, string userEmail, int clubPostId, int userPostId)
        {
            CommentLikesId = commentLikesId;
            Like = like;
            Dislike = dislike;
            CommentId = commentId;
            UserEmail = userEmail;
            ClubPostId = clubPostId;
            UserPostId = userPostId;
        }

        public CommentLikes(bool like, bool dislike, int commentId, string userEmail, int clubPostId, int userPostId)
        {
            Like = like;
            Dislike = dislike;
            CommentId = commentId;
            UserEmail = userEmail;
            ClubPostId = clubPostId;
            UserPostId = userPostId;
        }

        public int CommentLikesId { get; set; }
        public bool Like { get; set; }
        public bool Dislike { get; set; }
        [ForeignKey("Comment")]
        public int CommentId { get; set; }
        public Comment Comment { get; set; }
        [ForeignKey("User")]
        public string UserEmail { get; set; }
        public User User { get; set; }
        [ForeignKey("ClubPost")]
        public int ClubPostId { get; set; }
        public ClubPost ClubPost { get; set; }
        [ForeignKey("UserPost")]
        public int UserPostId { get; set; }
        public UserPost UserPost { get; set; }
    }
}
