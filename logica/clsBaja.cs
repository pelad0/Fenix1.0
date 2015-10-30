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
    public class clsBaja
    {
        public void Medico(IEntidad medico)
        {
            ManejaMedico manejaMedico = new ManejaMedico();
            manejaMedico.Baja(medico);
        }

        public void Paciente(IEntidad paciente)
        {
            ManejaPaciente manejapaciente = new ManejaPaciente();
            manejapaciente.Baja(paciente);
        }

        public void Turno(IEntidad turno)
        {
            ManejaTurno manejaTurno = new ManejaTurno();
            manejaTurno.Baja(turno);
        }

        public void SobreTurno(IEntidad sobreturno)
        {
            ManejaSobreturno manejaSobreturno = new ManejaSobreturno();
            manejaSobreturno.Baja(sobreturno);

        }

        public void ObraSocial(IEntidad obraSocial)
        {
            ManejaObraSocial manejaObrasocial = new ManejaObraSocial();
            manejaObrasocial.Baja(obraSocial);
        }

        public void Especialidad(IEntidad especialidad)
        {
            ManejaEspecialidad manejaEspecialidad = new ManejaEspecialidad();
            manejaEspecialidad.Baja(especialidad);
        }

        public void Factura(IEntidad factura)
        {
            ManejaFactura manejaFactura = new ManejaFactura();
            manejaFactura.Baja(factura);
        }

        public void Recibo(IEntidad recibo)
        {
            ManejaRecibo manejaRecibo = new ManejaRecibo();
            manejaRecibo.Baja(recibo);
        }
    }
}
