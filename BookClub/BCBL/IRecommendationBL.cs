using BCModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCBL
{
    public interface IRecommendationBL
    {
        public Recommendation AddRecommendation(Recommendation r);
        public Recommendation UpdateRecommendation(Recommendation r);
        public Recommendation GetRecommendationByEmail(string email);

        public List<Recommendation> GetRecommendations();
    }
}
