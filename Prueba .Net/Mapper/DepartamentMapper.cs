using Prueba.Net.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Prueba.Net.Mapper
{
    public class DepartamentMapper : EntityTypeConfiguration<Departament>
    {
        public DepartamentMapper(string schema)
        {
            ToTable("departamento", schema);

            HasKey(x => x.id_departamento).Property(x => x.id_departamento).IsRequired().HasColumnName("id_departamento");

            Property(x => x.nombre_departamento).IsRequired().HasMaxLength(20).HasColumnName("nombre_departamento");

            Property(x => x.estado).HasColumnName("estado");
        }
    }
}