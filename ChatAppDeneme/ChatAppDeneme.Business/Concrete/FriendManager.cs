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
    public class FriendManager : IFriendService
    {
        private IFriendDal _friendDal;
        public FriendManager(IFriendDal friendDal)
        {
            _friendDal = friendDal;
        }
        public void AddFriend(UserFriend friend)
        {
            _friendDal.Add(friend);
        }

        public void DeleteFriend(UserFriend friend)
        {
            _friendDal.Delete(friend);
        }

        public List<UserFriend> GetAllLazy(string path, int userId)
        {
           return _friendDal.GetAll(path,x => x.UserId == userId);
        }
    }
}
