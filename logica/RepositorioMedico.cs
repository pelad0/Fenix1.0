using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interfaces;
using entidades;
using Datos;
using System.Data;
using System.Data.SqlClient;

namespace logica
{
    public class RepositorioMedico
    {
        public void Alta(IEntidad medico)
        {
            ManejaMedico manejaMedico = new ManejaMedico();
            try
            {
                manejaMedico.Alta(medico);
            }
            catch(SqlException ex)
            {
                throw;
            }
        }

        public void Baja(IEntidad medico)
        {
            ManejaMedico manejaMedico = new ManejaMedico();
            manejaMedico.Baja(medico);
        }


        public void Modificacion(IEntidad medico)
        {
            ManejaMedico manejaMedico = new ManejaMedico();
            manejaMedico.Modificacion(medico);
        }

        public clsMedico buscarPorId(int id)
        {
            clsMedico med = new clsMedico();
            ManejaMedico manejaMedico = new ManejaMedico();
            med = (clsMedico)manejaMedico.buscaPorId(id);

            return med;
        }

    }
}
