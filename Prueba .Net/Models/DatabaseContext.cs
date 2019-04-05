using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Prueba.Net.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("DefaultConnection")
        {

        }
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public DbSet<Company> compañia { get; set; }

        public DbSet<RolSeg> rol_seg { get; set; }

        public DbSet<ProductSeg> producto { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Configurations.Add(new Mapper.CompanyMapper("dbo"));
            modelBuilder.Configurations.Add(new Mapper.RolSegMapper("dbo"));
            modelBuilder.Configurations.Add(new Mapper.ProductSegMapper("dbo"));
            modelBuilder.Configurations.Add(new Mapper.TypeDocumentMapper("dbo"));
            modelBuilder.Configurations.Add(new Mapper.DepartamentMapper("dbo"));
            modelBuilder.Configurations.Add(new Mapper.CityMapper("dbo"));
            modelBuilder.Configurations.Add(new Mapper.SaleMapper("dbo"));
        }

        
    }
}