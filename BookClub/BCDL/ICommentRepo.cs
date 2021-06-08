﻿using System;
using System.Collections.Generic;
using BCModel;

namespace BCDL
{
    public interface ICommentRepo
    {
        Comment AddComment(Comment comment);
        Comment GetComment(Comment comment);
        Comment GetCommentById(int commentID);
        List<Comment> GetAllComments();
        Comment DeleteComment(Comment comment);
        Comment UpdateComment(Comment comment);
    }
}