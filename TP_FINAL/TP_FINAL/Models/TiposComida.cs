using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.OleDb;

namespace TP_FINAL.Models
{
    public class TiposComida
    {
        public string nombre { get; set; }

        public int id { get; set; }

        static string Proveedor = @"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source= |DataDirectory|DB.accdb";

        static OleDbConnection conn = new OleDbConnection();

        private static void ConectarDB()
        {
            conn.ConnectionString = Proveedor;
            conn.Open();
        }

        public static List<TiposComida> CargarTiposComida()
        {
            List<TiposComida> miLista = new List<TiposComida>();

            try
            {
                ConectarDB();

                OleDbCommand Consulta = conn.CreateCommand();
                Consulta.CommandType = System.Data.CommandType.StoredProcedure;
                Consulta.CommandText = "TraerTiposComida";

                OleDbDataReader dr = Consulta.ExecuteReader();
                
                while (dr.Read())
                {
                    int tid = Convert.ToInt32(dr["idTipoComida"]);
                    string tnombre = dr["Nombre"].ToString();

                    TiposComida miTipoComida = new TiposComida();
                    miTipoComida.id = tid;
                    miTipoComida.nombre = tnombre;

                    miLista.Add(miTipoComida);
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