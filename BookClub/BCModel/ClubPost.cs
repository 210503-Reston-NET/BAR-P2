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

        public ClubPost(int id, string user, string post, int bookClub, int likes, int dislikes)
        {
            Id = id;
            User = user;
            Post = post;
            BookClubID = bookClub;
            TotalLike = likes;
            TotalDislike = dislikes;
        }

        public ClubPost( string user, string post, int bookClub, int likes, int dislikes)
        {
            User = user;
            Post = post;
            BookClubID = bookClub;
            TotalLike = likes;
            TotalDislike = dislikes;
        }

        public int Id { get; set; }
        public string User { get; set; }
        public string Post { get; set; }

        public int BookClubID { get; set; }
        public int TotalLike { get; set; }
        public int TotalDislike { get; set; }

        

    }
}
