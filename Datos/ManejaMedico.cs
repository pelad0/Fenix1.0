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
    public class ManejaMedico : iMetodos
    {
        iBdMetodos manager;

        public ManejaMedico()
        {
            manager=new BdMetodos();
        }

        public void Alta(IEntidad entidad)
        {
            clsMedico med = (clsMedico)entidad;
            try
            {
                manager.ejecutar("Insert into medico(nombre,apellido,dni,especialidad,matricula) values('" + med.Nombre + "','" + med.Apellido + "'," + med.Dni + "," + med.Especialidad + "," + med.Matricula + ");SELECT @@identity;");
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
            clsMedico med = (clsMedico)entidad;
            try
            {
                manager.ejecutar("update medico set activo=0 where id=" + med.Id);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void Modificacion(IEntidad entidad)
        {
            clsMedico med = (clsMedico)entidad;
            try
            {
                manager.ejecutar("update medico set nombre="+med.Nombre+",apellido="+med.Apellido+",dni="+med.Dni+",especialidad="+med.Especialidad+",matricula="+med.Matricula+ "where id=" + med.Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEntidad buscaPorId(int id)
        {
            DataTable aux = new DataTable();
            clsMedicoDatos med = new clsMedicoDatos();
            try
            {
               aux=manager.consultar("select * from medico where id="+id+" and activo=1");
                med.Id = Convert.ToInt32(aux.Rows[0]["id"]);
                med.Nombre = aux.Rows[0]["nombre"].ToString();
                med.Apellido = aux.Rows[0]["apellido"].ToString();
                med.Dni = Convert.ToInt64(aux.Rows[0]["dni"]);
                med.Matricula = Convert.ToInt32(aux.Rows[0]["matricula"]);
                med.Especialidad=Convert.ToInt32(aux.Rows[0]["especialidad"]);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            /*
             
            clsPaciente P = new clsPaciente();
            try
            {
                aux =manejar.Consultar("select * from paciente where idPaciente="+id);
                */
            return med;
        }

        public DataTable Todo(int pagina)
        {
            DataTable aux = new DataTable();
            try
            {
              //  aux = manager.consultar("select * from medico where activo=1");
                aux = manager.consultar(" SELECT * FROM (SELECT *, ROW_NUMBER() OVER (ORDER BY ID) AS RowNum FROM medico) AS tabla WHERE activo=1 and  tabla.RowNum BETWEEN " + pagina * 10 + " AND " + (pagina * 10) + 10);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return aux;
        }

   
    }
}
