using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interfaces;


namespace entidades
{
    public class clsEspecialidad:IEntidad
    {
        int id;
        string descripcion;

        public clsEspecialidad(int id,string descripcion)
        {
            this.id = id;
            this.descripcion = descripcion;
        }

        public clsEspecialidad(string descripcion)
        {
            
            this.descripcion = descripcion;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }


               
    }
}
