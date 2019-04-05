using Prueba.Net.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Prueba.Net.Mapper
{
    internal class CompanyMapper : EntityTypeConfiguration<Company>
    {

        public CompanyMapper(string schema) 
        {
            ToTable("compañia", schema);

            HasKey(x => x.id_compañia).Property(x => x.id_compañia).IsRequired().HasColumnName("id_compañia"); 

            Property(x => x.nombre_compañia).IsRequired().HasMaxLength(20).HasColumnName("nombre_compañia");

            Property(x => x.descripcion).HasMaxLength(200).HasColumnName("descripcion");

            Property(x => x.estado).HasColumnName("estado");
                
        }

            
    }
    
}