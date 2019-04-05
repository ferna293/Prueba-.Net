using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Prueba.Net.Models
{
    public class ProductSeg
    {
        
        public int id_producto { get; set; }

        
        public string nombre_producto { get; set; }

        
        public string descripcion { get; set; }

        
        public bool estado { get; set; }

        
        public int id_compañia { get; set; }
        
        public virtual Company compañia { get; set; }

        
        public int id_rol { get; set; }
        
        public virtual RolSeg rolSeg { get; set; }


    }
}