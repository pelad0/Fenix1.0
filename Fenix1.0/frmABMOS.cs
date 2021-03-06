﻿using System;
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
                DialogResult res = MessageBox.Show("Agregar a " + tbOS.Text +" con un máximo de cobertura de $"+ tbPesosAlta.Text+"."+tbCentAlta.Text+" al sistema?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (res == DialogResult.OK)
                {
                    float monto = float.Parse(tbPesosAlta.Text) + (float.Parse(tbCentAlta.Text) / 100);
                    clsObraSocial OSoc = new clsObraSocial(tbOS.Text, monto);
                    try
                    {
                        ros.Alta(OSoc);
                        iniciar();
                        tbOS.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Se ha producido el Sgte. error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        MessageBox.Show("Se ha producido el Sgte. error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        OS[pos].Nombre = tbModifOS.Text;
                        OS[pos].Monto = float.Parse(tbPesosMod.Text) + (float.Parse(tbCentMov.Text) / 100);
                        ros.Modificacion(OS[pos]);
                        iniciar();
                        tbModifOS.Focus();
                        MessageBox.Show(anterior+" cambió a: "+OS[pos].Nombre, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Se ha producido el Sgte. error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            tbPesosMod.Text = OS[dgvOSModif.CurrentRow.Index].pesos().ToString();

            if (OS[dgvOSModif.CurrentRow.Index].cent().ToString() == "0")
            {
                tbCentMov.Text = "00";
            }
            else
            {
                tbCentMov.Text = OS[dgvOSModif.CurrentRow.Index].cent().ToString();
            }
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
            tbPesosAlta.Text = "00";
            tbPesosMod.Text = "00";
            tbCentAlta.Text = "00";
            tbCentMov.Text = "00";

            tbOS.Clear();
        }


    }
}
