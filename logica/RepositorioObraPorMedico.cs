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
    public class RepositorioObraPorMedico
    {
        ManejaObraPorMedico manejaobraxmedico = new ManejaObraPorMedico();

        public void Alta(IEntidad omed)
        {
            try
            {

                manejaobraxmedico.Alta(omed);
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

        public void Baja(IEntidad omed)
        {
            try
            {
                manejaobraxmedico.Baja(omed);
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

        public void Modificacion(IEntidad omed)
        {
            try
            {
                manejaobraxmedico.Modificacion(omed);
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

        public clsObraXMedico buscarPorId(int id)
        {

            clsObraXMedico omed;
            try
            {
                omed = (clsObraXMedico)manejaobraxmedico.buscaPorId(id);

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }


            return omed;
        }

        public List<clsObraXMedico> TodasObras(int id)
        {
            DataTable tabla;
            List<clsObraXMedico> lista = new List<clsObraXMedico>();

            tabla = manejaobraxmedico.Todo(id);

            foreach (DataRow aux in tabla.Rows)
            {
                clsObraXMedico ob = new clsObraXMedico();

                ob.IdMedico = Convert.ToInt32(aux["idmedico"]);
                ob.IdObra = Convert.ToInt32(aux["idobra"]);

                lista.Add(ob);
            }

            return lista;

        }

        public List<clsObraXMedico> Todo(int pag)
        {
            DataTable tabla;
            List<clsObraXMedico> lista = new List<clsObraXMedico>();

            tabla = manejaobraxmedico.Todo(pag);

            foreach (DataRow aux in tabla.Rows)
            {
                clsObraXMedico ob = new clsObraXMedico();

                ob.IdMedico = Convert.ToInt32(aux["idmedico"]);
                ob.IdObra = Convert.ToInt32(aux["idobra"]);

                lista.Add(ob);
            }

            return lista;

        }

    }
}
