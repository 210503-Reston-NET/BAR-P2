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

        public Comment(int commentId, string userEmail, int userPostId, int clubPostId, string message)
        {
            CommentId = commentId;
            UserEmail = userEmail;
            UserPostID = userPostId;
            ClubPostID = clubPostId;
            Message = message;
        }

        public Comment( string userEmail, int userPostId, int clubPostId, string message)
        {
            UserEmail = userEmail;
            UserPostID = userPostId;
            ClubPostID = clubPostId;
            Message = message;
        }

        public int CommentId { get; set; }
        public string UserEmail { get; set; }
        public int UserPostID { get; set; }

        public int ClubPostID { get; set; }
        public string Message { get; set; }

        

    }
}
