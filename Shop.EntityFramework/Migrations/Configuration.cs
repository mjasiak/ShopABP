using System.Data.Entity.Migrations;

namespace Shop.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Shop.EntityFramework.ShopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Shop";
        }

        protected override void Seed(Shop.EntityFramework.ShopDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
        }
    }
}
