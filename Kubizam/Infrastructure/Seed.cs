using Kubizam.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Kubizam.Infrastructure
{
    public class Migrations
    {
        public class Database
        {
            public static void SeedDatabase(ApplicationDbContext context)
            {

                if (!context.Roles.Any(r => r.Name == "Administrator"))
                {   
                    var store = new RoleStore<IdentityRole>(context);
                    var manager = new RoleManager<IdentityRole>(store);
                    var role = new IdentityRole { Name = "Administrator" };
                    manager.Create(role);
                }
                if (!context.Users.Any(u => u.UserName == "tinc2k@gmail.com"))
                {
                    var store = new UserStore<ApplicationUser>(context);
                    var manager = new UserManager<ApplicationUser>(store);
                    var user = new ApplicationUser { UserName = "tinc2k@gmail.com", Email = "tinc2k@gmail.com", Hometown = "Springfield" };
                    manager.Create(user, "tinc2k@gmail.com"); //user, password
                    manager.AddToRole(user.Id, "Administrator");
                }
                context.SaveChanges();

                var countries = new List<Country>()
                {
                    new Country() { CountryId = 1, Name = "Croatia" },
                    new Country() { CountryId = 2, Name = "United Kingdom" },
                    new Country() { CountryId = 3, Name = "United States" }
                };
                countries.ForEach(c => context.Countries.AddOrUpdate(c));
                var regions = new List<Region>()
                {
                    new Region() { RegionId = 1, Country = countries[0], Name = "Kvarner" },
                    new Region() { RegionId = 2, Country = countries[0], Name = "Dalmacija" },
                    new Region() { RegionId = 3, Country = countries[0], Name = "Slavonija" },
                    new Region() { RegionId = 4, Country = countries[1], Name = "Great Britain" },
                    new Region() { RegionId = 5, Country = countries[1], Name = "Scotland" },
                    new Region() { RegionId = 6, Country = countries[2], Name = "West Coast" },
                    new Region() { RegionId = 7, Country = countries[2], Name = "East Coast" }
                };
                regions.ForEach(r => context.Regions.AddOrUpdate(r));

                var admin = context.Users.First(u => u.UserName == "tinc2k@gmail.com");
                var todolists = new List<TodoList>()
                {
                    new TodoList() {TodoListId = 1, User = admin, Name = "Inbox", IsImmortal = true},
                    new TodoList() {TodoListId = 2, User = admin, Name = "Ideas", IsImmortal = false},
                    new TodoList() {TodoListId = 3, User = admin, Name = "Coffee", IsImmortal = false}
                };
                todolists.ForEach(tl => context.TodoLists.AddOrUpdate(tl));
                context.SaveChanges();
            }
        }
    }
}