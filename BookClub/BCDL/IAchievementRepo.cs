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
        public Achievement AddAchievement(Achievement r);
        public Achievement UpdateAchievement(Achievement r);
        public Achievement GetAchievementByEmail(string email);

        public List<Achievement> GetAchievements();
    }
}
