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
    public class RepositorioMedico
    {
        ManejaMedico manejaMedico = new ManejaMedico();
        ManejaEspecialidad manejaEspecialidad = new ManejaEspecialidad();

        public void Alta(IEntidad medico)
        {
            
            try
            {
                manejaMedico.Alta(metodoS(medico));
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public void Baja(IEntidad medico)
        {
            try
            {               
                manejaMedico.Baja(metodoS(medico));
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

        public void Modificacion(IEntidad medico)
        {
            try
            {
               
                manejaMedico.Modificacion(metodoS(medico));
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

        public clsMedico buscarPorId(int id)
        {
            clsMedico m;
            clsMedicoDatos med;
            try
            {                
                
                med = (clsMedicoDatos)manejaMedico.buscaPorId(id);
                m=metodoL(med);

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return m;
        }

        public List<clsMedico>Todo(int pag)
        {
            DataTable tabla;
            List<clsMedico> lista = new List<clsMedico>();
            clsEspecialidad aux2;
            tabla=manejaMedico.Todo(pag);
            foreach(DataRow aux in tabla.Rows)
            {

                clsMedico med = new clsMedico();
                med.Id = Convert.ToInt32(aux["id"]);
                med.Nombre = aux["nombre"].ToString();
                med.Apellido = aux["apellido"].ToString();
                med.Dni = Convert.ToInt64(aux["dni"]);
                med.Matricula = Convert.ToInt32(aux["matricula"]);
                aux2=(clsEspecialidad)manejaEspecialidad.buscaPorId(med.Id);
                med.Especialidad=aux2.Descripcion;
                
                lista.Add(med);


            }

            return lista;

        }

        private clsMedicoDatos metodoS(IEntidad med2)
        {
            clsMedico med = (clsMedico)med2;
            clsMedicoDatos aux;
            clsMedicoDatos medico = new clsMedicoDatos();

            try
            {
                medico.Id = med.Id;
                medico.Nombre = med.Nombre;
                medico.Apellido = med.Apellido;
                medico.Dni = med.Dni;
                medico.Matricula = med.Matricula;
                medico.ObraSocial = med.ObraSocial;
                aux = (clsMedicoDatos)manejaMedico.buscaPorId(med.Id);
                medico.Especialidad = aux.Especialidad;
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

        private clsMedico metodoL(IEntidad med2)
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
                medico.ObraSocial = med.ObraSocial;
                aux = (clsEspecialidad)manejaEspecialidad.buscaPorId(med.Id);
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

               
              
         

    }
}
