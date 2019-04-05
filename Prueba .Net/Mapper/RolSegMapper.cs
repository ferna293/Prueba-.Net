using Prueba.Net.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Prueba.Net.Mapper
{
    public class RolSegMapper : EntityTypeConfiguration<RolSeg>
    {
        public RolSegMapper(string schema)
        {
            ToTable("rol_seg", schema);

            HasKey(x => x.id_rol).Property(x => x.id_rol).IsRequired().HasColumnName("id_compañia");

            Property(x => x.nombre_rol).IsRequired().HasMaxLength(50).HasColumnName("nombre_compañia");

            Property(x => x.descripcion).HasMaxLength(200).HasColumnName("descripcion");

            Property(x => x.estado).HasColumnName("estado");
        }
        
    }
}