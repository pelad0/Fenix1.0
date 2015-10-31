using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interfaces;
using entidades;
using Datos;

namespace logica
{
    public class RepositorioPaciente
    {
        public void Alta(IEntidad paciente)
        {
            ManejaPaciente manejapaciente = new ManejaPaciente();
            manejapaciente.Alta(paciente);
        }
        public void Baja(IEntidad paciente)
        {
            ManejaPaciente manejapaciente = new ManejaPaciente();
            manejapaciente.Baja(paciente);
        }

        public void Modificacion(IEntidad paciente)
        {
            ManejaPaciente manejapaciente = new ManejaPaciente();
            manejapaciente.Modificacion(paciente);
        }

        //public clsPaciente buscarPorId(int id)
        //{
        //    //clsPaciente pac = new clsPaciente();
        //    ManejaPaciente manejaPaciente = new ManejaPaciente();
        //    pac = (clsPaciente)manejaPaciente.buscaPorId(id);

        //    return pac;
        //}
    }
}
