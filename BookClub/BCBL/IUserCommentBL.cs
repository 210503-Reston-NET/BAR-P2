﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BCModel;

namespace BCBL
{
    public interface IUserCommentBL
    {
        Task<UserComment> AddCommentAsync(UserComment comment);
        Task<UserComment> GetCommentAsync(UserComment comment);
        Task<UserComment> GetCommentByIdAsync(int commentID);
        Task<List<UserComment>> GetUserPostCommentsAsync(int userPostId);
        Task<List<UserComment>> GetAllCommentsAsync();
        Task<UserComment> DeleteCommentAsync(UserComment comment);
        Task<UserComment> UpdateCommentAsync(UserComment comment);
    }
}
