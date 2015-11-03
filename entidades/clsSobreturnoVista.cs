using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entidades;
using interfaces;

namespace entidades
{
    public class clsSobreTurnoVista :IEntidad
    {
        int id;
        clsMedico medico;
        clsPaciente paciente;
        DateTime fecha;
        double costo;
        int idUsuario;
        bool estado;
                 
        public clsSobreTurnoVista()
        {

        }

        public  clsSobreTurnoVista(int id, clsMedico medico, clsPaciente paciente, DateTime fecha, double costo, int idUsuario, bool estado)
        {
            this.id = id;
            this.medico = medico;
            this.paciente = paciente;
            this.fecha = fecha;
            this.costo = costo;
            this.idUsuario = idUsuario;
            this.estado = estado;
        }

        public clsSobreTurnoVista(clsMedico medico, clsPaciente paciente, DateTime fecha, int idUsuario)
        {
            this.medico = medico;
            this.paciente = paciente;
            this.fecha = fecha;
            this.costo = 0;
            this.idUsuario = idUsuario;
            this.estado = false;
            
        }

        public clsMedico Medico
        {
            get { return medico; }
            set { medico = value; }
        }

        public clsPaciente Paciente
        {
            get { return paciente; }
            set { paciente = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }      


        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }        

        public double Costo
        {
            get { return costo; }
            set { costo = value; }
        }       

        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}
