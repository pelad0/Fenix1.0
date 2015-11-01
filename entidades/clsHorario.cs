using System;
using System.Collections.Generic;
using System.Linq;
using interfaces;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class clsHorario : IEntidad
    {
        int idMedico;

        public int IdMedico
        {
            get { return idMedico; }
            set { idMedico = value; }
        }
        DateTime lunesEntrada;
        DateTime lunesSalida;
        DateTime martesEntrada;
        DateTime martesSalida;
        DateTime miercolesEntrada;
        DateTime miercolesSalida;
        DateTime juevesEntrada;
        DateTime juevesSalida;
        DateTime viernesEntrada; 
        DateTime viernesSalida;
        DateTime sabadoEntrada;
        DateTime sabadoSalida;
        DateTime domingoEntrada;
        DateTime domingoSalida;

        public clsHorario(int idMedico, DateTime lunesEntrada, DateTime lunesSalida, DateTime martesEntrada, DateTime martesSalida, DateTime miercolesEntrada, DateTime miercolesSalida, DateTime juevesEntrada, DateTime juevesSalida, DateTime viernesEntrada, DateTime viernesSalida, DateTime sabadoEntrada, DateTime sabadoSalida, DateTime domingoEntrada, DateTime domingoSalida)
        {
            this.idMedico = idMedico;
            this.lunesEntrada =lunesEntrada;
            this.lunesSalida=lunesSalida;
            this.martesEntrada=martesEntrada;
            this.martesSalida=martesSalida;
            this.miercolesEntrada=miercolesEntrada;
            this.miercolesSalida=miercolesSalida;
            this.juevesEntrada=juevesEntrada;
            this.juevesSalida=juevesSalida;
            this.viernesEntrada=viernesEntrada;
            this.viernesSalida=viernesSalida;
            this.sabadoEntrada=sabadoEntrada;
            this.sabadoSalida=sabadoSalida;
            this.domingoEntrada=domingoEntrada;
            this.domingoSalida = domingoSalida;
        }

        public clsHorario(DateTime lunesEntrada, DateTime lunesSalida, DateTime martesEntrada, DateTime martesSalida, DateTime miercolesEntrada, DateTime miercolesSalida, DateTime juevesEntrada, DateTime juevesSalida, DateTime viernesEntrada, DateTime viernesSalida, DateTime sabadoEntrada, DateTime sabadoSalida, DateTime domingoEntrada, DateTime domingoSalida)
        {
            this.lunesEntrada = lunesEntrada;
            this.lunesSalida = lunesSalida;
            this.martesEntrada = martesEntrada;
            this.martesSalida = martesSalida;
            this.miercolesEntrada = miercolesEntrada;
            this.miercolesSalida = miercolesSalida;
            this.juevesEntrada = juevesEntrada;
            this.juevesSalida = juevesSalida;
            this.viernesEntrada = viernesEntrada;
            this.viernesSalida = viernesSalida;
            this.sabadoEntrada = sabadoEntrada;
            this.sabadoSalida = sabadoSalida;
            this.domingoEntrada = domingoEntrada;
            this.domingoSalida = domingoSalida;
        }

        public clsHorario()
        {

        }



        public DateTime LunesEntrada
        {
            get { return lunesEntrada; }
            set { lunesEntrada = value; }
        }
        

        public DateTime LunesSalida
        {
            get { return lunesSalida; }
            set { lunesSalida = value; }
        }
        

        public DateTime MartesEntrada
        {
            get { return martesEntrada; }
            set { martesEntrada = value; }
        }
        

        public DateTime MartesSalida
        {
            get { return martesSalida; }
            set { martesSalida = value; }
        }
        

        public DateTime MiercolesEntrada
        {
            get { return miercolesEntrada; }
            set { miercolesEntrada = value; }
        }
        

        public DateTime MiercolesSalida
        {
            get { return miercolesSalida; }
            set { miercolesSalida = value; }
        }
        

        public DateTime JuevesEntrada
        {
            get { return juevesEntrada; }
            set { juevesEntrada = value; }
        }
        

        public DateTime JuevesSalida
        {
            get { return juevesSalida; }
            set { juevesSalida = value; }
        }
        

        public DateTime ViernesEntrada
        {
            get { return viernesEntrada; }
            set { viernesEntrada = value; }
        }
        

        public DateTime ViernesSalida
        {
            get { return viernesSalida; }
            set { viernesSalida = value; }
        }
        

        public DateTime SabadoEntrada
        {
            get { return sabadoEntrada; }
            set { sabadoEntrada = value; }
        }
        

        public DateTime SabadoSalida
        {
            get { return sabadoSalida; }
            set { sabadoSalida = value; }
        }
        

        public DateTime DomingoEntrada
        {
            get { return domingoEntrada; }
            set { domingoEntrada = value; }
        }
        

        public DateTime DomingoSalida
        {
            get { return domingoSalida; }
            set { domingoSalida = value; }
        }


        public int Id
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
