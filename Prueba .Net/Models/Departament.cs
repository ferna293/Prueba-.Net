using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Prueba.Net.Models
{
    public class Departament
    {
        
        public int id_departamento { get; set; }

        public string nombre_departamento { get; set; }

        public bool estado { get; set; }
    }
}