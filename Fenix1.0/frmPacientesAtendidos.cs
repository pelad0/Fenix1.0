using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using logica;
using entidades;


namespace Fenix1._0
{
    public partial class frmPacientesAtendidos : Form
    {


        RepositorioMedico reposMedico = new RepositorioMedico();
        RepositorioTurno reposTurno = new RepositorioTurno();
        RepositorioPaciente reposPaciente = new RepositorioPaciente();
        RepositorioSobreturno reposSobreTurno = new RepositorioSobreturno();

        bool columnas = false;
        bool columnasTurno = false;
        List<clsTurnoVista> listaTurnos = new List<clsTurnoVista>();
        List<clsSobreTurnoVista> listaSobreTurnos = new List<clsSobreTurnoVista>();

        public frmPacientesAtendidos()
        {
            InitializeComponent();
        }

        private void frmPacientesAtendidos_Load(object sender, EventArgs e)
        {
            
            checkBoxMedico.Checked = false;

            if (!columnas)   //Para que se creeen una sola vez y no tener que borrarlas
            {
                CrearColumnas();
            }



            CargarMedicos();        //Carga todos los medicos al combo box;
            EstablecerFechas();     //Establece las fechas en los dateTimepicker, la menor es la del primer turno, la mayor del ultimo.
            
        }




        public void CargarMedicos()         //CARGA TODOS LOS MEDICOS EN EL COMBO BOX.
        {
            
            List<clsMedico> listaMedicos = new List<clsMedico>();

            listaMedicos = reposMedico.obtenerMedicos();        //Metodo que me trae todos los medicos

            foreach(clsMedico med in listaMedicos)
            {
                cbMedico.Items.Add(med.Apellido);
            }
            


        }

        public void EstablecerFechas()
        {
            try
            {
                clsTurno primerTurno = new clsTurno();
                clsTurno ultimoTurno = new clsTurno();

                primerTurno = reposTurno.primerTurno();     //Me retorna el primer turno dado.
                ultimoTurno = reposTurno.ultimoTurno();     //Me retorna el ultimo turno dado.

                DateTime h1 = primerTurno.Fecha.Add(new TimeSpan(-24, 0, 0));
                DateTime h2 = ultimoTurno.Fecha.Add(new TimeSpan(24, 0, 0));

                dtpDesde.MinDate = h1;
                dtpHasta.MaxDate = h2;

                dtpDesde.Value = h1;
                dtpHasta.Value = h2;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Actualmente no hay turnos en el sistema.");
            }
            
            
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            
            if(checkBoxMedico.Checked)
            {
                if(string.IsNullOrWhiteSpace(cbMedico.Text))
                {
                    MessageBox.Show("Debe seleccionar un medico para continuar", "¡Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {                    

                    //Borro todas las filas.
                    if (dgvPacientes.Rows.Count > 0)
                    {
                        dgvPacientes.Rows.Clear();
                    }



                    clsMedico medicoSeleccionado = new clsMedico();

                    List<clsMedico> listaMedicos = new List<clsMedico>();

                    listaMedicos = reposMedico.obtenerMedicos();            //Traigo todos los medicos

                    foreach(clsMedico med in listaMedicos)
                    {
                        if (med.Apellido == cbMedico.Text)
                            medicoSeleccionado = med;
                    }                                                       //Encuentro el medico seleccionado y traigo todos sus turnos

                    listaTurnos = reposTurno.obtenerTurnoMedico(medicoSeleccionado.Id);         //Traigo todos los turnos dados por ese medico
                    listaSobreTurnos = reposSobreTurno.obtenerSobreTurnoMedico(medicoSeleccionado.Id);        //Traigo todos los sobre turnos dados por ese medico


                    clsPaciente pas = new clsPaciente();        //Variable a la que se le asigna el paciente de cada turno.


                    foreach(clsTurnoVista turn in listaTurnos)   //Recorro todos los turnos obteniendo el paciente de cada uno.
                    {
                        if(turn.Fecha > dtpDesde.Value && turn.Fecha < dtpHasta.Value)
                        {                            
                            pas = reposPaciente.buscarPorId(turn.Paciente.Id);
                            
                            if(pas != null)         //Pregunto por si el paciente fue dado de baja.
                            {
                                dgvPacientes.Rows.Add(pas.Id,pas.Nombre, pas.Apellido, pas.Dni, pas.ObraSocial, pas.Telefono);
                                                            
                            }

                                
                        }


                    }

                    foreach(clsSobreTurnoVista turn in listaSobreTurnos)
                    {
                        if(turn.Fecha > dtpDesde.Value && turn.Fecha < dtpHasta.Value)
                        {
                            
                            pas = reposPaciente.buscarPorId(turn.Paciente.Id);

                            if(pas != null)
                            {
                                dgvPacientes.Rows.Add(pas.Id,pas.Nombre, pas.Apellido, pas.Dni, pas.ObraSocial, pas.Telefono);
                            }

                        }


                    }



                }
            }
            else                //QUE EL CHECK BOX DE MEDICO NO FUE SELECCIONADO
            {

                //Borro todas las filas.
                if (dgvPacientes.Rows.Count > 0)
                {
                    dgvPacientes.Rows.Clear();
                }


                List<clsTurnoVista> listaTurnos = new List<clsTurnoVista>();
                listaTurnos = reposTurno.TurnoEntreFechas(dtpDesde.Value, dtpHasta.Value);    //Guardo todos los turnos existentes entre las fechas seleccionadas.

                List<clsSobreTurnoVista> listaSobreTurnos = new List<clsSobreTurnoVista>();
                listaSobreTurnos = reposSobreTurno.TurnoEntreFechas(dtpDesde.Value, dtpHasta.Value);


                clsPaciente pas = new clsPaciente(); //Variable para ir asignando pacientes y mostrarlos

                foreach(clsTurnoVista turn in listaTurnos)
                {
                    if (turn.Fecha > dtpDesde.Value && turn.Fecha < dtpHasta.Value)
                    {
                        pas = reposPaciente.buscarPorId(turn.Paciente.Id);

                        if(pas != null)
                        {                          
                            dgvPacientes.Rows.Add(pas.Id,pas.Nombre, pas.Apellido, pas.Dni, pas.ObraSocial, pas.Telefono);                        
                            
                        }
                        
                    }
                }


                foreach(clsSobreTurnoVista turn in listaSobreTurnos)
                {
                    if(turn.Fecha > dtpDesde.Value && turn.Fecha < dtpHasta.Value)
                    {
                        pas = reposPaciente.buscarPorId(turn.Paciente.Id);

                        if(pas != null)
                        {
                            dgvPacientes.Rows.Add(pas.Id,pas.Nombre, pas.Apellido, pas.Dni, pas.ObraSocial, pas.Telefono);                        

                        }
                    }
                }

        


            }


            


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (!checkBoxMedico.Checked)
            {
                cbMedico.Enabled = false;
            }
            else
            {
                cbMedico.Enabled = true;
            }
            
        }

        public void CrearColumnas()
        {

            dgvPacientes.Columns.Add("id", "id");
            dgvPacientes.Columns["id"].Visible = false;
            dgvPacientes.Columns.Add("Nombre", "Nombre");
            dgvPacientes.Columns.Add("Apellido", "Apellido");
            dgvPacientes.Columns.Add("Dni", "Dni");
            dgvPacientes.Columns.Add("ObraSocial", "ObraSocial");
            dgvPacientes.Columns.Add("Telefono", "Telefono");
            

            columnas = true;
            
        }

        private void dgvPacientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if(!columnasTurno)
            {
                CrearColumnasTurno();
            }

            if (dgvTurnos.Rows.Count > 0)
            {
                //foreach (DataGridViewRow row in dgvTurnos.Rows)
                //{
                //    dgvTurnos.Rows.Remove(row);
                //}
                dgvTurnos.Rows.Clear();
            }
            


            //TOMO EL ID DEL PACIENTE SELECCIONADO
            int idPas = int.Parse(dgvPacientes.Rows[dgvPacientes.CurrentRow.Index].Cells[0].Value.ToString());


            List<clsTurnoVista> ListaTur = reposTurno.obtenerTurnoPaciente(idPas);
            List<clsSobreTurnoVista> ListaSobreTur = reposSobreTurno.obtenerSobreturnoPaciente(idPas);


            foreach(clsTurnoVista turn in ListaTur)
            {
                dgvTurnos.Rows.Add(turn.Fecha, turn.Costo);
            }

            foreach (clsSobreTurnoVista sobr in listaSobreTurnos)
            {
                dgvTurnos.Rows.Add(sobr.Fecha, sobr.Costo);
            }

            

        }


        public void CrearColumnasTurno()
        {
            dgvTurnos.Columns.Add("Fecha", "Fecha");
            dgvTurnos.Columns.Add("Costo", "Costo");
            dgvTurnos.Columns["Costo"].DefaultCellStyle.Format = "c";

            columnasTurno = true;
      
        }



    }
}
