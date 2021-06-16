using BCModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCDL
{
    class AchievementRepo : IAchievementRepo
    {
        private readonly BookClubDBContext _context;
        public AchievementRepo(BookClubDBContext context)
        {
            this._context = context;
        }
        public async Task<Achievement> AddAchievementAsync(Achievement r)
        {
            await _context.Achievements.AddAsync(r);
            await _context.SaveChangesAsync();
            return r;
        }

        public async Task<Achievement> GetAchievementByEmailAsync(string email)
        {
            return await _context.Achievements.AsNoTracking().FirstOrDefaultAsync(r => r.UserEmail == email);
        }

        public async Task<List<Achievement>> GetAchievementsAsync()
        {

            return await _context.Achievements.AsNoTracking().Select(
              r => r
          ).ToListAsync();
        }

        public async Task<Achievement> UpdateAchievementAsync(Achievement r)
        {
           _context.Achievements.Update(r);
           await _context.SaveChangesAsync();

            return r;
        }
    }
}
