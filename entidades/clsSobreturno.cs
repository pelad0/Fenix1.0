using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interfaces;
namespace entidades
{
    public class clsSobreturno : IEntidad
    {
        int id;
        int idMedico;
        int idPaciente;
        DateTime fecha;
        double costo;
        int idUsuario;
        bool estado;
                 
        public clsSobreturno()
        {

        }

        public clsSobreturno(int id,int idMedico,int idPaciente,DateTime fecha,double costo,int idUsuario,bool estado)
        {
            this.id = id;
            this.idMedico = idMedico;
            this.idPaciente = idPaciente;
            this.fecha = fecha;
            this.costo = costo;
            this.idUsuario = idUsuario;
            this.estado = estado;
        }

        public clsSobreturno(int idMedico, int idPaciente, DateTime fecha, int idUsuario)
        {
            this.idMedico = idMedico;
            this.idPaciente = idPaciente;
            this.fecha = fecha;
            this.costo = costo;
            this.idUsuario = idUsuario;
            this.estado = estado;

        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }      

        public int IdMedico
        {
            get { return idMedico; }
            set { idMedico = value; }
        }     

        public int IdPaciente
        {
            get { return idPaciente; }
            set { idPaciente = value; }
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

        public bool equal(clsSobreturno t)
        {
            if (this.Fecha == t.fecha && this.idMedico == t.idMedico)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
