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
   public class ManejaSobreturno : iMetodos
    {
       

            iBdMetodos manager;

            public ManejaSobreturno()
            {
                manager = new BdMetodos();
            }
            public void Alta(IEntidad entidad)
            {
                clsSobreturno tur = (clsSobreturno)entidad;
                try
                {
                    manager.ejecutar("Insert into sobreturno(idpaciente,idmedico,fecha,costo,estado,idusuario) values('" + tur.IdPaciente + "','" + tur.IdPaciente + "'," + tur.Fecha + "," + tur.Costo + "," + tur.Estado + "," + tur.IdUsuario + ");SELECT @@identity;");
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
                clsSobreturno tur = (clsSobreturno)entidad;
                try
                {
                    manager.ejecutar("update sobreturno set activo=0 where id=" + tur.Id);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public void Modificacion(IEntidad entidad)
            {
                clsSobreturno tur = (clsSobreturno)entidad;
                try
                {
                    manager.ejecutar("update sobreturno set idpaciente=" + tur.IdPaciente + ",idmedico=" + tur.IdMedico + ",fecha=" + tur.Fecha + ",costo=" + tur.Costo + ",estado=" + tur.Estado + ",idusuario= " + tur.IdUsuario + "where id=" + tur.Id);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public IEntidad buscaPorId(int id)
            {
                DataTable aux = new DataTable();
                clsSobreturno tur = new clsSobreturno();
                try
                {
                    aux = manager.consultar("select * from sobreturno where id=" + id + " and activo=1");
                    tur.Id = Convert.ToInt32(aux.Rows[0]["id"]);
                    tur.IdMedico = Convert.ToInt32(aux.Rows[0]["idmedico"]);
                    tur.IdPaciente = Convert.ToInt32(aux.Rows[0]["idpaciente"]);
                    tur.Fecha = Convert.ToDateTime(aux.Rows[0]["fecha"]);
                    tur.Costo = Convert.ToDouble(aux.Rows[0]["costo"]);
                    tur.Estado = Convert.ToBoolean(aux.Rows[0]["estado"]);
                }
                catch (Exception ex)
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
                    aux = manager.consultar(" SELECT * FROM (SELECT *, ROW_NUMBER() OVER (ORDER BY ID) AS RowNum FROM sobreturno) AS tabla WHERE activo=1 and  tabla.RowNum BETWEEN " + pagina * 10 + " AND " + (pagina * 10) + 10);
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                return aux;
            }

            public DataTable BuscarTurnoPorMedico(int id, string fecha)
            {
                DataTable aux = new DataTable();
                try
                {
                    aux = manager.consultar("select * from sobreturno where idmedico=" + id + "and activo=1 and convert(nvarchar , fecha, 103)='" + fecha + "'");
                }
                catch (Exception ex)
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
                    aux = manager.consultar("select * from sobreturno where idpaciente=" + id + "and activo=1");
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                return aux;
            }



        }
    }

