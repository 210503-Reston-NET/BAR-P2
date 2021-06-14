using System;
using System.Collections.Generic;
using BCModel;

namespace BCDL
{
    public interface IUserPostLikesRepo
    {
        UserPostLikes AddUserPostLike(UserPostLikes userPostLike);
        UserPostLikes GetUserPostLike(UserPostLikes userPostLike);
        List<UserPostLikes> GetAllUserPostLikes();
        List<UserPostLikes> GetUserPostLikesByUserPost(int userPostId);
        UserPostLikes GetUserPostLikesById(int Id);
    }
}
