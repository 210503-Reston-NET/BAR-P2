using BCModel;
using System.Collections.Generic;
using System.Linq;


namespace BCDL
{
    public class UserRepo : IUserRepo
    {
        private readonly BookClubDBContext _context;

        public UserRepo(BookClubDBContext context)
        {
            this._context = context;
        }
        public User AddUser(User u)
        {
            _context.Users.Add(
                    new User
                    {
                       
                        Email = u.Email,
                        Password = u.Password,
                        Address = u.Address,
                        
                    }
                );

            _context.SaveChanges();
            return u;
        }

        public User GetUserByEmail(string email)
        {
            return _context.Users.FirstOrDefault(user => user.Email == email);
        }

        public List<User> GetAllUsers()
        {
            return _context.Users.Select(
              user => user
          ).ToList();
        }

        public User UpdateUser(User u)
        {
            _context.Users.Update(u);
            _context.SaveChanges();

            return u;
        }
    }
}
