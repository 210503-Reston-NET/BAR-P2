using System;
using System.Collections.Generic;
using BCModel;

namespace BCDL
{
    public interface ICommentLikesRepo
    {
        CommentLikes AddCommentLikes(CommentLikes commentLike);
        CommentLikes GetCommentLike(CommentLikes commentLike);
        List<CommentLikes> GetAllCommentLikes();
        List<CommentLikes> GetCommentLikesByUserPost(int userPostId);
        List<CommentLikes> GetCommentLikesByClubPost(int clubPostId);
        CommentLikes GetCommentLikesById(int Id);
    }
}
