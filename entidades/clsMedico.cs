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
<<<<<<< HEAD
        int especialidad;       //id de especialidad
=======
        int especialidad;

        public int Especialidad
        {
            get { return especialidad; }
            set { especialidad = value; }
        }   
>>>>>>> origin/master
        List<string> obraSocial;

        public clsMedico(int id, int matricula, long dni, string nombre, string apellido, int especialidad, List<string> obraSocial )
        {
            this.id = id;
            this.matricula = matricula;
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.especialidad = especialidad;
            this.obraSocial = obraSocial;
        }

        public clsMedico(int matricula, long dni, string nombre, string apellido, int especialidad, List<string> obraSocial)
        {
            this.matricula = matricula;
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.especialidad = especialidad;
            this.obraSocial = obraSocial;
        }
        public clsMedico()
        {

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

<<<<<<< HEAD
        public int Especialidad
        {
            get { return especialidad; }
            set { especialidad = value; }
        }
=======

>>>>>>> origin/master
    

        public List<string> ObraSocial
        {
            get { return obraSocial; }
            set { obraSocial = value; }
        }


    }
}
