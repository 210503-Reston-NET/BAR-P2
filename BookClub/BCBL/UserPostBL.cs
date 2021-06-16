using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BCDL;
using BCModel;

namespace BCBL
{
    public class UserPostBL : IUserPostBL
    {

        private readonly IUserPostRepo _repo;
        public UserPostBL(IUserPostRepo repo)
        {
            _repo = repo;
        }

        public async Task<UserPost> AddUserPostAsync(UserPost userPost)
        {
            if (await _repo.GetUserPostAsync(userPost) != null)
            {
                throw new Exception("User Post already exists");
            }
            return await _repo.AddUserPostAsync(userPost);
        }

        public async Task<UserPost> DeleteUserPostAsync(UserPost userPost)
        {
            UserPost toBeDeleted = await _repo.GetUserPostAsync(userPost);
            if (toBeDeleted != null)
            {
                return await _repo.DeleteUserPostAsync(userPost);
            }
            throw new Exception("User Post does not exist");
        }

        public async Task<List<UserPost>> GetAllUserPostsAsync()
        {
            return await _repo.GetAllUserPostsAsync();
        }

        public async Task<UserPost> GetUserPostAsync(UserPost userPost)
        {
            return await _repo.GetUserPostAsync(userPost);
        }

        public async Task<UserPost> GetUserPostByIdAsync(int userPostId)
        {
            return await _repo.GetUserPostByIdAsync(userPostId);
        }

        public async Task<List<UserPost>> GetUserPostByUserAsync(string userEmail)
        {
            return await _repo.GetUserPostByUserAsync(userEmail);
        }

        public async Task<UserPost> UpdateUserPostAsync(UserPost userPost)
        {
            return await _repo.UpdateUserPostAsync(userPost);
        }
    }
}
