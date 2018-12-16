using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LeDad.conexion
{
    class Conexion
    {
        string Cadena = "data source = DESKTOP-G76B1GD; Initial catalog = LEDAD; Integrated Security = true";
        public SqlConnection conexionbd = new SqlConnection();

        public Conexion()
        {
            conexionbd.ConnectionString = Cadena;
        }

        public void AbrirConexion()
        {
            try
            {
                conexionbd.Open();
                Console.WriteLine("Conexion Exitosa");
            }
            catch(Exception e)
            {
                Console.WriteLine("ERROR: " + e.Message.ToString());
            }
        }

        public void CerrarConexion()
        {
            conexionbd.Close();
        }
    }
}
