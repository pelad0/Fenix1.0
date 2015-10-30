using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interfaces;

namespace entidades
{
    public class clsRecibo:IEntidad
    {
        int id;
        int idFactura;
        double cobertura;
        double importe;
        string detalle;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }
       

        public int IdFactura
        {
            get { return idFactura; }
            set { idFactura = value; }
        }
       

        public double Cobertura
        {
            get { return cobertura; }
            set { cobertura = value; }
        }
        

        public double Importe
        {
            get { return importe; }
            set { importe = value; }
        }
       

        public string Detalle
        {
            get { return detalle; }
            set { detalle = value; }
        }

        public clsRecibo(int id,int idFactura,double cobertura,double importe,string detalle)
        {
            this.id = id;
            this.idFactura = idFactura;
            this.cobertura = cobertura;
            this.importe = importe;
            this.detalle = detalle;
        }

        public clsRecibo(int idFactura, double cobertura, double importe, string detalle)
        {
            
            this.idFactura = idFactura;
            this.cobertura = cobertura;
            this.importe = importe;
            this.detalle = detalle;
        }

    }
}
