using Prueba.Net.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Prueba.Net.Mapper
{
    public class CityMapper : EntityTypeConfiguration<City>
    {
        public CityMapper(string schema)
        {
            ToTable("ciudad", schema);

            HasKey(x => x.id_ciudad).Property(x => x.id_ciudad).IsRequired().HasColumnName("id_ciudad");

            Property(x => x.nombre_ciudad).IsRequired().HasMaxLength(20).HasColumnName("nombre_ciudad");

            Property(x => x.estado).HasColumnName("estado");
        }
    }
}