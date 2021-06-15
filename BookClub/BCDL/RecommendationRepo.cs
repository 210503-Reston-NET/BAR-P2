using BCModel;
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
        public Recommendation AddRecommendation(Recommendation r)
        {
            _context.Recommendations.Add(r);
            _context.SaveChanges();
            return r;
        }

        public Recommendation GetRecommendationByEmail(string email)
        {
            return _context.Recommendations.FirstOrDefault(r => r.UserEmail == email);
        }

        public List<Recommendation> GetRecommendations()
        {
            return _context.Recommendations.Select(
              r => r
          ).ToList();
        }

        public Recommendation UpdateRecommendation(Recommendation r)
        {
            _context.Recommendations.Update(r);
            _context.SaveChanges();

            return r;
        }
    }
}
