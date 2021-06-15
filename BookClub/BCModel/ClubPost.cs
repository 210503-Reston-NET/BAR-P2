
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCModel
{
    public class ClubPost
    {
        public ClubPost() { }

        public ClubPost(int clubPostId, string userEmail, string post, int bookClubId, int totalLike, int totalDislikes, DateTime date)
        {
            ClubPostId = clubPostId;
            UserEmail = userEmail;
            Post = post;
            BookClubId = bookClubId;
            TotalLike = totalLike;
            TotalDislike = totalDislikes;
            Date = date;
        }

        public ClubPost( string userEmail, string post, int bookClubId, int totalLike, int totalDislike, DateTime date)
        {
            UserEmail = userEmail;
            Post = post;
            BookClubId = bookClubId;
            TotalLike = totalLike;
            TotalDislike = totalDislike;
            Date = date;
        }

        public int ClubPostId { get; set; }
        [ForeignKey("User")]
        public string UserEmail { get; set; }
        public User User { get; set; }
        public string Post { get; set; }
        [ForeignKey("BookClub")]
        public int BookClubId { get; set; }
        public BookClub BookClub { get; set; }
        public int TotalLike { get; set; }
        public int TotalDislike { get; set; }
        public DateTime Date { get; set; }



    }
}
