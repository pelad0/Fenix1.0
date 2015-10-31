using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using entidades;
using controles;
using logica;


namespace Fenix1._0
{
    public partial class frmABMOS : Form
    {
        public frmABMOS()
        {
            InitializeComponent();
        }

        int llamada = 1;
        RepositorioObraSocial ros = new RepositorioObraSocial();
        List<clsObraSocial> OS;

        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbOS.Text))
            {
                clsObraSocial OSoc = new clsObraSocial(tbOS.Text);
                try
                {
                    ros.Alta(OSoc);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se ha pruducido el Sgte. error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmABMOS_Load(object sender, EventArgs e)
        {
            iniciar();
        }

        private void iniciar()
        {
            OS = ros.Todo();
            dgvOSAlta.dataSource = OS;
            dgvOSAlta.Columns[0].Visible = false;
            dgvOSBaja.dataSource = OS;
            dgvOSBaja.Columns[0].Visible = false;
            dgvOSModif.dataSource = OS;
            dgvOSModif.Columns[0].Visible = false;
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (dgvOSBaja.SelectedRows.Count > 0)
            {
                
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvOSMod.SelectedRows.Count > 0 && !string.IsNullOrWhiteSpace(tbModifOS.Text))
            {
                
            }
        }

        private void dgvOSMod_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbModifOS.Text = OS[dgvOSMod.CurrentRow.Index].Nombre;
        }
    }
}
