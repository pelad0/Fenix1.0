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


namespace frmABMME
{
    public partial class frmPacientesAtendidos : Form
    {


        RepositorioMedico reposMedico = new RepositorioMedico();
        RepositorioTurno reposTurno = new RepositorioTurno();
        RepositorioPaciente reposPaciente = new RepositorioPaciente();
        bool columnas = false;
        bool columnasTurno = false;
        List<clsTurno> listaTurnos = new List<clsTurno>();

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

            listaMedicos = reposMedico.ObtenerMedicos();        //Metodo que me trae todos los medicos

            foreach(clsMedico med in listaMedicos)
            {
                cbMedico.Items.Add(med.Apellido);
            }



        }


        public void EstablecerFechas()
        {

            clsTurno primerTurno = new clsTurno();
            clsTurno ultimoTurno = new clsTurno();

            primerTurno = reposTurno.Primero();     //Me retorna el primer turno dado.
            ultimoTurno =  reposTurno.Ultimo();     //Me retorna el ultimo turno dado.

            dtpDesde.MinDate = primerTurno.Fecha;
            dtpHasta.MaxDate = ultimoTurno.Fecha;

            dtpDesde.Value = primerTurno.Fecha;
            dtpHasta.Value = ultimoTurno.Fecha;

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {

            //obtenerTurnoMedico(idMedico);     Me retorna todos los turnos de un medico determinado.

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
                        foreach (DataGridViewRow row in dgvPacientes.Rows)
                        {
                            dgvPacientes.Rows.Remove(row);
                        }
                    }



                    clsMedico medicoSeleccionado = new clsMedico();

                    List<clsMedico> listaMedicos = new List<clsMedico>();

                    listaMedicos = reposMedico.ObtenerMedicos();            //Traigo todos los medicos

                    foreach(clsMedico med in listaMedicos)
                    {
                        if (med.Apellido == cbMedico.Text)
                            medicoSeleccionado = med;
                    }                                                       //Encuentro el medico seleccionado y traigo todos sus turnos

                    listaTurnos = reposTurno.obtenerTurnoMedico(medicoSeleccionado.Id);     //Traigo todos los turnos dados por ese medico


                    foreach(clsTurno turn in listaTurnos)   //Recorro todos los turnos obteniendo el paciente de cada uno.
                    {
                        if(turn.Fecha > dtpDesde.Value && turn.Fecha < dtpHasta.Value)
                        {
                            clsPaciente pas = new clsPaciente();
                            pas = reposPaciente.buscarPorId(turn.IdPaciente);
                            
                            if(pas != null)         //Pregunto por si el paciente fue dado de baja.
                            {
                                dgvPacientes.Rows.Add(pas.Id, pas.Apellido, pas.Dni, pas.ObraSocial, pas.Telefono);
                                                            
                            }

                                
                        }


                    }



                }
            }
            else                //QUE EL CHECK BOX DE MEDICO NO FUE SELECCIONADO
            {
                List<clsTurno> listaTurnos = new List<clsTurno>();
                listaTurnos = reposTurno.RetornaTurnosEntre(dtpDesde.Value, dtpHasta.Value);    //Guardo todos los turnos existentes entre las fechas seleccionadas.

                clsPaciente pas = new clsPaciente(); //Variable para ir asignando pacientes y mostrarlos

                foreach(clsTurno turn in listaTurnos)
                {
                    if (turn.Fecha > dtpDesde.Value && turn.Fecha < dtpHasta.Value)
                    {
                        if(pas != null)
                        {
                            pas = reposPaciente.buscarPorId(turn.Id);

                            dgvPacientes.Rows.Add(pas.Id, pas.Apellido, pas.Dni, pas.ObraSocial, pas.Telefono);
                        
                            
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
                foreach (DataGridViewRow row in dgvTurnos.Rows)
                {
                    dgvTurnos.Rows.Remove(row);
                }
            }
            


            //TOMO EL ID DEL PACIENTE SELECCIONADO
            int idPas = int.Parse(dgvPacientes.Rows[dgvPacientes.CurrentRow.Index].Cells[0].Value.ToString());


            List<clsTurno> ListaTurnos = reposTurno.obtenerTurnoPaciente(idPas);

            foreach(clsTurno turn in listaTurnos)
            {
                dgvTurnos.Rows.Add(turn.Fecha);
                dgvTurnos.Rows.Add(turn.Costo);
            }

        }


        public void CrearColumnasTurno()
        {
            dgvTurnos.Columns.Add("Fecha", "Fecha");
            dgvTurnos.Columns.Add("Costo", "Costo");

            columnasTurno = true;
      
        }



    }
}
