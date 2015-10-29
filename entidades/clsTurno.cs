using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interfaces;

namespace entidades
{
    public class clsTurno :IEntidad
    {
        int id;

        int idMedico;

        int idPaciente;

        DateTime fecha;

        double costo;

        int idUsuario;

        public clsTurno()
        {

        }

     }
}
