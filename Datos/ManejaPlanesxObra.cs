using System;
using entidades;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interfaces;

namespace Datos
{
    public class ManejaPlanesxObra : iMetodos
    {
        iBdMetodos manager;

        public ManejaPlanesxObra()
        {
            manager = new BdMetodos();
        }
        public void Alta(IEntidad entidad)
        {
            clsPlanesXObra ob = (clsPlanesXObra)entidad;

            try
            {
                manager.ejecutar("Insert into planesxobra(idobra,nombreplan,importe) values('" + ob.IdObra + ",'" + ob.NombrePlan + "',"+ob.Importe+");SELECT @@identity;");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Baja(IEntidad entidad)
        {
            clsPlanesXObra ob = (clsPlanesXObra)entidad;
            try
            {
                manager.ejecutar("update planesxobra set activo=0 where nombreplan=" + ob.NombrePlan + "and idobra=" + ob.IdObra);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Modificacion(IEntidad entidad)
        {
            clsPlanesXObra ob = (clsPlanesXObra)entidad;

            try
            {
                manager.ejecutar("update planesxobra set nombreplan='" + ob.NombrePlan + "'," + " importe=" + ob.Importe);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEntidad buscaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public System.Data.DataTable Todo(int pagina)
        {
            DataTable aux = new DataTable();
            try
            {


                aux = manager.consultar(" SELECT * FROM (SELECT *, ROW_NUMBER() OVER (ORDER BY nombreplan) AS RowNum FROM planesxobra) AS tabla WHERE activo=1 and  tabla.RowNum BETWEEN " + pagina * 10 + " AND " + (pagina * 10) + 10);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return aux;
        }


    }
}
