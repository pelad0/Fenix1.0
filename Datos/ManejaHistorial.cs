using System;
using System.Collections.Generic;
using System.Linq;
using interfaces;
using System.Text;
using entidades;
using interfaces;
using System.Data;
using System.Threading.Tasks;

namespace Datos
{
    public class ManejaHistorial : iMetodos
    {
        iBdMetodos manager;

        public ManejaHistorial()
        {
            manager = new BdMetodos();
        }
        public void Alta(IEntidad entidad)
        {
            clsHistorial hist = (clsHistorial)entidad;
            try
            {
                manager.ejecutar("Insert into historial(Id,diagnostico,observaciones,fecha) values('" + hist.Id + "','" + hist.Diagnostico + "'," + hist.Observaciones + "," + hist.Fecha +");SELECT @@identity;");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Baja(IEntidad entidad)
        {
            clsHistorial hist = (clsHistorial)entidad;
            try
            {
                manager.ejecutar("update historial set activo=0 where id=" + hist.Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Modificacion(IEntidad entidad)
        {
            clsHistorial hist = (clsHistorial)entidad;
            try
            {
                manager.ejecutar("update historial set diagnostico=" + hist.Diagnostico + ",observaciones=" + hist.Observaciones + ",fecha=" + hist.Fecha + "where id=" + hist.Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEntidad buscaPorId(int id)
        {
            DataTable aux = new DataTable();
            clsHistorial hist = new clsHistorial();
            try
            {
                aux = manager.consultar("select * from historial where id=" + id + " and activo=1");
                hist.Id = Convert.ToInt32(aux.Rows[0]["id"]);
                hist.Diagnostico = aux.Rows[0]["diagnostico"].ToString();
                hist.Observaciones= aux.Rows[0]["observaciones"].ToString();
                hist.Fecha = Convert.ToDateTime(aux.Rows[0]["fecha"]);
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return hist;
        }

        public System.Data.DataTable Todo(int pagina)
        {
            DataTable aux = new DataTable();
            try
            {
                
                aux = manager.consultar(" SELECT * FROM (SELECT *, ROW_NUMBER() OVER (ORDER BY ID) AS RowNum FROM historial) AS tabla WHERE activo=1 and  tabla.RowNum BETWEEN " + pagina * 10 + " AND " + (pagina * 10) + 10);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return aux;
        }

        public DataTable Busca(int id)
        {
            DataTable aux = new DataTable();
           
            try
            {
                aux = manager.consultar("select * from historial where id=" + id + " and activo=1");
               

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return aux;
        }
    }
}
