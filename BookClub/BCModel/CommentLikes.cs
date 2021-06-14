using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCModel
{
    public class CommentLikes
    {
        public CommentLikes()
        {
        }

        public CommentLikes(int id, bool like, bool dislike, int commentId, string userEmail)
        {
            Id = id;
            Like = like;
            Dislike = dislike;
            CommentId = commentId;
            UserEmail = userEmail;
        }

        public int Id { get; set; }
        public bool Like { get; set; }
        public bool Dislike { get; set; }
        public int CommentId { get; set; }
        public string UserEmail { get; set; }
    }
}
