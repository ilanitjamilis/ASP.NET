using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC1.Models
{
    public class Novix
    {
        [Required(ErrorMessage = "Campo Obligatorio")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public string apellido { get; set; }

        public string rutaFoto { get; set; }
    }
}