using BCDL;
using BCModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCBL
{
    public class AchievementBL : IAchievementBL

    {
        private readonly IAchievementRepo _achievementRepo;
        public AchievementBL(IAchievementRepo achievementRepo) { this._achievementRepo = achievementRepo; }

        public async Task<Achievement> AddAchievementAsync(Achievement r)
        {
            return await _achievementRepo.AddAchievementAsync(r);
        }

        public async Task<Achievement> GetAchievementByEmailAsync(string email)
        {
            return await _achievementRepo.GetAchievementByEmailAsync(email);
        }

        public async Task<List<Achievement>> GetAchievementsAsync()
        {
            return await _achievementRepo.GetAchievementsAsync();
        }

        public async Task<Achievement> UpdateAchievementAsync(Achievement r)
        {
            return await _achievementRepo.UpdateAchievementAsync(r);
        }
    }
}
