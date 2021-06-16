using System;
using System.Collections.Generic;
using BCModel;
using BCDL;

namespace BCBL
{
    public class UserCommentLikesBL : IUserCommentLikeBL
    {
        private readonly IUserCommentLikesRepo _repo;
        public UserCommentLikesBL(IUserCommentLikesRepo repo)
        {
            _repo = repo;
        }

        public UserCommentLikes AddCommentLikes(UserCommentLikes commentLike)
        {
            return _repo.AddCommentLikes(commentLike);
        }

        public List<UserCommentLikes> GetAllCommentLikes()
        {
            return _repo.GetAllCommentLikes();
        }

        public UserCommentLikes GetCommentLike(UserCommentLikes commentLike)
        {
            return _repo.GetCommentLike(commentLike);
        }

        public UserCommentLikes GetCommentLikesById(int id)
        {
            return _repo.GetCommentLikesById(id);
        }

        public List<UserCommentLikes> GetCommentLikesByUserPost(int userPostId)
        {
            return _repo.GetCommentLikesByUserPost(userPostId);
        }
    }
}
