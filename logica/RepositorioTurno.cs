﻿using System;
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
        ManejaMedico manejamedico = new ManejaMedico();
        ManejaPaciente manejapaciente = new ManejaPaciente();
        ManejaEspecialidad manejaespecialidad = new ManejaEspecialidad();
        ManejaObraSocial manejaOs = new ManejaObraSocial();

        public void Alta(IEntidad turno)
        {
            try
            {               
                manejaTurno.Alta(turno);
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

        public void Modificacion(IEntidad turno)
        {
            try
            {

                manejaTurno.Modificacion(turno);
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

        public clsTurno buscarPorId(int idTurno)
        {
            clsTurno med;         
            try
            {
                med = (clsTurno)manejaTurno.buscaPorId(idTurno);
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
                    turno.Costo = float.Parse(aux["costo"].ToString());

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

        public List<clsTurnoVista> TodoVista(int pag)
        {
            DataTable tabla;
            List<clsTurnoVista> lista = new List<clsTurnoVista>();

            try
            {
                tabla = manejaTurno.Todo(pag);
                foreach (DataRow aux in tabla.Rows)
                {

                    clsTurnoVista turno = new clsTurnoVista();

                    turno.Id = Convert.ToInt32(aux["id"]);
                    turno.Medico = metodoM((clsMedicoDatos)manejamedico.buscaPorId(Convert.ToInt32(aux["idMedico"])));
                    turno.Paciente = metodoP((clsPacienteDatos)manejapaciente.buscaPorId(Convert.ToInt32(aux["idPaciente"])));
                    turno.IdUsuario = Convert.ToInt32(aux["idUsuario"]);
                    turno.Fecha = Convert.ToDateTime(aux["fecha"]);
                    turno.Estado = Convert.ToBoolean(aux["estado"]);
                    turno.Costo = float.Parse(aux["costo"].ToString());
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

        public List<clsTurnoVista> obtenerTurnoVista(int idMedico,DateTime fecha)//turno de los medicos
        {
            DataTable tabla;
            List<clsTurnoVista> lista = new List<clsTurnoVista>();
          
            try
            {
                tabla = manejaTurno.BuscarTurnoPorMedico(idMedico,fecha.ToShortDateString());
                foreach (DataRow aux in tabla.Rows)
                {
                                      
                        clsTurnoVista turno= new clsTurnoVista();

                        turno.Id = Convert.ToInt32(aux["id"]);
                        turno.Medico = metodoM((clsMedicoDatos)manejamedico.buscaPorId(Convert.ToInt32(aux["idMedico"])));
                        turno.Paciente=metodoP((clsPacienteDatos)manejapaciente.buscaPorId(Convert.ToInt32(aux["idPaciente"])));
                        turno.IdUsuario = Convert.ToInt32(aux["idUsuario"]);  
                        turno.Fecha = Convert.ToDateTime(aux["fecha"]);
                        turno.Estado = Convert.ToBoolean(aux["estado"]);
                        turno.Costo = float.Parse(aux["costo"].ToString());

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
      
        private clsMedico metodoM(IEntidad med2)
        {
            clsMedicoDatos med = (clsMedicoDatos)med2;
            clsEspecialidad aux;
            clsMedico medico = new clsMedico();

            try
            {
                medico.Id = med.Id;
                medico.Nombre = med.Nombre;
                medico.Apellido = med.Apellido;
                medico.Dni = med.Dni;
                medico.Matricula = med.Matricula;
                aux = (clsEspecialidad)manejaespecialidad.buscaPorId(med.Especialidad);
                medico.Especialidad = aux.Descripcion;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }


            return medico;
        }

        private clsPaciente metodoP(IEntidad pac2)
        {
            clsPacienteDatos pac = (clsPacienteDatos)pac2;
            clsObraSocial aux;
            clsPaciente paciente = new clsPaciente();

            try
            {
                paciente.Id = pac.Id;
                paciente.Nombre = pac.Nombre;
                paciente.Apellido = pac.Apellido;
                paciente.Dni = pac.Dni;
                paciente.Telefono = pac.Telefono;
                aux = (clsObraSocial)manejaOs.buscaPorId(pac2.Id);
                paciente.ObraSocial = aux.Nombre;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }


            return paciente;
        }

        public List<clsTurno> obtenerTurno(int idMedico, DateTime fecha)//turno de los medicos
        {
            DataTable tabla;
            List<clsTurno> lista = new List<clsTurno>();

            try
            {
                tabla = manejaTurno.BuscarTurnoPorMedico(idMedico, fecha.ToShortDateString());
                foreach (DataRow aux in tabla.Rows)
                {

                    clsTurno turno = new clsTurno();

                    turno.Id = Convert.ToInt32(aux["id"]);
                    turno.IdMedico = Convert.ToInt32(aux["idMedico"]);
                    turno.IdPaciente =Convert.ToInt32(aux["idPaciente"]);
                    turno.IdUsuario = Convert.ToInt32(aux["idUsuario"]);
                    turno.Fecha = Convert.ToDateTime(aux["fecha"]);
                    turno.Estado = Convert.ToBoolean(aux["estado"]);
                    turno.Costo = float.Parse(aux["costo"].ToString());

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

        public List<clsTurnoVista> obtenerTurnoPaciente(int idPaciente)//turno de un paciente 
        {
            DataTable tabla;
            List<clsTurnoVista> lista = new List<clsTurnoVista>();

            try
            {
                tabla = manejaTurno.BuscarTurnoPorPaciente(idPaciente);
                foreach (DataRow aux in tabla.Rows)
                {

                    clsTurnoVista turno = new clsTurnoVista();

                    turno.Id = Convert.ToInt32(aux["id"]);
                    turno.Medico = metodoM((clsMedicoDatos)manejamedico.buscaPorId(Convert.ToInt32(aux["idMedico"])));
                    turno.Paciente = metodoP((clsPacienteDatos)manejapaciente.buscaPorId(Convert.ToInt32(aux["idPaciente"])));
                    turno.IdUsuario = Convert.ToInt32(aux["idUsuario"]);
                    turno.Fecha = Convert.ToDateTime(aux["fecha"]);
                    turno.Estado = Convert.ToBoolean(aux["estado"]);
                    turno.Costo = float.Parse(aux["costo"].ToString());

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

        public List<clsTurnoVista>TurnoEntreFechas(DateTime desde,DateTime Hasta)
        {
            DataTable tabla;
            List<clsTurnoVista> lista = new List<clsTurnoVista>();

            try
            {
                tabla = manejaTurno.TurnosEntreFechas(desde,Hasta);
                foreach (DataRow aux in tabla.Rows)
                {

                    clsTurnoVista turno = new clsTurnoVista();

                    turno.Id = Convert.ToInt32(aux["id"]);
                    turno.Medico = metodoM((clsMedicoDatos)manejamedico.buscaPorId(Convert.ToInt32(aux["idMedico"])));
                    turno.Paciente = metodoP((clsPacienteDatos)manejapaciente.buscaPorId(Convert.ToInt32(aux["idPaciente"])));
                    turno.IdUsuario = Convert.ToInt32(aux["idUsuario"]);
                    turno.Fecha = Convert.ToDateTime(aux["fecha"]);
                    turno.Estado = Convert.ToBoolean(aux["estado"]);
                    turno.Costo = float.Parse(aux["costo"].ToString());

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

        public clsTurno primerTurno() 
        {

            DataTable tabla;

            clsTurno turno = new clsTurno();

            try
            {
                tabla = manejaTurno.PrimerTurno();
                foreach (DataRow aux in tabla.Rows)
                {

                    turno.Id = Convert.ToInt32(aux["id"]);
                    turno.IdMedico = Convert.ToInt32(aux["idMedico"]);
                    turno.IdPaciente = Convert.ToInt32(aux["idPaciente"]);
                    turno.IdUsuario = Convert.ToInt32(aux["idUsuario"]);
                    turno.Fecha = Convert.ToDateTime(aux["fecha"]);
                    turno.Estado = Convert.ToBoolean(aux["estado"]);
                    turno.Costo = float.Parse(aux["costo"].ToString());
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

            return turno;
        }

        public void ActualizarAsistencia(int idTurno)
        {
            try
            {
                manejaTurno.ActualizarAsistencia(idTurno);
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

        public clsTurno ultimoTurno() 
        {

            DataTable tabla;

            clsTurno turno = new clsTurno();

            try
            {
                tabla = manejaTurno.UltimoTurno();
                foreach (DataRow aux in tabla.Rows)
                {

                    turno.Id = Convert.ToInt32(aux["id"]);
                    turno.IdMedico = Convert.ToInt32(aux["idMedico"]);
                    turno.IdPaciente = Convert.ToInt32(aux["idPaciente"]);
                    turno.IdUsuario = Convert.ToInt32(aux["idUsuario"]);
                    turno.Fecha = Convert.ToDateTime(aux["fecha"]);
                    turno.Estado = Convert.ToBoolean(aux["estado"]);
                    turno.Costo = float.Parse(aux["costo"].ToString());
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

            return turno;
        }

        public List<clsTurnoVista> obtenerTurnoMedico(int idMedico)
        {
            DataTable tabla;
            List<clsTurnoVista> lista = new List<clsTurnoVista>();

            try
            {
                tabla = manejaTurno.BuscarTurnoPorMedico(idMedico);
                foreach (DataRow aux in tabla.Rows)
                {

                    clsTurnoVista turno = new clsTurnoVista();

                    turno.Id = Convert.ToInt32(aux["id"]);
                    turno.Medico = metodoM((clsMedicoDatos)manejamedico.buscaPorId(Convert.ToInt32(aux["idMedico"])));
                    turno.Paciente = metodoP((clsPacienteDatos)manejapaciente.buscaPorId(Convert.ToInt32(aux["idPaciente"])));
                    turno.IdUsuario = Convert.ToInt32(aux["idUsuario"]);
                    turno.Fecha = Convert.ToDateTime(aux["fecha"]);
                    turno.Estado = Convert.ToBoolean(aux["estado"]);
                    turno.Costo = float.Parse(aux["costo"].ToString());
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
