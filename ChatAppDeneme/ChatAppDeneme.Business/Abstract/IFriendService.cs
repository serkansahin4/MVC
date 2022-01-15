using ChatAppDeneme.DataAccess.Abstract;
using ChatAppDeneme.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAppDeneme.Business.Abstract
{
    public interface IFriendService
    {
       
        List<UserFriend> GetAllLazy(string path,int userId);
        void AddFriend(UserFriend friend);
        void DeleteFriend(UserFriend friend);
        
    }
}
