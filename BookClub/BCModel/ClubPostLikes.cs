using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCModel
{
    public class ClubPostLikes
    {
        public ClubPostLikes()
        {
        }

        public ClubPostLikes(int clubPostLikesId, bool like, bool dislike, int clubPostId, string userEmail)
        {
            ClubPostLikesId = clubPostLikesId;
            Like = like;
            Dislike = dislike;
            ClubPostId = clubPostId;
            UserEmail = userEmail;
        }

        public ClubPostLikes(bool like, bool dislike, int clubPostId, string userEmail)
        {
            Like = like;
            Dislike = dislike;
            ClubPostId = clubPostId;
            UserEmail = userEmail;
        }

        public int ClubPostLikesId { get; set; }
        public bool Like { get; set; }
        public bool Dislike { get; set; }
        [ForeignKey("ClubPost")]
        public int ClubPostId { get; set; }
        [ForeignKey("User")]
        public string UserEmail { get; set; }
    }
}
