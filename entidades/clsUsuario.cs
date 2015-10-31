using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interfaces;

namespace entidades
{
    public class clsUsuario : IEntidad
    {
        int id;        
        string usuario;
        string clave;
        string seguridad;

        public clsUsuario()
        {

        }

        public clsUsuario(string usuario, string clave, string seguridad)
        {
            this.usuario = usuario;
            this.clave = clave;
            this.seguridad = seguridad;
        }

        public clsUsuario(int id, string usuario, string clave, string seguridad)
        {
            this.id = id;
            this.usuario = usuario;
            this.clave = clave;
            this.seguridad = seguridad;

        }

        public string Clave
        {
          get { return clave; }
          set { clave = value; }
        }

        public string Ususario
        {
          get { return usuario; }
          set { usuario = value; }
        }

        public int Id
        {
          get { return id; }
          set { id = value; }
        }

        public string Seguridad
        {
          get { return seguridad; }
          set { seguridad = value; }
        }
    }
}
