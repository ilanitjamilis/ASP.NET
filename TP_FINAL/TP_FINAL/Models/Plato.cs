using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.OleDb;

namespace TP_FINAL.Models
{
    public class Plato
    {
        public static int idStatic { get; set; }


        public int ID { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public string rutaFoto { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public int idTipoComida { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public int precio { get; set; }

        public string tipoPlatoString { get; set; }

        static string Proveedor = @"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source= |DataDirectory|DB.accdb";

        static OleDbConnection conn = new OleDbConnection();

        private static void ConectarDB()
        {
            conn.ConnectionString = Proveedor;
            conn.Open();
        }

        public static bool GuardarNuevaComida(Plato unPlato)
        {
            try
            {
                ConectarDB();

                OleDbCommand Consulta = conn.CreateCommand();
                Consulta.CommandType = System.Data.CommandType.StoredProcedure;
                Consulta.CommandText = "InsertarPlato";
                OleDbParameter pnombre = new OleDbParameter("pnombre", unPlato.nombre);
                OleDbParameter prutaFoto = new OleDbParameter("prutaImagen", unPlato.rutaFoto);
                OleDbParameter pidTipoComida = new OleDbParameter("pidTipoComida", unPlato.idTipoComida);
                OleDbParameter pprecio = new OleDbParameter("pprecio", unPlato.precio);

                Consulta.Parameters.Add(pnombre);
                Consulta.Parameters.Add(prutaFoto);
                Consulta.Parameters.Add(pidTipoComida);
                Consulta.Parameters.Add(pprecio);

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

        public static bool ActualizarPlato(Plato unPlato)
        {
            try
            {
                ConectarDB();

                OleDbCommand Consulta = conn.CreateCommand();
                Consulta.CommandType = System.Data.CommandType.StoredProcedure;
                Consulta.CommandText = "ActualizarPlato";
                OleDbParameter pnombre = new OleDbParameter("pnombre", unPlato.nombre);
                OleDbParameter prutaFoto = new OleDbParameter("prutaImagen", unPlato.rutaFoto);
                OleDbParameter pidTipoComida = new OleDbParameter("pidTipoComida", unPlato.idTipoComida);
                OleDbParameter pprecio = new OleDbParameter("pprecio", unPlato.precio);
                OleDbParameter pid = new OleDbParameter("pidPlato", idStatic);

                Consulta.Parameters.Add(pnombre);
                Consulta.Parameters.Add(prutaFoto);
                Consulta.Parameters.Add(pidTipoComida);
                Consulta.Parameters.Add(pprecio);
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

        public static bool ActualizarPlatoNoFoto(Plato unPlato)
        {
            try
            {
                ConectarDB();

                OleDbCommand Consulta = conn.CreateCommand();
                Consulta.CommandType = System.Data.CommandType.StoredProcedure;
                Consulta.CommandText = "ActualizarPlatoNoFoto";
                OleDbParameter pnombree = new OleDbParameter("pnombre", unPlato.nombre);
                OleDbParameter pidTipoComidaa = new OleDbParameter("pidTipoComida", unPlato.idTipoComida);
                OleDbParameter pprecioo = new OleDbParameter("pprecio", unPlato.precio);
                OleDbParameter pidd = new OleDbParameter("pidPlato", idStatic);

                Consulta.Parameters.Add(pnombree);
                Consulta.Parameters.Add(pidTipoComidaa);
                Consulta.Parameters.Add(pprecioo);
                Consulta.Parameters.Add(pidd);

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

        public static List<Plato> TraerPlatos()
        {
            List<Plato> milistaplatos = new List<Plato>();
            try
            {
                ConectarDB();

                OleDbCommand Consulta = conn.CreateCommand();
                Consulta.CommandType = System.Data.CommandType.StoredProcedure;
                Consulta.CommandText = "TraerPlatos";

                OleDbDataReader dr = Consulta.ExecuteReader();
                while (dr.Read())
                {
                    int id = Convert.ToInt32(dr["idMenu"]);
                    string nombre = dr["Nombre"].ToString();

                    Plato unPlato = new Plato();
                    unPlato.ID = id;
                    unPlato.nombre = nombre;

                    milistaplatos.Add(unPlato);
                }

                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return milistaplatos;
        }

        public static List<Plato> TraerPlatosParaVista()
        {
            List<Plato> milistaplatos = new List<Plato>();
            try
            {
                ConectarDB();

                OleDbCommand Consulta = conn.CreateCommand();
                Consulta.CommandType = System.Data.CommandType.StoredProcedure;
                Consulta.CommandText = "TraerPlatosParaVista";

                OleDbDataReader dr = Consulta.ExecuteReader();
                while (dr.Read())
                {
                    string nombre = dr["Nombre"].ToString();
                    string imagen = dr["Imagen"].ToString();
                    int precio = Convert.ToInt32(dr["Precio"]);

                    Plato unPlato = new Plato();
                    unPlato.nombre = nombre;
                    unPlato.rutaFoto = imagen;
                    unPlato.precio = precio;

                    milistaplatos.Add(unPlato);
                }

                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return milistaplatos;
        }

        public static bool EliminarPlato(int id)
        {
            try
            {
                ConectarDB();

                OleDbCommand Consulta = conn.CreateCommand();
                Consulta.CommandType = System.Data.CommandType.StoredProcedure;
                Consulta.CommandText = "EliminarPlato";
                OleDbParameter pid = new OleDbParameter("pIdMenu", id);

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

        public static Plato TraerPlato(int platoID)
        {
            Plato unPlato = new Plato();

            try
            {
                ConectarDB();

                OleDbCommand Consulta = conn.CreateCommand();
                Consulta.CommandType = System.Data.CommandType.StoredProcedure;
                Consulta.CommandText = "TraerPlato";

                OleDbParameter platoIDd = new OleDbParameter("pidPlato", platoID);

                Consulta.Parameters.Add(platoIDd);

                OleDbDataReader dr = Consulta.ExecuteReader();
                while (dr.Read())
                {
                    int id = Convert.ToInt32(dr["idMenu"]);
                    string nombre = dr["nomMenu"].ToString();
                    string rutaFotoa = dr["Imagen"].ToString();
                    int precioo = Convert.ToInt32(dr["Precio"]);
                    int idTipoComidaa = Convert.ToInt32(dr["idTipoComida"]);
                    string stringTipoComida = dr["nomTipo"].ToString();


                    unPlato.ID = id;
                    unPlato.nombre = nombre;
                    unPlato.rutaFoto = rutaFotoa;
                    unPlato.idTipoComida = idTipoComidaa;
                    unPlato.precio = precioo;
                    unPlato.tipoPlatoString = stringTipoComida;

                }

                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return unPlato;
        }

        public static Plato TraerPlato2(string nomPlato)
        {
            Plato unPlato = new Plato();

            try
            {
                ConectarDB();

                OleDbCommand Consulta = conn.CreateCommand();
                Consulta.CommandType = System.Data.CommandType.StoredProcedure;
                Consulta.CommandText = "TraerPlato2";

                OleDbParameter pnomPlato = new OleDbParameter("Nombre", nomPlato);

                Consulta.Parameters.Add(pnomPlato);

                OleDbDataReader dr = Consulta.ExecuteReader();
                while (dr.Read())
                {
                    int id = Convert.ToInt32(dr["idMenu"]);
                    string nombre = dr["nomMenu"].ToString();
                    string rutaFotoa = dr["Imagen"].ToString();
                    int precioo = Convert.ToInt32(dr["Precio"]);
                    int idTipoComidaa = Convert.ToInt32(dr["idTipoComida"]);
                    string stringTipoComida = dr["nomTipo"].ToString();


                    unPlato.ID = id;
                    unPlato.nombre = nombre;
                    unPlato.rutaFoto = rutaFotoa;
                    unPlato.idTipoComida = idTipoComidaa;
                    unPlato.precio = precioo;
                    unPlato.tipoPlatoString = stringTipoComida;

                }

                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return unPlato;
        }

    }
}