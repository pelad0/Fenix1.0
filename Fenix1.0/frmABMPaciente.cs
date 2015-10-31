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
    public partial class frmABMPaciente : Form
    {
        public frmABMPaciente()
        {
            InitializeComponent();
        }

        int lista = 1;
        RepositorioPaciente rp = new RepositorioPaciente();
        RepositorioObraSocial ros = new RepositorioObraSocial();
        List<string> OS = new List<string>();
        List<clsPaciente> pacientes = new List<clsPaciente>();

        private void frmABMPaciente_Load(object sender, EventArgs e)
        {
            iniciar();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in tpAlta.Controls)
            {
                if (ctrl is TextBoxLetras)
                {
                    if (string.IsNullOrWhiteSpace((ctrl as TextBoxLetras).Text) || (ctrl as TextBoxLetras).Text.Length < 3)
                    {
                        MessageBox.Show("Completar el campo "+(ctrl as TextBoxLetras).Tag, "Campo Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        (ctrl as TextBoxLetras).Focus();
                        return;
                    }
                }
                else if(ctrl is TextBoxNumeros)
                {
                    if (string.IsNullOrWhiteSpace((ctrl as TextBoxNumeros).Text) || (ctrl as TextBoxLetras).Text.Length < 8)
                    {
                        MessageBox.Show("Completar el campo con la cantidad de digitos correcta." + (ctrl as TextBoxLetras).Tag, "Campo Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        (ctrl as TextBoxNumeros).Focus();
                        return;
                    }
                }else if(ctrl is ComboBox)
                {
                    if(string.IsNullOrWhiteSpace((ctrl as ComboBox).SelectedItem.ToString()))
                    {
                        MessageBox.Show("Seleccione un valor para" + (ctrl as TextBoxLetras).Tag, "Campo Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cbOSAlta.Focus();
                        return;
                    }
                }
            }
            clsPaciente p = new clsPaciente(tbNombreAlta.Text, tbApellidoAlta.Text, Convert.ToInt64(tbDniAlta.Text), cbOSAlta.SelectedItem.ToString(), Convert.ToInt64(tbTelALta.Text));
            try
            {
                rp.Alta(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha pruducido el Sgte. error: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (dgvEliminar.CurrentRow.Index != -1)
            {
                DialogResult res = MessageBox.Show("Desea eliminar a " + pacientes[dgvEliminar.CurrentRow.Index].nomCompleto() + " del registro de pacientes?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (res == DialogResult.OK)
                {
                    try
                    {
                        rp.Baja(pacientes[dgvEliminar.CurrentRow.Index]);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Se ha pruducido el Sgte. error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnAnt_Click(object sender, EventArgs e)
        {
            if (lista > 1)
            {
                lista--;
                dgvEliminar.DataSource = null;
                dgvEliminar.DataSource = rp.Todo(lista);
                dgvEliminar.Columns[0].Visible = false;
                dgvPacMod.Columns[0].Visible = false;
                dgvPacMod.DataSource = rp.Todo(lista);
                dgvPacMod.Columns[0].Visible = false;
            }
        }

        private void btnSig_Click(object sender, EventArgs e)
        {
            lista++;
            dgvEliminar.DataSource = null;
            dgvEliminar.DataSource = rp.Todo(lista);
            dgvEliminar.Columns[0].Visible = false;
            dgvPacMod.Columns[0].Visible = false;
            dgvPacMod.DataSource = rp.Todo(lista);
            dgvPacMod.Columns[0].Visible = false;
        }

        private void iniciar()
        {
            dgvEliminar.DataSource = null;
            pacientes = rp.Todo(lista);
            dgvEliminar.DataSource = pacientes;
            dgvEliminar.Columns[0].Visible = false;
            dgvPacMod.Columns[0].Visible = false;
            dgvPacMod.DataSource = pacientes;
            dgvPacMod.Columns[0].Visible = false;
            List<clsObraSocial> obras = ros.Todo();
            foreach (clsObraSocial obra in obras)
            {
                OS.Add(obra.Nombre);
            }
            cbOSAlta.DataSource = OS;
            cbOSMod.DataSource = OS;
        }

        private void dgvPacMod_SelectionChanged(object sender, EventArgs e)
        {
            tbNombreMod.Text = pacientes[dgvPacMod.CurrentRow.Index].Nombre;
            tbApellidoMod.Text = pacientes[dgvPacMod.CurrentRow.Index].Apellido;
            tbDniMod.Text = pacientes[dgvPacMod.CurrentRow.Index].Dni.ToString();
            tbTelMod.Text = pacientes[dgvPacMod.CurrentRow.Index].Telefono.ToString();
            cbOSMod.SelectedItem = pacientes[dgvPacMod.CurrentRow.Index].ObraSocial;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            if (dgvPacMod.CurrentRow.Index != -1)
            {
                DialogResult res = MessageBox.Show("Desea editar la información de " + pacientes[dgvPacMod.CurrentRow.Index].nomCompleto(), "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (res == DialogResult.OK)
                {
                    foreach (Control ctrl in tpMod.Controls)
                    {
                        if (ctrl is TextBoxLetras)
                        {
                            if (string.IsNullOrWhiteSpace((ctrl as TextBoxLetras).Text) || (ctrl as TextBoxLetras).Text.Length < 3)
                            {
                                MessageBox.Show("Completar el campo " + (ctrl as TextBoxLetras).Tag, "Campo Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                (ctrl as TextBoxLetras).Focus();
                                return;
                            }
                        }
                        else if (ctrl is TextBoxNumeros)
                        {
                            if (string.IsNullOrWhiteSpace((ctrl as TextBoxNumeros).Text) || (ctrl as TextBoxLetras).Text.Length < 8)
                            {
                                MessageBox.Show("Completar el campo con la cantidad de digitos correcta." + (ctrl as TextBoxLetras).Tag, "Campo Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                (ctrl as TextBoxNumeros).Focus();
                                return;
                            }
                        }
                        else if (ctrl is ComboBox)
                        {
                            if (string.IsNullOrWhiteSpace((ctrl as ComboBox).SelectedItem.ToString()))
                            {
                                MessageBox.Show("Seleccione un valor para" + (ctrl as TextBoxLetras).Tag, "Campo Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                cbOSAlta.Focus();
                                return;
                            }
                        }
                    }
                    clsPaciente pac = pacientes[dgvPacMod.CurrentRow.Index];
                    pac.Nombre = tbNombreMod.Text;
                    pac.Apellido = tbApellidoMod.Text;
                    pac.Dni = Convert.ToInt64(tbDniMod.Text);
                    pac.Telefono = Convert.ToInt64(tbTelMod.Text);
                    pac.ObraSocial = cbOSMod.SelectedItem.ToString();
                    try
                    {
                        rp.Modificacion(pac);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Se ha pruducido el Sgte. error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

    }
}
