using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Prueba.Net.Models
{
    public class Sale
    {
        public int id_venta { get; set; }

        public int id_producto { get; set; }
        public virtual ProductSeg product { get; set; }

        public string primer_nombre { get; set; }

        public string segundo_nombre { get; set; }

        public string primer_apellido { get; set; }

        public string segundo_apellido { get; set; }

        public int idTipoDocument { get; set; }
        public virtual TypeDocument typeDocument { get; set; }

        public int numero_documento { get; set; }

        public string correo_electronico { get; set; }

        public int telefono { get; set; }

        public int idDepartamento { get; set; }
        public virtual Departament departament { get; set; }

        public int idCiudad { get; set; }
        public virtual City city { get; set; }

        public string obervacion { get; set; }

    }
}