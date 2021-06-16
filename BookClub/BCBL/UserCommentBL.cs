using System;
using System.Collections.Generic;
using BCDL;
using BCModel;

namespace BCBL
{
    public class CommentBL : IUserCommentBL
    {
        private readonly IUserCommentRepo _repo;
        public CommentBL(IUserCommentRepo repo)
        {
            _repo = repo;
        }

        public UserComment AddComment(UserComment comment)
        {
            if (_repo.GetComment(comment) != null)
            {
                throw new Exception("Comment already exists");
            }
            return _repo.AddComment(comment);
        }

        public UserComment DeleteComment(UserComment comment)
        {
            UserComment toBeDeleted = _repo.GetComment(comment);
            if (toBeDeleted != null)
            {
                return _repo.DeleteComment(comment);
            }
            throw new Exception("Comment does not exist");
        }

        public List<UserComment> GetAllComments()
        {
            return _repo.GetAllComments();
        }

        public UserComment GetComment(UserComment comment)
        {
            return _repo.GetComment(comment);
        }

        public UserComment GetCommentById(int commentID)
        {
            return _repo.GetCommentById(commentID);
        }

        public List<UserComment> GetUserPostComments(int userPostId)
        {
            return _repo.GetCommentByUserPost(userPostId);
        }

        public UserComment UpdateComment(UserComment comment)
        {
            return _repo.UpdateComment(comment);
        }
    }
}
