using Prueba.Net.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Prueba.Net.Mapper
{
    public class SaleMapper : EntityTypeConfiguration<Sale>
    {
        public SaleMapper(string schema)
        {
            ToTable("venta", schema);

            HasKey(x => x.id_venta).Property(x => x.id_venta).IsRequired().HasColumnName("id_venta");

            Property(x => x.id_producto).HasColumnName("id_producto");

            Property(x => x.primer_nombre).IsRequired().HasMaxLength(20).HasColumnName("primer_nombre");

            Property(x => x.segundo_nombre).HasMaxLength(20).HasColumnName("segundo_nombre");

            Property(x => x.primer_apellido).IsRequired().HasMaxLength(20).HasColumnName("primer_apellido");

            Property(x => x.segundo_apellido).HasMaxLength(20).HasColumnName("segundo_apellido");

            Property(x => x.idTipoDocument).HasColumnName("tipo_document");

            Property(x => x.numero_documento).IsRequired().HasColumnName("numero_document");

            Property(x => x.correo_electronico).IsRequired().HasMaxLength(100).HasColumnName("correo_electronico");

            Property(x => x.telefono).IsRequired().HasColumnName("telefono");

            Property(x => x.idDepartamento).HasColumnName("nombre_departamento");

            Property(x => x.idCiudad).HasColumnName("nombre_ciudad");

            Property(x => x.obervacion).HasMaxLength(500).HasColumnName("observacion");

        }
    }
}