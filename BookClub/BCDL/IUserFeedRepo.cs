using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCModel;

namespace BCDL
{
    public interface IUserFeedRepo
    {
        Task<List<UserFeed>> GetuserFeedAsync(string email);
    }
}
