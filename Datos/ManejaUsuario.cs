using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interfaces;
using entidades;
using System.Data;

namespace Datos
{
    public class ManejaUsuario: iMetodos
    {
        iBdMetodos manager;
        public ManejaUsuario()
        {
            manager = new BdMetodos();
        }

        public void Alta(IEntidad entidad)
        {
            clsUsuario us = (clsUsuario)entidad;
            try
            {
                manager.ejecutar("Insert into usuario(user,pass,seguridad) values('"+us.Id+"','"+us.Usuario+"','"+us.Seguridad+"');SELECT @@identity;");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Baja(IEntidad entidad)
        {
            clsUsuario us = (clsUsuario)entidad;
            try
            {
                manager.ejecutar("update usuario set activo=0 where id="+us.Id);

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void Modificacion(IEntidad entidad)
        {
            clsUsuario us = (clsUsuario)entidad;
            try
            {
                manager.ejecutar("update usuario set user="+us.Usuario+",pass="+us.Clave+",seguridad="+us.Seguridad+" where id="+us.Id);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEntidad buscaPorId(int id)
        {

                DataTable aux = new DataTable();
                clsUsuario us = new clsUsuario();
                try
                {

                    aux = manager.consultar("select * from usuario where id=" + id + " and activo=1");
                    us.Id = Convert.ToInt32(aux.Rows[0]["id"]);
                    us.Seguridad = aux.Rows[0]["seguridad"].ToString();
                    us.Clave = aux.Rows[0]["pass"].ToString();
                    us.Usuario = aux.Rows[0]["user"].ToString();
                   
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return us;


        }

        public DataTable Todo(int pagina)
        {
            DataTable aux = new DataTable();
            try
            {
                aux = manager.consultar("select * from usuario where activo=1");
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return aux;
        }
    }
}
