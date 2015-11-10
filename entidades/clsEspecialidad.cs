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
        float canon;

       

        public clsEspecialidad() 
        {
        
        }

        public clsEspecialidad(int id,string descripcion, float canon)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.canon = canon;
        }

        public clsEspecialidad(string descripcion, float canon)
        {
            
            this.descripcion = descripcion;
            this.canon = canon;
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

        public float Canon
        {
            get { return canon; }
            set { canon = value; }
        }

               
    }
}
