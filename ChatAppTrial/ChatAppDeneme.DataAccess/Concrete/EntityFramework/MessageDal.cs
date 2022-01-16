using ChatAppDeneme.DataAccess.Abstract;
using ChatAppDeneme.DataAccess.Concrete.EntityFramework.Concrete.Context;
using ChatAppDeneme.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAppDeneme.DataAccess.Concrete.EntityFramework
{
    public class MessageDal:EfEntityRepositoryBase<Message,ChatAppDenemeContext>,IMessageDal
    {
    }
}
