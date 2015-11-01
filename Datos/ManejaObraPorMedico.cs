﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaces;
using System.Threading.Tasks;
using entidades;
using System.Data;

namespace Datos
{
    public class ManejaObraPorMedico : iMetodos
    {
        iBdMetodos manager;
        public ManejaObraPorMedico()
        {
            manager = new BdMetodos();
        }
        public void Alta(IEntidad entidad)
        {
            clsObraXMedico ob = (clsObraXMedico)entidad;

            try
            {
                manager.ejecutar("Insert into obramedico(idmedico,idobra) values('" + ob.IdMedico + "," + ob.IdObra + ");SELECT @@identity;");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Baja(IEntidad entidad)
        {
            clsObraXMedico ob = (clsObraXMedico)entidad;
            try
            {
                manager.ejecutar("update obraXmedico set activo=0 where idmedico=" + ob.IdMedico+"and idobra="+ob.IdObra);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Modificacion(IEntidad entidad)
        {
            clsObraXMedico ob = (clsObraXMedico)entidad;

            try
            {
                manager.ejecutar("update obraXmedico set idobra=" + ob.IdObra + "," +" idmedico="+ob.IdMedico);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEntidad buscaPorId(int id)
        {
            DataTable aux = new DataTable();
            clsObraXMedico ob = new clsObraXMedico();
            try
            {

                aux = manager.consultar("select * from obraxmedico where idmedico=" + id + " and activo=1");
                ob.IdMedico = Convert.ToInt32(aux.Rows[0]["idmedico"]);
                ob.IdObra = Convert.ToInt32(aux.Rows[0]["idobra"]);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ob;
        }

        public System.Data.DataTable Todo(int pagina)
        {
            DataTable aux = new DataTable();
            try
            {
                

                aux = manager.consultar(" SELECT * FROM (SELECT *, ROW_NUMBER() OVER (ORDER BY Idmedico) AS RowNum FROM obraxmedico) AS tabla WHERE activo=1 and  tabla.RowNum BETWEEN" + pagina * 10 + " AND " + (pagina * 10) + 10);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return aux;
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
