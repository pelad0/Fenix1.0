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
    public class RepositorioHorario
    {

        ManejaHorarioMañana manejamañana = new ManejaHorarioMañana();
        ManejaHorarioTarde manejatarde = new ManejaHorarioTarde();

        public void Alta(IEntidad Hm,IEntidad Ht)
        {
            try
            {
                manejamañana.Alta(Hm);
                manejatarde.Alta(Ht);                
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
        public void Alta(IEntidad Hr,int var)
        {
            try
            {
                if(var==1)
                  manejamañana.Alta(Hr);                   
                else
                   manejatarde.Alta(Hr);

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

        public void Baja(IEntidad Hm, IEntidad Ht)
        {
            try
            {
                manejamañana.Baja(Hm);
                manejatarde.Baja(Ht);

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
        public void Baja(IEntidad Hr, int var) 
        {

            try
            {
                if (var == 1)
                    manejamañana.Baja(Hr);
                else
                    manejatarde.Baja(Hr);

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

        public void Modificacion(IEntidad Hm, IEntidad Ht)
        {
            try
            {
                manejamañana.Modificacion(Hm);
                manejatarde.Modificacion(Ht);

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
        public void Modificacion(IEntidad Hr, int var) 
        {

            try
            {
                if (var == 1)
                    manejamañana.Alta(Hr);
                else
                    manejatarde.Alta(Hr);

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


        public clsHorario buscarPorId(int id,int var) 
        {
            clsHorario hr;
            try
            {
                if (var == 1)
                   hr=(clsHorario) manejamañana.buscaPorId(id);
                else
                    hr=(clsHorario)manejatarde.buscaPorId(id);

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return hr;
        }

        public List<clsHorario> Todo(int pag,int var)
        {
            DataTable tabla;
            List<clsHorario> lista = new List<clsHorario>();
            if (var == 1)
                tabla = manejamañana.Todo(var);
            else
                tabla = manejatarde.Todo(var);
             
            foreach (DataRow aux in tabla.Rows)
            {
                               

            }

            return lista;
        }
       
    }
}
