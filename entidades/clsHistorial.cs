using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class clsHistorial
    {
        int idPaciente;

        public int IdPaciente
        {
            get { return idPaciente; }
            set { idPaciente = value; }
        }
        string diagnostico;

        public string Diagnostico
        {
            get { return diagnostico; }
            set { diagnostico = value; }
        }
        string observaciones;

        public string Observaciones
        {
            get { return observaciones; }
            set { observaciones = value; }
        }
        DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public clsHistorial()
        {

        }

        public clsHistorial(int idPaciente,string diagnostico,string observaciones,DateTime fecha)
        {
            this.idPaciente = idPaciente;
            this.diagnostico = diagnostico;
            this.observaciones = observaciones;
            this.fecha = fecha;
        }
    }
}
