using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AFA_Clases
{
    class Division
    {
        public string nombre { get; set; }
        public List<Equipo> listaEquipos = new List<Equipo>();

        public Division()
        {

        }

        public Division (string nombreDivision)
        {
            this.nombre = nombreDivision;
        }
    }
}
