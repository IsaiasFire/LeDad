using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeDad.conexion;
using LeDad.Modelos;
using LeDad;


namespace LeDad.Controladores
{
    class ControladorEstudiante
    {
        Conexion conexion = new Conexion();
        DataSet ds;


        public DataTable MostrarEstudiantes()
        {
            conexion.AbrirConexion();
            SqlCommand cmd = new SqlCommand("select * from estudiante",conexion.conexionbd);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "estudiante");
            conexion.CerrarConexion();
            return ds.Tables["estudiante"];
        }

        public DataTable BuscarEstudiante(string nombre)
        {
            conexion.AbrirConexion();
            SqlCommand cmd = new SqlCommand(string.Format("select * from estudiante where nombre like '%{0}%'",nombre) ,conexion.conexionbd);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adapter.Fill(ds, "estudiante");
            conexion.CerrarConexion();
            return ds.Tables["estudiante"];
        }

        public bool EliminarEstudiante(string id)
        {
            conexion.AbrirConexion();
            SqlCommand cmd = new SqlCommand(string.Format("Delete from estudiante where EstudianteId ='{0}'", id), conexion.conexionbd);
            int FilasAfectadas = cmd.ExecuteNonQuery();
            conexion.CerrarConexion();

            if (FilasAfectadas > 0) return true;
            else return false;
        }


        public bool RegistrarEstudiante(Estudiante estudiante)
        {
            conexion.AbrirConexion();
            SqlCommand cmd = new SqlCommand(string.Format("insert into Estudiante(Nombre, Apellido, Sexo, FechaNacimiento, Edad, NombreTutor, TelefonoTutor) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')",
             
               estudiante.GetNombre(),
               estudiante.GetApellidos(),
               estudiante.GetSexo(),
               estudiante.GetFechaNacimiento(),
               estudiante.GetEdad(),
               estudiante.GetTutor(),
               estudiante.GetTelefonoTutor()), conexion.conexionbd);

            int FilasAfectadas = cmd.ExecuteNonQuery();
            conexion.CerrarConexion();

            if (FilasAfectadas > 0) return true;
            else return false;
        }

        public bool AtualizarEstudiante(Estudiante estudiante)
        {
         
            conexion.AbrirConexion();
            SqlCommand cmd = new SqlCommand(string.Format("update Estudiante set Nombre = '{0}', Apellido = '{1}', Sexo = '{2}', FechaNacimiento = '{3}', Edad = {4}, NombreTutor = '{5}', TelefonoTutor = '{6}' where EstudianteID = {7}",

               estudiante.GetNombre(),
               estudiante.GetApellidos(),
               estudiante.GetSexo(),
               estudiante.GetFechaNacimiento(),
               estudiante.GetEdad(),
               estudiante.GetTutor(),
               estudiante.GetTelefonoTutor(),
               estudiante.GetCodigo()), conexion.conexionbd);

            int FilasAfectadas = cmd.ExecuteNonQuery();
            conexion.CerrarConexion();

            if (FilasAfectadas > 0) return true;
            else return false;
        }
    }
}
