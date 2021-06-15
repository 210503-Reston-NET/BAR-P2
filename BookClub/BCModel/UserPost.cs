using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCModel
{
    public class UserPost
    {
        public UserPost() { }

        public UserPost(string userEmail, string post, int Totallike, int Totaldislike, DateTime date)
        {
            UserEmail = userEmail;
            Post = post;
            TotalLike = Totallike;
            TotalDislike = Totaldislike;
            Date = date;
        }

        public UserPost(int userPostId, string userEmail, string post, int totalLike, int totalDislike, DateTime date)
        {
            UserPostId = userPostId;
            UserEmail = userEmail;
            Post = post;
            TotalLike = totalLike;
            TotalDislike = totalDislike;
        }

        public int UserPostId { get; set; }
        [ForeignKey("User")]
        public string UserEmail { get; set; }
        public string Post { get; set; }
        public int TotalLike { get; set; }
        public int TotalDislike { get; set; }
        public DateTime Date { get; set; }

    }
}
