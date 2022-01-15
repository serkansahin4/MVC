using ChatAppDeneme.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ChatAppDeneme.Entities.Concrete
{
    public class User : BaseEntity
    {
        public User()
        {
            FriendMessages = new List<Message>();
            Messages = new List<Message>();
            UserFriends = new List<UserFriend>();
            Users = new List<UserFriend>();
        }
        public string FirstName { get; set; }
       
        public string LastName { get; set; }
       
        public string UserName { get; set; }
      
        public string Password { get; set; }

        public virtual List<Message> Messages { get; set; }
        public virtual List<Message> FriendMessages { get; set; }
        public virtual List<UserFriend> UserFriends { get; set; }
        public virtual List<UserFriend> Users { get; set; }
       
    }
}
