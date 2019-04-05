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

        public DbSet<Company> Company { get; set; }
        public DbSet<RolSeg> RolSeg { get; set; }
        public DbSet<ProductSeg> Product { get; set; }
        public DbSet<TypeDocument> TypeDocument { get; set; }
        public DbSet<Departament> Departament { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Sale> Sale { get; set; }
        

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