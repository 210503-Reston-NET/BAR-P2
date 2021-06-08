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

        public Comment(int id, string user, int userpost, int clubPost, string message)
        {
            Id = id;
            Email = user;
            UserPostID = userpost;
            ClubPostID = clubPost;
            Message = message;
        }

        public Comment( string user, int userpost, int clubPost, string message)
        {
            Email = user;
            UserPostID = userpost;
            ClubPostID = clubPost;
            Message = message;
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public int UserPostID { get; set; }

        public int ClubPostID { get; set; }
        public string Message { get; set; }

        

    }
}
