using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace AlumnosORT
{
    class Alumnos
    {
        public static string miRuta = @"D:\Ort\5to año\Programacion\Primer Trimestre\AlumnosORT/MiBaseDeDatos.txt";

        public static bool GuardarAlumnos(Alumno alumnoAGuardar)
        {
            try
            {
                StreamWriter miArchivo = new StreamWriter(miRuta, true);
                miArchivo.WriteLine(alumnoAGuardar.ToString());
                miArchivo.Close();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
 
        public static bool ModificarAlumno(Alumno alumnoAModificar, Alumno alumnoModificado)
        {
            string miListaAlumnos = "";
            try
            {
                StreamReader miArchivoLectura = new StreamReader(miRuta);
                string lineaAModificar = alumnoAModificar.ToString();

                while (! miArchivoLectura.EndOfStream)
                {
                    string linea = miArchivoLectura.ReadLine();

                    if(linea!=lineaAModificar)
                    {
                        miListaAlumnos += linea + Environment.NewLine;
                    }
                    else
                    {
                        miListaAlumnos += alumnoModificado.ToString() + Environment.NewLine;
                    }
                }
                miArchivoLectura.Close();

                StreamWriter miArchivoEscritura = new StreamWriter(miRuta, false);
                miArchivoEscritura.Write(miListaAlumnos);
                miArchivoEscritura.Close();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
 
        public static bool EliminarAlumno(Alumno alumnoAEliminar)
        {
            string miListaAlumnos = "";
            try
            {
                StreamReader miArchivoLectura = new StreamReader(miRuta);
                string lineaAEliminar = alumnoAEliminar.ToString();

                while (! miArchivoLectura.EndOfStream)
                {
                    string linea = miArchivoLectura.ReadLine();

                    if (linea != lineaAEliminar)
                    {
                        miListaAlumnos += linea + Environment.NewLine;
                    }

                }
                miArchivoLectura.Close();

                StreamWriter miArchivoEscritura = new StreamWriter(miRuta, false);
                miArchivoEscritura.Write(miListaAlumnos);
                miArchivoEscritura.Close();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
       
        
        public static List<Alumno> ObtenerAlumnos()
        {
            List<Alumno> listaAlumnos = new List<Alumno>();
            try
            {
                StreamReader miArchivoLectura = new StreamReader(miRuta);

                while (! miArchivoLectura.EndOfStream)
                {
                    string linea = miArchivoLectura.ReadLine();

                    string[] propiedadesAlumno = linea.Split('-');

                    string nombreApellido = propiedadesAlumno[0];

                    string[] nombreYApellido = nombreApellido.Split(' ');

                    string nombre = nombreYApellido[0];
                    string apellido = nombreYApellido[1];

                    if (propiedadesAlumno.Length == 3)
                    {
                        int año = Convert.ToInt32(propiedadesAlumno[1]);
                        string orientacion = propiedadesAlumno[2];

                        Alumno oAlumno = new Alumno(nombre, apellido, año, orientacion);
                        listaAlumnos.Add(oAlumno);
                    }
                }
                miArchivoLectura.Close();

            }
            catch (Exception e)
            {

            }
            return listaAlumnos;
        }
    }
}
