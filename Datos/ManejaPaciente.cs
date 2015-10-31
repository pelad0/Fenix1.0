using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interfaces;
using entidades;
using System.Data;

namespace Datos
{
    public class ManejaPaciente: iMetodos
    {
        iBdMetodos manager;
        public ManejaPaciente()
        {
            manager = new BdMetodos();
        }


        public void Alta(IEntidad entidad)
        {
            clsPaciente pac = (clsPaciente)entidad;

            try
            {
                manager.ejecutar("Insert into paciente(nombre,apellido,dni,obra,telefono) values('" + pac.Nombre + "','" + pac.Apellido + "'," + pac.Dni + "," + pac.ObraSocial + "," + pac.Telefono + ");SELECT @@identity;");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }
        }

        public void Baja(IEntidad entidad)
        {
            clsPaciente pac = (clsPaciente)entidad;
            try
            {
                manager.ejecutar("update paciente set activo=0 where id=" + pac.Id);
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }

        public void Modificacion(IEntidad entidad)
        {
            clsPaciente pac = (clsPaciente)entidad;

            try
            {
                manager.ejecutar("update paciente set nombre="+pac.Nombre+","+"apellido="+pac.Apellido+","+"dni="+pac.Dni+","+"obra="+pac.ObraSocial+","+"telefono="+pac.Telefono);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEntidad buscaPorId(int id)
        {
            DataTable aux = new DataTable();
            clsPaciente pac = new clsPaciente();
            try
            {

                aux = manager.consultar("select * from medico where idmedico=" + id + "and activo=1");
                pac.Id = Convert.ToInt32(aux.Rows[0]["idPaciente"]);
                pac.Nombre = aux.Rows[0]["nombre"].ToString();
                pac.Apellido = aux.Rows[0]["apellido"].ToString();
                pac.Dni = Convert.ToInt64(aux.Rows[0]["dni"]);
                pac.ObraSocial = aux.Rows[0]["obra"];
                pac.Telefono = Convert.ToInt32(aux.Rows[0]["matricula"]);
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
                aux = manager.consultar("select * from paciente where activo=1");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return aux;
        }



    }
}
