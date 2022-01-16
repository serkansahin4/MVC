using ChatAppDeneme.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAppDeneme.Entities.Concrete
{
    public class Message:BaseEntity
    {
        public int AliciId { get; set; }
        [Required(ErrorMessage = "Mesaj 500 Karakterden Az Olmalı"),MaxLength(500)]
        public string Mesaj { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }
        public virtual User Alici { get; set; }
    }
}
