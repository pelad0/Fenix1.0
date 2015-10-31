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
        public void Alta(IEntidad entidad,int idusuario)
        {
            clsTurno tur = (clsTurno)entidad;
            try
            {
                manager.ejecutar("Insert into turno(idpaciente,idmedico,fecha,costo,estado,idusuario) values('" + tur.IdPaciente + "','" + tur.IdPaciente + "'," + tur.Fecha + "," + tur.Costo + "," + tur.Estado +","+idusuario+");SELECT @@identity;");
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

        public void Modificacion(IEntidad entidad,int idusuario)
        {
            clsTurno tur = (clsTurno)entidad;
            try
            {
                manager.ejecutar("update turno set idpaciente=" + tur.IdPaciente + ",idmedico=" + tur.IdMedico + ",fecha=" + tur.Fecha+ ",costo=" +tur.Costo + ",estado=" + tur.Estado +",idusuario= "+idusuario+"where id=" + tur.Id);
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
               aux=manager.consultar("select * from medico where idmedico="+id+"and activo=1");
                tur.Id = Convert.ToInt32(aux.Rows[0]["idPaciente"]);
                tur.IdMedico = Convert.ToInt32(aux.Rows[0]["idmedico"]);
                tur.IdPaciente = Convert.ToInt32(aux.Rows[0]["idpaciente"]);
                tur.Fecha = Convert.ToDateTime(aux.Rows[0]["fecha"]);
                tur.Costo = Convert.ToDouble(aux.Rows[0]["matricula"]);
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
                aux = manager.consultar("select * from turno where activo=1");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return aux;
        }


    }
}
