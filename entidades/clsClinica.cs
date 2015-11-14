using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interfaces;

namespace entidades
{
    class clsClinica : IEntidad
    {

        DateTime fechaInicioActividades;        
        string cuit;        
        float ingresosBrutos;        
        string nombreFantasia;        
        string razonSocial;        
        string domicilioComercial;        
        string domicilioFiscal;       


        public clsClinica(DateTime fechaInicioActividades, string cuit, float ingresosBrutos, string nombreFantasia, string razonSocial, string domicilioComercial, string domicilioFiscal)
        {
            this.fechaInicioActividades = fechaInicioActividades;
            this.cuit = cuit;
            this.ingresosBrutos = ingresosBrutos;
            this.nombreFantasia = nombreFantasia;
            this.razonSocial = razonSocial;
            this.domicilioComercial = domicilioComercial;

        }

        public clsClinica()
        {

        }

        public string DomicilioFiscal
        {
            get { return domicilioFiscal; }
            set { domicilioFiscal = value; }
        }

        public string DomicilioComercial
        {
            get { return domicilioComercial; }
            set { domicilioComercial = value; }
        }

        public string RazonSocial
        {
            get { return razonSocial; }
            set { razonSocial = value; }
        }

        public string NombreFantasia
        {
            get { return nombreFantasia; }
            set { nombreFantasia = value; }
        }

        public float IngresosBrutos
        {
            get { return ingresosBrutos; }
            set { ingresosBrutos = value; }
        }

        public string Cuit
        {
            get { return cuit; }
            set { cuit = value; }
        }

        public DateTime FechaInicioActividades
        {
            get { return fechaInicioActividades; }
            set { fechaInicioActividades = value; }
        }


    }
}
