using ChatAppDeneme.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAppDeneme.Entities.Concrete
{
    public class UserFriend : BaseEntity
    {
        public int FriendId { get; set; }
        public int UserId { get; set; }
        public virtual User Friend { get; set; }
        public virtual User User { get; set; }
        

    }
}
