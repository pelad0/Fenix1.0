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
        int idMedico;
        string seguridad;

        public clsUsuario()
        {

        }

        public clsUsuario(string usuario, string clave, string seguridad, int idMedico)
        {
            this.usuario = usuario;
            this.clave = clave;
            this.seguridad = seguridad;
            this.idMedico = idMedico;
        }

        public clsUsuario(int id, string usuario, string clave, string seguridad, int idMedico)
        {
            this.id = id;
            this.usuario = usuario;
            this.clave = clave;
            this.seguridad = seguridad;
            this.idMedico = idMedico;


        }

        public string Clave
        {
          get { return clave; }
          set { clave = value; }
        }

        public string Usuario
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

        public int IdMedico
        {
            get { return idMedico; }
            set { idMedico = value; }
        }

    }
}
