using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using logica;
using entidades;

namespace Fenix1._0
{
    public partial class frmHorariosMedico : Form
    {

        frmABMME FormMaestro;

        public frmHorariosMedico(frmABMME frmQueViene)
        {
            InitializeComponent();
            FormMaestro = frmQueViene;
        }

        clsHorario horario = new clsHorario();
        clsHorario horarioTC = new clsHorario();


        private void rbMT_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMT.Checked)
            {
                pnlMedioTiempo.Visible = true;
                pnlTiempoCompleto.Visible = false;
            }
        }

        private void rbTC_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAmbos.Checked)
            {
                pnlMedioTiempo.Visible = true;
                pnlTiempoCompleto.Visible = true;
            }
        }

        private void rbTarde_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTarde.Checked)
            {
                pnlMedioTiempo.Visible = false;
                pnlTiempoCompleto.Visible = true;
            }
        }


        private void cbLunes_CheckedChanged(object sender, EventArgs e)
        {

            if (sender is CheckBox)
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


            foreach (Control control in pnlMedioTiempo.Controls)
            {
                if (control is DateTimePicker || control is CheckBox || control is Label)
                {
                    if (control.Tag.ToString() == tag)
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
            foreach (Control control in this.Controls)
            {
                if (control is CheckBox && control.Tag.ToString() != "10")
                {
                    (control as CheckBox).Checked = true;
                }

            }
        }


        private void btnTerminar_Click(object sender, EventArgs e)
        {
            if (rbAmbos.Checked)    //Si el medico trabaja tiempo completo algún día.
            {
                if (cbLunes.Checked == false && cbMartes.Checked == false && cbMiercoles.Checked == false && cbJueves.Checked == false && cbViernes.Checked == false && cbSabado.Checked == false && cbDomingo.Checked == false)
                {
                    MessageBox.Show("Debe seleccionar al menos un dia de trabajo para el Médico");
                }
                else        //Si tiene algun horario de medio tiempo seleccionado.
                {


                    bool errores = false;

                    if (cbLunes.Checked == true)
                    {
                        if ((dtpEntradaMT_Lunes.Value < dtpSalidaMT_Lunes.Value) && (dtpEntradaTC_Lunes.Value < dtpSalidaTC_Lunes.Value))
                        {
                            horario.LunesEntrada = dtpEntradaMT_Lunes.Value;
                            horario.LunesSalida = dtpSalidaMT_Lunes.Value;

                            horarioTC.LunesEntrada = dtpEntradaTC_Lunes.Value;
                            horarioTC.LunesSalida = dtpSalidaTC_Lunes.Value;

                        }
                        else
                            errores = true;
                    }

                    if (cbMartes.Checked == true)
                    {
                        if ((dtpEntradaMT_Martes.Value < dtpSalidaMT_Martes.Value) && (dtpEntradaTC_Martes.Value < dtpSalidaTC_Martes.Value))
                        {
                            horario.MartesEntrada = dtpEntradaMT_Martes.Value;
                            horario.MartesSalida = dtpSalidaMT_Martes.Value;

                            horarioTC.MartesEntrada = dtpEntradaTC_Martes.Value;
                            horarioTC.MartesSalida = dtpSalidaTC_Martes.Value;
                        }
                        else
                            errores = true;
                    }

                    if (cbMiercoles.Checked == true)
                    {
                        if ((dtpEntradaMT_Miercoles.Value < dtpSalidaMT_Miercoles.Value) && (dtpEntradaTC_Miercoles.Value < dtpSalidaTC_Miercoles.Value))
                        {
                            horario.MiercolesEntrada = dtpEntradaMT_Miercoles.Value;
                            horario.MiercolesSalida = dtpSalidaMT_Miercoles.Value;

                            horarioTC.MiercolesEntrada = dtpEntradaTC_Miercoles.Value;
                            horarioTC.MiercolesSalida = dtpSalidaTC_Miercoles.Value;
                        }
                        else
                            errores = true;
                    }

                    if (cbJueves.Checked == true)
                    {
                        if ((dtpEntradaMT_Jueves.Value < dtpSalidaMT_Jueves.Value) && (dtpEntradaTC_Jueves.Value < dtpSalidaTC_Jueves.Value))
                        {
                            horario.JuevesEntrada = dtpEntradaMT_Jueves.Value;
                            horario.JuevesSalida = dtpSalidaMT_Jueves.Value;

                            horarioTC.JuevesEntrada = dtpEntradaTC_Jueves.Value;
                            horarioTC.JuevesSalida = dtpSalidaTC_Jueves.Value;
                        }
                        else
                            errores = true;
                    }

                    if (cbViernes.Checked == true)
                    {
                        if ((dtpEntradaMT_Viernes.Value < dtpSalidaMT_Viernes.Value) && (dtpEntradaTC_Viernes.Value < dtpSalidaTC_Viernes.Value))
                        {
                            horario.ViernesEntrada = dtpEntradaMT_Viernes.Value;
                            horario.ViernesSalida = dtpSalidaMT_Viernes.Value;

                            horarioTC.ViernesEntrada = dtpEntradaTC_Viernes.Value;
                            horarioTC.ViernesSalida = dtpSalidaTC_Viernes.Value;

                        }
                        else
                            errores = true;
                    }

                    if (cbSabado.Checked == true)
                    {
                        if ((dtpEntradaMT_Sabado.Value < dtpSalidaMT_Sabado.Value) && (dtpEntradaTC_Sabado.Value < dtpSalidaTC_Sabado.Value))
                        {
                            horario.SabadoEntrada = dtpEntradaMT_Sabado.Value;
                            horario.SabadoSalida = dtpSalidaMT_Sabado.Value;

                            horarioTC.SabadoEntrada = dtpEntradaTC_Sabado.Value;
                            horarioTC.SabadoSalida = dtpSalidaTC_Sabado.Value;

                        }
                        else
                            errores = true;
                    }

                    if (cbDomingo.Checked == true)
                    {
                        if ((dtpEntradaMT_Domingo.Value < dtpSalidaMT_Domingo.Value) && (dtpEntradaTC_Domingo.Value < dtpSalidaTC_Domingo.Value))
                        {
                            horario.DomingoEntrada = dtpEntradaMT_Domingo.Value;
                            horario.DomingoSalida = dtpSalidaMT_Domingo.Value;

                            horarioTC.DomingoEntrada = dtpEntradaTC_Domingo.Value;
                            horarioTC.DomingoSalida = dtpSalidaTC_Domingo.Value;

                        }
                        else
                            errores = true;
                    }

                    if (errores == true)
                    {
                        MessageBox.Show("Alguno de sus horarios de entrada es mayor al horario de salida", "Error de horario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        FormMaestro.CargarHorarios(horario, horarioTC);
                       
                        this.Close();

                        //AQUÍ TERMINA EL DOBLE TURNO..
                    }
                }


            }
            else
            {
                DateTime dateNow;
                dateNow = DateTime.Now;

                if (rbMT.Checked)    //SI EL MEDICO TRABAJA SOLO MAÑANA
                {
                    if (cbLunes.Checked == false && cbMartes.Checked == false && cbMiercoles.Checked == false && cbJueves.Checked == false && cbViernes.Checked == false && cbSabado.Checked == false && cbDomingo.Checked == false)
                    {
                        MessageBox.Show("Debe seleccionar al menos un dia de trabajo para el Médico");
                    }
                    else        //Si tiene algun horario de medio tiempo seleccionado.
                    {

                        bool errores = false;

                        if (cbLunes.Checked == true)
                        {
                            if (dtpEntradaMT_Lunes.Value < dtpSalidaMT_Lunes.Value)
                            {
                                horario.LunesEntrada = dtpEntradaMT_Lunes.Value;                                
                                horario.LunesSalida = dtpSalidaMT_Lunes.Value;
                            }
                            else
                                errores = true;
                        }

                        if (cbMartes.Checked == true)
                        {
                            if (dtpEntradaMT_Martes.Value < dtpSalidaMT_Martes.Value)
                            {
                                horario.MartesEntrada = dtpEntradaMT_Martes.Value;
                                horario.MartesSalida = dtpSalidaMT_Martes.Value;
                            }
                            else
                                errores = true;
                        }

                        if (cbMiercoles.Checked == true)
                        {
                            if (dtpEntradaMT_Miercoles.Value < dtpSalidaMT_Miercoles.Value)
                            {
                                horario.MiercolesEntrada = dtpEntradaMT_Miercoles.Value;
                                horario.MiercolesSalida = dtpSalidaMT_Miercoles.Value;
                            }
                            else
                                errores = true;
                        }

                        if (cbJueves.Checked == true)
                        {
                            if (dtpEntradaMT_Jueves.Value < dtpSalidaMT_Jueves.Value)
                            {
                                horario.JuevesEntrada = dtpEntradaMT_Jueves.Value;
                                horario.JuevesSalida = dtpSalidaMT_Jueves.Value;
                            }
                            else
                                errores = true;
                        }

                        if (cbViernes.Checked == true)
                        {
                            if (dtpEntradaMT_Viernes.Value < dtpSalidaMT_Viernes.Value)
                            {
                                horario.ViernesEntrada = dtpEntradaMT_Viernes.Value;
                                horario.ViernesSalida = dtpSalidaMT_Viernes.Value;
                            }
                            else
                                errores = true;
                        }

                        if (cbSabado.Checked == true)
                        {
                            if (dtpEntradaMT_Sabado.Value < dtpSalidaMT_Sabado.Value)
                            {
                                horario.SabadoEntrada = dtpEntradaMT_Sabado.Value;
                                horario.SabadoSalida = dtpSalidaMT_Sabado.Value;
                            }
                            else
                                errores = true;
                        }

                        if (cbDomingo.Checked == true)
                        {
                            if (dtpEntradaMT_Domingo.Value < dtpSalidaMT_Domingo.Value)
                            {
                                horario.DomingoEntrada = dtpEntradaMT_Domingo.Value;
                                horario.DomingoSalida = dtpSalidaMT_Domingo.Value;
                            }
                            else
                                errores = true;
                        }

                        if (errores)
                        {
                            MessageBox.Show("Alguno de sus horarios de entrada es mayor al horario de salida", "Error de horario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {

                            FormMaestro.CargarHorarios(horario, 1);
                      
                            this.Close();

                            //AQUÍ TERMINA EL TRABAJA SOLO MAÑANA
                        }
                    }
                }
                else            //SI EK MEDICO TRABAJA SOLO TARDE.
                {
                    bool errores = false;

                    if (cbLunes.Checked == true)
                    {
                        if (dtpEntradaTC_Lunes.Value < dtpSalidaTC_Lunes.Value)
                        {
                            horario.LunesEntrada = dtpEntradaTC_Lunes.Value;
                            horario.LunesSalida = dtpSalidaTC_Lunes.Value;
                        }
                        else
                            errores = true;
                    }

                    if (cbMartes.Checked == true)
                    {
                        if (dtpEntradaTC_Martes.Value < dtpSalidaTC_Martes.Value)
                        {
                            horario.MartesEntrada = dtpEntradaTC_Martes.Value;
                            horario.MartesSalida = dtpSalidaTC_Martes.Value;
                        }
                        else
                            errores = true;
                    }

                    if (cbMiercoles.Checked == true)
                    {
                        if (dtpEntradaTC_Miercoles.Value < dtpSalidaTC_Miercoles.Value)
                        {
                            horario.MiercolesEntrada = dtpEntradaTC_Miercoles.Value;
                            horario.MiercolesSalida = dtpSalidaTC_Miercoles.Value;
                        }
                        else
                            errores = true;
                    }

                    if (cbJueves.Checked == true)
                    {
                        if (dtpEntradaTC_Jueves.Value < dtpSalidaTC_Jueves.Value)
                        {
                            horario.JuevesEntrada = dtpEntradaTC_Jueves.Value;
                            horario.JuevesSalida = dtpSalidaTC_Jueves.Value;
                        }
                        else
                            errores = true;
                    }

                    if (cbViernes.Checked == true)
                    {
                        if (dtpEntradaTC_Viernes.Value < dtpSalidaTC_Viernes.Value)
                        {
                            horario.ViernesEntrada = dtpEntradaTC_Viernes.Value;
                            horario.ViernesSalida = dtpSalidaTC_Viernes.Value;
                        }
                        else
                            errores = true;
                    }

                    if (cbSabado.Checked == true)
                    {
                        if (dtpEntradaTC_Sabado.Value < dtpSalidaTC_Sabado.Value)
                        {
                            horario.SabadoEntrada = dtpEntradaTC_Sabado.Value;
                            horario.SabadoSalida = dtpSalidaTC_Sabado.Value;
                        }
                        else
                            errores = true;
                    }

                    if (cbDomingo.Checked == true)
                    {
                        if (dtpEntradaTC_Domingo.Value < dtpSalidaTC_Domingo.Value)
                        {
                            horario.DomingoEntrada = dtpEntradaTC_Domingo.Value;
                            horario.DomingoSalida = dtpSalidaTC_Domingo.Value;
                        }
                        else
                            errores = true;
                    }

                    if (errores)
                    {
                        MessageBox.Show("Alguno de sus horarios de entrada es mayor al horario de salida", "Error de horario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        FormMaestro.CargarHorarios(horario, 2);
                       
                        this.Close();

                        //AQUÍ TERMINA EL TRABAJA SOLO TARDE.
                    }
                }
            }


        }



        private void cbRepetirMT_CheckedChanged(object sender, EventArgs e)
        {
            DateTime entradaMT = dtpEntradaMT_Lunes.Value;
            DateTime salidaMT = dtpSalidaMT_Lunes.Value;

            DateTime entradaTC = dtpEntradaTC_Lunes.Value;
            DateTime salidaTC = dtpSalidaTC_Lunes.Value;


            if ((sender as CheckBox).Checked)
            {
                if ((sender as CheckBox).Name == "cbRepetirMT")
                {
                    foreach (Control control in pnlMedioTiempo.Controls)
                    {
                        if (control.Tag.ToString() != "1" && (control is DateTimePicker))
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

        private void frmHorariosMedico_Load(object sender, EventArgs e)
        {

        }









    }
}
