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
    public class RepositorioHistorial
    {
        ManejaHistorial manejahistorial = new ManejaHistorial();
        public void Alta(IEntidad historial)
        {
            try
            {
                manejahistorial.Alta(historial);
                
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

        public void Baja(IEntidad historial)
        {
            try
            {
                manejahistorial.Baja(historial);
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

        public void Modificacion(IEntidad historial)
        {
            try
            {
                manejahistorial.Modificacion(historial);
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
        public clsHistorial buscarPorId(int id)
        {

            clsHistorial rec;
            try
            {
                rec = (clsHistorial)manejahistorial.buscaPorId(id);

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }


            return rec;
        }

        public List<clsHistorial> Todo(int pag)
        {
            DataTable tabla;
            List<clsHistorial> lista = new List<clsHistorial>();

            tabla = manejahistorial.Todo(pag);

            foreach (DataRow aux in tabla.Rows)
            {
                clsHistorial hist = new clsHistorial();

                hist.Id = Convert.ToInt32(aux["id"]);
                hist.Diagnostico = aux["diagnostico"].ToString();
                hist.Observaciones = aux["observaciones"].ToString();
                hist.Fecha = Convert.ToDateTime(aux["fecha"]);
                
                lista.Add(hist);
            }

            return lista;

        }
    }
}
