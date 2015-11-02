using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interfaces;

namespace entidades
{
    public class clsHistorial : IEntidad
    {
        string diagnostico;
        string observaciones;
        DateTime fecha;
        private int id;

        public clsHistorial(int idPaciente, string diagnostico, string observaciones, DateTime fecha)
        {
            this.Id = idPaciente;
            this.diagnostico = diagnostico;
            this.observaciones = observaciones;
            this.fecha = fecha;
        }

        public clsHistorial()
        {

        }

        public string Diagnostico
        {
            get { return diagnostico; }
            set { diagnostico = value; }
        }

        public string Observaciones
        {
            get { return observaciones; }
            set { observaciones = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
