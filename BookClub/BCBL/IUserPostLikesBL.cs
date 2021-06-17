using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BCModel;

namespace BCBL
{
    public interface IUserPostLikesBL
    {
        Task<UserPostLikes> AddUserPostLikeAsync(UserPostLikes userPostLike);
        Task<List<UserPostLikes>> GetAllUserPostLikesAsync();
        Task<List<UserPostLikes>> GetUserPostLikesByUserPostAsync(int userPostId);
        Task<UserPostLikes> GetUserPostLikesByIdAsync(int id);
    }
}
