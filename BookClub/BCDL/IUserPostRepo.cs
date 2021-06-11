﻿using System;
using System.Collections.Generic;
using BCModel;

namespace BCDL
{
    public interface IUserPostRepo
    {
        UserPost AddUserPost(UserPost userPost);
        UserPost GetUserPost(UserPost userPost);
        List<UserPost> GetAllUserPosts();
        List<UserPost> GetUserPostByUser(string userEmail);
        UserPost GetUserPostById(int userPostId);
        UserPost DeleteUserPost(UserPost userPost);
        UserPost UpdateUserPost(UserPost userPost);
    }
}