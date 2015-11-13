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
        int idSobreTurno;     
        int idTurno;
        DateTime fecha;
        
        double cobertura;
        double importe;
        string detalle;



        public clsRecibo()
        {

        }

        public clsRecibo(int id, int idFactura, int idSobreTurno, int idTurno, DateTime fecha, double cobertura, double importe, string detalle)
        {
            this.id = id;
            this.idFactura = idFactura;
            this.idSobreTurno = idSobreTurno;
            this.idTurno = idTurno;
            this.fecha = fecha;
            this.cobertura = cobertura;
            this.importe = importe;
            this.detalle = detalle;
        }

        public clsRecibo(int idFactura, int idSobreTurno, int idTurno, DateTime fecha, double cobertura, double importe, string detalle)
        {
            this.idFactura = idFactura;
            this.idSobreTurno = idSobreTurno;
            this.idTurno = idTurno;
            this.fecha = fecha;
            this.cobertura = cobertura;
            this.importe = importe;
            this.detalle = detalle;
        }




        public int IdSobreTurno
        {
            get { return idSobreTurno; }
            set { idSobreTurno = value; }
        }



        public int IdTurno
        {
            get { return idTurno; }
            set { idTurno = value; }
        }


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


        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        

    }
}
