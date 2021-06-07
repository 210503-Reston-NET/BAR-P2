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

        public ClubPost(int id, User user, string post, BookClub bookClub, int likes, int dislikes)
        {
            Id = id;
            User = user;
            Post = post;
            BookClub = bookClub;
            TotalLike = likes;
            TotalDislike = dislikes;
        }

        public ClubPost( User user, string post, BookClub bookClub, int likes, int dislikes)
        {
            User = user;
            Post = post;
            BookClub = bookClub;
            TotalLike = likes;
            TotalDislike = dislikes;
        }

        public int Id { get; set; }
        public User User { get; set; }
        public string Post { get; set; }

        public BookClub BookClub { get; set; }
        public int TotalLike { get; set; }
        public int TotalDislike { get; set; }

        

    }
}
