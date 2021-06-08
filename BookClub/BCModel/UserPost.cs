using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCModel
{
    public class UserPost
    {
        public UserPost() { }

        public UserPost(string user, string post, int likes, int dislikes)
        {
            Email = user;
            Post = post;
            TotalLike = likes;
            TotalDislike = dislikes;
        }

        public UserPost(int id, string user, string post, int likes, int dislikes)
        {
            Id = id;
            Email = user;
            Post = post;
            TotalLike = likes;
            TotalDislike = dislikes;
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string Post { get; set; }
        public int TotalLike { get; set; }
        public int TotalDislike { get; set; }

        
    }
}
