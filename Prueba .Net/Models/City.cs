using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Prueba.Net.Models
{
    public class City
    {
        public int id_ciudad { get; set; }

        public string nombre_ciudad { get; set; }

        public bool estado { get; set; }
    }
}