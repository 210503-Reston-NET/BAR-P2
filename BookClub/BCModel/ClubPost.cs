using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCModel
{
    public class ClubPost
    {
        public ClubPost() { }

        public ClubPost(int clubPostId, string userEmail, string post, int bookClubId, int totalLike, int totalDislikes)
        {
            ClubPostId = clubPostId;
            UserEmail = userEmail;
            Post = post;
            BookClubId = bookClubId;
            TotalLike = totalLike;
            TotalDislike = totalDislikes;
        }

        public ClubPost( string userEmail, string post, int bookClubId, int totalLike, int totalDislike)
        {
            UserEmail = userEmail;
            Post = post;
            BookClubId = bookClubId;
            TotalLike = totalLike;
            TotalDislike = totalDislike;
        }

        public int ClubPostId { get; set; }
        public string UserEmail { get; set; }
        public string Post { get; set; }

        public int BookClubId { get; set; }
        public int TotalLike { get; set; }
        public int TotalDislike { get; set; }

        

    }
}
