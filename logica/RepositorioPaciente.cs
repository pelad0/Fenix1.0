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
    public class RepositorioPaciente
    {
        ManejaPaciente manejaPaciente = new ManejaPaciente();
        ManejaObraSocial manejaOs = new ManejaObraSocial();

        public void Alta(IEntidad paciente)
        {
            try
            {

                manejaPaciente.Alta(metodoS(paciente));
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

        public void Baja(IEntidad paciente)
        {

            try
            {

                manejaPaciente.Baja(metodoS(paciente));
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

        public void Modificacion(IEntidad paciente)
        {
            try
            {

                manejaPaciente.Modificacion(metodoS(paciente));
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

        public clsPaciente buscarPorId(int id)
        {
            clsPacienteDatos paciente = new clsPacienteDatos();
            clsPaciente pac;
            try
            {
                paciente = (clsPacienteDatos)manejaPaciente.buscaPorId(id);
                pac = metodoL(paciente);

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }


            return pac;
        }

        public clsPaciente buscarDni(long dni)
        {
            clsPacienteDatos paciente = new clsPacienteDatos();
            clsPaciente pac;
            try
            {
                paciente = (clsPacienteDatos)manejaPaciente.BuscarPorDni((int)dni);//pasar a long
                pac = metodoL(paciente);

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }


            return pac;
        }

        public List<clsPaciente> Todo(int pag)
        {
            DataTable tabla;
            List<clsPaciente> lista = new List<clsPaciente>();
            clsObraSocial aux2;

            tabla = manejaPaciente.Todo(pag);
            foreach (DataRow aux in tabla.Rows)
            {
                aux2 = (clsObraSocial)manejaOs.buscaPorId(Convert.ToInt32(aux["obra"]));
                if (aux2 != null)
                {
                    clsPaciente pac = new clsPaciente();

                    pac.Id = Convert.ToInt32(aux["id"]);
                    pac.Nombre = aux["nombre"].ToString();
                    pac.Apellido = aux["apellido"].ToString();
                    pac.Dni = Convert.ToInt64(aux["dni"]);

                    pac.ObraSocial = aux2.Nombre;
                    pac.Telefono = Convert.ToInt64(aux["telefono"]);


                    lista.Add(pac);
                }

            }

            return lista;

        }

        private IEntidad metodoS(IEntidad pac2)
        {
            clsPaciente pac = (clsPaciente)pac2;
            clsObraSocial aux;
            clsPacienteDatos paciente = new clsPacienteDatos();

            try
            {
                paciente.Id = pac.Id;
                paciente.Nombre = pac.Nombre;
                paciente.Apellido = pac.Apellido;
                paciente.Dni = pac.Dni;
                paciente.Telefono = pac.Telefono;
                aux = (clsObraSocial)manejaOs.buscaPorNombre(pac.ObraSocial);
                paciente.ObraSocial = aux.Id;
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

        private clsPaciente metodoL(IEntidad pac2)
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
                aux = (clsObraSocial)manejaOs.buscaPorId(pac.ObraSocial);
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

        public List<clsPaciente> obtenerAlfabeticamente(string letra)
        {
            DataTable tabla;
            List<clsPaciente> lista = new List<clsPaciente>();
            clsObraSocial aux2;

            tabla = manejaPaciente.BuscarApellidoPorLetra(letra);

            foreach (DataRow aux in tabla.Rows)
            {
                aux2 = (clsObraSocial)manejaOs.buscaPorId(Convert.ToInt32(aux["obra"]));
                if (aux2 != null)
                {
                    clsPaciente pac = new clsPaciente();

                    pac.Id = Convert.ToInt32(aux["id"]);
                    pac.Nombre = aux["nombre"].ToString();
                    pac.Apellido = aux["apellido"].ToString();
                    pac.Dni = Convert.ToInt64(aux["dni"]);

                    pac.ObraSocial = aux2.Nombre;
                    pac.Telefono = Convert.ToInt64(aux["telefono"]);


                    lista.Add(pac);
                }

            }
            return lista;
        }
    }
}