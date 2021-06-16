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
        public Recommendation AddRecommendation(Recommendation r)
        {
            return _repo.AddRecommendationAsync(r);
        }

        public Recommendation GetRecommendationByEmail(string email)
        {
            return _repo.GetRecommendationByEmailAsync(email);
        }

        public List<Recommendation> GetRecommendations()
        {
            return _repo.GetRecommendationsAsync();
                
        }

        public Recommendation UpdateRecommendation(Recommendation r)
        {

            return _repo.UpdateRecommendationAsync(r);
        }
    }
}
