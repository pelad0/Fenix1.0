using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interfaces;
using System.Data;
using entidades;

namespace Datos
{
    public class ManejaTurno: iMetodos
    {

        iBdMetodos manager;

        public ManejaTurno()
        {
            manager = new BdMetodos();
        }
        public void Alta(IEntidad entidad)
        {
            clsTurno tur = (clsTurno)entidad;
            try
            {
               // manager.ejecutar("Insert into turno(idpaciente,idmedico,fecha,costo,estado,idusuario) values(" + tur.IdPaciente + "," + tur.IdMedico + ",'" + tur.Fecha + "'," + tur.Costo + "," + 0 +","+tur.IdUsuario+");SELECT @@identity;");
                manager.ejecutar("exec insertarTurno "+tur.IdPaciente+","+tur.IdMedico+",'"+tur.Fecha+"',"+tur.Costo+","+0+","+tur.IdUsuario);
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
            clsTurno tur = (clsTurno)entidad;
            try
            {
                manager.ejecutar("update turno set activo=0 where id=" + tur.Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Modificacion(IEntidad entidad)
        {
            clsTurno tur = (clsTurno)entidad;
            try
            {
                manager.ejecutar("update turno set idpaciente=" + tur.IdPaciente + ",idmedico=" + tur.IdMedico + ",fecha='" + tur.Fecha+ "',costo=" +tur.Costo + ",estado=" + tur.Estado +",idusuario= "+tur.IdUsuario+"where id=" + tur.Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void ActualizarAsistencia(int id)
        {
             try
            {
                manager.ejecutar("update turno set estado=" + true + " where id=" + id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEntidad buscaPorId(int id)
        {
            DataTable aux = new DataTable();
            clsTurno tur = new clsTurno();
            try
            {
                aux=manager.consultar("select * from turno where id="+id+" and activo=1");
                tur.Id = Convert.ToInt32(aux.Rows[0]["id"]);
                tur.IdMedico = Convert.ToInt32(aux.Rows[0]["idmedico"]);
                tur.IdPaciente = Convert.ToInt32(aux.Rows[0]["idpaciente"]);
                tur.Fecha = Convert.ToDateTime(aux.Rows[0]["fecha"]);
                tur.Costo = Convert.ToDouble(aux.Rows[0]["costo"]);
                tur.Estado=Convert.ToBoolean(aux.Rows[0]["estado"]);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return tur;
        }

        public DataTable Todo(int pagina)
        {
            DataTable aux = new DataTable();
            try
            {
              //  aux = manager.consultar("select * from turno where activo=1");
                aux = manager.consultar(" SELECT * FROM (SELECT *, ROW_NUMBER() OVER (ORDER BY ID) AS RowNum FROM turno) AS tabla WHERE activo=1 and  tabla.RowNum BETWEEN " + pagina * 10 + " AND " + (pagina * 10) + 10);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return aux;
        }


        public DataTable BuscarTurnoPorMedico(int id,string fecha)
        {
            DataTable aux = new DataTable();
            try
            {
                aux = manager.consultar("select * from turno where idmedico=" + id + " and activo=1 and convert(nvarchar , fecha, 103)='" + fecha + "'");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return aux;
        }
        public DataTable BuscarTurnoPorPaciente(int id,DateTime fecha)
        {
            DataTable aux = new DataTable();
            try
            {
                aux = manager.consultar("select * from turno where idpaciente=" + id + " and activo=1 and fecha='"+fecha+"'");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return aux;
        }
        public DataTable TurnosEntreFechas(DateTime desde,DateTime hasta)
        {
            DataTable aux = new DataTable();
            try
            {
                aux = manager.consultar("select * from turno where fecha between '"+desde+"' and '"+hasta+"'");
            }
            catch(Exception ex)
            {
                throw ex;
            }


            return aux;
        }
        public DataTable BuscarTurnoPorPaciente(int id)
        {
            DataTable aux = new DataTable();
            try
            {
                aux = manager.consultar("select * from turno where idpaciente=" + id + " and activo=1");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return aux;
        }

      
    }
}
