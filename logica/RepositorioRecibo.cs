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
    public class RepositorioRecibo
    {
        ManejaRecibo manejarecibo = new ManejaRecibo();

        public void Alta(IEntidad recibo)
        {
            try
            {

                manejarecibo.Alta(recibo);
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

        public void Baja(IEntidad recibo)
        {
             try
            {
                manejarecibo.Baja(recibo);
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

        public void Modificacion(IEntidad recibo)
        {
            try
            {
                manejarecibo.Modificacion(recibo);
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
        public clsRecibo buscarPorId(int id)
        {

            clsRecibo rec;
            try
            {
                rec =(clsRecibo) manejarecibo.buscaPorId(id);

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

        public List<clsRecibo> Todo(int pag)
        {
            DataTable tabla;
            List<clsRecibo> lista = new List<clsRecibo>();
            
            tabla =manejarecibo.Todo(pag);

            foreach (DataRow aux in tabla.Rows)
            {
                clsRecibo rec = new clsRecibo();
                
                rec.Id = Convert.ToInt32(aux["id"]);
                rec.Detalle= aux["detalle"].ToString();
                rec.IdFactura = Convert.ToInt32(aux["idFactura"]);
                rec.Cobertura = float.Parse(aux["cobertura"].ToString());
                rec.Importe = float.Parse(aux["importe"].ToString());
                
               lista.Add(rec);
            }

            return lista;

        }

    }
}
