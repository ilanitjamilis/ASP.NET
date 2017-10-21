using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.OleDb;

namespace TP_FINAL.Models
{
    public class Usuario
    {
        public static int ID { get; set; }

        [StringLength(30, MinimumLength = 4, ErrorMessage = "Deben ser entre 4 y 30 caracteres")]
        [Required(ErrorMessage = "Campo Obligatorio")]
        public string usuario { get; set; }


        [StringLength(30, MinimumLength = 4, ErrorMessage = "Deben ser entre 4 y 30 caracteres")]
        [Required(ErrorMessage = "Campo Obligatorio")]
        public string contraseña { get; set; }

        public string mail { get; set; }

        public DateTime ultimoLogin { get; set; }



        static string Proveedor = @"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source= |DataDirectory|DB.accdb";

        static OleDbConnection conn = new OleDbConnection();

        private static void ConectarDB()
        {
            conn.ConnectionString = Proveedor;
            conn.Open();
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
                    int id = Convert.ToInt32(dr["idUsuarios"]);
                    string nombre = dr["Usuario"].ToString();
                    string email = dr["Email"].ToString();
                    string contraseñaA = dr["Contraseña"].ToString();
                    

                    Usuario.ID = id;
                    unUsuario.usuario = nombre;
                    unUsuario.contraseña = contraseñaA;
                    unUsuario.mail = email;
                    unUsuario.ultimoLogin = DateTime.Now;
                }

                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return unUsuario;

        }

        public static void ActualizarLogin()
        {
    //        DateTime ahora = DateTime.Now;

            try
            {
                ConectarDB();

                OleDbCommand Consulta = conn.CreateCommand();
                Consulta.CommandType = System.Data.CommandType.StoredProcedure;
                Consulta.CommandText = "ActualizarUltimoLogin";
                OleDbParameter idUsuario = new OleDbParameter("pidUsuario", Usuario.ID);
      //          OleDbParameter fecha = new OleDbParameter("pahora", ahora);

                //Consulta.Parameters.Add(fecha);
                Consulta.Parameters.Add(idUsuario);

                Consulta.ExecuteNonQuery();
                
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}