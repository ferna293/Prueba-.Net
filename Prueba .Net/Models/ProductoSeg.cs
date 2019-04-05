using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Prueba.Net.Models
{
    public class ProductoSeg
    {
        [Key]
        public int id_producto { get; set; }

        [StringLength(50)]
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El campo Nombre es obligatorio")]
        public string nombre_producto { get; set; }

        [StringLength(200)]
        [Display(Name = "Descripcion")]
        public string descripcion { get; set; }

        [Display(Name = "Estado")]
        [Required(ErrorMessage = "El campo Estado es obligatorio")]
        public bool estado { get; set; }

        [StringLength(20)]
        [Display(Name = "Compañia")]
        [Required(ErrorMessage = "El campo Compañia es obligatorio")]
        [ForeignKey("idCompañia")]
        public int idCompañia { get; set; }

        [StringLength(50)]
        [Display(Name = "Rol Producto")]
        [Required(ErrorMessage = "El campo Rol Producto es obligatorio")]
        [ForeignKey("idRol")]
        public int idRol { get; set; }
        

    }
}