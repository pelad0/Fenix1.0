using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaces;
using System.Data;
using System.Threading.Tasks;

namespace Datos
{
    class ManejaClinica: iMetodos
    {
        iBdMetodos manager;
        public ManejaClinica()
        {
            manager = new BdMetodos();
        }
        public void Alta(IEntidad entidad)
        {
            throw new NotImplementedException();
        }

        public void Baja(IEntidad entidad)
        {
            throw new NotImplementedException();
        }

        public void Modificacion(IEntidad entidad)
        {
            throw new NotImplementedException();
        }

        public IEntidad buscaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable Todo(int pagina)
        {
            DataTable aux = new DataTable();
            try
            {
                //aux = manager.consultar("select * from paciente where activo=1");

                aux = manager.consultar(" SELECT * FROM clinica");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return aux;
        }
        
    }
}
