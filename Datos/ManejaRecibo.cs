using System;
using System.Collections.Generic;
using System.Linq;
using interfaces;
using System.Text;
using System.Threading.Tasks;
using entidades;
using System.Data;

namespace Datos
{
    public class ManejaRecibo : iMetodos
    {
        iBdMetodos manager;

        public ManejaRecibo()
        {
            manager =new BdMetodos();
        }
        public void Alta(IEntidad entidad)
        {
            clsRecibo rec = (clsRecibo)entidad;
            try
            {
                //manager.ejecutar("Insert into recibo(idfactura,idsobreturno,idturno,fecha,cobertura,importe,detalle) values(" + rec.IdFactura + "," + rec.IdSobreTurno + "," + rec.IdTurno + ",'" + rec.Fecha + "'," + rec.Cobertura + "," + rec.Importe + ",'" + rec.Detalle + "');SELECT @@identity;");
                manager.ejecutar("Insert into recibo(idfactura,idsobreturno,idturno,fecha,cobertura,importe,detalle) values(" + rec.IdFactura + "," + null + "," + rec.IdTurno + ",'" + rec.Fecha + "'," + 100 + "," + 200 + ",'" + rec.Detalle + "');SELECT @@identity;");

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Baja(IEntidad entidad)
        {
            clsRecibo rec = (clsRecibo)entidad;
            try
            {
                manager.ejecutar("update recibo set activo=0 where id=" + rec.Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Modificacion(IEntidad entidad)
        {
            clsRecibo rec = (clsRecibo)entidad;
            try
            {
                manager.ejecutar("update recibo set idfactura=" + rec.IdFactura + ",idsobreturno=" + rec.IdSobreTurno + ",idturno=" + rec.IdTurno + ",fecha=" + rec.Fecha + ",cobertura=" + rec.Cobertura + ",importe=" + rec.Importe + ",detalle='" + rec.Detalle + "' where id=" + rec.Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEntidad buscaPorId(int id)
        {
            DataTable aux = new DataTable();
            clsRecibo rec = new clsRecibo();
            try
            {
                aux = manager.consultar("select * from recibo where Id=" + id + " and activo=1");
                rec.Id = Convert.ToInt32( aux.Rows[0]["id"]);
                rec.IdFactura = Convert.ToInt32(aux.Rows[0]["idfactura"]);
                rec.IdSobreTurno = Convert.ToInt32(aux.Rows[0]["idsobreturno"]);
                rec.IdTurno = Convert.ToInt32(aux.Rows[0]["idturno"]);
                rec.Fecha = Convert.ToDateTime(aux.Rows[0]["fecha"]);                
                rec.Cobertura =float.Parse( aux.Rows[0]["cobertura"].ToString());
                rec.Importe = float.Parse(aux.Rows[0]["importe"].ToString());
                rec.Detalle = aux.Rows[0]["detalle"].ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return rec;
        }

        public System.Data.DataTable Todo(int pagina)
        {
            DataTable aux = new DataTable();
            try
            {

                aux = manager.consultar(" SELECT * FROM (SELECT *, ROW_NUMBER() OVER (ORDER BY ID) AS RowNum FROM recibo) AS tabla WHERE activo=1 and  tabla.RowNum BETWEEN " + pagina * 10 + " AND " + (pagina * 10) + 10);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return aux;
        }

        
    }
}
