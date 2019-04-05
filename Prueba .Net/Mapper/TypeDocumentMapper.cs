using Prueba.Net.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Prueba.Net.Mapper
{
    public class TypeDocumentMapper : EntityTypeConfiguration<TypeDocument>
    {
        public TypeDocumentMapper(string schema)
        {
            ToTable("tipo_documnet", schema);

            HasKey(x => x.id_tipo_document).Property(x => x.id_tipo_document).IsRequired().HasColumnName("id_tipo_document");

            Property(x => x.nombre_document).IsRequired().HasMaxLength(20).HasColumnName("nombre_document");

            Property(x => x.estado).HasColumnName("estado");
        }
    }
}