namespace ChatAppDeneme.DataAccess.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ChatAppDeneme.DataAccess.Concrete.EntityFramework.Concrete.Context.ChatAppDenemeContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ChatAppDeneme.DataAccess.Concrete.EntityFramework.Concrete.Context.ChatAppDenemeContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
