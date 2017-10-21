using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;

namespace MVC1.Models.DataAccess
{
    public class Usuarios
    {
        static string Proveedor = @"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=D:\Ort\5to año\Programacion\Segundo Trimestre\MVC1\DB_Usuarios.accdb";

        static OleDbConnection conn = new OleDbConnection();

        private static void ConectarDB()
        {
            conn.ConnectionString = Proveedor;
            conn.Open();
        }


        public static bool GuardarUsuario(Usuario usuarioAGuardar)
        {
            try
            {
                ConectarDB();

                OleDbCommand Consulta = conn.CreateCommand();
                Consulta.CommandType = System.Data.CommandType.StoredProcedure;
                Consulta.CommandText = "GuardarUsuario";
                
                if(usuarioAGuardar.mail==null)
                {
                    usuarioAGuardar.mail = "";
                }

                OleDbParameter nombreUsuario = new OleDbParameter("nombre", usuarioAGuardar.nombre);
                OleDbParameter apellidoUsuairo = new OleDbParameter("apellido", usuarioAGuardar.apellido);
                OleDbParameter estudianteUsuario = new OleDbParameter("estudiante", usuarioAGuardar.estudiante);
                OleDbParameter mailUsuario = new OleDbParameter("mail", usuarioAGuardar.mail);
                OleDbParameter usuarioUsuario = new OleDbParameter("usuario", usuarioAGuardar.usuario);
                OleDbParameter contraseñaUsuario = new OleDbParameter("contraseña", usuarioAGuardar.contraseña);
                

                Consulta.Parameters.Add(nombreUsuario);
                Consulta.Parameters.Add(apellidoUsuairo);
                Consulta.Parameters.Add(estudianteUsuario);
                Consulta.Parameters.Add(mailUsuario);
                Consulta.Parameters.Add(usuarioUsuario);
                Consulta.Parameters.Add(contraseñaUsuario);


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

        public static Usuario ObtenerUsuario(Usuario unUsuario)
        {
            string usuarioUsuario = unUsuario.usuario;
            string contraseñaUsuario = unUsuario.contraseña;

            try
            {
                ConectarDB();

                OleDbCommand Consulta = conn.CreateCommand();
                Consulta.CommandType = System.Data.CommandType.StoredProcedure;
                Consulta.CommandText = "TraerUsuario";
                OleDbParameter usuario = new OleDbParameter("usuario", usuarioUsuario);
                OleDbParameter contraseña = new OleDbParameter("contraseña", contraseñaUsuario);

                Consulta.Parameters.Add(usuario);
                Consulta.Parameters.Add(contraseña);

                OleDbDataReader dr = Consulta.ExecuteReader();
                while (dr.Read())
                {
                    string nombreUsuario = dr["nombre"].ToString();
                    string apellidoUsuario = dr["apellido"].ToString();
                    bool estudianteUsuario = (bool)dr["estudiante"];
                    string mailUsuario = dr["mail"].ToString();

                    unUsuario.nombre = nombreUsuario;
                    unUsuario.apellido = apellidoUsuario;
                    unUsuario.estudiante = estudianteUsuario;
                    unUsuario.mail = mailUsuario;
                }

                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Hubo un Error");
            }

            return unUsuario;

        }

    }
}