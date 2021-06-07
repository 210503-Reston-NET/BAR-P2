using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCModel
{
    class ClubPost
    {
        public ClubPost() { }

        public ClubPost(int id, User user, string post, BookClub bookClub, int likes, int dislikes)
        {
            Id = id;
            UserId = user;
            Post = post;
            BookClubId = bookClub;
            TotalLike = likes;
            TotalDislike = dislikes;
        }

        public ClubPost( User user, string post, BookClub bookClub, int likes, int dislikes)
        {
            UserId = user;
            Post = post;
            BookClubId = bookClub;
            TotalLike = likes;
            TotalDislike = dislikes;
        }

        public int Id { get; set; }
        public User UserId { get; set; }
        public string Post { get; set; }

        public BookClub BookClubId { get; set; }
        public int TotalLike { get; set; }
        public int TotalDislike { get; set; }

        

    }
}
