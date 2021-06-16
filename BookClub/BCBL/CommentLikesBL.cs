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
            return _repo.AddCommentLikesAsync(commentLike);
        }

        public List<CommentLikes> GetAllCommentLikes()
        {
            return _repo.GetAllCommentLikesAsync();
        }

        public CommentLikes GetCommentLike(CommentLikes commentLike)
        {
            return _repo.GetCommentLikeAsync(commentLike);
        }

        public List<CommentLikes> GetCommentLikesByClubPost(int clubPostId)
        {
            return _repo.GetCommentLikesByClubPostAsync(clubPostId);
        }

        public CommentLikes GetCommentLikesById(int id)
        {
            return _repo.GetCommentLikesByIdAsync(id);
        }

        public List<CommentLikes> GetCommentLikesByUserPost(int userPostId)
        {
            return _repo.GetCommentLikesByUserPostAsync(userPostId);
        }
    }
}
