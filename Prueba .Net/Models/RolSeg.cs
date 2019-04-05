using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Prueba.Net.Models
{
    public class RolSeg
    {
        [Key]
        public int id_rol { get; set; }

        [StringLength(50)]
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El campo Nombre es obligatorio")]
        public string nombre_rol { get; set; }

        [StringLength(200)]
        [Display(Name = "Descripcion")]
        public string descripcion { get; set; }

        [Display(Name = "Estado")]
        [Required(ErrorMessage = "El campo Estado es obligatorio")]
        public bool estado { get; set; }
    }
}