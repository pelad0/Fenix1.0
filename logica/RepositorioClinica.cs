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
    public class RepositorioClinica
    {

        ManejaClinica manejaclinica = new ManejaClinica();
        public void Alta(IEntidad clinica)
        {
            try
            {
                manejaclinica.Alta(clinica);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void Baja(IEntidad clinica)
        {
            try
            {
                manejaclinica.Baja(clinica);
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

        public void Modificacion(IEntidad clinica)
        {
            try
            {
                manejaclinica.Modificacion(clinica);
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


        public clsClinica buscarPorId(int id)
        {

            clsClinica os;
            try
            {
                os = (clsClinica)manejaclinica.buscaPorId(id);
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


        public clsClinica Todo(int pag)
        {
            DataTable tabla= new DataTable();
            clsClinica cl = new clsClinica();
            try
            {
                tabla = manejaclinica.Todo(pag);
                foreach (DataRow aux in tabla.Rows)
                {                    
                    cl.FechaInicioActividades = Convert.ToDateTime(aux["fia"]);
                    cl.Cuit=aux["cuit"].ToString();
                    cl.IngresosBrutos = Convert.ToDouble(aux["iibb"]);
                    cl.NombreFantasia = aux["nombrefantasia"].ToString();
                    cl.RazonSocial = aux["razonsocial"].ToString();
                    cl.DomicilioComercial=aux["domiciliocom"].ToString();
                    cl.DomicilioFiscal = aux["domiciliofisc"].ToString();
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


            return cl;

        }

    }
}
