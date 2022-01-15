using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAppDeneme.Entities.Abstract
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            DateNow = DateTime.Now;
        }
        public int Id { get; set; }
        public DateTime DateNow { get; set; }
    }
}
