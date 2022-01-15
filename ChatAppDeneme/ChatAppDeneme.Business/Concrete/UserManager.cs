using ChatAppDeneme.Business.Abstract;
using ChatAppDeneme.DataAccess.Abstract;
using ChatAppDeneme.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAppDeneme.Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public void Delete(User user)
        {
            _userDal.Delete(user);
        }

        public User Get(string userName)
        {
            return _userDal.Get(x=>x.UserName==userName);
        }

        public void Update(User user)
        {
            _userDal.Update(user);
        }

    }
}
