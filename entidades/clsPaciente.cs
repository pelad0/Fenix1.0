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

        public string ObraSocial
        {
            get { return obraSocial; }
            set { obraSocial = value; }
        }
        long telefono;

        public clsPaciente()
        {

        }

        public clsPaciente(string nombre, string apellido, long dni, string obra, long telefono)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.obraSocial = obra;
            this.telefono = telefono;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

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



        public long Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string nomCompleto()
        {
            return nombre + " " + apellido;
        }
    }
}
