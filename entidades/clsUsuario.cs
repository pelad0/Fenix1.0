using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interfaces;

namespace entidades
{
    public class clsUsuario : IEntidad;
    {
        int id;        
        string ususario;
        string clave;
        string seguridad;

        public clsUsuario()
        {

        }

        public clsUsuario(string usuario, string clave, string seguridad)
        {
            this.ususario = ususario;
            this.clave = clave;
            this.seguridad = seguridad;
        }

        public clsUsuario(int id, string usuario, string clave, string seguridad)
        {
            this.id = id;
            this.ususario = usuario;
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
          get { return ususario; }
          set { ususario = value; }
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
