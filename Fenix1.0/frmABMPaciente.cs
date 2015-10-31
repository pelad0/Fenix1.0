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

        int lista = 1;
        RepositorioPaciente rp = new RepositorioPaciente();

        private void frmABMPaciente_Load(object sender, EventArgs e)
        {
            
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
            int espe;
            //RepositorioEspecialidades re = new RepositorioEspecialidades();
            //List<clsEspecialidad> esp = re.todo();
            //foreach (clsEspecialidad es in esp)
            //{
            //    if (es.Descripcion == cbOSAlta.SelectedItem.ToString())
            //    {
            //        espe = es.Id;
            //    }
            //}

            clsPaciente p = new clsPaciente(tbNombreAlta.Text, tbApellidoAlta.Text, Convert.ToInt64(tbDniAlta.Text), espe, Convert.ToInt64(tbTelALta.Text));

            try
            {
                //rp.Alta(p);

            }
            catch (Exception ex)
            {
                
                throw;
            }
        }

        private void btnAnt_Click(object sender, EventArgs e)
        {

        }

        private void btnSig_Click(object sender, EventArgs e)
        {

        }
    }
}
