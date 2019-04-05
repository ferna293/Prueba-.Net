using Prueba.Net.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Prueba.Net.Mapper
{
    public class ProductSegMapper : EntityTypeConfiguration<ProductSeg>
    {
        public ProductSegMapper(string schema)
        {
            ToTable("producto", schema);

            HasKey(x => x.id_producto).Property(x => x.id_producto).IsRequired().HasColumnName("id_producto");

            Property(x => x.nombre_producto).IsRequired().HasMaxLength(50).HasColumnName("nombre_producto");

            Property(x => x.descripcion).HasMaxLength(200).HasColumnName("descripcion");

            Property(x => x.estado).HasColumnName("estado");

            Property(x => x.id_compañia).HasColumnName("nombre_compañia");

            Property(x => x.id_producto).HasColumnName("nombre_producto");
        }
    }
}