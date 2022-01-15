using ChatAppDeneme.DataAccess.Abstract;
using ChatAppDeneme.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAppDeneme.Business.Abstract
{
    public interface IUserService
    {
        User Get(string userName);
        void Add(User user);
        void Update(User user);
        void Delete(User user);

    }
}
