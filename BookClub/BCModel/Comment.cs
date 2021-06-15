using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        [ForeignKey("User")]
        public string UserEmail { get; set; }
        public User User { get; set; }
        [ForeignKey("UserPost")]
        public int UserPostID { get; set; }
        public UserPost UserPost { get; set; }
        [ForeignKey("ClubPost")]
        public int ClubPostID { get; set; }
        public ClubPost ClubPost { get; set; }
        public string Message { get; set; }



    }
}
