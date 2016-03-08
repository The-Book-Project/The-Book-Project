namespace TheBookProject.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public sealed class Configuration : DbMigrationsConfiguration<TheBookProjectDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(TheBookProjectDbContext context)
        {
            DataSeeder.SeedRoles(context);
            DataSeeder.SeedUser(context);
        }
    }
}
