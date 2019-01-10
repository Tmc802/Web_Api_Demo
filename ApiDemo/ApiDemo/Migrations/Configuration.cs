using ApiDemo.Models;

namespace ApiDemo.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ApiDemo.Models.ApiDemoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ApiDemo.Models.ApiDemoContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Contacts.AddOrUpdate(new Contact[]
                {
                    new Contact { Id = 0, FirstName = "Andrew", LastName = "Peters"},
                    new Contact { Id = 1, FirstName = "Brice", LastName = "Lambson"},
                    new Contact { Id = 2, FirstName = "Rowan", LastName = "Miller"}
                });
        }
    }
}
