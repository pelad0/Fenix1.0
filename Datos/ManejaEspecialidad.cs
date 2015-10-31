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
        public void Alta(IEntidad entidad)
        {
            clsEspecialidad ent = (clsEspecialidad)entidad;
            try
            {
                manager.ejecutar("Insert into especialidad(descripcion) values('"+ent.Descripcion+");SELECT @@identity;");
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
                manager.ejecutar("update especialidad set activo=0 where id=" + esp.Descripcion);
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
                manager.ejecutar("update especialidad set descripcion="+esp.Descripcion);
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
                aux = manager.consultar("select * from medico where idmedico=" + id + "and activo=1");
                esp.Id = Convert.ToInt32(aux.Rows[0]["id"]);
                esp.Descripcion = aux.Rows[0]["descripcion"].ToString();
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return esp;
        }

        public System.Data.DataTable Todo(int pagina)
        {
            DataTable aux = new DataTable();
            try
            {
                aux = manager.consultar("select * from especialidad where activo=1");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return aux;

        }

    }
}
