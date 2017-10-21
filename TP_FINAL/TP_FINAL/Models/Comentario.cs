using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.OleDb;

namespace TP_FINAL.Models
{
    public class Comentario
    {
        public static int idSucursalStatic { get; set; }


        public int idComentario { get; set; }

        public int idSucursal { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public string nombreComenta { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public int calificacion { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public string textoComentario{ get; set; }

        public bool aprobado { get; set; }

        static string Proveedor = @"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source= |DataDirectory|DB.accdb";

        static OleDbConnection conn = new OleDbConnection();

        private static void ConectarDB()
        {
            conn.ConnectionString = Proveedor;
            conn.Open();
        }

        public static bool InsertarComentario(Comentario unComentario)
        {
            try
            {
                ConectarDB();

                OleDbCommand Consulta = conn.CreateCommand();
                Consulta.CommandType = System.Data.CommandType.StoredProcedure;
                Consulta.CommandText = "InsertarComentario";
                OleDbParameter pidSucursal = new OleDbParameter("pSucursal", Comentario.idSucursalStatic);
                OleDbParameter pnombre = new OleDbParameter("pnombre", unComentario.nombreComenta);
                OleDbParameter pcalificacion = new OleDbParameter("pcalificacion", unComentario.calificacion);
                OleDbParameter ptexto = new OleDbParameter("ptexto", unComentario.textoComentario);
                OleDbParameter paprobado = new OleDbParameter("paprobado", unComentario.aprobado);

                Consulta.Parameters.Add(pidSucursal);
                Consulta.Parameters.Add(pnombre);
                Consulta.Parameters.Add(pcalificacion);
                Consulta.Parameters.Add(ptexto);
                Consulta.Parameters.Add(paprobado);

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



        public static List<Comentario> TraerComentariosNoAprobados()
        {
            List<Comentario> miListaComentarios = new List<Comentario>();
            try
            {
                ConectarDB();

                OleDbCommand Consulta = conn.CreateCommand();
                Consulta.CommandType = System.Data.CommandType.StoredProcedure;
                Consulta.CommandText = "TraerComentariosNoAprobados";

                OleDbDataReader dr = Consulta.ExecuteReader();
                while (dr.Read())
                {
                    int idp = Convert.ToInt32(dr["IdComentario"]);
                    string nombrep = dr["NombreComenta"].ToString();
                    int calificacionp = Convert.ToInt32(dr["Calificacion"]);
                    string textop = dr["TextoComentario"].ToString();

                    Comentario unComentario = new Comentario();
                    unComentario.idComentario = idp;
                    unComentario.nombreComenta = nombrep;
                    unComentario.calificacion = calificacionp;
                    unComentario.textoComentario = textop;

                    miListaComentarios.Add(unComentario);
                }

                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return miListaComentarios;
        }

        public static bool EliminarComentario(int id)
        {
            try
            {
                ConectarDB();

                OleDbCommand Consulta = conn.CreateCommand();
                Consulta.CommandType = System.Data.CommandType.StoredProcedure;
                Consulta.CommandText = "EliminarComentario";
                OleDbParameter pid = new OleDbParameter("pIdComentario", id);

                Consulta.Parameters.Add(pid);

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
                Console.WriteLine(e.Message);
                return false;
            }

        }

        public static bool AprobarComentario(int id)
        {
            try
            {
                ConectarDB();

                OleDbCommand Consulta = conn.CreateCommand();
                Consulta.CommandType = System.Data.CommandType.StoredProcedure;
                Consulta.CommandText = "AprobarComentario";
                OleDbParameter pid = new OleDbParameter("pIdComentario", id);

                Consulta.Parameters.Add(pid);

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

        public static List<Comentario> Traer3Comentarios(int id)
        {
            List<Comentario> miListaComentarios = new List<Comentario>();
            try
            {
                ConectarDB();

                OleDbCommand Consulta = conn.CreateCommand();
                Consulta.CommandType = System.Data.CommandType.StoredProcedure;
                Consulta.CommandText = "Top3ComentarioSucursal";
                OleDbParameter miId = new OleDbParameter("idSucursalP", id);
                Consulta.Parameters.Add(miId);

                OleDbDataReader dr = Consulta.ExecuteReader();
                while (dr.Read())
                {
                    string nombre = dr["NombreComenta"].ToString();
                    int calificacion = Convert.ToInt32(dr["Calificacion"]);
                    string texto = dr["TextoComentario"].ToString();

                    Comentario unComentario = new Comentario();
                    unComentario.nombreComenta = nombre;
                    unComentario.calificacion = calificacion;
                    unComentario.textoComentario = texto;

                    miListaComentarios.Add(unComentario);
                }

                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return miListaComentarios;
        }

        public static List<Comentario> Traer5Comentarios()
        {
            List<Comentario> miListaComentarios = new List<Comentario>();
            try
            {
                ConectarDB();

                OleDbCommand Consulta = conn.CreateCommand();
                Consulta.CommandType = System.Data.CommandType.StoredProcedure;
                Consulta.CommandText = "Top5Comentarios";

                OleDbDataReader dr = Consulta.ExecuteReader();
                while (dr.Read())
                {
                    string nombre = dr["NombreComenta"].ToString();
                    int calificacion = Convert.ToInt32(dr["Calificacion"]);
                    string texto = dr["TextoComentario"].ToString();

                    Comentario unComentario = new Comentario();
                    unComentario.nombreComenta = nombre;
                    unComentario.calificacion = calificacion;
                    unComentario.textoComentario = texto;

                    miListaComentarios.Add(unComentario);
                }

                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return miListaComentarios;
        }
    }
}