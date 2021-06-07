using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCModel
{
    class UserPost
    {
        public UserPost() { }

        public UserPost(User user, string post, int likes, int dislikes)
        {
            UserId = user;
            Post = post;
            TotalLike = likes;
            TotalDislike = dislikes;
        }

        public UserPost(int id, User user, string post, int likes, int dislikes)
        {
            Id = id;
            UserId = user;
            Post = post;
            TotalLike = likes;
            TotalDislike = dislikes;
        }

        public int Id { get; set; }
        public User UserId { get; set; }
        public string Post { get; set; }
        public int TotalLike { get; set; }
        public int TotalDislike { get; set; }

        
    }
}
