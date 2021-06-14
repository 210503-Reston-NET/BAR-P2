using System;
using System.Collections.Generic;
using BCModel;

namespace BCBL
{
    public interface ICommentLikeBL
    {
        CommentLikes AddCommentLikes(CommentLikes commentLike);
        CommentLikes GetCommentLike(CommentLikes commentLike);
        List<CommentLikes> GetAllCommentLikes();
        List<CommentLikes> GetCommentLikesByUserPost(int userPostId);
        List<CommentLikes> GetCommentLikesByClubPost(int clubPostId);
        CommentLikes GetCommentLikesById(int id);
    }
}
