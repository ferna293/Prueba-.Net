using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Prueba.Net.Models
{
    public class TypeDocument
    {
        public int id_tipo_document { get; set; }

        public string nombre_document { get; set; }

        public bool estado { get; set; }
    }
}