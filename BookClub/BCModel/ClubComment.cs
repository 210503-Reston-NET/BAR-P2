using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCModel
{
    public class ClubComment
    {
        public ClubComment() { }

        public ClubComment(int clubCommentId, string userEmail, int clubPostId, string message)
        {
            ClubCommentId = clubCommentId;
            UserEmail = userEmail;
            ClubPostID = clubPostId;
            Message = message;
        }

        public ClubComment(string userEmail, int clubPostId, string message)
        {
            UserEmail = userEmail;
            ClubPostID = clubPostId;
            Message = message;
        }

        public int ClubCommentId { get; set; }
        [ForeignKey("User")]
        public string UserEmail { get; set; }
        public User User { get; set; }
        [ForeignKey("ClubPost")]
        public int ClubPostID { get; set; }
        public ClubPost ClubPost { get; set; }
        public string Message { get; set; }



    }
}
