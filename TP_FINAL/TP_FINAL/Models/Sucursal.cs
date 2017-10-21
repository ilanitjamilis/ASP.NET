using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.OleDb;

namespace TP_FINAL.Models
{
    public class Sucursal
    {
        public static int idStatic { get; set; }


        public int ID { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public string mapa { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public string rutaFoto { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public int idProvincia { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public string domicilio { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public string telefono { get; set; }

        public string provincia { get; set; }

        public string pais { get; set; }




        static string Proveedor = @"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source= |DataDirectory|DB.accdb";

        static OleDbConnection conn = new OleDbConnection();

        private static void ConectarDB()
        {
            conn.ConnectionString = Proveedor;
            conn.Open();
        }

        public static List<Sucursal> TraerSucursales()
        {
            List<Sucursal> miListaSucursales = new List<Sucursal>();
            try
            {
                ConectarDB();

                OleDbCommand Consulta = conn.CreateCommand();
                Consulta.CommandType = System.Data.CommandType.StoredProcedure;
                Consulta.CommandText = "TraerSucursales";

                OleDbDataReader dr = Consulta.ExecuteReader();
                while (dr.Read())
                {
                    int idp = Convert.ToInt32(dr["IdSucursal"]);
                    string nombrep = dr["Nombre"].ToString();
                    string imagenp = dr["Imagen"].ToString();

                    Sucursal unaSucursal = new Sucursal();
                    unaSucursal.ID = idp;
                    unaSucursal.nombre = nombrep;
                    unaSucursal.rutaFoto = imagenp;

                    miListaSucursales.Add(unaSucursal);
                }

                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return miListaSucursales;
        }


        public static Sucursal TraerSucursal(int sucursalID)
        {
            Sucursal unaSucursal = new Sucursal();

            try
            {
                ConectarDB();

                OleDbCommand Consulta = conn.CreateCommand();
                Consulta.CommandType = System.Data.CommandType.StoredProcedure;
                Consulta.CommandText = "TraerSucursal";

                OleDbParameter sucursalIDp = new OleDbParameter("pidSucursal", sucursalID);

                Consulta.Parameters.Add(sucursalIDp);

                OleDbDataReader dr = Consulta.ExecuteReader();
                while (dr.Read())
                {
                    int id = Convert.ToInt32(dr["idSucursal"]);
                    string nombre = dr["sucNombre"].ToString();
                    string mapa = dr["Mapa"].ToString();
                    string imagen = dr["Imagen"].ToString();
                    string domicilio = dr["Domicilio"].ToString();
                    string telefono = dr["Telefono"].ToString();
                    string provinciaNombre = dr["provNombre"].ToString();
                    string pais = dr["Pais"].ToString();

                    unaSucursal.ID = id;
                    unaSucursal.nombre = nombre;
                    unaSucursal.mapa = mapa;
                    unaSucursal.rutaFoto = imagen;
                    unaSucursal.domicilio = domicilio;
                    unaSucursal.telefono = telefono;
                    unaSucursal.provincia = provinciaNombre;
                    unaSucursal.pais = pais;
                }

                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return unaSucursal;
        }

        public static Sucursal TraerSucursal2(string nomSucursal)
        {
            Sucursal unaSucursal = new Sucursal();

            try
            {
                ConectarDB();

                OleDbCommand Consulta = conn.CreateCommand();
                Consulta.CommandType = System.Data.CommandType.StoredProcedure;
                Consulta.CommandText = "TraerSucursal2";

                OleDbParameter pnomSucursal = new OleDbParameter("Nombre", nomSucursal);

                Consulta.Parameters.Add(pnomSucursal);

                OleDbDataReader dr = Consulta.ExecuteReader();
                while (dr.Read())
                {
                    int id = Convert.ToInt32(dr["idSucursal"]);
                    string nombre = dr["sucNombre"].ToString();
                    string mapa = dr["Mapa"].ToString();
                    string imagen = dr["Imagen"].ToString();
                    string domicilio = dr["Domicilio"].ToString();
                    string telefono = dr["Telefono"].ToString();
                    string provinciaNombre = dr["provNombre"].ToString();
                    string pais = dr["Pais"].ToString();

                    unaSucursal.ID = id;
                    unaSucursal.nombre = nombre;
                    unaSucursal.mapa = mapa;
                    unaSucursal.rutaFoto = imagen;
                    unaSucursal.domicilio = domicilio;
                    unaSucursal.telefono = telefono;
                    unaSucursal.provincia = provinciaNombre;
                    unaSucursal.pais = pais;

                }

                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return unaSucursal;
        }

        public static bool EliminarSucursal(int id)
        {
            try
            {
                ConectarDB();

                OleDbCommand Consulta = conn.CreateCommand();
                Consulta.CommandType = System.Data.CommandType.StoredProcedure;
                Consulta.CommandText = "EliminarSucursal";
                OleDbParameter pid = new OleDbParameter("pidSucursal", id);

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

        public static bool EliminarComentariosSucursal(int id)
        {
            try
            {
                ConectarDB();

                OleDbCommand Consulta = conn.CreateCommand();
                Consulta.CommandType = System.Data.CommandType.StoredProcedure;
                Consulta.CommandText = "EliminarComentariosSucursal";
                OleDbParameter pid = new OleDbParameter("pidSucursal", id);

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

        public static bool GuardarNuevaSucursal(Sucursal unaSucursal)
        {
            try
            {
                ConectarDB();

                OleDbCommand Consulta = conn.CreateCommand();
                Consulta.CommandType = System.Data.CommandType.StoredProcedure;
                Consulta.CommandText = "InsertarSucursal";
                OleDbParameter pnombre = new OleDbParameter("pnombre", unaSucursal.nombre);
                OleDbParameter pmapa = new OleDbParameter("pmapa", unaSucursal.mapa);
                OleDbParameter pimagen = new OleDbParameter("prutaImagen", unaSucursal.rutaFoto);
                OleDbParameter pidprovincia = new OleDbParameter("pidProvincia", unaSucursal.idProvincia);
                OleDbParameter pdomicilio = new OleDbParameter("pdomicilio", unaSucursal.domicilio);
                OleDbParameter ptelefono = new OleDbParameter("ptelefono", unaSucursal.telefono);

                Consulta.Parameters.Add(pnombre);
                Consulta.Parameters.Add(pmapa);
                Consulta.Parameters.Add(pimagen);
                Consulta.Parameters.Add(pidprovincia);
                Consulta.Parameters.Add(pdomicilio);
                Consulta.Parameters.Add(ptelefono);

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

        public static bool ActualizarSucursal(Sucursal unaSucursal)
        {
            try
            {
                ConectarDB();

                OleDbCommand Consulta = conn.CreateCommand();
                Consulta.CommandType = System.Data.CommandType.StoredProcedure;
                Consulta.CommandText = "ActualizarSucursal";

                OleDbParameter pnombre = new OleDbParameter("pnombre", unaSucursal.nombre);
                OleDbParameter pmapa = new OleDbParameter("pmapa", unaSucursal.mapa);
                OleDbParameter pimagen = new OleDbParameter("pimagen", unaSucursal.rutaFoto);
                OleDbParameter pidprovincia = new OleDbParameter("pidProvincia", unaSucursal.idProvincia);
                OleDbParameter pdomicilio = new OleDbParameter("pdomicilio", unaSucursal.domicilio);
                OleDbParameter ptelefono = new OleDbParameter("ptelefono", unaSucursal.telefono);
                OleDbParameter pidSucursal = new OleDbParameter("pidSucursal", idStatic);

                Consulta.Parameters.Add(pnombre);
                Consulta.Parameters.Add(pmapa);
                Consulta.Parameters.Add(pimagen);
                Consulta.Parameters.Add(pidprovincia);
                Consulta.Parameters.Add(pdomicilio);
                Consulta.Parameters.Add(ptelefono);
                Consulta.Parameters.Add(pidSucursal);

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


        public static bool ActualizarSucursalNoFoto(Sucursal unaSucursal)
        {
            try
            {
                ConectarDB();

                OleDbCommand Consulta = conn.CreateCommand();
                Consulta.CommandType = System.Data.CommandType.StoredProcedure;
                Consulta.CommandText = "ActualizarSucursalNoFoto";

                OleDbParameter pnombre = new OleDbParameter("pnombre", unaSucursal.nombre);
                OleDbParameter pmapa = new OleDbParameter("pmapa", unaSucursal.mapa);
                OleDbParameter pidprovincia = new OleDbParameter("pidProvincia", unaSucursal.idProvincia);
                OleDbParameter pdomicilio = new OleDbParameter("pdomicilio", unaSucursal.domicilio);
                OleDbParameter ptelefono = new OleDbParameter("ptelefono", unaSucursal.telefono);
                OleDbParameter pidSucursal = new OleDbParameter("pidSucursal", idStatic);

                Consulta.Parameters.Add(pnombre);
                Consulta.Parameters.Add(pmapa);
                Consulta.Parameters.Add(pidprovincia);
                Consulta.Parameters.Add(pdomicilio);
                Consulta.Parameters.Add(ptelefono);
                Consulta.Parameters.Add(pidSucursal);

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
    }
}