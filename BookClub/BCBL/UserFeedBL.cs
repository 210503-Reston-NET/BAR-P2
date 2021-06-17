using BCModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCDL;

namespace BCBL
{
    public class UserFeedBL : IUserFeedBL
    {
        private IUserFeedRepo _repo;
        public UserFeedBL(IUserFeedRepo repo)
        {
            _repo = repo;
        }

        public async Task<List<UserFeed>> GetuserFeedAsync(string email)
        {
            return await _repo.GetuserFeedAsync(email);
        }
    }
}
