using System;
using System.Collections.Generic;
using System.Text;
using assignment1.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace assignment1.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<assignment1.Models.ApplicationRole> ApplicationRole { get; set; }
        public DbSet<assignment1.Models.ApplicationUser> ApplicationUser { get; set; }
    }
}
