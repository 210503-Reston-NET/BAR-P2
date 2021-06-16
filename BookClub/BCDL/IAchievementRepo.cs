using BCModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCDL
{
   public interface IAchievementRepo
    {
        public Task<Achievement> AddAchievementAsync(Achievement r);
        public Task<Achievement> UpdateAchievementAsync(Achievement r);
        public Task<Achievement> GetAchievementByEmailAsync(string email);

        public Task<List<Achievement>> GetAchievementsAsync();
    }
}
