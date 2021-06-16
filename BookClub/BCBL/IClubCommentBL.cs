using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCModel;

namespace BCBL
{
    public interface IClubCommentBL
    {
        Task<ClubComment> AddCommentAsync(ClubComment comment);
        Task<ClubComment> GetCommentAsync(ClubComment comment);
        Task<ClubComment> GetCommentByIdAsync(int commentID);
        Task<List<ClubComment>> GetCommentByClubIdAsync(int ClubId);
        Task<List<ClubComment>> GetAllCommentsAsync();
        Task<ClubComment> DeleteCommentAsync(int id);
        Task<ClubComment> UpdateCommentAsync(ClubComment comment);
    }
}
