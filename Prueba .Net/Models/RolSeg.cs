using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Prueba.Net.Models
{
    public class RolSeg
    {        
        public int id_rol { get; set; }
        
        public string nombre_rol { get; set; }
       
        public string descripcion { get; set; }
       
        public bool estado { get; set; }
    }
}