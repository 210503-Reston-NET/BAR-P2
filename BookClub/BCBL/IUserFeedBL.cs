using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCModel;

namespace BCBL
{
    public interface IUserFeedBL
    {
        Task<List<UserFeed>> GetuserFeedAsync(string email);
    }
}
