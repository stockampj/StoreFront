using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StoreFront.Models;

namespace StoreFront.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public virtual DbSet<Flavor> Flavors {get; set;}
        public virtual DbSet<Treat> Treats {get; set;}

        public DbSet<TreatFlavor> TreatFlavors {get; set;}

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }
}
