namespace Onoma.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Onoma.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Web.WebSockets;

    internal sealed class Configuration : DbMigrationsConfiguration<Onoma.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Onoma.Models.ApplicationDbContext context)
        {
            
            if(!context.Roles.Any(x=>x.Name==RoleName.Administrators))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole() { Name = RoleName.Administrators };

                manager.Create(role);

            }

            if (!context.Roles.Any(x => x.Name == RoleName.Spectators))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole() { Name = RoleName.Spectators };

                manager.Create(role);

            }





            if (!context.Users.Any(user=>user.UserName == "Mponatsos2@gmail.com"))
            {
                var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
                var passwordHash = new PasswordHasher();


                var user = new ApplicationUser
                {
                    UserName = "Mponatsos2@gmail.com",
                    Email = "Mponatsos2@gmail.com",
                    PasswordHash = passwordHash.HashPassword("Admin123!")
                };

                userManager.Create(user);
                userManager.AddToRole(user.Id, RoleName.Administrators);

            }
            if (!context.Users.Any(user => user.UserName == "Mitsos@gmail.com"))
            {
                var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
                var passwordHash = new PasswordHasher();


                var user = new ApplicationUser
                {
                    UserName = "Mitsos@gmail.com",
                    Email = "Mitsos@gmail.com",
                    PasswordHash = passwordHash.HashPassword("Admin123!")
                };

                userManager.Create(user);
                userManager.AddToRole(user.Id, RoleName.Administrators);
                userManager.AddToRole(user.Id, RoleName.Spectators);
            }


        }
    }
}
