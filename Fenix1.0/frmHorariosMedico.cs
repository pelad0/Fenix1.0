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
        frmEditarMedico formEditarMedico;

        int valor = 0;
        clsMedico medicoEditar;

        RepositorioHorario reposHorario = new RepositorioHorario();

        public frmHorariosMedico(frmABMME frmQueViene)
        {
            InitializeComponent();
            FormMaestro = frmQueViene;
        }

        public frmHorariosMedico(clsMedico med, frmEditarMedico fo)
        {
            InitializeComponent();
            medicoEditar = med;
            valor = 1;
            formEditarMedico = fo;

        }


        clsHorario horario = new clsHorario();
        clsHorario horarioTC = new clsHorario();

        DateTime tiempo = new DateTime();


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
            if (valor != 1)
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

            else     //SE VA A MODIFICAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAARRRRRRRRRR
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

                            formEditarMedico.sincronizarHorarios(horario, horarioTC);
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

                                formEditarMedico.sincronizarHorarios(horario, 1);

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
                            formEditarMedico.sincronizarHorarios(horario, 2);

                            this.Close();

                            //AQUÍ TERMINA EL TRABAJA SOLO TARDE.
                        }
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
            if(valor == 1)
            {

                bool mañana = false;
                bool tarde = false;

                clsHorario horariosMañana = new clsHorario();
                clsHorario horariosTarde = new clsHorario();

                try
                {
                    horariosMañana = reposHorario.buscarPorId(medicoEditar.Id, 1);
                    mañana = true;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                try
                {
                    horariosTarde = reposHorario.buscarPorId(medicoEditar.Id, 2);
                    tarde = true;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                if(mañana == true && tarde == true)     //QUE TRABAJA LOS DOS DIAS
                {
                    rbAmbos.Checked = true;

          

                    if(horariosMañana.LunesEntrada.Value.Year != 1900 )     //si es distinto de null;
                    {
                        dtpEntradaMT_Lunes.Value = horariosMañana.LunesEntrada.Value;

                        dtpSalidaMT_Lunes.Value = horariosMañana.LunesSalida.Value;

                        dtpEntradaTC_Lunes.Value = horariosTarde.LunesEntrada.Value;

                        dtpSalidaTC_Lunes.Value = horariosTarde.LunesSalida.Value;

                        cbLunes.Checked = true;
                    }
                    else
                    {
                        cbLunes.Checked = false;                    
                    }


                    if (horariosMañana.MartesEntrada.Value.Year != 1900)     
                    {
                        dtpEntradaMT_Martes.Value = horariosMañana.MartesEntrada.Value;

                        dtpSalidaMT_Martes.Value = horariosMañana.MartesSalida.Value;

                        dtpEntradaTC_Martes.Value = horariosTarde.MartesEntrada.Value;

                        dtpSalidaTC_Martes.Value = horariosTarde.MartesSalida.Value;

                        cbMartes.Checked = true;
                    }
                    else
                    {
                        cbMartes.Checked = false;
                    }


                    if(horariosMañana.MiercolesEntrada.Value.Year != 1900)
                    {
                        dtpEntradaMT_Miercoles.Value = horariosMañana.MiercolesEntrada.Value;

                        dtpSalidaMT_Miercoles.Value = horariosMañana.MiercolesSalida.Value;

                        dtpEntradaTC_Miercoles.Value = horariosTarde.MiercolesEntrada.Value;

                        dtpSalidaTC_Miercoles.Value = horariosTarde.MiercolesSalida.Value;

                        cbMiercoles.Checked = true;
                    }
                    else
                    {
                        cbMiercoles.Checked = false;
                    }



                    if(horariosMañana.JuevesEntrada.Value.Year != 1900)
                    {
                        dtpEntradaMT_Jueves.Value = horariosMañana.JuevesEntrada.Value;

                        dtpSalidaMT_Jueves.Value = horariosMañana.JuevesSalida.Value;

                        dtpEntradaTC_Jueves.Value = horariosTarde.JuevesEntrada.Value;

                        dtpSalidaTC_Jueves.Value = horariosTarde.JuevesSalida.Value;

                        cbJueves.Checked = true;
                    }
                    else
                    {
                        cbJueves.Checked = false;
                    }


                    if(horariosMañana.ViernesEntrada.Value.Year != 1900)
                    {
                        dtpEntradaMT_Viernes.Value = horariosMañana.ViernesEntrada.Value;

                        dtpSalidaMT_Viernes.Value = horariosMañana.ViernesSalida.Value;

                        dtpEntradaTC_Viernes.Value = horariosTarde.ViernesEntrada.Value;

                        dtpSalidaTC_Viernes.Value = horariosTarde.ViernesSalida.Value;

                        cbViernes.Checked = true;
                    }
                    else
                    {
                        cbViernes.Checked = false;
                    }


                    if(horariosMañana.SabadoEntrada.Value.Year != 1900)
                    {
                        dtpEntradaMT_Sabado.Value = horariosMañana.SabadoEntrada.Value;

                        dtpSalidaMT_Sabado.Value = horariosMañana.SabadoSalida.Value;

                        dtpEntradaTC_Sabado.Value = horariosTarde.SabadoEntrada.Value;

                        dtpSalidaTC_Sabado.Value = horariosTarde.SabadoSalida.Value;

                        cbViernes.Checked = true;

                    }
                    else
                    {
                        cbViernes.Checked = false;
                    }


                    if(horariosMañana.DomingoEntrada.Value.Year != 1900)
                    {
                        dtpEntradaMT_Domingo.Value = horariosMañana.DomingoEntrada.Value;

                        dtpSalidaMT_Domingo.Value = horariosMañana.DomingoSalida.Value;

                        dtpEntradaTC_Domingo.Value = horariosTarde.DomingoEntrada.Value;

                        dtpSalidaTC_Domingo.Value = horariosTarde.DomingoSalida.Value;

                        cbDomingo.Checked = true;
                    }
                    else
                    {
                        cbDomingo.Checked = false;
                    }


                    if(cbLunes.Checked && cbMartes.Checked && cbMiercoles.Checked && cbJueves.Checked && cbViernes.Checked && cbSabado.Checked && cbDomingo.Checked)
                    {
                        cbTodos.Checked = true;
                    }



                }
                else                    //SI ES SOLO O MAÑANA O TARDE
                {
                    if(mañana == true)
                    {
                        rbMT.Checked = true;

                        if (horariosMañana.LunesEntrada.Value.Year != 1900)     //si es distinto de null;
                        {
                            dtpEntradaMT_Lunes.Value = horariosMañana.LunesEntrada.Value;

                            dtpSalidaMT_Lunes.Value = horariosMañana.LunesSalida.Value;

                           

                            cbLunes.Checked = true;
                        }
                        else
                        {
                            cbLunes.Checked = false;
                        }


                        if (horariosMañana.MartesEntrada.Value.Year != 1900)
                        {
                            dtpEntradaMT_Martes.Value = horariosMañana.MartesEntrada.Value;

                            dtpSalidaMT_Martes.Value = horariosMañana.MartesSalida.Value;

                            

                            cbMartes.Checked = true;
                        }
                        else
                        {
                            cbMartes.Checked = false;
                        }


                        if (horariosMañana.MiercolesEntrada.Value.Year != 1900)
                        {
                            dtpEntradaMT_Miercoles.Value = horariosMañana.MiercolesEntrada.Value;

                            dtpSalidaMT_Miercoles.Value = horariosMañana.MiercolesSalida.Value;


                            cbMiercoles.Checked = true;
                        }
                        else
                        {
                            cbMiercoles.Checked = false;
                        }



                        if (horariosMañana.JuevesEntrada.Value.Year != 1900)
                        {
                            dtpEntradaMT_Jueves.Value = horariosMañana.JuevesEntrada.Value;

                            dtpSalidaMT_Jueves.Value = horariosMañana.JuevesSalida.Value;


                            cbJueves.Checked = true;
                        }
                        else
                        {
                            cbJueves.Checked = false;
                        }


                        if (horariosMañana.ViernesEntrada.Value.Year != 1900)
                        {
                            dtpEntradaMT_Viernes.Value = horariosMañana.ViernesEntrada.Value;

                            dtpSalidaMT_Viernes.Value = horariosMañana.ViernesSalida.Value;

           

                            cbViernes.Checked = true;
                        }
                        else
                        {
                            cbViernes.Checked = false;
                        }


                        if (horariosMañana.SabadoEntrada.Value.Year != 1900)
                        {
                            dtpEntradaMT_Sabado.Value = horariosMañana.SabadoEntrada.Value;

                            dtpSalidaMT_Sabado.Value = horariosMañana.SabadoSalida.Value;


                            cbSabado.Checked = true;

                        }
                        else
                        {
                            cbSabado.Checked = false;
                        }


                        if (horariosMañana.DomingoEntrada.Value.Year != 1900)
                        {
                            dtpEntradaMT_Domingo.Value = horariosMañana.DomingoEntrada.Value;

                            dtpSalidaMT_Domingo.Value = horariosMañana.DomingoSalida.Value;


                            cbDomingo.Checked = true;
                        }
                        else
                        {
                            cbDomingo.Checked = false;
                        }


                        if (cbLunes.Checked && cbMartes.Checked && cbMiercoles.Checked && cbJueves.Checked && cbViernes.Checked && cbSabado.Checked && cbDomingo.Checked)
                        {
                            cbTodos.Checked = true;
                        }

                    }
                    if(tarde == true)
                    {
                        rbTarde.Checked = true;


                        if (horariosTarde.LunesEntrada.Value.Year != 1900)     //si es distinto de null;
                        {
                            
                            dtpEntradaTC_Lunes.Value = horariosTarde.LunesEntrada.Value;

                            dtpSalidaTC_Lunes.Value = horariosTarde.LunesSalida.Value;

                            cbLunes.Checked = true;
                        }
                        else
                        {
                            cbLunes.Checked = false;
                        }


                        if (horariosTarde.MartesEntrada.Value.Year != 1900)
                        {
                           

                            dtpEntradaTC_Martes.Value = horariosTarde.MartesEntrada.Value;

                            dtpSalidaTC_Martes.Value = horariosTarde.MartesSalida.Value;

                            cbMartes.Checked = true;
                        }
                        else
                        {
                            cbMartes.Checked = false;
                        }


                        if (horariosTarde.MiercolesEntrada.Value.Year != 1900)
                        {
                          

                            dtpEntradaTC_Miercoles.Value = horariosTarde.MiercolesEntrada.Value;

                            dtpSalidaTC_Miercoles.Value = horariosTarde.MiercolesSalida.Value;

                            cbMiercoles.Checked = true;
                        }
                        else
                        {
                            cbMiercoles.Checked = false;
                        }



                        if (horariosTarde.JuevesEntrada.Value.Year != 1900)
                        {
                           

                            dtpEntradaTC_Jueves.Value = horariosTarde.JuevesEntrada.Value;

                            dtpSalidaTC_Jueves.Value = horariosTarde.JuevesSalida.Value;

                            cbJueves.Checked = true;
                        }
                        else
                        {
                            cbJueves.Checked = false;
                        }


                        if (horariosTarde.ViernesEntrada.Value.Year != 1900)
                        {
                          

                            dtpEntradaTC_Viernes.Value = horariosTarde.ViernesEntrada.Value;

                            dtpSalidaTC_Viernes.Value = horariosTarde.ViernesSalida.Value;

                            cbViernes.Checked = true;
                        }
                        else
                        {
                            cbViernes.Checked = false;
                        }


                        if (horariosTarde.SabadoEntrada.Value.Year != 1900)
                        {
                         

                            dtpEntradaTC_Sabado.Value = horariosTarde.SabadoEntrada.Value;

                            dtpSalidaTC_Sabado.Value = horariosTarde.SabadoSalida.Value;

                            cbSabado.Checked = true;

                        }
                        else
                        {
                            cbSabado.Checked = false;
                        }


                        if (horariosTarde.DomingoEntrada.Value.Year != 1900)
                        {
                         

                            dtpEntradaTC_Domingo.Value = horariosTarde.DomingoEntrada.Value;

                            dtpSalidaTC_Domingo.Value = horariosTarde.DomingoSalida.Value;

                            cbDomingo.Checked = true;
                        }
                        else
                        {
                            cbDomingo.Checked = false;
                        }


                        if (cbLunes.Checked && cbMartes.Checked && cbMiercoles.Checked && cbJueves.Checked && cbViernes.Checked && cbSabado.Checked && cbDomingo.Checked)
                        {
                            cbTodos.Checked = true;
                        }

                    }
                    




                }



                

            }
        }

        private void dtpEntradaMT_Lunes_ValueChanged(object sender, EventArgs e)
        {

            if((sender as DateTimePicker).Value.Minute != tiempo.Second)    //PREGUNTO SI ME TOCARON EL MINUTO O LA HORA
            {
                DateTime dt = (sender as DateTimePicker).Value;

                if (dt.Minute < 15)
                {
                    int dif = 30 - dt.Minute;
                    dt = dt.AddMinutes(dif);
                    (sender as DateTimePicker).Value = dt;

                }
                if(dt.Minute > 30)
                {
                    int dif = 60 - dt.Minute;
                    dt = dt.AddMinutes(dif);
                    (sender as DateTimePicker).Value = dt;
                }

            }


            



        }

        private void dtpEntradaMT_Lunes_MouseEnter(object sender, EventArgs e)
        {
            tiempo = (sender as DateTimePicker).Value;
        }









    }
}
