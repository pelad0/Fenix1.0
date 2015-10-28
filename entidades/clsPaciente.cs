using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interfaces;

namespace entidades
{
    public class clsPaciente : IEntidad
    {
        int id;
        string nombre;
        string apellido;
        long dni;
        string obraSocial;
        long telefono;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public long Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public string ObraSocial
        {
            get { return obraSocial; }
            set { obraSocial = value; }
        }

        public long Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
    }
}
