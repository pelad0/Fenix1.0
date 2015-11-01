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
    public class RepositorioPaciente
    {
        ManejaPaciente manejaPaciente = new ManejaPaciente();
        public void Alta(IEntidad paciente)
        {
            try
            {               
                manejaPaciente.Alta(paciente);
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
        public void Baja(IEntidad paciente)
        {
            
            manejaPaciente.Baja(paciente);
        }

        public void Modificacion(IEntidad paciente)
        {
            
            manejaPaciente.Modificacion(paciente);
        }

        public clsPaciente buscarPorId(int id)
        {
            clsPaciente pac = new clsPaciente();
            try
            {
                pac = (clsPaciente)manejaPaciente.buscaPorId(id);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            

            return pac;
        }

        public clsPaciente buscarDni(int dni)
        {
            clsPacienteDatos pac = new clsPacienteDatos();

            try
            {
                pac=(clsPacienteDatos)manejaPaciente.BuscarPorDni(dni);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
                      
            
            return pac;
        }

        public List<clsPaciente> Todo(int pag)
        {
            DataTable tabla;
            List<clsPaciente> lista = new List<clsPaciente>();
           
            tabla = manejaPaciente.Todo(pag);
            foreach (DataRow i in tabla.Rows)
            {
                clsPaciente med = new clsPaciente();
            }

            return lista;

        }
    }
}
