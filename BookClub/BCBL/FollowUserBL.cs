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
            return _repo.AddFollowUser(followUser);
        }

        public FollowUser DeleteFollowUser(int id)
        {
            return _repo.DeleteFollowUser(id);
        }

        public List<FollowUser> GetAllFollowUser()
        {
            return _repo.GetAllFollowUser();
        }

        public List<User> GetFollowersByUser(string email)
        {
            return _repo.GetFollowersByUser(email);
        }

        public List<User> GetFollowingByUser(string email)
        {
            return _repo.GetFollowingByUser(email);
        }
    }
}
