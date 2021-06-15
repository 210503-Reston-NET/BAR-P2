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

        public CommentLikes(int id, bool like, bool dislike, int commentId, string userEmail, int clubPostId, int userPostId)
        {
            Id = id;
            Like = like;
            Dislike = dislike;
            CommentId = commentId;
            UserEmail = userEmail;
            ClubPostId = clubPostId;
            UserPostId = userPostId;
        }

        public CommentLikes(bool like, bool dislike, int commentId, string userEmail, int clubPostId, int userPostId)
        {
            Like = like;
            Dislike = dislike;
            CommentId = commentId;
            UserEmail = userEmail;
            ClubPostId = clubPostId;
            UserPostId = userPostId;
        }

        public int Id { get; set; }
        public bool Like { get; set; }
        public bool Dislike { get; set; }
        public int CommentId { get; set; }
        public string UserEmail { get; set; }
        public int ClubPostId { get; set; }
        public int UserPostId { get; set; }
    }
}
