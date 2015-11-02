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
using frmABMME;

namespace Fenix1._0
{
    public partial class frmABMUsuario : Form
    {
        RepositorioUsuario ru = new RepositorioUsuario();
        List<clsUsuario> usuarios = new List<clsUsuario>();
        
        public frmABMUsuario()
        {
            InitializeComponent();
        }

        private void frmABMUsuario_Load(object sender, EventArgs e)
        {
            iniciar();
        }

        private void dgvModif_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(usuarios[dgvModif.CurrentRow.Index].Usuario))
            {

                clsUsuario u = usuarios[dgvModif.CurrentRow.Index];
                tbUsuMod.Text = u.Usuario;
                tbContMod.Text = u.Clave;
                tbContMod2.Text = u.Clave;
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbUsuAlta.Text) && !string.IsNullOrWhiteSpace(tbContAlta1.Text) && !string.IsNullOrWhiteSpace(tbContAlta2.Text) && cbSeguridad.SelectedIndex > -1)
            {
                if (tbContAlta1.Text == tbContAlta2.Text)
                {
                    clsUsuario u = new clsUsuario(tbUsuAlta.Text, tbContAlta1.Text, cbSeguridad.SelectedItem.ToString());
                    try
                    {
                        ru.Alta(u);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Se ha pruducido el Sgte. error: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        iniciar();
                    }
                }
                else
                {
                    MessageBox.Show("Las contraseñas ingresadas no coinciden.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                MessageBox.Show("Complete todos los campos correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(usuarios[dgvEliminar.CurrentRow.Index].Usuario))
            {
                if (usuarios[dgvEliminar.CurrentRow.Index].Usuario == "admin")
                {
                    MessageBox.Show("No esta permitido que se elimine admin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                frmConfirmaUsuario fcu = new frmConfirmaUsuario(usuarios[dgvEliminar.CurrentRow.Index].Clave);
                DialogResult res = fcu.ShowDialog();
                if (res == DialogResult.OK)
                {
                    try
                    {
                        string nombre = usuarios[dgvEliminar.CurrentRow.Index].Usuario;
                        ru.Baja(usuarios[dgvEliminar.CurrentRow.Index]);
                        MessageBox.Show(nombre + " se elimino con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Se ha pruducido el Sgte. error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        iniciar();
                    }
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (comprobarDatosModif())
            {
                clsUsuario u = usuarios[dgvModif.CurrentRow.Index];
                frmConfirmaUsuario fcu = new frmConfirmaUsuario(u.Clave);
                DialogResult res = fcu.ShowDialog();
                if (res == DialogResult.OK)
                {
                    u.Clave = tbContMod.Text;
                    u.Usuario = tbUsuMod.Text;
                    u.Seguridad = cbSegMod.SelectedItem.ToString();
                    try
                    {
                        ru.Modificacion(u);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Se ha pruducido el Sgte. error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        iniciar();
                    }
                }
            }
        }

        private bool comprobarDatosModif()
        {
            foreach (Control c in tpMod.Controls)
            {
                if (c is TextBox)
                {
                    if (string.IsNullOrWhiteSpace((c as TextBox).Text))
                    {
                        MessageBox.Show("Campo " + (c as TextBox).Tag + " incompleto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else if (c is ComboBox)
                {
                    if ((c as ComboBox).SelectedIndex < 0)
                    {
                        MessageBox.Show("Campo " + (c as ComboBox).Tag + " incompleto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        private void iniciar()
        {
            usuarios.Clear();
            usuarios = ru.Todo(0);
            dgvEliminar.DataSource = null;
            dgvEliminar.DataSource = usuarios;
            dgvEliminar.Columns[0].Visible = false;
            dgvEliminar.Columns[2].Visible = false;

            dgvModif.DataSource = null;
            dgvModif.DataSource = usuarios;
            dgvModif.Columns[0].Visible = false;
            dgvModif.Columns[2].Visible = false;

            tbContAlta1.Clear();
            tbContAlta2.Clear();
            tbUsuAlta.Clear();
            cbSeguridad.SelectedIndex = -1;
            cbSegMod.SelectedIndex = -1;
        }

        private void dgvModif_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(usuarios[dgvModif.CurrentRow.Index].Usuario))
            {

                clsUsuario u = usuarios[dgvModif.CurrentRow.Index];
                tbUsuMod.Text = u.Usuario;
                tbContMod.Text = u.Clave;
                tbContMod2.Text = u.Clave;
                cbSegMod.SelectedItem = u.Seguridad;
            }
            else
            {
                tbUsuMod.Clear();
                tbContMod.Clear();
                tbContMod2.Clear();
                cbSegMod.SelectedIndex = -1;

            }

        }

    }
}
