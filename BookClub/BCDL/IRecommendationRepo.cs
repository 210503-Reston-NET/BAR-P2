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
        public Task<Recommendation> AddRecommendationAsync(Recommendation recommendation);
        public Task<Recommendation> UpdateRecommendationAsync(Recommendation recommendation);
        public Task<Recommendation> GetRecommendationByEmailAsync(string email);
        public Task<List<Recommendation>> GetRecommendationsAsync();
    }
}
