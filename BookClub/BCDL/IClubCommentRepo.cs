using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCModel;

namespace BCDL
{
    public interface IClubCommentRepo
    {
        ClubComment AddComment(ClubComment comment);
        ClubComment GetComment(ClubComment comment);
        ClubComment GetCommentById(int commentID);
        List<ClubComment> GetCommentByClubId(int ClubId);
        List<ClubComment> GetAllComments();
        ClubComment DeleteComment(int id);
        ClubComment UpdateComment(ClubComment comment);
    }
}
