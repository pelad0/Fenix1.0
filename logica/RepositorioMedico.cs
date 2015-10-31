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
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public void Baja(IEntidad medico)
        {
            try
            {

                ManejaMedico manejaMedico = new ManejaMedico();
                manejaMedico.Baja(medico);
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


        public void Modificacion(IEntidad medico)
        {
            try
            {
                ManejaMedico manejaMedico = new ManejaMedico();
                manejaMedico.Modificacion(medico);
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

        public DataTable buscarPorId(int id)
        {
            DataTable med = new DataTable();
            clsMedico m = new clsMedico();
            try
            {                
                ManejaMedico manejaMedico = new ManejaMedico();
                m = (clsMedico)manejaMedico.buscaPorId(id);


            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return med;
        }

        public List<clsMedico>Todo(int pag)
        {
            DataTable tabla;
            List<clsMedico> lista = new List<clsMedico>();
            ManejaMedico manejaMedico = new ManejaMedico();
            tabla=manejaMedico.Todo(pag);
            foreach(DataRow i in tabla.Rows)
            {

                clsMedico med = new clsMedico();

            }

            return lista;

        }

    }
}
