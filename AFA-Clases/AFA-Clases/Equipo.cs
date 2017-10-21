using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AFA_Clases
{
    class Equipo
    {
        public string nombre { get; set; }
        public List<Jugador> listaJugadores = new List<Jugador>();

        public Equipo (string nombreEquipo)
        {
            this.nombre = nombreEquipo;
        }
    }
}
