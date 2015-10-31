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


namespace Fenix1._0
{
    public partial class frmABMUsuario : Form
    {
        public frmABMUsuario()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbUsuAlta.Text) && !string.IsNullOrWhiteSpace(tbContAlta1.Text) && !string.IsNullOrWhiteSpace(tbContAlta2.Text))
            {
                if (tbContAlta1.Text == tbContAlta2.Text)
                {
                    try
                    {
                        RepositorUsuario.Alta(tbUsuAlta.Text, tbContAlta1.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Se ha pruducido el Sgte. error: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvModif_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            
            DialogResult res =
        }

    }
}
