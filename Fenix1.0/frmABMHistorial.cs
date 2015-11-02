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
        public frmABMHistorial()
        {
            InitializeComponent();
        }

        List<clsPaciente> pacientes = new List<clsPaciente>();
        List<clsHistorial> historiales = new List<clsHistorial>();
        RepositorioPaciente rp = new RepositorioPaciente();
        RepositorioHistorial rh = new RepositorioHistorial();
        int pagina = 0;
        
        private void frmABMHistorial_Load(object sender, EventArgs e)
        {
            pacientes = rp.Todo(pagina);
            dgvAlta.DataSource = pacientes;
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

        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (true)
            {
                
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

        private void iniciar()
        {
            pacientes.Clear();
            pacientes = rp.Todo(pagina);
            dgvAlta.DataSource = null;
            dgvAlta.DataSource = pacientes;

            dgvPacBaja.DataSource = null;
            dgvPacBaja.DataSource = pacientes;

            dgvHistBaja.DataSource = null;
            

            rtbDiagAlta.Clear();
            rtbObserAlta.Clear();

            dtpFechaAlta.Value = System.DateTime.Today;
            lblPac.Text = "Paciente";
        }

        private void dgvAlta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblPac.Text = pacientes[dgvAlta.CurrentRow.Index].nomCompleto();
        }

        private bool confirmaAlta()
        {
            if (string.IsNullOrWhiteSpace(rtbDiagAlta.Text))
            {
                MessageBox.Show("Completar campo Diagnostico", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return false;
            }
            if (string.IsNullOrWhiteSpace(rtbObserAlta.Text))
            {
                MessageBox.Show("Completar campo Observaciones", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(pacientes[dgvAlta.CurrentRow.Index].Nombre))
            {
                MessageBox.Show("Seleccione un paciente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }


        private void dgvPacBaja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(pacientes[dgvPacBaja.CurrentRow.Index].Nombre))
            {
                historiales.Clear();
                historiales = rh.listar(pacientes[dgvPacBaja.CurrentRow.Index].Id);
                dgvHistBaja.DataSource = null;
                dgvHistBaja.DataSource = historiales;
            }
        }

        private void dgvHistBaja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
