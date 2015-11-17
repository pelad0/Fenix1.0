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
    public class RepositorioFactura
    {
        ManejaFactura manejafactura = new ManejaFactura();

        public void Alta(IEntidad factura)
        {
            try
            {

                manejafactura.Alta(factura);
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

        public void Baja(IEntidad factura)
        {
            try
            {
                manejafactura.Baja(factura);
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

        public void Modificacion(IEntidad factura)
        {
            try
            {
                manejafactura.Modificacion(factura);
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
        public clsFactura buscarPorId(int id)
        {

            clsFactura rec;
            try
            {
                rec = (clsFactura) manejafactura.buscaPorId(id);

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

        public List<clsFactura> Todo(int pag)
        {
            DataTable tabla;
            List<clsFactura> lista = new List<clsFactura>();
            try
            {
                tabla = manejafactura.Todo(pag);

                foreach (DataRow aux in tabla.Rows)
                {
                    clsFactura fac = new clsFactura();

                    fac.Id = Convert.ToInt32(aux["id"]);
                    fac.Cuitcliente = aux["cuitcliente"].ToString();
                    fac.NumeroFactura = Convert.ToInt32(aux["numerofactura"]);
                    fac.TipoFactura = aux["tipofactura"].ToString();
                    fac.RazonSocial = aux["razonsocial"].ToString();
                    fac.Terminal = Convert.ToInt32(aux["numeroterminal"]);
                    fac.Total = float.Parse(aux["total"].ToString());
                    fac.Fecha = Convert.ToDateTime(aux["fecha"]);
                    fac.IdUsuario = Convert.ToInt32(aux["idusuario"]);
                    fac.Cliente = aux["cliente"].ToString();
                    fac.PagoEfectivo = float.Parse(aux["pagoefectivo"].ToString());
                    fac.PagoTarjeta = float.Parse(aux["pagotarjeta"].ToString());

                    lista.Add(fac);
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

        public clsFactura ultimoId()
        {
            DataTable tabla;
            clsFactura fac = new clsFactura();
            try
            {
                tabla = manejafactura.ultimoID();

                foreach (DataRow aux in tabla.Rows)
                {
                    

                    fac.Id = Convert.ToInt32(aux["id"]);                    
                    fac.NumeroFactura = Convert.ToInt32(aux["numerofactura"]);
                    fac.Cuitcliente = aux["cuitcliente"].ToString();
                    fac.TipoFactura = aux["tipofactura"].ToString();
                    fac.RazonSocial = aux["razonsocial"].ToString();
                    fac.Terminal = Convert.ToInt32(aux["numeroterminal"]);
                    fac.Total = float.Parse(aux["total"].ToString());
                    fac.Fecha = Convert.ToDateTime(aux["fecha"]);
                    fac.IdUsuario = Convert.ToInt32(aux["idusuario"]);
                    fac.Cliente = aux["cliente"].ToString();
                    fac.PagoEfectivo = float.Parse(aux["pagoefectivo"].ToString());
                    fac.PagoTarjeta = float.Parse(aux["pagotarjeta"].ToString());

                    
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

            return fac;
        }
    }
}
