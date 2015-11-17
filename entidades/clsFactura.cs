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
        string cuitcliente;
        int numeroFactura;
        string tipoFactura;
        string razonSocial;
        int terminal;        
        float total;
        DateTime fecha;
        int idUsuario;
        string cliente;
        float pagoEfectivo;
        float pagoTarjeta;


        public string Cuitcliente
        {
            get { return cuitcliente; }
            set { cuitcliente = value; }
        }


        public int Terminal
        {
            get { return terminal; }
            set { terminal = value; }
        }
        


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
       

        public string TipoFactura
        {
            get { return tipoFactura; }
            set { tipoFactura = value; }
        }
        

        public string RazonSocial
        {
            get { return razonSocial; }
            set { razonSocial = value; }
        }
        

        public float Total
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
       

        public float PagoEfectivo
        {
            get { return pagoEfectivo; }
            set { pagoEfectivo = value; }
        }
       

        public float PagoTarjeta
        {
            get { return pagoTarjeta; }
            set { pagoTarjeta = value; }
        }

        public clsFactura()
        {

        }

        public clsFactura(int id, int numeroFactura,string tipoFactura,string razonSocial,int terminal, string cuitcliente, float total, DateTime fecha,int idUsuario,string cliente,float pagoEfectivo, float pagoTarjeta)
        {
            this.id = id;
            this.numeroFactura = numeroFactura;
            this.tipoFactura = tipoFactura;
            this.razonSocial = razonSocial;
            this.terminal = terminal;
            this.cuitcliente = cuitcliente;
            this.total = total;
            this.fecha = fecha;
            this.idUsuario = idUsuario;
            this.cliente = cliente;
            this.pagoEfectivo = pagoEfectivo;
            this.pagoTarjeta = pagoTarjeta;


        }
        public clsFactura(int numeroFactura, string tipoFactura, string razonSocial, int terminal, string cuitcliente, float total, DateTime fecha, int idUsuario, string cliente, float pagoEfectivo, float pagoTarjeta)
        {

            this.numeroFactura = numeroFactura;
            this.tipoFactura = tipoFactura;
            this.razonSocial = razonSocial;
            this.terminal = terminal;
            this.cuitcliente = cuitcliente;
            this.total = total;
            this.fecha = fecha;
            this.idUsuario = idUsuario;
            this.cliente = cliente;
            this.pagoEfectivo = pagoEfectivo;
            this.pagoTarjeta = pagoTarjeta;
        }

    }
}
