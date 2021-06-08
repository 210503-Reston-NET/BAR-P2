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
        private readonly IUserDL _userDL;
        public BLFacade(IUserDL userDL)
        {
            this._userDL = userDL;
        }
        public User AddAccount(User user)
        {
            return _userDL.AddUser(user);
        }
    }
}
