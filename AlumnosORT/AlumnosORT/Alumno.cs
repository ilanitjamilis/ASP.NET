using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlumnosORT
{
    class Alumno
    {

        string nombre;
        string apellido;
        int año;
        string orientacion;

        
        public Alumno(string nombreAlumno, string apellidoAlumno, int añoAlumno, string orientacionAlumno)
        {
            this.nombre=nombreAlumno;
            this.apellido=apellidoAlumno;
            this.año=añoAlumno;
            this.orientacion=orientacionAlumno;
        }

        
        public override string ToString()
        {
            if (año <= 6)
            {
                return string.Concat(nombre, " ", apellido, "-", año, "-", orientacion);
            }
            else
            {
                return string.Concat(nombre, " ", apellido, "-", orientacion);
            }
        }

        public string GetNombre()
        {
            return this.nombre;
        }

        public string GetApellido()
        {
            return this.apellido;
        }

        public void PasoAño()
        {
            this.año++;
        }

        public int GetAño()
        {
            return this.año;
        }

        public string GetOrientacion()
        {
            return this.orientacion;
        }

        public void CambioDeOrientacion(string orientacionParaCambio)
        {
            this.orientacion = orientacionParaCambio;
        }

    }
}
