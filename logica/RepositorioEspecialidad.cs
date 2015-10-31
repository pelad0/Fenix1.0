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
    public class RepositorioEspecialidad
    {

        ManejaEspecialidad manejaEspecialidad = new ManejaEspecialidad();
        public void Alta(IEntidad especialidad)
        {
                        
            try
            {
                manejaEspecialidad.Alta(especialidad);
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

        public void Baja(IEntidad especialidad)
        {
            try
            {
                                
                manejaEspecialidad.Baja(especialidad);
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


        public void Modificacion(IEntidad especialidad)
        {
            try
            {
               manejaEspecialidad.Modificacion(especialidad);
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

        public clsEspecialidad buscarPorId(int id)
        {
            clsEspecialidad esp = new clsEspecialidad();
            try
            {
                
                esp = (clsEspecialidad)manejaEspecialidad.buscaPorId(id);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return esp;
        }

        public List<clsEspecialidad> Todo()
        {
            DataTable tabla;
            List<clsEspecialidad> lista = new List<clsEspecialidad>();
           
            tabla = manejaEspecialidad.Todo();
            foreach (DataRow aux in tabla.Rows)
            {
                clsEspecialidad esp = new clsEspecialidad();
                esp.Id = Convert.ToInt32(aux["id"].ToString());
                esp.Descripcion = aux["descripcion"].ToString();
                lista.Add(esp);
            }

            return lista;

        }
    }
}
