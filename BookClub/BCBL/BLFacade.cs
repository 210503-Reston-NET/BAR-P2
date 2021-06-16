using BCDL;
using BCModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCBL
{
    public class BLFacade : IBLFacade
    {
        private readonly IUserRepo _userRepo;
        public BLFacade(IUserRepo userRepo)
        {
            this._userRepo = userRepo;
        }
        public User AddAccount(User user)
        {
            return _userRepo.AddUserAsync(user);
        }
    }
}
