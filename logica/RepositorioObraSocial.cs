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
    public class RepositorioObraSocial
    {
        ManejaObraSocial manejaOs = new ManejaObraSocial();
        public void Alta(IEntidad obraSocial)
        {            
            try
            {
                manejaOs.Alta(obraSocial);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
         
        public void Baja(IEntidad obraSocial)
        {
            try
            {
                manejaOs.Baja(obraSocial);
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

        public void Modificacion(IEntidad obraSocial)
        {
            try
            {
                manejaOs.Baja(obraSocial);
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


        public clsObraSocial buscarPorId(int id)
        {
           
            clsObraSocial os = new clsObraSocial();
            try
            {
                os =(clsObraSocial) manejaOs.buscaPorId(id);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return os;
            
        }


        public List<clsObraSocial> Todo(int pag)
        {
            DataTable tabla;
            List<clsObraSocial> lista = new List<clsObraSocial>();
           
            tabla = manejaOs.Todo(pag);
            foreach (DataRow i in tabla.Rows)
            {
                              

            }

            return lista;

        }
    }
}
