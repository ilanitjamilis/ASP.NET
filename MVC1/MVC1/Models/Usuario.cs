using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace MVC1.Models
{
    public class Usuario
    {
        [Required(ErrorMessage ="Campo Obligatorio")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public string apellido { get; set;}

        public bool estudiante { get; set; }

        [EmailAddress(ErrorMessage = "Email inválido")]
        public string mail { get; set; }

        [StringLength(30, MinimumLength =6, ErrorMessage ="Usuario inválido, mínimo 6 caracteres.")]
        [Required(ErrorMessage = "Campo Obligatorio")]
        public string usuario { get; set; }

        [StringLength(30, MinimumLength = 6, ErrorMessage = "Contraseña inválida, mínimo 6 caracteres.")]
        [Required(ErrorMessage = "Campo Obligatorio")]
        public string contraseña { get; set; }

        [Compare("contraseña", ErrorMessage ="Las contraseñas no coinciden")]
        public string confirmarConstraseña { get; set; }

    }
}