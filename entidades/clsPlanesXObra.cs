using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class clsPlanesXObra
    {
        int idObra;

        public int IdObra
        {
            get { return idObra; }
            set { idObra = value; }
        }
        string nombrePlan;

        public string NombrePlan
        {
            get { return nombrePlan; }
            set { nombrePlan = value; }
        }
        double importe;

        public double Importe
        {
            get { return importe; }
            set { importe = value; }
        }

        public clsPlanesXObra()
        {

        }

        public clsPlanesXObra(int idObra,string nombrePlan,double importe)
        {
            this.idObra = idObra;
            this.nombrePlan = nombrePlan;
            this.importe = importe;
        }
    }
}
