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

        int pagina = 0;
        RepositorioObraSocial ros = new RepositorioObraSocial();
        List<clsObraSocial> OS;

        private void frmABMOS_Load(object sender, EventArgs e)
        {
            iniciar();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbOS.Text))
            {
                DialogResult res = MessageBox.Show("Agregar a " + tbOS.Text + " al sistema?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (res == DialogResult.OK)
                {
                    clsObraSocial OSoc = new clsObraSocial(tbOS.Text);
                    try
                    {
                        ros.Alta(OSoc);
                        iniciar();
                        tbOS.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Se ha pruducido el Sgte. error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(OS[dgvOSBaja.CurrentRow.Index].Nombre))
            {
                string exOS = OS[dgvOSBaja.CurrentRow.Index].Nombre;
                DialogResult res = MessageBox.Show("Desea eliminar a "+ exOS +" del registro?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (res == DialogResult.OK)
                {
                    try
                    {
                        ros.Baja(OS[dgvOSBaja.CurrentRow.Index]);
                        iniciar();
                        MessageBox.Show(exOS+" se elimino con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Se ha pruducido el Sgte. error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione Obra Social a eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbModifOS.Text))
            {
                int pos = dgvOSModif.CurrentRow.Index;
                string anterior = OS[pos].Nombre;

                DialogResult res = MessageBox.Show("Desea editar la información de " + anterior + "?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (res == DialogResult.OK)
                {
                    try
                    {
                        ros.Modificacion(OS[dgvOSModif.CurrentRow.Index]);
                        iniciar();
                        tbModifOS.Focus();
                        MessageBox.Show(anterior+" cambió a: "+OS[pos].Nombre, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Se ha pruducido el Sgte. error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione Obra Social a modificar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void dgvOSMod_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbModifOS.Text = OS[dgvOSModif.CurrentRow.Index].Nombre;
        }

        private void iniciar()
        {
            OS = ros.Todo(0);
            dgvOSAlta.DataSource = null;
            dgvOSAlta.DataSource = OS;
            dgvOSAlta.Columns[1].Visible = false;

            dgvOSBaja.DataSource = null;
            dgvOSBaja.DataSource = OS;
            dgvOSBaja.Columns[1].Visible = false;

            dgvOSModif.DataSource = null;
            dgvOSModif.DataSource = OS;
            dgvOSModif.Columns[1].Visible = false;

            tbModifOS.Clear();
            tbOS.Clear();
        }

    }
}
