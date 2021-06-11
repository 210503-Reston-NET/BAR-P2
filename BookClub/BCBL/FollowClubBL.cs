using BCModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCDL;

namespace BCBL
{
    public class FollowClubBL : IFollowClubBL
    {
        private readonly IFollowClubRepo _repo;

        public FollowClubBL(IFollowClubRepo repo)
        {
            _repo = repo;
        }
        public FollowClub AddFollowClub(FollowClub followClub)
        {
            return _repo.AddFollowClub(followClub);
        }

        public FollowClub DeleteFollowClub(int id)
        {
            return _repo.DeleteFollowClub(id);
        }

        public List<FollowClub> GetAllFollowClub()
        {
            return _repo.GetAllFollowClub();
        }

        public List<User> GetFollowersByClub(int id)
        {
            return _repo.GetFollowersByClub(id);
        }

        public List<BookClub> GetFollowingByUser(string email)
        {
            return _repo.GetFollowingByUser(email);
        }
    }
}
