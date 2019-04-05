using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Prueba.Net.Models
{
    public class Ciudad
    {
        [Key]
        public int id_ciudad { get; set; }

        [StringLength(20)]
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El campo Nombre es obligatorio")]
        public string nombre_ciudad { get; set; }

        [Display(Name = "Estado")]
        [Required(ErrorMessage = "El campo Estado es obligatorio")]
        public bool estado { get; set; }
    }
}