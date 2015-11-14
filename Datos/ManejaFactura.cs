using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaces;
using entidades;
using System.Data;
using System.Threading.Tasks;

namespace Datos
{
    public class ManejaFactura : iMetodos
    {
        iBdMetodos manager;
        public ManejaFactura()
        {
            manager= new BdMetodos();
        }

        public void Alta(IEntidad entidad)
        {
            clsFactura fack = (clsFactura)entidad;
            try
            {
                manager.ejecutar("Insert into factura(cuitcliente,numerofactura,tipofactura,razonsocial,numeroterminal,total,fecha,idusuario,cliente,pagoefectivo,pagotarjeta) values('" +fack.Cuitcliente + "'," + fack.NumeroFactura + ",'" + fack.TipoFactura + "','" + fack.RazonSocial +"','"+fack.Terminal+"',"+fack.Total+",'"+fack.Fecha+"',"+fack.IdUsuario+",'"+fack.Cliente+"',"+fack.PagoEfectivo+","+fack.PagoTarjeta+");SELECT @@identity;");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Baja(IEntidad entidad)
        {
            clsFactura fack = (clsFactura)entidad;
            try
            {
                manager.ejecutar("update factura set activo=0 where id=" + fack.Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Modificacion(IEntidad entidad)
        {
            clsFactura fack = (clsFactura)entidad;
            try
            {                                                                                                                                                          //razonsocial,numeroterminal,total,fecha,idusuario,cliente,pagoefectivo,pagotarjeta)
                manager.ejecutar("update factura set cuitcliente='" + fack.Cuitcliente + "',numerofactura=" + fack.NumeroFactura + ",tipofactura='" + fack.TipoFactura + "',razonsocial='" + fack.RazonSocial + "',numeroterminal='" + fack.Terminal + "',total=" + fack.Total + ",fecha='" + fack.Fecha + "',idusuario=" + fack.IdUsuario + "',cliente='" + fack.Cliente + "',pagoefectivo=" + fack.PagoEfectivo + ",pagotarjeta=" + fack.PagoTarjeta + " where id=" + fack.Id);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEntidad buscaPorId(int id)
        {
            DataTable aux = new DataTable();
            clsFactura fack = new clsFactura();
            try
            {
                //cuitcliente,numerofactura,tipofactura,razonsocial,numeroterminal,total,fecha,idusuario,cliente,pagoefectivo,pagotarjeta
                aux = manager.consultar("select * from factura where id=" + id + " and activo=1");
                fack.Id = Convert.ToInt32(aux.Rows[0]["id"]);
                fack.Cuitcliente = aux.Rows[0]["cuitcliente"].ToString();
                fack.NumeroFactura =Convert.ToInt32( aux.Rows[0]["numerofactura"]);
                fack.RazonSocial = aux.Rows[0]["razonsocial"].ToString();
                fack.Terminal = aux.Rows[0]["numeroterminal"].ToString();
                fack.Total = Convert.ToDouble(aux.Rows[0]["total"]);
                fack.Fecha = Convert.ToDateTime(aux.Rows[0]["fecha"]);
                fack.IdUsuario = Convert.ToInt32(aux.Rows[0]["idusuario"]);
                fack.Cliente = aux.Rows[0]["cliente"].ToString();
                fack.PagoEfectivo = Convert.ToDouble(aux.Rows[0]["pagoefectivo"]);
                fack.PagoTarjeta = Convert.ToDouble(aux.Rows[0]["pagotarjeta"]);
           


            }
            catch (Exception ex)
            {
                throw ex;
            }
            return fack;
        }

        public System.Data.DataTable Todo(int pagina)
        {
            DataTable aux = new DataTable();
            try
            {

                aux = manager.consultar(" SELECT * FROM (SELECT *, ROW_NUMBER() OVER (ORDER BY ID) AS RowNum FROM factura) AS tabla WHERE activo=1 and  tabla.RowNum BETWEEN " + pagina * 10 + " AND " + (pagina * 10) + 10);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return aux;
        }

        public DataTable ultimoID()
        {
            DataTable aux = new DataTable();
            try
            {

                aux = manager.consultar("select TOP 1 id from factura where activo=1 order by id desc ");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return aux;
        }

     
    }
}
