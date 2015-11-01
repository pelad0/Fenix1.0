﻿using System;
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

        int pagina = 0;
        RepositorioPaciente rp = new RepositorioPaciente();
        RepositorioObraSocial ros = new RepositorioObraSocial();
        List<string> OS = new List<string>();
        List<clsPaciente> pacientes = new List<clsPaciente>();

        private void frmABMPaciente_Load(object sender, EventArgs e)
        {
            iniciar();
        }

        private void dgvPacMod_SelectionChanged(object sender, EventArgs e)
        {
            int pos = dgvPacMod.CurrentRow.Index;
            tbNombreMod.Text = pacientes[pos].Nombre;
            tbApellidoMod.Text = pacientes[pos].Apellido;
            tbDniMod.Text = pacientes[pos].Dni.ToString();
            tbTelMod.Text = pacientes[pos].Telefono.ToString();
            cbOSMod.SelectedItem = pacientes[pos].ObraSocial;
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (comprobarCamposAlta())
            {
                clsPaciente p = new clsPaciente(tbNombreAlta.Text, tbApellidoAlta.Text, Convert.ToInt64(tbDniAlta.Text), cbOSAlta.SelectedItem.ToString(), Convert.ToInt64(tbTelALta.Text));
                try
                {
                    rp.Alta(p);
                    iniciar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se ha pruducido el Sgte. error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    iniciar();
                }
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (dgvBaja.CurrentRow.Index != -1)
            {
                DialogResult res = MessageBox.Show("Desea eliminar a " + pacientes[dgvBaja.CurrentRow.Index].nomCompleto() + " del registro de pacientes?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (res == DialogResult.OK)
                {
                    try
                    {
                        rp.Baja(pacientes[dgvBaja.CurrentRow.Index]);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Se ha pruducido el Sgte. error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        iniciar();
                    }
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(dgvPacMod.CurrentRow.Index.ToString()))
            {
                DialogResult res = MessageBox.Show("Desea editar la información de " + pacientes[dgvPacMod.CurrentRow.Index].nomCompleto(), "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (res == DialogResult.OK)
                {
                    if (comprobarCamposModif())
                    {
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
                        finally
                        {
                            iniciar();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione algún paciente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbBuscar.Text))
            {
                iniciar();
            }
            else
            {
                try
                {
                    dgvAlta.DataSource = null;
                    dgvAlta.DataSource = rp.buscarDni(Convert.ToInt64(tbBuscar.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se ha pruducido el Sgte. error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAnt_Click(object sender, EventArgs e)
        {
            if (pagina > 1)
            {
                pagina--;
                pacientes = rp.Todo(pagina);

                dgvBaja.DataSource = null;
                dgvBaja.DataSource = pacientes;
                dgvBaja.Columns[0].Visible = false;

                dgvPacMod.DataSource = null;
                dgvPacMod.DataSource = pacientes;
                dgvPacMod.Columns[0].Visible = false;

                dgvAlta.DataSource = null;
                dgvAlta.DataSource = pacientes;
                dgvAlta.Columns[0].Visible = false;
            }
        }

        private void btnSig_Click(object sender, EventArgs e)
        {
            pacientes = rp.Todo(pagina);
            pagina++;

            dgvBaja.DataSource = null;
            dgvBaja.DataSource = pacientes;
            dgvBaja.Columns[0].Visible = false;

            dgvPacMod.DataSource = null;
            dgvPacMod.DataSource = pacientes;
            dgvPacMod.Columns[0].Visible = false;

            dgvAlta.DataSource = null;
            dgvAlta.DataSource = pacientes;
            dgvAlta.Columns[0].Visible = false;
        }

        private void btnDarTurno_Click(object sender, EventArgs e)
        {

        }

        private void iniciar()
        {
            pagina = 0;

            pacientes = rp.Todo(pagina);

            dgvAlta.DataSource = null;
            dgvAlta.DataSource = pacientes;
            dgvAlta.Columns[0].Visible = false;

            dgvBaja.DataSource = null;
            dgvBaja.DataSource = pacientes;
            dgvBaja.Columns[0].Visible = false;

            dgvPacMod.DataSource = null;
            dgvPacMod.DataSource = pacientes;
            dgvPacMod.Columns[0].Visible = false;

            List<clsObraSocial> obras = ros.Todo(0);
            foreach (clsObraSocial obra in obras)
            {
                OS.Add(obra.Nombre);
            }
            cbOSAlta.DataSource = OS;
            cbOSMod.DataSource = OS;

            tbBuscar.Clear();
            tbNombreAlta.Clear();
            tbApellidoAlta.Clear();
            tbDniAlta.Clear();
            tbTelALta.Clear();
            cbOSAlta.SelectedIndex = -1;

            tbNombreMod.Clear();
            tbApellidoMod.Clear();
            tbDniMod.Clear();
            tbTelMod.Clear();
            cbOSMod.SelectedIndex = -1;
        }

        private bool comprobarCamposAlta()
        {
            foreach (Control ctrl in tpAlta.Controls)
            {
                if (ctrl is TextBoxLetras)
                {
                    if (string.IsNullOrWhiteSpace((ctrl as TextBoxLetras).Text) || (ctrl as TextBoxLetras).Text.Length < 3)
                    {
                        MessageBox.Show("Completar el campo " + (ctrl as TextBoxLetras).Tag, "Campo Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        (ctrl as TextBoxLetras).Focus();
                        return false;
                    }
                }
                else if (ctrl is TextBoxNumeros)
                {
                    if (string.IsNullOrWhiteSpace((ctrl as TextBoxNumeros).Text) || (ctrl as TextBoxLetras).Text.Length < 8)
                    {
                        MessageBox.Show("Completar el campo con la cantidad de digitos correcta." + (ctrl as TextBoxLetras).Tag, "Campo Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        (ctrl as TextBoxNumeros).Focus();
                        return false;
                    }
                }
                else if (ctrl is ComboBox)
                {
                    if (string.IsNullOrWhiteSpace((ctrl as ComboBox).SelectedItem.ToString()))
                    {
                        MessageBox.Show("Seleccione un valor para" + (ctrl as TextBoxLetras).Tag, "Campo Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cbOSAlta.Focus();
                        return false;
                    }
                }
            }
            return true;
        }

        private bool comprobarCamposModif()
        {
            foreach (Control ctrl in tpMod.Controls)
            {
                if (ctrl is TextBoxLetras)
                {
                    if (string.IsNullOrWhiteSpace((ctrl as TextBoxLetras).Text) || (ctrl as TextBoxLetras).Text.Length < 3)
                    {
                        MessageBox.Show("Completar el campo " + (ctrl as TextBoxLetras).Tag, "Campo Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        (ctrl as TextBoxLetras).Focus();
                        return false;
                    }
                }
                else if (ctrl is TextBoxNumeros)
                {
                    if (string.IsNullOrWhiteSpace((ctrl as TextBoxNumeros).Text) || (ctrl as TextBoxLetras).Text.Length < 8)
                    {
                        MessageBox.Show("Completar el campo con la cantidad de digitos correcta." + (ctrl as TextBoxLetras).Tag, "Campo Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        (ctrl as TextBoxNumeros).Focus();
                        return false;
                    }
                }
                else if (ctrl is ComboBox)
                {
                    if (string.IsNullOrWhiteSpace((ctrl as ComboBox).SelectedItem.ToString()))
                    {
                        MessageBox.Show("Seleccione un valor para" + (ctrl as TextBoxLetras).Tag, "Campo Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cbOSAlta.Focus();
                        return false;
                    }
                }
            }
            return true;
        }

    }
}
