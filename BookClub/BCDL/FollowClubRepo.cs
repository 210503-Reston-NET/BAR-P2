using BCModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCDL
{
    public class FollowClubRepo : IFollowClubRepo
    {
        private readonly BookClubDBContext _context;

        public FollowClubRepo(BookClubDBContext context)
        {
            _context = context;
        }
        public FollowClub AddFollowClub(FollowClub followClub)
        {
            _context.FollowClubs.Add(followClub);
            _context.SaveChanges();
            return followClub;
        }

        public FollowClub DeleteFollowClub(int id)
        {
            FollowClub toBeDeleted = _context.FollowClubs.FirstOrDefault(fc => fc.Id == id);
            if (toBeDeleted != null)
            {
                _context.FollowClubs.Remove(toBeDeleted);
                _context.SaveChanges();
            }
            return toBeDeleted;
        }

        public List<FollowClub> GetAllFollowClub()
        {
            return _context.FollowClubs.Select(fc => fc).ToList();
        }

        public List<BookClub> GetFollowingByUser(string email)
        {
            List<FollowClub> followClubs = _context.FollowClubs.Where(fc => fc.FollowerEmail.Equals(email)).ToList();
            List<BookClub> bookClubs = new List<BookClub>();
            BookClub bookClub;

            foreach(FollowClub follow in followClubs)
            {
                bookClub = _context.BookClubs.FirstOrDefault(bc => bc.Id == follow.ClubID);
                bookClubs.Add(bookClub);
            }

            return bookClubs;
        }

        public List<User> GetFollowersByClub(int id)
        {
            List<FollowClub> followClubs = _context.FollowClubs.Where(fc => fc.ClubID == id).Select(bc => bc).ToList();
            List<User> users = new List<User>();
            User user;

            foreach (FollowClub follow in followClubs)
            {
                user = _context.Users.FirstOrDefault(usr => usr.Email.Equals(follow.FollowerEmail));
                users.Add(user);
            }

            return users;
        }
    }
}
