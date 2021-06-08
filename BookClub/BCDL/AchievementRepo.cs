using BCModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCDL
{
   public  class AchievementRepo : IAchievementRepo
    {
        private readonly BookClubDBContext _context;
        public AchievementRepo(BookClubDBContext context)
        {
            this._context = context;
        }
        public Achievement AddAchievement(Achievement r)
        {
            _context.Achievements.Add(r);
            _context.SaveChanges();
            return r;
        }

        public Achievement GetAchievementByEmail(string email)
        {
            return _context.Achievements.FirstOrDefault(r => r.User.Email == email);
        }

        public List<Achievement> GetAchievements()
        {

            return _context.Achievements.Select(
              r => r
          ).ToList();
        }

        public Achievement UpdateAchievement(Achievement r)
        {
            _context.Achievements.Update(r);
            _context.SaveChanges();

            return r;
        }
    }
}
