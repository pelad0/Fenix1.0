﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaces;
using entidades;
using System.Threading.Tasks;
using System.Data;

namespace Datos
{
    public class ManejaObraSocial : iMetodos
    {
         iBdMetodos manager;
        public ManejaObraSocial()
        {
            manager = new BdMetodos();
        }

        public void Alta(IEntidad entidad)
        {
            clsObraSocial ob = (clsObraSocial)entidad;

            try
            {
                manager.ejecutar("Insert into obrasocial(nombre) values('"+ob.Nombre+"');SELECT @@identity;");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /*
         * 
create table obrasocial
(
id int identity(1,1) primary key,
nombre char(20) not null,
activo bit default 1
)
         */ 
        public void Baja(IEntidad entidad)
        {
            clsObraSocial ob = (clsObraSocial)entidad;
            try
            {
                manager.ejecutar("update obrasocial set activo=0 where id=" + ob.Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Modificacion(IEntidad entidad)
        {
            clsObraSocial ob = (clsObraSocial)entidad;

            try
            {
                manager.ejecutar("update obrasocial set nombre=" + ob.Nombre );
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEntidad buscaPorId(int id)
        {
            DataTable aux = new DataTable();
            clsObraSocial pac = new clsObraSocial();
            try
            {

                aux = manager.consultar("select * from obrasocial where id=" + id + " and activo=1");
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return pac;
        }

        public DataTable Todo(int pagina)
        {
            DataTable aux = new DataTable();
            try
            {
               aux = manager.consultar("select * from obrasocial where activo=1");

               // aux = manager.consultar(" SELECT * FROM (SELECT *, ROW_NUMBER() OVER (ORDER BY ID) AS RowNum FROM obrasocial) AS tabla WHERE activo=1 and tabla.RowNum BETWEEN" + pagina * 10 + "AND" + (pagina * 10) + 10);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return aux;
        }

       
    }
}
