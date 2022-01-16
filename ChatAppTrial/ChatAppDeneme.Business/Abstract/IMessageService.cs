using ChatAppDeneme.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAppDeneme.Business.Abstract
{
    public interface IMessageService
    {
        List<Message> GetMessages(int aliciId,int gondericiId);
        void Add(Message message);
        void Delete(Message message);
    }
}
