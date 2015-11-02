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
    public class RepositorioPlanesPorObra
    {
        ManejaPlanesxObra manejaplanesxobra = new ManejaPlanesxObra();

        public void Alta(IEntidad plan)
        {
            try
            {

                manejaplanesxobra.Alta(plan);
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

        public void Baja(IEntidad plan)
        {
            try
            {
                manejaplanesxobra.Baja(plan);
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

        public void Modificacion(IEntidad plan)
        {
            try
            {
                manejaplanesxobra.Modificacion(plan);
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
        public clsPlanesXObra buscarPorId(int id)
        {

           clsPlanesXObra rec;
            try
            {
                rec = (clsPlanesXObra) manejaplanesxobra.buscaPorId(id);

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

        public List<clsPlanesXObra> Todo(int pag)
        {
            DataTable tabla;
            List<clsPlanesXObra> lista = new List<clsPlanesXObra>();
            try
            {
                tabla = manejaplanesxobra.Todo(pag);

                foreach (DataRow aux in tabla.Rows)
                {
                    clsPlanesXObra rec = new clsPlanesXObra();

                    rec.IdObra = Convert.ToInt32(aux["idobra"]);
                    rec.NombrePlan = aux["nombreplan"].ToString();
                    rec.Importe = Convert.ToDouble(aux["importe"]);


                    lista.Add(rec);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lista;

        }
    }
}
