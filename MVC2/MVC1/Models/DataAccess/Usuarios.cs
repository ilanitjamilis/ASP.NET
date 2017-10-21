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
            Data Source= G:\Ort\5 año\Programacion\Tercer Trimestre\MVC2\DB_Usuarios.accdb";

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


        public static bool VerificarUsuario(string usuario)
        {
            bool usuarioDisponible = true;

            try
            {
                ConectarDB();

                OleDbCommand Consulta = conn.CreateCommand();
                Consulta.CommandType = System.Data.CommandType.StoredProcedure;
                Consulta.CommandText = "VerificarUsuario";
                OleDbParameter usuarioPrueba = new OleDbParameter("usuario", usuario);

                Consulta.Parameters.Add(usuarioPrueba);

                OleDbDataReader dr = Consulta.ExecuteReader();
                while (dr.Read())
                {
                    usuarioDisponible = false;
                }

                conn.Close();
            }

            catch (Exception e)
            {
                return false;
            }

            return usuarioDisponible;
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
                    int id = Convert.ToInt32(dr["id"]);
                    string nombreUsuario = dr["nombre"].ToString();
                    string apellidoUsuario = dr["apellido"].ToString();
                    bool estudianteUsuario = (bool)dr["estudiante"];
                    string mailUsuario = dr["mail"].ToString();

                    Usuario.ID = id;
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


        public static Usuario ObtenerMiUsuario()
        {
            int miID = Usuario.ID;
            Usuario miUsuario = new Usuario();

            try
            {
                ConectarDB();

                OleDbCommand Consulta = conn.CreateCommand();
                Consulta.CommandType = System.Data.CommandType.StoredProcedure;
                Consulta.CommandText = "TraerMiUsuario";
                OleDbParameter idUsuario = new OleDbParameter("idUsuario", miID);

                Consulta.Parameters.Add(idUsuario);

                OleDbDataReader dr = Consulta.ExecuteReader();
                while (dr.Read())
                {
                    string nombreUsuario = dr["nombre"].ToString();
                    string apellidoUsuario = dr["apellido"].ToString();
                    bool estudianteUsuario = (bool)dr["estudiante"];
                    string mailUsuario = dr["mail"].ToString();

                    
                    miUsuario.nombre = nombreUsuario;
                    miUsuario.apellido = apellidoUsuario;
                    miUsuario.estudiante = estudianteUsuario;
                    miUsuario.mail = mailUsuario;
                }

                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Hubo un Error");
            }

            return miUsuario;

        }


        public static List<Novix> TraerNovixs(Usuario unUsuario)
        {
            int id = Usuario.ID;
            List<Novix> listaNovix = new List<Novix>();

            try
            {
                ConectarDB();

                OleDbCommand Consulta = conn.CreateCommand();
                Consulta.CommandType = System.Data.CommandType.StoredProcedure;
                Consulta.CommandText = "TraerNovix";
                OleDbParameter idUsuario = new OleDbParameter("idUsuario", id);

                Consulta.Parameters.Add(idUsuario);

                OleDbDataReader dr = Consulta.ExecuteReader();
                
                while (dr.Read())
                {
                    Novix unNovix = new Novix();

                    unNovix.nombre = dr["Nombre"].ToString();
                    unNovix.apellido = dr["Apellido"].ToString();
                    unNovix.rutaFoto = dr["RutaFoto"].ToString();

                    listaNovix.Add(unNovix);
                }

                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Hubo un Error");
            }

            return listaNovix;

        }

    }
}