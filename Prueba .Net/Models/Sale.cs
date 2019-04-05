using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Prueba.Net.Models
{
    public class Venta
    {
        [Key]
        public int id_venta { get; set; }

        [StringLength(50)]
        [Display(Name = "Primer Nombre")]
        [Required(ErrorMessage = "El campo Primer Nombre es obligatorio")]
        public string primer_nombre { get; set; }

        [StringLength(20)]
        [Display(Name = "Segundo Nombre")]
        public string segundo_nombre { get; set; }

        [StringLength(20)]
        [Display(Name = "Primer Apellido")]
        [Required(ErrorMessage = "El campo Primer Apellido es obligatorio")]
        public string primer_apellido { get; set; }

        [StringLength(20)]
        [Display(Name = "Segundo Apellido")]
        public string segundo_apellido { get; set; }

        [StringLength(20)]
        [Display(Name = "Tipo Documento")]
        [Required(ErrorMessage = "El campo Tipo Documento es obligatorio")]
        [ForeignKey("idTipoDocument")]
        public int idTipoDocument { get; set; }

        [StringLength(20)]
        [Display(Name = "Numero Documento")]
        [Required(ErrorMessage = "El campo Numero Documento es obligatorio")]
        public int numero_documento { get; set; }

        [StringLength(100)]
        [Display(Name = "Correo Electronico")]
        [Required(ErrorMessage = "El campo Correo Electronico es obligatorio")]
        public string correo_electronico { get; set; }

        [StringLength(20)]
        [Display(Name = "Telefono")]
        [Required(ErrorMessage = "El campo Telefono es obligatorio")]
        public int telefono { get; set; }

        [StringLength(20)]
        [Display(Name = "Departamento")]
        [Required(ErrorMessage = "El campo Departamento es obligatorio")]
        [ForeignKey("idDepartamento")]
        public int idDepartamento { get; set; }

        [StringLength(20)]

        [Display(Name = "Ciudad")]
        [Required(ErrorMessage = "El campo Ciudad es obligatorio")]
        [ForeignKey("idCiudad")]
        public int idCiudad { get; set; }

        [StringLength(500)]
        [Display(Name = "Observacion")]
        public string obervacion { get; set; }

    }
}