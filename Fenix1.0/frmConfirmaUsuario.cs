using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmABMME
{
    public partial class frmConfirmaUsuario : Form
    {
        string claveAntigua;
        public frmConfirmaUsuario(string aConfirmar)
        {
            InitializeComponent();
            claveAntigua = aConfirmar;
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbConfirm.Text))
            {
                if (claveAntigua == tbConfirm.Text)
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Clave incorrecta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    tbConfirm.Clear();
                    tbConfirm.Focus();
                }
            }
        }
    }
}
