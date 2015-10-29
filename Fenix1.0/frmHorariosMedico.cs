﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fenix1._0
{
    public partial class frmHorariosMedico : Form
    {
        public frmHorariosMedico()
        {
            InitializeComponent();
        }

        private void rbMT_CheckedChanged(object sender, EventArgs e)
        {
            if(rbMT.Checked)
            {
                pnlMedioTiempo.Visible = true;
                pnlTiempoCompleto.Visible = false;
            }
        }

        private void rbTC_CheckedChanged(object sender, EventArgs e)
        {
            if(rbTC.Checked)
            {
                pnlMedioTiempo.Visible = true;
                pnlTiempoCompleto.Visible = true;
            }
        }

        private void cbLunes_CheckedChanged(object sender, EventArgs e)
        {
            
            if(sender is CheckBox)
            {
                string tag = (sender as CheckBox).Tag.ToString();

                if ((sender as CheckBox).Checked == true)        //Si esta checkeado los quiero aparecer, sino desaparecerlos.
                {
                    Aparecer(tag);
                                        
                }
                else                                            //Los desaparesco.
                {
                    Desaparecer(tag);
                }

            }


        }


        private void Desaparecer(string tag)
        {
            foreach(Control control in this.Controls)
            {
                if(control is DateTimePicker)
                {
                    if(control.Tag.ToString() == tag)
                    {
                        control.Visible = false;
                    }
                }
            }
        }


        private void Aparecer(string tag)
        {
            foreach (Control control in this.Controls)
            {
                if (control is DateTimePicker)
                {
                    if (control.Tag.ToString() == tag)
                    {
                        control.Visible = true;
                    }
                }
            }
        }


    }
}
