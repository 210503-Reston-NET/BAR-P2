using BCModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCDL
{
    class RecommendationRepo : IRecommendationRepo
    {
        private readonly BookClubDBContext _context;
        public RecommendationRepo(BookClubDBContext context)
        {
            this._context = context;
        }
        public async Task<Recommendation> AddRecommendationAsync(Recommendation recommendation)
        {
            await _context.Recommendations.AddAsync(recommendation);
            await _context.SaveChangesAsync();
            return recommendation;
        }

        public async Task<Recommendation> GetRecommendationByEmailAsync(string email)
        {
            return await _context.Recommendations.AsNoTracking().FirstOrDefaultAsync(r => r.UserEmail == email);
        }

        public async Task<List<Recommendation>> GetRecommendationsAsync()
        {
            return await _context.Recommendations.AsNoTracking().Select(
              r => r
          ).ToListAsync();
        }

        public async Task<Recommendation> UpdateRecommendationAsync(Recommendation recommendation)
        {
            _context.Recommendations.Update(recommendation);
            await _context.SaveChangesAsync();

            return recommendation;
        }
    }
}
