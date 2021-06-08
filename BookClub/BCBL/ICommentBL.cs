using System;
using System.Collections.Generic;
using BCModel;

namespace BCBL
{
    public interface ICommentBL
    {
        Comment AddComment(Comment comment);
        Comment GetComment(Comment comment);
        Comment GetCommentById(int commentID);
        List<Comment> GetAllComments();
        Comment DeleteComment(Comment comment);
        Comment UpdateComment(Comment comment);
    }
}
