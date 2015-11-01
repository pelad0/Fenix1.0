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
    public class RepositorioUsuario
    {
        ManejaUsuario manejaUsuario = new ManejaUsuario();
        public void Alta(IEntidad usuario)
        {
            try
            {
                manejaUsuario.Alta(usuario);
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

        public void Baja(IEntidad usuario)
        {
            try
            {
                manejaUsuario.Baja(usuario);
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

        public void Modificacion(IEntidad usuario)
        {
            try
            {
                manejaUsuario.Modicacion(usuario);
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

        public clsUsuario buscarPorId(int id)
        {
            clsUsuario usu = new clsUsuario();
            try
            {
                usu=manejaUsuario.buscarPorId(id);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return usu;
        }

        public List<clsUsuario> Todo(int pag)
        {
            DataTable tabla;
            List<clsUsuario> lista = new List<clsUsuario>();
           
            tabla = manejaUsuario.Todo(pag);
            foreach (DataRow i in tabla.Rows)
            {

                clsMedico med = new clsMedico();

            }

            return lista;

        }

    }
}
