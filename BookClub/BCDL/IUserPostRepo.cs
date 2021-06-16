using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BCModel;

namespace BCDL
{
    public interface IUserPostRepo
    {
        Task<UserPost> AddUserPostAsync(UserPost userPost);
        Task<UserPost> GetUserPostAsync(UserPost userPost);
        Task<List<UserPost>> GetAllUserPostsAsync();
        Task<List<UserPost>> GetUserPostByUserAsync(string userEmail);
        Task<UserPost> GetUserPostByIdAsync(int userPostId);
        Task<UserPost> DeleteUserPostAsync(UserPost userPost);
        Task<UserPost> UpdateUserPostAsync(UserPost userPost);
    }
}
