using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCModel
{
    public class Comment
    {
        public Comment() { }

        public Comment(int id, User user, UserPost userpost, ClubPost clubPost, string message)
        {
            Id = id;
            User = user;
            UserPost = userpost;
            ClubPost = clubPost;
            Message = message;
        }

        public Comment( User user, UserPost userpost, ClubPost clubPost, string message)
        {
            User = user;
            UserPost = userpost;
            ClubPost = clubPost;
            Message = message;
        }

        public int Id { get; set; }
        public User User { get; set; }
        public UserPost UserPost { get; set; }

        public ClubPost ClubPost { get; set; }
        public string Message { get; set; }

        

    }
}
