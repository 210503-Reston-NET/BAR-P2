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

        public FollowUser AddFollowUser(FollowUser followUser)
        {
            return _repo.AddFollowUserAsync(followUser);
        }

        public FollowUser DeleteFollowUser(int id)
        {
            return _repo.DeleteFollowUserAsync(id);
        }

        public List<FollowUser> GetAllFollowUser()
        {
            return _repo.GetAllFollowUserAsync();
        }

        public List<User> GetFollowersByUser(string email)
        {
            return _repo.GetFollowersByUserAsync(email);
        }

        public List<User> GetFollowingByUser(string email)
        {
            return _repo.GetFollowingByUserAsync(email);
        }

        public bool IsFollowing(string followerEmail, string followedEmail)
        {
            return _repo.IsFollowingAsync(followerEmail, followedEmail);
        }
    }
}
