using System;
using System.Collections.Generic;
using BCModel;

namespace BCBL
{
    public interface IUserCommentBL
    {
        UserComment AddComment(UserComment comment);
        UserComment GetComment(UserComment comment);
        UserComment GetCommentById(int commentID);
        List<UserComment> GetUserPostComments(int userPostId);
        List<UserComment> GetAllComments();
        UserComment DeleteComment(UserComment comment);
        UserComment UpdateComment(UserComment comment);
    }
}
