using System;
using System.Collections.Generic;
using BCModel;

namespace BCBL
{
    public interface IUserPostLikesBL
    {
        UserPostLikes AddUserPostLike(UserPostLikes userPostLike);
        UserPostLikes GetUserPostLike(UserPostLikes userPostLike);
        List<UserPostLikes> GetAllUserPostLikes();
        List<UserPostLikes> GetUserPostLikesByUserPost(int userPostId);
        UserPostLikes GetUserPostLikesById(int Id);
    }
}
