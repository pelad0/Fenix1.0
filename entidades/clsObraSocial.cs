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
        float monto;

        public clsObraSocial()
        { }
        
        public clsObraSocial(int id, string nombre, float monto)
        {
            this.id = id;
            this.nombre = nombre;
            this.monto = monto;
        }

        public clsObraSocial(string nombre, float monto)
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

        public float Monto
        {
            get { return monto; }
            set { monto = value; }
        }
      
        public int pesos()
        {
            return (int)monto;
        }

        public int cent()
        {
            string numStr = monto.ToString();
            if (numStr.Split('.').Count() > 1)
            {
                int cent = int.Parse(numStr.Split('.')[1]);
                return cent;
            }
            else
            {
                return 00;
            }
        }
    }
}
