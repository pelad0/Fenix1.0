using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using controles;
using logica;
using entidades;

namespace Fenix1._0
{
    public partial class frmABMHistorial : Form
    {
        frmInicio i;
        public frmABMHistorial(frmInicio i)
        {
            InitializeComponent();
            this.i = i;
        }

        List<clsPaciente> pacientes = new List<clsPaciente>();
        List<clsHistorial> historiales = new List<clsHistorial>();
        List<clsTurnoVista> turnos = new List<clsTurnoVista>();
        List<clsSobreTurnoVista> sobreTurnos = new List<clsSobreTurnoVista>();
        RepositorioPaciente rp = new RepositorioPaciente();
        RepositorioHistorial rh = new RepositorioHistorial();
        RepositorioTurno rt = new RepositorioTurno();
        RepositorioSobreturno rst = new RepositorioSobreturno();
        int pagina = 0;
        
        private void frmABMHistorial_Load(object sender, EventArgs e)
        {
            iniciar();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (confirmaAlta())
            {
                clsHistorial h = new clsHistorial(pacientes[dgvAlta.CurrentRow.Index].Id, rtbDiagAlta.Text, rtbObserAlta.Text, dtpFechaAlta.Value);
                try
                {
                    rh.Alta(h);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se ha pruducido el Sgte. error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    pagina = 0;
                    iniciar();
                }
            }
        }

        private void btnAntAlta_Click(object sender, EventArgs e)
        {
            if(pagina > 1)
            {
                pagina--;
                iniciar();
            }
        }

        private void btnSigAlta_Click(object sender, EventArgs e)
        {
            if (rp.Todo(pagina + 1).Count > 0)
            {
                pagina++;
                iniciar();

            }
        }

        private void dgvAlta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblPac.Text = pacientes[dgvAlta.CurrentRow.Index].nomCompleto();
        }

        private void dgvPacBaja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(pacientes[dgvPacBaja.CurrentRow.Index].Nombre))
            {
                historiales.Clear();
                historiales = rh.listar(pacientes[dgvPacBaja.CurrentRow.Index].Id);
                dgvHistBaja.DataSource = null;
                dgvHistBaja.DataSource = historiales;
                dgvHistBaja.Columns[3].Visible = false;
            }
        }

        private bool confirmaAlta()
        {
            if (string.IsNullOrWhiteSpace(rtbDiagAlta.Text))
            {
                MessageBox.Show("Completar campo Diagnostico", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(rtbObserAlta.Text))
            {
                MessageBox.Show("Completar campo Observaciones", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (lblPac.Text == "Paciente")
            {
                MessageBox.Show("Seleccione un paciente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void iniciar()
        {
            pacientes.Clear();
            pacientes = rp.Todo(pagina);
            dgvAlta.DataSource = null;
            dgvAlta.DataSource = pacientes;
            dgvAlta.Columns[0].Visible = false;

            dgvPacBaja.DataSource = null;
            dgvPacBaja.DataSource = pacientes;
            dgvPacBaja.Columns[0].Visible = false;

            dgvHistBaja.DataSource = null;

            rtbDiagAlta.Clear();
            rtbObserAlta.Clear();

            dtpFechaAlta.Value = System.DateTime.Today;
            lblPac.Text = "Paciente";

            turnos.Clear();
            turnos = rt.obtenerTurnoVista(i.U.IdMedico, DateTime.Now);
            dgvTurnos.DataSource = turnos;

            dgvTurnos.Columns[0].Visible = false;
            dgvTurnos.Columns[2].Visible = false;
            dgvTurnos.Columns[4].Visible = false;
            dgvTurnos.Columns[5].Visible = false;

            sobreTurnos.Clear();
            sobreTurnos = rst.obtenerSobreturnoVista(i.U.IdMedico, DateTime.Now);
            dgvSobreTurnos.DataSource = sobreTurnos;
            
            dgvSobreTurnos.Columns[0].Visible = false;
            dgvSobreTurnos.Columns[2].Visible = false;
            dgvSobreTurnos.Columns[4].Visible = false;
            dgvSobreTurnos.Columns[5].Visible = false;

        }

        private void frmABMHistorial_FormClosed(object sender, FormClosedEventArgs e)
        {
            i.limpiar();
            i.Show();
        }

        private void dgvTurnos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if((sender as DataGridView).Name == "dgvTurnos")
            {
                rt.ActualizarAsistencia(turnos[dgvTurnos.CurrentRow.Index].Id);
                turnos.Clear();
                turnos = rt.obtenerTurnoVista(i.U.IdMedico, DateTime.Now);
                dgvTurnos.DataSource = turnos;

                dgvTurnos.Columns[0].Visible = false;
                dgvTurnos.Columns[2].Visible = false;
                dgvTurnos.Columns[4].Visible = false;
                dgvTurnos.Columns[5].Visible = false;
            }
            else
            {
                rst.ActualizarAsistencia(turnos[dgvTurnos.CurrentRow.Index].Id);

                sobreTurnos.Clear();
                sobreTurnos = rst.obtenerSobreturnoVista(i.U.IdMedico, DateTime.Now);
                dgvSobreTurnos.DataSource = sobreTurnos;

                dgvSobreTurnos.Columns[0].Visible = false;
                dgvSobreTurnos.Columns[2].Visible = false;
                dgvSobreTurnos.Columns[4].Visible = false;
                dgvSobreTurnos.Columns[5].Visible = false;

            }
        }

    }
}
