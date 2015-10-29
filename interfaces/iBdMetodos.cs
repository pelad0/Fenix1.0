using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace interfaces
{
    public interface iBdMetodos
    {
        int ejecutar(String sql);
        DataTable Consultar();

    }
}
