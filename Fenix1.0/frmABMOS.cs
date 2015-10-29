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

        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbOS.Text))
            {
                clsObraSocial OS = new clsObraSocial(tbOS.Text);
                //altaObraSocial(OS);
            }
        }

        private void frmABMOS_Load(object sender, EventArgs e)
        {
            //dgvOSAlta.dataSource = listarObraSocial(llamada);
            //dgvOSBaja.dataSource = dgvOSAlta;
            //dgvOSModif.dataSource = dgvOSAlta;
        }

        private void btnSgte_Click(object sender, EventArgs e)
        {
            llamada++;
            //dgvOS.dataSource = listarObraSocial(llamada);
            //dgvOSBaja.dataSource = dgvOSAlta;
            //dgvOSModif.dataSource = dgvOSAlta;

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if(llamada>1)
            {
                llamada--;
                //dgvOS.dataSource = listarObraSocial(llamada);
                //dgvOSBaja.dataSource = dgvOSAlta;
                //dgvOSModif.dataSource = dgvOSAlta;
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (dgvOSBaja.SelectedRows.Count > 0)
            {
                //llamar a quien elimina medico
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvOSMod.SelectedRows.Count > 0 && !string.IsNullOrWhiteSpace(tbModifOS.Text))
            {
                //llamar a quien edita medico
            }
        }

    }
}
