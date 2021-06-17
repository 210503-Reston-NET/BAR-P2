using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BCModel;

namespace BCDL
{
    public interface IUserPostLikesRepo
    {
        Task<UserPostLikes> AddUserPostLikeAsync(UserPostLikes userPostLike);
        Task<UserPostLikes> GetUserPostLikeAsync(UserPostLikes userPostLike);
        Task<List<UserPostLikes>> GetAllUserPostLikesAsync();
        Task<List<UserPostLikes>> GetUserPostLikesByUserPostAsync(int userPostId);
        Task<UserPostLikes> GetUserPostLikesByIdAsync(int id);
    }
}
