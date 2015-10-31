using System;
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

                if (tag == "10" && (sender as CheckBox).Checked == true)        //PREGUNTO SI ES EL CBTODOS.
                {
                    MarcarTodosCB();
                }
                else
                {
                    if ((sender as CheckBox).Checked == true)        //Si esta checkeado los quiero aparecer, sino desaparecerlos.
                    {
                        Aparecer(tag);

                    }
                    else                                            //Los desaparesco.
                    {
                        Desaparecer(tag);
                        cbTodos.Checked = false;
                    }
                }

            }


        }


        private void Desaparecer(string tag)
        {


            foreach(Control control in pnlMedioTiempo.Controls)
            {
                if (control is DateTimePicker || control is CheckBox || control is Label)
                {
                    if(control.Tag.ToString() == tag)
                    {
                        control.Visible = false;
                    }
                }
            }

            foreach (Control control in pnlTiempoCompleto.Controls)
            {
                if (control is DateTimePicker || control is CheckBox || control is Label)
                {
                    if (control.Tag.ToString() == tag)
                    {
                        control.Visible = false;
                    }
                }
            }


        }


        private void Aparecer(string tag)
        {
            foreach (Control control in pnlMedioTiempo.Controls)
            {
                if (control is DateTimePicker || control is CheckBox || control is Label)
                {
                    if (control.Tag.ToString() == tag)
                    {
                        control.Visible = true;
                    }
                }
            }


            foreach (Control control in pnlTiempoCompleto.Controls)
            {
                if (control is DateTimePicker || control is CheckBox || control is Label)
                {
                    if (control.Tag.ToString() == tag)
                    {
                        control.Visible = true;
                    }
                }
            }
        }

        public void MarcarTodosCB()
        {
            foreach(Control control in this.Controls)
            {
                if(control is CheckBox && control.Tag.ToString() != "10")
                {
                    (control as CheckBox).Checked = true;
                }

            }
        }












        private void btnTerminar_Click(object sender, EventArgs e)
        {
            if(rbMT.Checked)    //Si solo va a trabajar medio tiempo creo una lista de horarios.
            {

            }
            else                //Si trabaja tiempo completo creo dos listas.
            {
                
            }



        }

        private void cbRepetirMT_CheckedChanged(object sender, EventArgs e)
        {
            DateTime entradaMT = dtpEntradaMT_Lunes.Value;
            DateTime salidaMT = dtpSalidaMT_Lunes.Value;

            DateTime entradaTC = dtpEntradaTC_Lunes.Value;
            DateTime salidaTC = dtpSalidaTC_Lunes.Value;


            if((sender as CheckBox).Checked)
            {
                if((sender as CheckBox).Name == "cbRepetirMT")
                {
                    foreach(Control control in pnlMedioTiempo.Controls)
                    {
                        if(control.Tag.ToString() != "1" && (control is DateTimePicker))
                        {
                            if ((control as DateTimePicker).TabIndex == 1)
                                (control as DateTimePicker).Value = entradaMT;
                            else
                                (control as DateTimePicker).Value = salidaMT;
                        }
                    }           


                }

                else
                {
                    foreach (Control control in pnlTiempoCompleto.Controls)    
                    {
                        if (control.Tag.ToString() != "1" && (control is DateTimePicker))
                        {
                            if ((control as DateTimePicker).TabIndex == 1)
                                (control as DateTimePicker).Value = entradaTC;
                            else
                                (control as DateTimePicker).Value = salidaTC;
                        }
                    }
                }


                
            }


        }

      

        

       


    }
}
