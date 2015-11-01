using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interfaces;

namespace entidades
{
    public class clsObraXMedico : IEntidad
    {
        int idMedico;
        int idObra;

        public clsObraXMedico()
        {

        }

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
