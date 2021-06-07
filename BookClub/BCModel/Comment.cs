using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCModel
{
    class Comment
    {
        public Comment() { }

        public Comment(int id, User user, UserPost userpost, ClubPost clubPost, string message)
        {
            Id = id;
            UserID = user;
            UserPostId = userpost;
            ClubPostId = clubPost;
            Message = message;
        }

        public Comment( User user, UserPost userpost, ClubPost clubPost, string message)
        {
            UserID = user;
            UserPostId = userpost;
            ClubPostId = clubPost;
            Message = message;
        }

        public int Id { get; set; }
        public User UserID { get; set; }
        public UserPost UserPostId { get; set; }

        public ClubPost ClubPostId { get; set; }
        public string Message { get; set; }

        

    }
}
