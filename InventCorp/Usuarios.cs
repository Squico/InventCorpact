using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventCorp
{
    public abstract class Usuarios
    {
        private string Nombre;
        private int Identificacion;
        private string Perfil;
        private int Codigo;
        private string Email;

        protected Usuarios(string nombre, int identificacion, string perfil, int codigo, string email)
        {
            Nombre = nombre;
            Identificacion = identificacion;
            Perfil = perfil;
            Codigo = codigo;
            Email = email;
        }

        public string GetNombre()
        {
            return Nombre;
        }

        public void SetNombre(string value)
        {
            Nombre = value;
        }

        public int GetIdentificacion()
        {
            return Identificacion;
        }

        public void SetIdentificacion(int value)
        {
            Identificacion = value;
        }

        public string GetPerfil()
        {
            return Perfil;
        }

        public void SetPerfil(string value)
        {
            Perfil = value;
        }

        public int GetCodigo()
        {
            return Codigo;
        }

        public void SetCodigo(int value)
        {
            Codigo = value;
        }

        public string GetEmail()
        {
            return Email;
        }

        public void SetEmail(string value)
        {
            Email = value;
        }
    }
}
