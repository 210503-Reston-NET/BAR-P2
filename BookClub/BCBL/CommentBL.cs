using System;
using System.Collections.Generic;
using BCDL;
using BCModel;

namespace BCBL
{
    public class CommentBL : ICommentBL
    {
        private readonly ICommentRepo _repo;
        public CommentBL(ICommentRepo repo)
        {
            _repo = repo;
        }

        public Comment AddComment(Comment comment)
        {
            if (_repo.GetCommentAsync(comment) != null)
            {
                throw new Exception("Comment already exists");
            }
            return _repo.AddCommentAsync(comment);
        }

        public Comment DeleteComment(Comment comment)
        {
            Comment toBeDeleted = _repo.GetCommentAsync(comment);
            if (toBeDeleted != null)
            {
                return _repo.DeleteCommentAsync(comment);
            }
            throw new Exception("Comment does not exist");
        }

        public List<Comment> GetAllComments()
        {
            return _repo.GetAllCommentsAsync();
        }

        public List<Comment> GetClubPostComments(int clubPostId)
        {
            return _repo.GetCommentByClubPostAsync(clubPostId);
        }

        public Comment GetComment(Comment comment)
        {
            return _repo.GetCommentAsync(comment);
        }

        public Comment GetCommentById(int commentID)
        {
            return _repo.GetCommentByIdAsync(commentID);
        }

        public List<Comment> GetUserPostComments(int userPostId)
        {
            return _repo.GetCommentByUserPostAsync(userPostId);
        }

        public Comment UpdateComment(Comment comment)
        {
            return _repo.UpdateCommentAsync(comment);
        }
    }
}
