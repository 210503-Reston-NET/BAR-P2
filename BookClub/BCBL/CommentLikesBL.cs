using System;
using System.Collections.Generic;
using BCModel;
using BCDL;

namespace BCBL
{
    public class CommentLikesBL : ICommentLikeBL
    {
        private readonly ICommentLikesRepo _repo;
        public CommentLikesBL(ICommentLikesRepo repo)
        {
            _repo = repo;
        }

        public CommentLikes AddCommentLikes(CommentLikes commentLike)
        {
            return _repo.AddCommentLikes(commentLike);
        }

        public List<CommentLikes> GetAllCommentLikes()
        {
            return _repo.GetAllCommentLikes();
        }

        public CommentLikes GetCommentLike(CommentLikes commentLike)
        {
            return _repo.GetCommentLike(commentLike);
        }

        public List<CommentLikes> GetCommentLikesByClubPost(int clubPostId)
        {
            return _repo.GetCommentLikesByClubPost(clubPostId);
        }

        public CommentLikes GetCommentLikesById(int id)
        {
            return _repo.GetCommentLikesById(id);
        }

        public List<CommentLikes> GetCommentLikesByUserPost(int userPostId)
        {
            return _repo.GetCommentLikesByUserPost(userPostId);
        }
    }
}
