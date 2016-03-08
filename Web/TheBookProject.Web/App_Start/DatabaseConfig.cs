namespace TheBookProject.Web.App_Start
{
    using System.Data.Entity;

    using Data;
    using Data.Migrations;

    public class DatabaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TheBookProjectDbContext, Configuration>());
            TheBookProjectDbContext.Create().Database.Initialize(true);
        }
    }
}
