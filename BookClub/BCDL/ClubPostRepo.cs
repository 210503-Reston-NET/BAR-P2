﻿using System;
using System.Collections.Generic;
using System.Linq;
using BCModel;

namespace BCDL
{
    public class ClubPostRepo : IClubPostRepo
    {
        private BookClubDBContext _context;

        public ClubPostRepo(BookClubDBContext context)
        {
            _context = context;
        }

        public ClubPost AddClubPost(ClubPost clubPost)
        {
            _context.ClubPosts.Add(clubPost);
            _context.SaveChanges();
            return clubPost;
        }

        public ClubPost DeleteClubPost(ClubPost clubPost)
        {
            ClubPost toBeDeleted = _context.ClubPosts.First(cp => cp.Id == clubPost.Id);
            _context.ClubPosts.Remove(toBeDeleted);
            _context.SaveChanges();
            return clubPost;
        }

        public List<ClubPost> GetAllClubPosts()
        {
            return _context.ClubPosts.Select(clubPost => clubPost).ToList();
        }

        public ClubPost GetClubPost(ClubPost clubPost)
        {
            ClubPost found = _context.ClubPosts.FirstOrDefault(cp => cp.User == clubPost.User && cp.Post == clubPost.Post && cp.BookClub.Id == clubPost.BookClub.Id && cp.TotalLike == clubPost.TotalLike && cp.TotalDislike == clubPost.TotalDislike);
            if (found == null)
            {
                return null;
            }
            return new ClubPost(found.User, found.Post, found.BookClub, found.TotalLike, found.TotalDislike);
        }

        public ClubPost GetClubPostById(int clubPostId)
        {
            return _context.ClubPosts.Find(clubPostId);
        }

        public ClubPost UpdateClubPost(ClubPost clubPost)
        {
            _context.ClubPosts.Update(clubPost);
            _context.SaveChanges();
            return clubPost;
        }
    }
}