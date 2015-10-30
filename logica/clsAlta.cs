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
    public class clsAlta
    {
        public void Medico(IEntidad medico)
        {
            ManejaMedico manejaMedico = new ManejaMedico();
            manejaMedico.Alta(medico);
        }

        public void Paciente(IEntidad paciente)
        {
            ManejaPaciente manejapaciente = new ManejaPaciente();
            manejapaciente.Alta(paciente);
        }

        public void Turno(IEntidad turno)
        {
            ManejaTurno manejaTurno = new ManejaTurno();
            manejaTurno.Alta(turno);
        }

        public void SobreTurno(IEntidad sobreturno)
        {
            ManejaSobreturno manejaSobreturno = new ManejaSobreturno();
            manejaSobreturno.Alta(sobreturno);
        }

        public void ObraSocial(IEntidad obraSocial)
        {
            ManejaObraSocial manejaObrasocial = new ManejaObraSocial();
            manejaObrasocial.Alta(obraSocial);
        }
      
        public void Especialidad(IEntidad especialidad)
        {
            ManejaEspecialidad manejaEspecialidad = new ManejaEspecialidad();
            manejaEspecialidad.Alta(especialidad);
        }
        public void Factura(IEntidad factura)
        {
            ManejaFactura manejaFactura = new ManejaFactura();
            manejaFactura.Alta(factura);
        }

        public void Recibo(IEntidad recibo)
        {
            ManejaRecibo manejaRecibo = new ManejaRecibo();
            manejaRecibo.Alta(recibo);
        }       

     
    }
}
