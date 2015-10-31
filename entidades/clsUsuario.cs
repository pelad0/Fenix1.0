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

        public clsUsuario()
        {

        }

        public clsUsuario(string usuario, string clave)
        {
            this.ususario = ususario;
            this.clave = clave;
        }

        public clsUsuario(int id, string usuario, string clave)
        {
            this.id = id;
            this.ususario = usuario;
            this.clave = clave;
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
    }
}
