using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interfaces;


namespace entidades
{
    public class clsFactura : IEntidad
    {
        int id;
        int numeroFactura;
        char tipoFactura;
        string razonSocial;
        string terminal;
        string cuitcliente;

        public string Cuitcliente
        {
            get { return cuitcliente; }
            set { cuitcliente = value; }
        }


        public string Terminal
        {
            get { return terminal; }
            set { terminal = value; }
        }
        double total;
        DateTime fecha;
        int idUsuario;
        string cliente;
        double pagoEfectivo;
        double pagoTarjeta;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        

        public int NumeroFactura
        {
            get { return numeroFactura; }
            set { numeroFactura = value; }
        }
       

        public char TipoFactura
        {
            get { return tipoFactura; }
            set { tipoFactura = value; }
        }
        

        public string RazonSocial
        {
            get { return razonSocial; }
            set { razonSocial = value; }
        }
        

        public double Total
        {
            get { return total; }
            set { total = value; }
        }
       

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        

        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }
      

        public string Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }
       

        public double PagoEfectivo
        {
            get { return pagoEfectivo; }
            set { pagoEfectivo = value; }
        }
       

        public double PagoTarjeta
        {
            get { return pagoTarjeta; }
            set { pagoTarjeta = value; }
        }

        public clsFactura()
        {

        }

        public clsFactura(int id, int numeroFactura,char tipoFactura,string razonSocial,double total, DateTime fecha,int idUsuario,string cliente,double pagoEfectivo, double pagoTarjeta)
        {
            this.id = id;
            this.numeroFactura = numeroFactura;
            this.tipoFactura = tipoFactura;
            this.razonSocial = razonSocial;
            this.total = total;
            this.fecha = fecha;
            this.idUsuario = idUsuario;
            this.cliente = cliente;
            this.pagoEfectivo = pagoEfectivo;
            this.pagoTarjeta = pagoTarjeta;
        }
        public clsFactura(int numeroFactura, char tipoFactura, string razonSocial, double total, DateTime fecha, int idUsuario, string cliente, double pagoEfectivo, double pagoTarjeta)
        {
            
            this.numeroFactura = numeroFactura;
            this.tipoFactura = tipoFactura;
            this.razonSocial = razonSocial;
            this.total = total;
            this.fecha = fecha;
            this.idUsuario = idUsuario;
            this.cliente = cliente;
            this.pagoEfectivo = pagoEfectivo;
            this.pagoTarjeta = pagoTarjeta;
        }

    }
}
