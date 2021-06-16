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
        ClubCommentLikes AddCommentLikesAsync(ClubCommentLikes commentLike);
        ClubCommentLikes GetCommentLikeAsync(ClubCommentLikes commentLike);
        List<ClubCommentLikes> GetAllCommentLikesAsync();
        List<ClubCommentLikes> GetCommentLikesByUserPostAsync(int userPostId);
        ClubCommentLikes GetCommentLikesByIdAsync(int Id);
    }
}
