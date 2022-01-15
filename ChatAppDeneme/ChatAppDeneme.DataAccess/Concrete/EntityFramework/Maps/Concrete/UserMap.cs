using ChatAppDeneme.DataAccess.Concrete.EntityFramework.Maps.Abstract;
using ChatAppDeneme.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAppDeneme.DataAccess.Concrete.EntityFramework.Maps.Concrete
{
    public class UserMap:BaseMap<User>
    {
        public UserMap()
        {
            Property(x => x.UserName).HasMaxLength(20);
            Property(x => x.Password).HasMaxLength(20);
        }
    }
}
