using System;
using System.Collections.Generic;
using BCModel;

namespace BCDL
{
    public interface IUserCommentLikesRepo
    {
        UserCommentLikes AddCommentLikes(UserCommentLikes commentLike);
        UserCommentLikes GetCommentLike(UserCommentLikes commentLike);
        List<UserCommentLikes> GetAllCommentLikes();
        List<UserCommentLikes> GetCommentLikesByUserPost(int userPostId);
        UserCommentLikes GetCommentLikesById(int Id);
    }
}
