using assignment1.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assignment1.Data
{
    public class DummyData
    {
        public static async Task Initialize(ApplicationDbContext context,
                              UserManager<ApplicationUser> userManager,
                              RoleManager<ApplicationRole> roleManager)
        {

            //Ensure Database is created.
            context.Database.EnsureCreated();

            String adminId = "";

            string role1 = "Admin";
            string desc1 = "This is the administrator role";

            string role2 = "Member";
            string desc2 = "This is the members role";

            string password = "P@$$w0rd";

            //Check Admin role already exists in database or not.
            if (await roleManager.FindByNameAsync(role1) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(role1, desc1, DateTime.Now));
            }

            //Check User role already exists in database or not.
            if (await roleManager.FindByNameAsync(role2) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(role2, desc2, DateTime.Now));
            }

            //Admin.
            if (await userManager.FindByNameAsync("a") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "a",
                    Email = "a@a.a",
                    FirstName = "Adam",
                    LastName = "Aldridge",
                    Street = "Fake St",
                    City = "Vancouver",
                    Province = "BC",
                    PostalCode = "V5U K8I",
                    Country = "Canada",
                    PhoneNumber = "6902341234"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    //Add password.
                    await userManager.AddPasswordAsync(user, password);
                    //Add role.
                    await userManager.AddToRoleAsync(user, role1);
                }

                adminId = user.Id;

            }

            //Member.(Not Admin)
            if (await userManager.FindByNameAsync("m") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "m",
                    Email = "m@m.m",
                    FirstName = "Mob",
                    LastName = "Marker",
                    Street = "Vermont St",
                    City = "Surrey",
                    Province = "BC",
                    PostalCode = "V1P I5T",
                    Country = "Canada",
                    PhoneNumber = "7788951456"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role2);
                }
            }
        }
    }
}