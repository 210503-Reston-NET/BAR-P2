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
        public async Task<FollowClub> AddFollowClubAsync(FollowClub followClub)
        {
            return await _repo.AddFollowClubAsync(followClub);
        }

        public async Task<FollowClub> DeleteFollowClubAsync(int id)
        {
            return await _repo.DeleteFollowClubAsync(id);
        }

        public Task<FollowClub> DeleteFollowerByEmailsAsync(string followerEmail, int id)
        {
            return _repo.DeleteFollowerByEmailsAsync(followerEmail, id);
        }

        public async Task<List<FollowClub>> GetAllFollowClubAsync()
        {
            return await _repo.GetAllFollowClubAsync();
        }

        public async Task<List<User>> GetFollowersByClubAsync(int id)
        {
            return await _repo.GetFollowersByClubAsync(id);
        }

        public async Task<List<BookClub>> GetFollowingByUserAsync(string email)
        {
            return await _repo.GetFollowingByUserAsync(email);
        }

        public async Task<bool> IsFollowingAsync(string followerEmail, int id)
        {
            return await _repo.IsFollowingAsync(followerEmail, id);
        }
    }
}
