using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using Microsoft.Framework.Configuration;
using IAT.Web.Models.DAL.Entities;

namespace IAT.Web.Models.DAL
{
    public class IATDataContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<App>().ToTable("Apps");
            modelBuilder.Entity<AppException>().ToTable("Exceptions");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<App> Apps { get; set; }
        public DbSet<AppException> Exceptions { get; set; }
    }
}
