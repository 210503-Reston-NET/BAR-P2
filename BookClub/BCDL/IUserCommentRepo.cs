using System;
using System.Collections.Generic;
using BCModel;

namespace BCDL
{
    public interface IUserCommentRepo
    {
        UserComment AddComment(UserComment comment);
        UserComment GetComment(UserComment comment);
        UserComment GetCommentById(int commentID);
        List<UserComment> GetCommentByUserPost(int userPostId);
        List<UserComment> GetAllComments();
        UserComment DeleteComment(UserComment comment);
        UserComment UpdateComment(UserComment comment);
    }
}
