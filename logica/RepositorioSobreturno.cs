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
    public class RepositorioSobreturno
    {       
        ManejaSobreturno manejaTurno = new ManejaSobreturno();
        public void Alta(IEntidad turno, int id)
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

        public void Modificacion(IEntidad turno, int id)
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
        public clsSobreturno buscarPorId(int id)
        {
            clsSobreturno med;

            try
            {

                med = (clsSobreturno)manejaTurno.buscaPorId(id);
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

        public List<clsSobreturno> Todo(int pag)
        {
            DataTable tabla;
            List<clsSobreturno> lista = new List<clsSobreturno>();
            try
            {
                tabla = manejaTurno.Todo(pag);
                foreach (DataRow aux in tabla.Rows)
                {
                    clsSobreturno turno = new clsSobreturno();
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

    

        public List<clsSobreturno> obtenerSobreturno(int id, DateTime fecha)//implementar
        {
            DataTable tabla;
            List<clsSobreturno> lista = new List<clsSobreturno>();

            try
            {
                tabla = manejaTurno.BuscarTurnoPorMedico(id, fecha.ToShortDateString());
                foreach (DataRow aux in tabla.Rows)
                {

                    clsSobreturno turno = new clsSobreturno();
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

        public List<clsSobreturno> obtenerSobreturnoPaciente(int id, DateTime fecha)//implementar
        {
            DataTable tabla;
            List<clsSobreturno> lista = new List<clsSobreturno>();

            try
            {
                tabla = manejaTurno.BuscarTurnoPorPaciente(id);
                foreach (DataRow aux in tabla.Rows)
                {

                    clsSobreturno turno = new clsSobreturno();
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

    }
}
