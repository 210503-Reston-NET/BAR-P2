using System;
using System.Collections.Generic;
using BCModel;

namespace BCBL
{
    public interface IUserCommentLikeBL
    {
        UserCommentLikes AddCommentLikes(UserCommentLikes commentLike);
        UserCommentLikes GetCommentLike(UserCommentLikes commentLike);
        List<UserCommentLikes> GetAllCommentLikes();
        List<UserCommentLikes> GetCommentLikesByUserPost(int userPostId);
        UserCommentLikes GetCommentLikesById(int id);
    }
}
