﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interfaces;
using entidades;
using System.Data;

namespace Datos
{
    public class ManejaHorarioTarde
    {
        
        iBdMetodos manager;

        public ManejaHorarioTarde()
        {
            manager = new BdMetodos();
        }
        public void Alta(IEntidad entidad)
        {
            clsHorario ent = (clsHorario)entidad;
            DataTable aux = new DataTable();

            try
            {
                 aux = manager.consultar("select * from horarioTarde where idmedico=" + ent.IdMedico);

                 if (aux.Rows.Count == 0)
                 {
                     manager.ejecutar("Insert into horarioTarde(idmedico,lunesentrada,lunessalida,martesentrada,martessalida,miercolesentrada,miercolessalida,juevesentrada,juevessalida,viernesentrada,viernessalida,sabadoentrada,sabadosalida,domingoentrada,domingosalida) values(" + ent.IdMedico + ",'" + ent.LunesEntrada + "','" + ent.LunesSalida + "','" + ent.MartesEntrada + "','" + ent.MartesSalida + "','" + ent.MiercolesEntrada + "','" + ent.MiercolesSalida + "','" + ent.JuevesEntrada + "','" + ent.JuevesSalida + "','" + ent.ViernesEntrada + "','" + ent.ViernesSalida + "','" + ent.SabadoEntrada + "','" + ent.SabadoSalida + "','" + ent.DomingoEntrada + "','" + ent.DomingoSalida + "')");
                 }
                 else
                 {
                     if (Convert.ToInt32(aux.Rows[0]["activo"]) == 0)
                     {
                         manager.ejecutar("update horarioTarde set activo=1 where idmedico=" + ent.IdMedico);
                         manager.ejecutar("update horarioTarde set lunesentrada='" + ent.LunesEntrada + "',lunessalida='" + ent.LunesSalida + "',martesentrada='" + ent.MartesEntrada + "',martessalida='" + ent.MartesSalida + "',miercolesentrada='" + ent.MiercolesEntrada + "',miercolessalida='" + ent.MiercolesSalida + "',juevesentrada='" + ent.JuevesEntrada + "',juevessalida='" + ent.JuevesSalida + "',viernesentrada='" + ent.ViernesEntrada + "',viernessalida='" + ent.ViernesSalida + "',sabadoentrada='" + ent.SabadoEntrada + "',sabadosalida='" + ent.SabadoSalida + "',domingoentrada='" + ent.DomingoEntrada + "',domingosalida='" + ent.DomingoSalida + "' where idmedico=" + ent.IdMedico);

                     }
                 }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Baja(IEntidad entidad)
        {
            clsHorario esp = (clsHorario)entidad;
            try
            {
                manager.ejecutar("update horarioTarde set activo=0 where idmedico=" + esp.IdMedico);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Modificacion(IEntidad entidad)
        {
            clsHorario esp = (clsHorario)entidad;
            try
            {
                manager.ejecutar("update horarioTarde set lunesentrada='" + esp.LunesEntrada+"',lunessalida='"+esp.LunesSalida+"',martesentrada='"+esp.MartesEntrada+"',martessalida='"+esp.MartesSalida+"',miercolesentrada='"+esp.MiercolesEntrada+"',miercolessalida='"+esp.MiercolesSalida+"',juevesentrada='"+esp.JuevesEntrada+"',juevessalida='"+esp.JuevesSalida+"',viernesentrada='"+esp.ViernesEntrada+"',viernessalida='"+esp.ViernesSalida+"',sabadoentrada='"+esp.SabadoEntrada+"',sabadosalida='"+esp.SabadoSalida+"',domingoentrada='"+esp.DomingoEntrada+"',domingosalida='"+esp.DomingoSalida+"' where idmedico="+esp.IdMedico);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEntidad buscaPorId(int id)
        {
            DataTable aux = new DataTable();
            clsHorario esp = new clsHorario();
            try
            { 
                   aux = manager.consultar("select * from horarioTarde where idmedico=" + id + " and activo=1");
           
                    esp.IdMedico = Convert.ToInt32(aux.Rows[0]["idmedico"]);                
                    esp.LunesEntrada = Convert.ToDateTime(aux.Rows[0]["lunesentrada"]);
                    esp.LunesSalida = Convert.ToDateTime(aux.Rows[0]["lunessalida"]);
                    esp.MartesEntrada = Convert.ToDateTime(aux.Rows[0]["martesentrada"]);
                    esp.MartesSalida = Convert.ToDateTime(aux.Rows[0]["martessalida"]);
                    esp.MiercolesEntrada = Convert.ToDateTime(aux.Rows[0]["miercolesentrada"]);
                    esp.MiercolesSalida = Convert.ToDateTime(aux.Rows[0]["miercolessalida"]);
                    esp.JuevesEntrada = Convert.ToDateTime(aux.Rows[0]["juevesentrada"]);
                    esp.JuevesSalida = Convert.ToDateTime(aux.Rows[0]["juevessalida"]);
                    esp.ViernesEntrada = Convert.ToDateTime(aux.Rows[0]["viernesentrada"]);
                    esp.ViernesSalida = Convert.ToDateTime(aux.Rows[0]["viernessalida"]);
                    esp.SabadoEntrada = Convert.ToDateTime(aux.Rows[0]["sabadoentrada"]);
                    esp.SabadoSalida = Convert.ToDateTime(aux.Rows[0]["sabadosalida"]);
                    esp.DomingoEntrada = Convert.ToDateTime(aux.Rows[0]["domingoentrada"]);
                    esp.DomingoSalida = Convert.ToDateTime(aux.Rows[0]["domingosalida"]);
                               

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return esp;
        }

        public System.Data.DataTable Todo(int pagina)
        {
            DataTable aux = new DataTable();
            try
            {
                aux = manager.consultar("select * from horarioTarde where activo=1");
                //aux = manager.consultar(" SELECT * FROM (SELECT *, ROW_NUMBER() OVER (ORDER BY ID) AS RowNum FROM especialidad) AS tabla WHERE activo=1 and  tabla.RowNum BETWEEN" + pagina * 10 + "AND" + (pagina * 10) + 10);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return aux;
        }


    }
}
