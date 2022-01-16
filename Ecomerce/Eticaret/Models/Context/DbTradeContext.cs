using Eticaret.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Eticaret.Models.Context
{
    public class DbTradeContext:DbContext
    {
        public DbTradeContext()
        {
            Database.Connection.ConnectionString = "server=DESKTOP-CHSJJ4J\\SQLEXPRESS;database=DbTrade;Trusted_Connection=true;";
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductCategories> ProductCategories { get; set; }
    }
}