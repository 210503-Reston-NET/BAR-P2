using BCModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCDL;

namespace BCBL
{
    public class FollowUserBL : IFollowUserBL
    {
        private readonly IFollowUserRepo _repo;
        public FollowUserBL(IFollowUserRepo repo)
        {
            _repo = repo;
        }

        public async Task<FollowUser> AddFollowUserAsync(FollowUser followUser)
        {
            return await _repo.AddFollowUserAsync(followUser);
        }

        public async Task<FollowUser> DeleteFollowUserAsync(int id)
        {
            return await _repo.DeleteFollowUserAsync(id);
        }

        public async Task<FollowUser> DeleteFollowerByEmailsAsync(string followerEmail, string followedEmail)
        {
            return await _repo.DeleteFollowerByEmailsAsync(followerEmail, followedEmail);
        }

        public async Task<List<FollowUser>> GetAllFollowUserAsync()
        {
            return await _repo.GetAllFollowUserAsync();
        }

        public async Task<List<User>> GetFollowersByUserAsync(string email)
        {
            return await _repo.GetFollowersByUserAsync(email);
        }

        public async Task<List<User>> GetFollowingByUserAsync(string email)
        {
            return await _repo.GetFollowingByUserAsync(email);
        }

        public async Task<bool> IsFollowingAsync(string followerEmail, string followedEmail)
        {
            return await _repo.IsFollowingAsync(followerEmail, followedEmail);
        }
    }
}
