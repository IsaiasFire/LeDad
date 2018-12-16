using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeDad.Modelos;
using LeDad.conexion;
using System.Data;
using System.Data.SqlClient;

namespace LeDad.Controladores
{
    class ControladorUsuario
    {
        Conexion conexion = new Conexion();

        public bool RegistrarUsuario(Usuario user)
        {
       
                conexion.AbrirConexion();
                SqlCommand cmd = new SqlCommand(string.Format("insert into Usuario(Nombre, Apellido, Cedula, CorreoElectronico, NombreDeUsuario, ClaveDeAcceso) values ('{0}','{1}','{2}','{3}','{4}','{5}')",
                  
                    user.GetNombre(),
                    user.GetApellido(),
                    user.GetCedula(),
                    user.GetCorreo(),
                    user.GetNombreUsuario(),
                    user.GetClaveAcceso()), conexion.conexionbd);
                    
                int FilasAfectadas = cmd.ExecuteNonQuery();
                conexion.CerrarConexion();


            if (FilasAfectadas > 0) return true;
                else return false;
   
        }
    }
}
