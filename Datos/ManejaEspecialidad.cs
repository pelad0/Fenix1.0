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
    public class ManejaEspecialidad : iMetodos
    {

        iBdMetodos manager;

        public ManejaEspecialidad()
        {
            manager = new BdMetodos();
        }
        public void Alta(IEntidad entidad)
        {
            clsEspecialidad ent = (clsEspecialidad)entidad;
            try
            {
                manager.ejecutar("Insert into especialidad(descripcion) values('"+ent.Descripcion+"');SELECT @@identity;");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Baja(IEntidad entidad)
        {
            clsEspecialidad esp = (clsEspecialidad)entidad;
            try
            {
                manager.ejecutar("update especialidad set activo=0 where id=" + esp.Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Modificacion(IEntidad entidad)
        {
            clsEspecialidad esp = (clsEspecialidad)entidad;
            try
            {
                manager.ejecutar("update especialidad set descripcion='"+esp.Descripcion+"'");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEntidad buscaPorId(int id)
        {
            DataTable aux = new DataTable();
            clsEspecialidad esp = new clsEspecialidad();
            try
            {
                aux = manager.consultar("select * from especialidad where id=" + id + "and activo=1");
                esp.Id = Convert.ToInt32(aux.Rows[0]["id"]);
                esp.Descripcion = aux.Rows[0]["descripcion"].ToString();
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return esp;
        }

        public System.Data.DataTable Todo()
        {
            DataTable aux = new DataTable();
            try
            {
                aux = manager.consultar("select * from especialidad where activo=1");
                //aux = manager.consultar(" SELECT * FROM (SELECT *, ROW_NUMBER() OVER (ORDER BY ID) AS RowNum FROM especialidad) AS tabla WHERE activo=1 and  tabla.RowNum BETWEEN" + pagina * 10 + "AND" + (pagina * 10) + 10);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return aux;

        }


        public IEntidad buscaPorNombre(string nombre)
        {
            DataTable aux = new DataTable();
            clsEspecialidad esp = new clsEspecialidad();
            try
            {
                aux = manager.consultar("select * from especialidad where descripcion='" + nombre + "' and activo=1");
                esp.Id = Convert.ToInt32(aux.Rows[0]["id"]);
                esp.Descripcion = aux.Rows[0]["descripcion"].ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return esp;
        }


        public DataTable Todo(int pagina)
        {
            throw new NotImplementedException();
        }
    }
}
