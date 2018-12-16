using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeDad.Modelos
{
    class Usuario
    {
        private int UsuarioID;
        private string Nombre;
        private string Apellido;
        private string Cedula;
        private string Correo;
        private string NombreUsuario;
        private string ClaveAcceso;

        public int GetUsuarioID()
        {
            return UsuarioID;
        }

        public void SetUsuarioID(int id)
        {
            UsuarioID = id;
        }

        public string GetNombre()
        {
            return Nombre;
        }

        public void SetNombre(string _nombre)
        {
            Nombre = _nombre;
        }

        public string GetApellido()
        {
            return Apellido;
        }

        public void SetApellido(string _apellido)
        {
            Apellido = _apellido;
        }

        public string GetCedula()
        {
            return Cedula;
        }

        public void SetCedula(string _cedula)
        {
            Cedula = _cedula;
        }

        public string GetCorreo()
        {
            return Correo;
        }

        public void SetCorreo(string _correo)
        {
            Correo = _correo;
        }

        public string GetNombreUsuario()
        {
            return NombreUsuario;
        }

        public void SetNombreUsuario(string _nombreUsuario)
        {
            NombreUsuario = _nombreUsuario;
        }

        public string GetClaveAcceso()
        {
            return ClaveAcceso;
        }

        public void SetClaveAcceso(string _claveAcceso)
        {
            ClaveAcceso = _claveAcceso;
        }


    }
}
