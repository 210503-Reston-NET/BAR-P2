﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCModel;

namespace BCDL
{
    public interface IFollowUserRepo
    {
        FollowUser AddFollowUser(FollowUser followClub);
        List<FollowUser> GetAllFollowUser();
        List<User> GetFollowingByUser(string email);
        List<User> GetFollowersByUser(string email);
        FollowUser DeleteFollowUser(int id);
        bool IsFollowing(string followerEmail, string followedEmail);
    }
}
