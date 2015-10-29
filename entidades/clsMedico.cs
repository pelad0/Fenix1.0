using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interfaces;

namespace entidades
{
    public class clsMedico : IEntidad
    {
        int id;
        int matricula;
        long dni;
        string nombre;
        string apellido;
        string especialidad;

        public clsMedico(int id, int matricula, long dni, string nombre, string apellido, string especialidad)
        {
            this.id = id;
            this.matricula = matricula;
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.especialidad = especialidad;
        }

        public clsMedico(int matricula, long dni, string nombre, string apellido, string especialidad)
        {
            this.matricula = matricula;
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.especialidad = especialidad;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public long Dni
        {
            get { return dni; }
            set { dni = value; }
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


        public string Especialidad
        {
            get { return especialidad; }
            set { especialidad = value; }
        }
        

       
    }
}
