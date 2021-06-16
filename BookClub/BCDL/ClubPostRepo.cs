using System;
using System.Collections.Generic;
using System.Linq;
using BCModel;
using Microsoft.EntityFrameworkCore;

namespace BCDL
{
    public class ClubPostRepo : IClubPostRepo
    {
        private readonly BookClubDBContext _context;

        public ClubPostRepo(BookClubDBContext context)
        {
            _context = context;
        }

        public ClubPost AddClubPost(ClubPost clubPost)
        {
            _context.ChangeTracker.Clear();
            clubPost.Date = DateTime.Now;
            _context.ClubPosts.Add(clubPost);
            _context.SaveChanges();
            return clubPost;
        }

        public ClubPost DeleteClubPost(ClubPost clubPost)
        {
            ClubPost toBeDeleted = _context.ClubPosts.First(cp => cp.ClubPostId == clubPost.ClubPostId);
            _context.ClubPosts.Remove(toBeDeleted);
            _context.SaveChanges();
            return clubPost;
        }

        public List<ClubPost> GetAllClubPosts()
        {
            return _context.ClubPosts.Select(clubPost => clubPost).ToList();
        }

        public ClubPost GetClubPostById(int clubPostId)
        {
            return _context.ClubPosts.Find(clubPostId);
        }

        public ClubPost GetClubPost(ClubPost clubPost)
        {
            ClubPost found = _context.ClubPosts.FirstOrDefault(cp => cp.UserEmail == clubPost.UserEmail && cp.Post == clubPost.Post && cp.BookClubId == clubPost.BookClubId && cp.TotalLike == clubPost.TotalLike && cp.TotalDislike == clubPost.TotalDislike && cp.Date == clubPost.Date);
            if (found == null)
            {
                return null;
            }
            return new ClubPost(found.UserEmail, found.Post, found.BookClubId, found.TotalLike, found.TotalDislike, found.Date);
        }

        public ClubPost UpdateClubPost(ClubPost clubPost)
        {
            _context.ClubPosts.Update(clubPost);
            _context.SaveChanges();
            return clubPost;
        }

        public List<ClubPost> GetClubPostByBookClub(int bookClubId)
        {
            return _context.ClubPosts.Where(cp => cp.BookClubId == bookClubId).Select(cp => cp).ToList();
        }

        public ClubPost LikeClubPost(ClubPost clubPost)
        {
            ClubPost old = _context.ClubPosts.FirstOrDefault(cp => cp.ClubPostId == clubPost.ClubPostId);
            old.TotalLike = old.TotalDislike + 1;
            _context.ClubPosts.Update(old);
            //_context.Entry(clubPost).CurrentValues;
            _context.SaveChanges();
            return old;
        }

        public ClubPost DislikeClubPost(ClubPost clubPost)
        {
            ClubPost old = _context.ClubPosts.FirstOrDefault(cp => cp.ClubPostId == clubPost.ClubPostId);
            int x = old.TotalDislike - 1;
            if (x < 0) { x = 0; }
            old.TotalLike =x;
            _context.ClubPosts.Update(old);
            _context.SaveChanges();
            return old;
        }
    }
}
