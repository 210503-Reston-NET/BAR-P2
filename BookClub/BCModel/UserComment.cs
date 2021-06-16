using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCModel
{
    public class UserComment
    {
        public UserComment() { }

        public UserComment(int userCommentId, string userEmail, int userPostId, string message)
        {
            UserCommentId = userCommentId;
            UserEmail = userEmail;
            UserPostID = userPostId;
            Message = message;
        }

        public UserComment( string userEmail, int userPostId, string message)
        {
            UserEmail = userEmail;
            UserPostID = userPostId;
            Message = message;
        }

        public int UserCommentId { get; set; }
        [ForeignKey("User")]
        public string UserEmail { get; set; }
        public User User { get; set; }
        [ForeignKey("UserPost")]
        public int UserPostID { get; set; }
        public UserPost UserPost { get; set; }
        public string Message { get; set; }



    }
}
