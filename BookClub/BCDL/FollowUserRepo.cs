﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCModel;

namespace BCDL
{
    public class FollowUserRepo : IFollowUserRepo
    {
        private BookClubDBContext _context;

        public FollowUserRepo(BookClubDBContext context)
        {
            _context = context;
        }
        public FollowUser AddFollowUser(FollowUser followClub)
        {
            _context.FollowUsers.Add(followClub);
            _context.SaveChanges();
            return followClub;
        }

        public FollowUser DeleteFollowUser(int id)
        {
            FollowUser toBeDeleted = _context.FollowUsers.FirstOrDefault(fc => fc.Id == id);
            if (toBeDeleted != null)
            {
                _context.FollowUsers.Remove(toBeDeleted);
                _context.SaveChanges();
            }
            return toBeDeleted;
        }

        public List<FollowUser> GetAllFollowUser()
        {
            return _context.FollowUsers.Select(fc => fc).ToList();
        }

        public List<User> GetFollowingByUser(string email)
        {
            List<FollowUser> followUsers = _context.FollowUsers.Where(fc => fc.FollowerEmail.Equals(email)).ToList();
            List<User> users = new List<User>();
            User user;

            foreach (FollowUser follow in followUsers)
            {
                user = _context.Users.FirstOrDefault(usr => usr.Email == follow.FollowedEmail);
                users.Add(user);
            }

            return users;
        }

        public List<User> GetFollowersByUser(string email)
        {
            List<FollowUser> followUsers = _context.FollowUsers.Where(fc => fc.FollowedEmail.Equals(email)).ToList();
            List<User> users = new List<User>();
            User user;

            foreach (FollowUser follow in followUsers)
            {
                user = _context.Users.FirstOrDefault(usr => usr.Email.Equals(follow.FollowerEmail));
                users.Add(user);
            }

            return users;
        }
    }
}