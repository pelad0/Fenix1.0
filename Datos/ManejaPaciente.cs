using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interfaces;

namespace Datos
{
    public class ManejaPaciente: iMetodos
    {
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

        public System.Data.DataTable Todo(int pagina)
        {
            throw new NotImplementedException();
        }

        public int Id
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
