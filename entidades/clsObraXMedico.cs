using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class clsObraXMedico
    {
        int idMedico;
        int idObra;

        public clsObraXMedico(int idMedico, int idObra)
        {
            this.idMedico = idMedico;
            this.idObra = idObra;
        }
        public int IdMedico
        {
            get { return idMedico; }
            set { idMedico = value; }
        }        

        public int IdObra
        {
            get { return idObra; }
            set { idObra = value; }
        }

       
    }
}
