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
        public Achievement AddAchievement(Achievement r)
        {
            return _achievementRepo.AddAchievement(r);


        }

        public Achievement GetAchievementByEmail(string email)
        {
            return _achievementRepo.GetAchievementByEmail(email);
        }

        public List<Achievement> GetAchievements()
        {
            return _achievementRepo.GetAchievements();
        }

        public Achievement UpdateAchievement(Achievement r)
        {
            return _achievementRepo.UpdateAchievement(r);
        }
    }
}
