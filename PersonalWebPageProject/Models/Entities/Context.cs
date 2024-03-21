using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PersonalWebPageProject.Models.Entities
{
    public class Context : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Homepage> Homepages { get; set; }
        public DbSet<Icon> Icons { get; set; }
    }
}