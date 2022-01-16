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
    public class MessageManager : IMessageService
    {
        private IMessageDal _messageDal;
        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }
        public void Add(Message message)
        {
            _messageDal.Add(message);
        }

        public void Delete(Message message)
        {
            _messageDal.Delete(message);
        }

        public List<Message> GetMessages(int aliciId, int gondericiId)
        {
           return _messageDal.GetAll("User",x => x.UserId == aliciId && x.AliciId == gondericiId||x.UserId==gondericiId&&x.AliciId==aliciId).OrderByDescending(x=>x.DateNow).ToList();
        }
    }
}
