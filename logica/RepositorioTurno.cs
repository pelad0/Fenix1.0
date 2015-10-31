using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interfaces;
using entidades;
using Datos;
using System.Data.SqlClient;

namespace logica
{
    public class RepositorioTurno
    {
        public void Alta(IEntidad turno,int id)
        {
            try
            {
                ManejaTurno manejaTurno = new ManejaTurno();
                manejaTurno.Alta(turno, id);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public void Baja(IEntidad turno)
        {
            ManejaTurno manejaTurno = new ManejaTurno();
            manejaTurno.Baja(turno);
        }

        public void Modificacion(IEntidad turno)
        {
            ManejaTurno manejaTurno = new ManejaTurno();
            manejaTurno.Modificacion(turno);
        }
        public clsTurno buscarPorId(int id)
        {
            clsTurno med = new clsTurno();
            ManejaMedico manejaMedico = new ManejaMedico();
            med = (clsTurno)manejaMedico.buscaPorId(id);

            return med;
        }
    }
}
