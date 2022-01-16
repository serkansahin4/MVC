using ChatAppDeneme.DataAccess.Concrete.EntityFramework.Maps.Concrete;
using ChatAppDeneme.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAppDeneme.DataAccess.Concrete.EntityFramework.Concrete.Context
{
    public class ChatAppDenemeContext : DbContext
    {
        public ChatAppDenemeContext() : base("ChatAppDeneme")
        {
            
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<UserFriend> Friends { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            

            modelBuilder.Configurations.Add(new MessageMap());
            modelBuilder.Configurations.Add(new UserMap());

            modelBuilder.Entity<UserFriend>().HasRequired<User>(x => x.Friend).WithMany(x => x.UserFriends).HasForeignKey(x => x.FriendId).WillCascadeOnDelete(false);
            modelBuilder.Entity<UserFriend>().HasRequired<User>(x => x.User).WithMany(x => x.Users).HasForeignKey(x => x.UserId).WillCascadeOnDelete(false);
            modelBuilder.Entity<UserFriend>().HasKey(x => new { x.UserId, x.FriendId}).Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<Message>().HasRequired<User>(x => x.Alici).WithMany(x => x.FriendMessages).HasForeignKey(x => x.AliciId).WillCascadeOnDelete(false);


            base.OnModelCreating(modelBuilder);
        }

     
    }
}
