using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCModel
{
    class ClubPost
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Post { get; set; }

        public int BookClubId { get; set; }
        public int TotalLike { get; set; }
        public int TotalDislike { get; set; }

        public ClubPost() { }

    }
}
