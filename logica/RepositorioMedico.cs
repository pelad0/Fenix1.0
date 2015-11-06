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

        public List<clsMedico>Todo(int pag)///
        {
            DataTable tabla;
            List<clsMedico> lista = new List<clsMedico>();
            clsEspecialidad aux2;
            try
            {
                tabla = manejaMedico.Todo(pag);
                foreach (DataRow aux in tabla.Rows)
                {

                    clsMedico med = new clsMedico();
                    med.Id = Convert.ToInt32(aux["id"]);
                    med.Nombre = aux["nombre"].ToString();
                    med.Apellido = aux["apellido"].ToString();
                    med.Dni = Convert.ToInt64(aux["dni"]);
                    med.Matricula = Convert.ToInt32(aux["matricula"]);
                    aux2 = (clsEspecialidad)manejaEspecialidad.buscaPorId(Convert.ToInt32(aux["especialidad"]));
                    med.Especialidad = aux2.Descripcion;

                    lista.Add(med);


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

        public List<clsMedico> Busca(string esp)//buscar por especialidad
        {
            DataTable tabla;
            List<clsMedico> lista = new List<clsMedico>();
        
            clsEspecialidad aux3;
            try
            {
                aux3 = (clsEspecialidad)manejaEspecialidad.buscaPorNombre(esp);
                tabla = manejaMedico.Busca(aux3.Id);

                foreach (DataRow aux in tabla.Rows)
                {

                    clsMedico med = new clsMedico();
                    med.Id = Convert.ToInt32(aux["id"]);
                    med.Nombre = aux["nombre"].ToString();
                    med.Apellido = aux["apellido"].ToString();
                    med.Dni = Convert.ToInt64(aux["dni"]);
                    med.Matricula = Convert.ToInt32(aux["matricula"]);                                       
                    med.Especialidad = esp;

                    lista.Add(med);


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

        public clsMedico BuscarPorDni(long dni) //busca un medico por dni
        {
            
            clsMedico m;
            clsMedicoDatos med;
            try
            {
                med = (clsMedicoDatos)manejaMedico.BuscarPorDni(dni);
                m = metodoL(med);
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

        private clsMedicoDatos metodoS(IEntidad med2)
        {
            clsMedico med = (clsMedico)med2;
            clsEspecialidad aux;
            clsMedicoDatos medico = new clsMedicoDatos();

            try
            {
                medico.Id = med.Id;
                medico.Nombre = med.Nombre;
                medico.Apellido = med.Apellido;
                medico.Dni = med.Dni;
                medico.Matricula = med.Matricula;
                aux = (clsEspecialidad)manejaEspecialidad.buscaPorNombre(med.Especialidad);
                medico.Especialidad = aux.Id;
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
                aux = (clsEspecialidad)manejaEspecialidad.buscaPorId(med.Especialidad);
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

        private clsMedico getCast(IEntidad e)
        {
            if (e.GetType().Equals(typeof(clsMedico)))
                return (clsMedico)e;
            else
                throw new ArgumentException("el tipo '" + e.GetType().ToString() + "' no esta soportado en un repositorio del tipo '" + this.GetType().ToString());
        }

        public clsHorario BuscarHorarioMañana(int id)
        {
            DataTable aux;
            clsHorario esp = new clsHorario();
            try
            {
                aux = manejaMedico.BuscarHorarioMañana(id);

                if (Convert.ToInt32(aux.Rows.Count.ToString()) != 0)
                {

                    esp.IdMedico = Convert.ToInt32(aux.Rows[0]["idmedico"]);
                    esp.LunesEntrada = Convert.ToDateTime(aux.Rows[0]["lunesentrada"]);
                    esp.LunesSalida = Convert.ToDateTime(aux.Rows[0]["lunessalida"]);
                    esp.MartesEntrada = Convert.ToDateTime(aux.Rows[0]["martesentrada"]);
                    esp.MartesSalida = Convert.ToDateTime(aux.Rows[0]["martessalida"]);
                    esp.MiercolesEntrada = Convert.ToDateTime(aux.Rows[0]["miercolesentrada"]);
                    esp.MiercolesSalida = Convert.ToDateTime(aux.Rows[0]["miercolessalida"]);
                    esp.JuevesEntrada = Convert.ToDateTime(aux.Rows[0]["juevesentrada"]);
                    esp.JuevesSalida = Convert.ToDateTime(aux.Rows[0]["juevessalida"]);
                    esp.ViernesEntrada = Convert.ToDateTime(aux.Rows[0]["viernesentrada"]);
                    esp.ViernesSalida = Convert.ToDateTime(aux.Rows[0]["viernessalida"]);
                    esp.SabadoEntrada = Convert.ToDateTime(aux.Rows[0]["sabadoentrada"]);
                    esp.SabadoSalida = Convert.ToDateTime(aux.Rows[0]["sabadosalida"]);
                    esp.DomingoEntrada = Convert.ToDateTime(aux.Rows[0]["domingoentrada"]);
                    esp.DomingoSalida = Convert.ToDateTime(aux.Rows[0]["domingosalida"]);

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

            return esp;
        }
        public clsHorario BuscarHorarioTarde(int id)
        {
            DataTable aux;
            clsHorario esp = new clsHorario();
            try
            {
                   aux= manejaMedico.BuscarHorarioTarde(id);

                   if (Convert.ToInt32(aux.Rows.Count.ToString()) != 0)
                   {
                       esp.IdMedico = Convert.ToInt32(aux.Rows[0]["idmedico"]);
                       esp.LunesEntrada = Convert.ToDateTime(aux.Rows[0]["lunesentrada"]);
                       esp.LunesSalida = Convert.ToDateTime(aux.Rows[0]["lunessalida"]);
                       esp.MartesEntrada = Convert.ToDateTime(aux.Rows[0]["martesentrada"]);
                       esp.MartesSalida = Convert.ToDateTime(aux.Rows[0]["martessalida"]);
                       esp.MiercolesEntrada = Convert.ToDateTime(aux.Rows[0]["miercolesentrada"]);
                       esp.MiercolesSalida = Convert.ToDateTime(aux.Rows[0]["miercolessalida"]);
                       esp.JuevesEntrada = Convert.ToDateTime(aux.Rows[0]["juevesentrada"]);
                       esp.JuevesSalida = Convert.ToDateTime(aux.Rows[0]["juevessalida"]);
                       esp.ViernesEntrada = Convert.ToDateTime(aux.Rows[0]["viernesentrada"]);
                       esp.ViernesSalida = Convert.ToDateTime(aux.Rows[0]["viernessalida"]);
                       esp.SabadoEntrada = Convert.ToDateTime(aux.Rows[0]["sabadoentrada"]);
                       esp.SabadoSalida = Convert.ToDateTime(aux.Rows[0]["sabadosalida"]);
                       esp.DomingoEntrada = Convert.ToDateTime(aux.Rows[0]["domingoentrada"]);
                       esp.DomingoSalida = Convert.ToDateTime(aux.Rows[0]["domingosalida"]);
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

            return esp;
        }

        public List<clsMedico> obtenerMedicos() //completar
        {
            List<clsMedico> med = new List<clsMedico>();

            return med;

        }

    }
}
