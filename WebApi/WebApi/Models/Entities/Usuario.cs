using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApi.Models.Entities
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(250)]
        public string Apellido { get; set; }

        [Required]
        [StringLength(250)]
        public string Telefono { get; set; }

        [Required]
        [StringLength(250)]
        public string Domicilio { get; set; }

        [Required]
        [StringLength(250)]
        public string Edad { get; set; }

    }
}