using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.OleDb;

namespace WindowsFormsApplication4
{
    public class Personas
    {

        static string Proveedor = @"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=D:\Ort\5to año\Programacion\Segundo Trimestre\Ejemplo Simple Clases\WindowsFormsApplication4\DB.accdb";

        static OleDbConnection conn = new OleDbConnection();

        private static void ConectarDB()
        {
            conn.ConnectionString = Proveedor;
            conn.Open();
        }


        public static bool GuardarPersona(Persona personaAGuardar)
        {
            try
            {
                ConectarDB();

                OleDbCommand Consulta = conn.CreateCommand();
                Consulta.CommandType = System.Data.CommandType.StoredProcedure;
                Consulta.CommandText = "GuardarPersona";
                OleDbParameter nombrePersona = new OleDbParameter("Nombre", personaAGuardar.GetNombre());
                OleDbParameter apellidoPersona= new OleDbParameter("Apellido", personaAGuardar.GetApellido());
                OleDbParameter edadPersona= new OleDbParameter("Edad", personaAGuardar.GetEdad());
                OleDbParameter sexoPersona= new OleDbParameter("Sexo", personaAGuardar.GetSexo());
                Consulta.Parameters.Add(nombrePersona);
                Consulta.Parameters.Add(apellidoPersona);
                Consulta.Parameters.Add(edadPersona);
                Consulta.Parameters.Add(sexoPersona);

                int resultado = (int)Consulta.ExecuteNonQuery();
                bool funciono = false;
                if (resultado == 1)
                {
                    funciono = true;
                }

                conn.Close();

                return funciono;
            }

            catch (Exception e)
            {
                return false;
            }
        }


        public static bool ModificarPersona(Persona personaSinModificar, Persona personaModificada)
        {
            try
            {
                ConectarDB();

                OleDbCommand Consulta = conn.CreateCommand();
                Consulta.CommandType = System.Data.CommandType.StoredProcedure;
                Consulta.CommandText = "ModificarPersona";
                OleDbParameter nombreAnterior = new OleDbParameter("NombreAnterior", personaSinModificar.GetNombre());
                OleDbParameter apellidoAnterior = new OleDbParameter("ApellidoAnterior", personaSinModificar.GetApellido());
                OleDbParameter nombreNuevo = new OleDbParameter("Nombre", personaModificada.GetNombre());
                OleDbParameter apellidoNuevo = new OleDbParameter("Apellido", personaModificada.GetApellido());
                OleDbParameter edadNuevo = new OleDbParameter("Edad", personaModificada.GetEdad());
                OleDbParameter sexoNuevo = new OleDbParameter("Sexo", personaModificada.GetSexo());
                Consulta.Parameters.Add(nombreNuevo);
                Consulta.Parameters.Add(apellidoNuevo);
                Consulta.Parameters.Add(edadNuevo);
                Consulta.Parameters.Add(sexoNuevo);
                Consulta.Parameters.Add(nombreAnterior);
                Consulta.Parameters.Add(apellidoAnterior);

                int resultado = (int)Consulta.ExecuteNonQuery();
                bool funciono = false;
                if (resultado == 1)
                {
                    funciono = true;
                }

                conn.Close();

                return funciono;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool EliminarPersona(Persona personaAEliminar)
        {
            try
            {
                ConectarDB();

                OleDbCommand Consulta = conn.CreateCommand();
                Consulta.CommandType = System.Data.CommandType.StoredProcedure;
                Consulta.CommandText = "EliminarPersona";
                OleDbParameter nombrePersona = new OleDbParameter("Nombre", personaAEliminar.GetNombre());
                OleDbParameter apellidoPersona = new OleDbParameter("Apellido", personaAEliminar.GetApellido());
                Consulta.Parameters.Add(nombrePersona);
                Consulta.Parameters.Add(apellidoPersona);

                int resultado = (int)Consulta.ExecuteNonQuery();
                bool funciono = false;
                if (resultado == 1)
                {
                    funciono = true;
                }

                conn.Close();

                return funciono;
            }

            catch (Exception e)
            {
                Console.WriteLine("Hubo un Error " + e.ToString());
                return false;
            }
        }

        private static List<Persona> listaPersonas;

        public static List<Persona> ObtenerPersonas()
        {
            listaPersonas = new List<Persona>();
            try
            {
                ConectarDB();

                OleDbCommand Consulta = conn.CreateCommand();
                Consulta.CommandType = System.Data.CommandType.StoredProcedure;
                Consulta.CommandText = "TraerPersonas";

                OleDbDataReader drPersonas = Consulta.ExecuteReader();
                while (drPersonas.Read())
                {
                    string nombre = drPersonas["Nombre"].ToString();
                    string apellido = drPersonas["Apellido"].ToString();
                    int edad = Convert.ToInt32(drPersonas["Edad"].ToString());
                    string sexo = drPersonas["Sexo"].ToString();

                    Persona oPersona = new Persona(nombre, apellido, edad, sexo);
                    listaPersonas.Add(oPersona);
                }

                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Hubo un Error");
                
            }
            return listaPersonas;
            
        }
    }
}
