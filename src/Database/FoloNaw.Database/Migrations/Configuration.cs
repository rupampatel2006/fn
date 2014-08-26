using System.Data.Entity;
using System.Data.Entity.Migrations;
using FoloNow.Database.Models.Entities;

namespace FoloNow.Database.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<EFContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(EFContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            DbSet<Customer> set = context.Set<Customer>();
            set.AddOrUpdate(new Customer {Name = "test", Email = "abc@gmail.com"});
            //  //new Person { FullName = "Brice Lambson" },
            //  //new Person { FullName = "Rowan Miller" }
            //);

        }
    }
}
