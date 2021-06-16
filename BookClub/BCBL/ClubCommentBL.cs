using BCModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCDL;

namespace BCBL
{
    public class ClubCommentBL : IClubCommentBL
    {
        private IClubCommentRepo _repo;
        public ClubCommentBL(IClubCommentRepo repo)
        {
            _repo = repo;
        }

        public ClubComment AddComment(ClubComment comment)
        {
            return _repo.AddComment(comment);
        }

        public ClubComment DeleteComment(int id)
        {
            return _repo.DeleteComment(id);
        }

        public List<ClubComment> GetAllComments()
        {
            return _repo.GetAllComments();
        }

        public ClubComment GetComment(ClubComment comment)
        {
            return _repo.GetComment(comment);
        }

        public List<ClubComment> GetCommentByClubId(int ClubId)
        {
            return _repo.GetCommentByClubId(ClubId);
        }

        public ClubComment GetCommentById(int commentID)
        {
            return _repo.GetCommentById(commentID);
        }

        public ClubComment UpdateComment(ClubComment comment)
        {
            return _repo.UpdateComment(comment);
        }
    }
}
