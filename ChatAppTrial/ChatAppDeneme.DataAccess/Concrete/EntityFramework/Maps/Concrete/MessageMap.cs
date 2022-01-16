using ChatAppDeneme.DataAccess.Concrete.EntityFramework.Maps.Abstract;
using ChatAppDeneme.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAppDeneme.DataAccess.Concrete.EntityFramework.Maps.Concrete
{
    public class MessageMap:BaseMap<Message>
    {
        public MessageMap()
        {
            Property(x => x.Mesaj).HasMaxLength(500);
        }
    }
}
