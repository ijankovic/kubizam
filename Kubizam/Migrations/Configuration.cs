namespace Kubizam.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Kubizam.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Kubizam.Models.ApplicationDbContext";
        }

        protected override void Seed(Kubizam.Models.ApplicationDbContext context)
        {
            Infrastructure.Migrations.Database.SeedDatabase(context);
        }
    }
}
