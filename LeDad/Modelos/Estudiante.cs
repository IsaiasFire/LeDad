using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeDad.Modelos
{
    class Estudiante
    {
        Usuario user = new Usuario();

        private int Codigo;
        private string Nombre;
        private string Apellidos;
        private string Sexo;
        private string FechaNacimiento;
        private int Edad;
        private string NombreDelTutor;
        private string TelefonoDelTutor;

        public int GetCodigo()
        {
            return Codigo;
        }

        public void SetCodigo(int codigo)
        {
            Codigo = codigo;
        }

        public string GetNombre()
        {
            return Nombre;
        }

        public void SetNombre(string nombre)
        {
            Nombre = nombre;
        }

        public string GetApellidos()
        {
            return Apellidos;
        }

        public void SetApellidos(string apellidos)
        {
            Apellidos = apellidos;
        }

        public string GetSexo()
        {
            return Sexo;
        }

        public void SetSexo(string sexo)
        {
            Sexo = sexo;
        }

        public string GetFechaNacimiento()
        {
            return FechaNacimiento;
        }

        public void SetFechaNacimiento(string fecha)
        {
            FechaNacimiento = fecha;
        }

        public int GetEdad()
        {
            return Edad;
        }
        public void SetEdad(int edad)
        {
            Edad = edad;
        }

        public string GetTutor()
        {
            return NombreDelTutor;
        }

        public void SetTutor(string tutor)
        {
            NombreDelTutor = tutor;
        }

        public string GetTelefonoTutor()
        {
            return TelefonoDelTutor;
        }

        public void SetTelefonoTutor(string telefono)
        {
            TelefonoDelTutor = telefono;
        }
    }
}
