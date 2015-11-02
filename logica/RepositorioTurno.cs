using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interfaces;
using entidades;
using Datos;
using System.Data;
using System.Data.SqlClient;

namespace logica
{
    public class RepositorioTurno
    {
        ManejaTurno manejaTurno = new ManejaTurno();
        
        public void Alta(IEntidad turno,int id)
        {
            try
            {
               
                manejaTurno.Alta(turno, id);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public void Baja(IEntidad turno)
        {          
          
            try
            {

                manejaTurno.Baja(turno);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Modificacion(IEntidad turno,int id)
        {
            try
            {

                manejaTurno.Modificacion(turno, id);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public clsTurno buscarPorId(int id)
        {
            clsTurno med;         
            try
            {
                med = (clsTurno)manejaTurno.buscaPorId(id);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return med;
        }

        public List<clsTurno> Todo(int pag)
        {
            DataTable tabla;
            List<clsTurno> lista = new List<clsTurno>();

            try
            {
                tabla = manejaTurno.Todo(pag);
                foreach (DataRow aux in tabla.Rows)
                {
                    clsTurno turno = new clsTurno();
                    turno.Id = Convert.ToInt32(aux["id"]);
                    turno.IdMedico = Convert.ToInt32(aux["idMedico"]);
                    turno.IdPaciente = Convert.ToInt32(aux["idPaciente"]);
                    turno.IdUsuario = Convert.ToInt32(aux["idUsuario"]);
                    turno.Fecha = Convert.ToDateTime(aux["fecha"]);
                    turno.Estado = Convert.ToBoolean(aux["estado"]);

                    lista.Add(turno);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lista;

        }

        public List<clsTurno> obtenerTurno(int id,DateTime fecha)//implementar
        {
            DataTable tabla;
            List<clsTurno> lista = new List<clsTurno>();

            try
            {
                tabla = manejaTurno.Todo(id);
                foreach (DataRow aux in tabla.Rows)
                {
                    if (Convert.ToDateTime(aux["fecha"]).CompareTo(fecha) == 0)
                    {
                        clsTurno turno = new clsTurno();
                        turno.Id = Convert.ToInt32(aux["id"]);
                        turno.IdMedico = Convert.ToInt32(aux["idMedico"]);
                        turno.IdPaciente = Convert.ToInt32(aux["idPaciente"]);
                        turno.IdUsuario = Convert.ToInt32(aux["idUsuario"]);
                        turno.Fecha = Convert.ToDateTime(aux["fecha"]);
                        turno.Estado = Convert.ToBoolean(aux["estado"]);

                        lista.Add(turno);
                    }

                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lista;

        }
        
    }
}
