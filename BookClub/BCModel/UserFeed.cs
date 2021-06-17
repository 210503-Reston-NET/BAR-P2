using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCModel
{
    public class UserFeed
    {
        public UserFeed()
        {
        }

        public UserFeed(string post, string email, string bookclub, int bookClubId, int userPostid, int clubPostId, int likes, int dislikes, DateTime date)
        {
            Post = post;
            UserEmail = email;
            BookClub = bookclub;
            BookClubID = bookClubId;
            UserPostId = userPostid;
            ClubPostId = clubPostId;
            TotalLike = likes;
            TotalDislike = dislikes;
            Date = date;
        }
        public string Post { get; set; }
        public string UserEmail { get; set; }
        public string BookClub { get; set; }
        public int BookClubID { get; set; }
        public int UserPostId { get; set; }
        public int ClubPostId { get; set; }
        public int TotalLike { get; set; }
        public int TotalDislike { get; set; }
        public DateTime Date { get; set; }
    }
}
