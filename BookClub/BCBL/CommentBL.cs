﻿using System;
using System.Collections.Generic;
using BCDL;
using BCModel;

namespace BCBL
{
    public class CommentBL : ICommentBL
    {
        private ICommentRepo _repo;
        public CommentBL(ICommentRepo repo)
        {
            _repo = repo;
        }

        public Comment AddComment(Comment comment)
        {
            if (_repo.GetComment(comment) != null)
            {
                throw new Exception("Comment already exists");
            }
            return _repo.AddComment(comment);
        }

        public Comment DeleteComment(Comment comment)
        {
            Comment toBeDeleted = _repo.GetComment(comment);
            if (toBeDeleted != null)
            {
                return _repo.DeleteComment(comment);
            }
            throw new Exception("Comment does not exist");
        }

        public List<Comment> GetAllComments()
        {
            return _repo.GetAllComments();
        }

        public Comment GetComment(Comment comment)
        {
            return _repo.GetComment(comment);
        }

        public Comment GetCommentById(int commentID)
        {
            return _repo.GetCommentById(commentID);
        }

        public Comment UpdateComment(Comment comment)
        {
            return _repo.UpdateComment(comment);
        }
    }
}