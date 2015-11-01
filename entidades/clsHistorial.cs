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
            this.Id = idPaciente;
            this.diagnostico = diagnostico;
            this.observaciones = observaciones;
            this.fecha = fecha;
        }

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

    }
}
