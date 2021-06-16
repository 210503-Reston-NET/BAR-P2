using BCDL;
using BCModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCBL
{
    public class RecommendationBL : IRecommendationBL
    {

        private readonly IRecommendationRepo _repo;
        public RecommendationBL(IRecommendationRepo repo) { this._repo = repo; }

        public async Task<Recommendation> AddRecommendationAsync(Recommendation recommendation)
        {
            return await _repo.AddRecommendationAsync(recommendation);
        }

        public async Task<Recommendation> GetRecommendationByEmailAsync(string email)
        {
            return await _repo.GetRecommendationByEmailAsync(email);
        }

        public async Task<List<Recommendation>> GetRecommendationsAsync()
        {
            return await _repo.GetRecommendationsAsync();
                
        }

        public async Task<Recommendation> UpdateRecommendationAsync(Recommendation r)
        {

            return await _repo.UpdateRecommendationAsync(r);
        }
    }
}
