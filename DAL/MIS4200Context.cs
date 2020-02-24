using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using KontraMIS4200.Models;

namespace KontraMIS4200.DAL
{
    public class MIS4200Context : DbContext 
    {
        public MIS4200Context() : base("name=DefaultConnection")
        {

        }
        public DbSet<customer> Customers { get; set; }
        public DbSet<orders> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<orderDetail> orderDetail { get; set; }
      //  public DbSet<Vet> Vets { get; set; }
      //  public DbSet<Pet> Pets { get; set; }

        public System.Data.Entity.DbSet<KontraMIS4200.Models.Vet> Vets { get; set; }

        public System.Data.Entity.DbSet<KontraMIS4200.Models.Pet> Pets { get; set; }

        public System.Data.Entity.DbSet<KontraMIS4200.Models.appointmentDetail> appointmentDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}