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

        [Display(Name = "Compañia")]
        [Required(ErrorMessage = "El campo Compañia es obligatorio")]
        public int id_compañia { get; set; }
        [ForeignKey("id_compañia")]
        public virtual Compañia compañia { get; set; }

        [Display(Name = "Rol Producto")]
        [Required(ErrorMessage = "El campo Rol Producto es obligatorio")]
        public int id_rol { get; set; }
        [ForeignKey("id_rol")]
        public virtual RolSeg rolSeg { get; set; }


    }
}