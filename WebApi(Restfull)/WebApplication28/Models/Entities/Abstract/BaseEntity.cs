using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication28.Models.Entities.Abstract
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            CreatedDate = DateTime.Now;
        }
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}