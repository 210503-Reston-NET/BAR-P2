﻿using System;
using System.Collections.Generic;
using BCDL;
using BCModel;

namespace BCBL
{
    public class ClubPostBL : IClubPostBL
    {
        private IClubPostRepo _repo;
        public ClubPostBL(IClubPostRepo repo)
        {
            _repo = repo;
        }

        public ClubPost AddClubPost(ClubPost clubPost)
        {
            if (_repo.GetClubPost(clubPost) != null)
            {
                throw new Exception("Club Post already exists");
            }
            return _repo.AddClubPost(clubPost);
        }

        public ClubPost DeleteClubPost(ClubPost clubPost)
        {
            ClubPost toBeDeleted = _repo.GetClubPost(clubPost);
            if (toBeDeleted != null)
            {
                return _repo.DeleteClubPost(clubPost);
            }
            throw new Exception("Club Post does not exist");
        }

        public List<ClubPost> GetAllClubPosts()
        {
            return _repo.GetAllClubPosts();
        }

        public ClubPost GetClubPost(ClubPost clubPost)
        {
            return _repo.GetClubPost(clubPost);
        }

        public ClubPost GetClubPostById(int clubPostId)
        {
            return _repo.GetClubPostById(clubPostId);
        }

        public ClubPost UpdateClubPost(ClubPost clubPost)
        {
            return _repo.UpdateClubPost(clubPost);
        }
    }
}