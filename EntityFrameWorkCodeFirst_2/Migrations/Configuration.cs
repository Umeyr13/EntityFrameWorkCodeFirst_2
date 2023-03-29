namespace EntityFrameWorkCodeFirst_2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EntityFrameWorkCodeFirst_2.Model.OkulDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "EntityFrameWorkCodeFirst_2.Model.OkulDB";
        }

        protected override void Seed(EntityFrameWorkCodeFirst_2.Model.OkulDB context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
