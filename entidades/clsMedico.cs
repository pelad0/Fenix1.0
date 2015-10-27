﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class clsMedico : IEntidad
    {
        int idMedico;
        int matricula;
        long dni;
        string nombre;
        string apellido;
        string especialidad;

        public clsMedico(int id, int matricula, long dni, string nombre, string apellido, string especialidad)
        {
            this.idMedico = id;
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

        public int IdMedico
        {
            get { return idMedico; }
            set { idMedico = value; }
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
