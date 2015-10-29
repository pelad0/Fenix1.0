using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaces;
using System.Data;
using System.Threading.Tasks;

namespace Datos
{
     public class BdMetodos : iBdMetodos
    {
         //comment 

         public int ejecutar(String sql)
         {
             return 9;
         }


         public DataTable Consultar()
         {
             throw new NotImplementedException();
         }
    }
}
