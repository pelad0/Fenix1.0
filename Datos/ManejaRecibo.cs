﻿using System;
using System.Collections.Generic;
using System.Linq;
using interfaces;
using System.Text;
using System.Threading.Tasks;
using entidades;
using interfaces;
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
                manager.ejecutar("Insert into recibo(Idfactura,cobertura,importe,detalle) values('" + rec.IdFactura + "','" + rec.Cobertura + "'," + rec.Importe + "," + rec.Detalle + ");SELECT @@identity;");
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
                manager.ejecutar("update recibo set idfactura=" + rec.IdFactura + ",cobertura=" + rec.Cobertura + ",importe=" + rec.Importe +",detalle="+rec.Detalle+ "where id=" + rec.Id);
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
               rec.IdFactura = Convert.ToInt32(aux.Rows[0]["Idfactura"]);
                rec.Id = Convert.ToInt32( aux.Rows[0]["id"]);
                rec.Cobertura =Convert.ToDouble( aux.Rows[0]["cobertura"]);
                rec.Importe = Convert.ToDouble(aux.Rows[0]["importe"]);
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

                aux = manager.consultar(" SELECT * FROM (SELECT *, ROW_NUMBER() OVER (ORDER BY ID) AS RowNum FROM recibo) AS tabla WHERE activo=1 and  tabla.RowNum BETWEEN" + pagina * 10 + " AND " + (pagina * 10) + 10);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return aux;
        }

        
    }
}
