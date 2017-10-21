using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.OleDb;

namespace TP_FINAL.Models
{
    public class Provincias
    {
        public string nombre { get; set; }

        public int idProvincia { get; set; }

        public string pais { get; set; }

        static string Proveedor = @"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source= |DataDirectory|DB.accdb";

        static OleDbConnection conn = new OleDbConnection();

        private static void ConectarDB()
        {
            conn.ConnectionString = Proveedor;
            conn.Open();
        }

        public static List<Provincias> CargarProvincias()
        {
            List<Provincias> miLista = new List<Provincias>();

            try
            {
                ConectarDB();

                OleDbCommand Consulta = conn.CreateCommand();
                Consulta.CommandType = System.Data.CommandType.StoredProcedure;
                Consulta.CommandText = "TraerProvincias";

                OleDbDataReader dr = Consulta.ExecuteReader();

                while (dr.Read())
                {
                    int tid = Convert.ToInt32(dr["IdProvincia"]);
                    string tnombre = dr["Nombre"].ToString();
                    string tpais = dr["Pais"].ToString();

                    Provincias miProvincia = new Provincias();
                    miProvincia.idProvincia = tid;
                    miProvincia.nombre = tnombre;
                    miProvincia.pais = tpais;

                    miLista.Add(miProvincia);
                }
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Hubo un Error");
            }
            return miLista;
        }

    }
}