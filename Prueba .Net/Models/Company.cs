using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Prueba.Net.Models
{
    public class Company
    {
        public int id_compañia { get; set; }
       
        public string nombre_compañia { get; set; }
        
        public string descripcion { get; set; }

        public bool estado { get; set; }

    }
}