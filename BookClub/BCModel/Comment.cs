using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCModel
{
    class Comment
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public int UserPostId { get; set; }

        public int ClubPostId { get; set; }
        public string Message { get; set; }

        public Comment() { }

    }
}
