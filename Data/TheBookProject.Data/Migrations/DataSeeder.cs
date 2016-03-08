namespace TheBookProject.Data.Migrations
{
    using System.Linq;

    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;

    using TheBookProject.Common.Constants;

    public static class DataSeeder
    {
        public static void SeedUser(TheBookProjectDbContext context)
        {
            if (!context.Users.Any())
            {
                const string UserUserName = "dimitar.dzhurenov@gmail.com";
                const string UserPassword = "123456q";

                var userManager = new UserManager<User>(new UserStore<User>(context));

                var user = new User
                {
                    UserName = UserUserName,
                    Email = UserUserName,
                    FirstName = "Dimitar",
                    LastName = "Dzhurenov",
                    ProfileImage = "https://scontent-frt3-1.xx.fbcdn.net/hprofile-xfa1/v/t1.0-1/p160x160/11902276_656489041153858_217816622943518089_n.jpg?oh=f3610635edcb9aa10234546de03c5c25&oe=574BC706"
                };

                userManager.Create(user, UserPassword);
                userManager.AddToRole(user.Id, GlobalConstants.UserRoleName);

                context.SaveChanges();
            }
        }

        public static void SeedRoles(TheBookProjectDbContext context)
        {
            if (context.Roles.Any())
            {
                return;
            }

            var roleStore = new RoleStore<IdentityRole>(context);
            var roleManager = new RoleManager<IdentityRole>(roleStore);

            roleManager.Create(new IdentityRole { Name = GlobalConstants.UserRoleName });

            context.SaveChanges();
        }
    }
}
