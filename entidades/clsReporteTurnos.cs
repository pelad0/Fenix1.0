using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class clsReporteTurnos
    {
        string nombre;
        DateTime fecha;
        string asistencia;

        public clsReporteTurnos(string nombre, DateTime fecha, string asistencia)
        {
            this.nombre = nombre;
            this.fecha = fecha;
            this.asistencia = asistencia;
        }

        public clsReporteTurnos() { }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public string Asistencia
        {
            get { return asistencia; }
            set { asistencia = value; }
        }

    }
}
