using BCModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCDL
{
   public interface IRecommendationRepo
    {
        public Task<Recommendation> AddRecommendationAsync(Recommendation r);
        public Task<Recommendation> UpdateRecommendationAsync(Recommendation r);
        public Task<Recommendation> GetRecommendationByEmailAsync(string email);
        public Task<List<Recommendation>> GetRecommendationsAsync();
    }
}
