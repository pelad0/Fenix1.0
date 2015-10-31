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
    public class RepositorioObraSocial
    {

        public void Alta(IEntidad obraSocial)
        {
            ManejaObraSocial manejaOs = new ManejaObraSocial();
            try
            {
                manejaOs.Alta(obraSocial);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
            
    }
}
