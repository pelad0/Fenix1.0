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
            ManejaPaciente manejaPaciente = new ManejaPaciente();
            manejaPaciente.Modificacion(paciente);
        }

        public clsPaciente buscarPorId(int id)
        {
            clsPaciente pac = new clsPaciente();
            ManejaPaciente manejaPaciente = new ManejaPaciente();
            pac = (clsPaciente)manejaPaciente.buscaPorId(id);

            return pac;
        }

        public clsPaciente buscarDni(long dni)
        {
            clsPaciente pac = new clsPaciente();
                        
            DataTable tabla;
           
           
            tabla = manejaPaciente.Todo(pag);
            foreach (DataRow aux in tabla.Rows)
            {
                if (dni == Convert.ToInt64(aux["dni"]))
                {
                      clsPaciente med = new clsPaciente();
                }

              

            }
            return pac;
        }

        public List<clsPaciente> Todo(int pag)
        {
            DataTable tabla;
            List<clsPaciente> lista = new List<clsPaciente>();
            ManejaMedico manejaPaciente = new ManejaMedico();
            tabla = manejaPaciente.Todo(pag);
            foreach (DataRow i in tabla.Rows)
            {

                clsPaciente med = new clsPaciente();

            }

            return lista;

        }
    }
}
