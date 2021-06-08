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
            return _repo.AddRecommendation(r);
        }

        public Recommendation GetRecommendationByEmail(string email)
        {
            return _repo.GetRecommendationByEmail(email);
        }

        public List<Recommendation> GetRecommendations()
        {
            return _repo.GetRecommendations();
                
        }

        public Recommendation UpdateRecommendation(Recommendation r)
        {

            return _repo.UpdateRecommendation(r);
        }
    }
}
