using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCModel;

namespace BCDL
{
    public interface IClubCommentLikesRepo
    {
        ClubCommentLikes AddCommentLikes(ClubCommentLikes commentLike);
        ClubCommentLikes GetCommentLike(ClubCommentLikes commentLike);
        List<ClubCommentLikes> GetAllCommentLikes();
        List<ClubCommentLikes> GetCommentLikesByUserPost(int userPostId);
        ClubCommentLikes GetCommentLikesById(int Id);
    }
}
