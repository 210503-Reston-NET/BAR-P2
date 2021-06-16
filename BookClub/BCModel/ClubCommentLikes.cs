using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCModel
{
    public class ClubCommentLikes
    {
        public ClubCommentLikes()
        {
        }

        public ClubCommentLikes(int clubCommentLikesId, bool like, bool dislike, int clubCommentId, string userEmail, int clubPostId)
        {
            ClubCommentLikesId = clubCommentLikesId;
            Like = like;
            Dislike = dislike;
            ClubCommentId = clubCommentId;
            UserEmail = userEmail;
            ClubPostId = clubPostId;
        }

        public ClubCommentLikes(bool like, bool dislike, int clubCommentId, string userEmail, int clubPostId)
        {
            Like = like;
            Dislike = dislike;
            ClubCommentId = clubCommentId;
            UserEmail = userEmail;
            ClubPostId = clubPostId;
        }

        public int ClubCommentLikesId { get; set; }
        public bool Like { get; set; }
        public bool Dislike { get; set; }
        [ForeignKey("ClubComment")]
        public int ClubCommentId { get; set; }
        public ClubComment ClubComment { get; set; }
        [ForeignKey("User")]
        public string UserEmail { get; set; }
        public User User { get; set; }
        [ForeignKey("ClubPost")]
        public int ClubPostId { get; set; }
        public ClubPost ClubPost { get; set; }
    }
}
