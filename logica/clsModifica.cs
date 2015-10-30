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
    public class clsModifica
    {
        public void Medico(IEntidad medico)
        {
            ManejaMedico manejaMedico = new ManejaMedico();
            manejaMedico.Modificacion(medico);
        }

        public void Paciente(IEntidad paciente)
        {
            ManejaPaciente manejapaciente = new ManejaPaciente();
            manejapaciente.Modificacion(paciente);
        }

        public void Turno(IEntidad turno)
        {
            ManejaTurno manejaTurno = new ManejaTurno();
            manejaTurno.Modificacion(turno);
        }

        public void SobreTurno(IEntidad sobreturno)
        {
            ManejaSobreturno manejaSobreturno = new ManejaSobreturno();
            manejaSobreturno.Modificacion(sobreturno);

        }

        public void ObraSocial(IEntidad obraSocial)
        {
            ManejaObraSocial manejaObrasocial = new ManejaObraSocial();
            manejaObrasocial.Modificacion(obraSocial);
        }

        public void Especialidad(IEntidad especialidad)
        {
            ManejaEspecialidad manejaEspecialidad = new ManejaEspecialidad();
            manejaEspecialidad.Modificacion(especialidad);
        }

        public void Factura(IEntidad factura)
        {
            ManejaFactura manejaFactura = new ManejaFactura();
            manejaFactura.Modificacion(factura);
        }

        public void Recibo(IEntidad recibo)
        {
            ManejaRecibo manejaRecibo = new ManejaRecibo();
            manejaRecibo.Modificacion(recibo);
        }
       
    }
}
