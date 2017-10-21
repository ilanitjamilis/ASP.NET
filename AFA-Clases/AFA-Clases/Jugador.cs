using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AFA_Clases
{
    class Jugador
    {
        public string nombre { get; set; }
        public int numero { get; set; }
        public string posicion { get; set; }

        public Jugador(string nombreJugador)
        {
            this.nombre = nombreJugador;
        }

        public override string ToString()
        {
            return nombre;
        }
    }
}
