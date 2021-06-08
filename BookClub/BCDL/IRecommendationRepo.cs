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
        public Recommendation AddRecommendation(Recommendation r);
        public Recommendation UpdateRecommendation(Recommendation r);
        public Recommendation GetRecommendationByEmail(string email);

        public List<Recommendation> GetRecommendations();
    }
}
