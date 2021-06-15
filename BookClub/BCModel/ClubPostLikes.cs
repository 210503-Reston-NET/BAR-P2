using System;
using System.Collections.Generic;
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

        public ClubPostLikes(int id, bool like, bool dislike, int clubPostId, string userEmail)
        {
            Id = id;
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

        public int Id { get; set; }
        public bool Like { get; set; }
        public bool Dislike { get; set; }
        public int ClubPostId { get; set; }
        public string UserEmail { get; set; }
    }
}
