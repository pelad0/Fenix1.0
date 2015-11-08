using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interfaces;

namespace entidades
{
    public class clsObraSocial : IEntidad
    {
        private int id;
        string nombre;
        double monto;

        public clsObraSocial()
        { }
        
        public clsObraSocial(int id, string nombre, double monto)
        {
            this.id = id;
            this.nombre = nombre;
            this.monto = monto;
        }

        public clsObraSocial(string nombre, double monto)
        {
            this.nombre = nombre;
            this.monto = monto;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public double Monto
        {
            get { return monto; }
            set { monto = value; }
        }
      
    }
}
