using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;

namespace MVC1.Models.DataAccess
{
    public class Novixs
    {

        static string Proveedor = @"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source= G:\Ort\5 año\Programacion\Tercer Trimestre\MVC2\DB_Usuarios.accdb";

        static OleDbConnection conn = new OleDbConnection();

        private static void ConectarDB()
        {
            conn.ConnectionString = Proveedor;
            conn.Open();
        }
        public static bool AgregarNovix(Novix unNovix)
        {
            try
            {
                ConectarDB();

                OleDbCommand Consulta = conn.CreateCommand();
                Consulta.CommandType = System.Data.CommandType.StoredProcedure;
                Consulta.CommandText = "GuardarNovix";

                OleDbParameter nombreNovix = new OleDbParameter("nombre", unNovix.nombre);
                OleDbParameter apellidoNovix = new OleDbParameter("apellido", unNovix.apellido);
                OleDbParameter rutaFotoNovix = new OleDbParameter("rutaFoto", unNovix.rutaFoto);
                OleDbParameter idUsuario = new OleDbParameter("idUsuario", Usuario.ID);


                Consulta.Parameters.Add(nombreNovix);
                Consulta.Parameters.Add(apellidoNovix);
                Consulta.Parameters.Add(rutaFotoNovix);
                Consulta.Parameters.Add(idUsuario);
               

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