namespace Fenix1._0
{
    partial class frmHorariosMedico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbMT = new System.Windows.Forms.RadioButton();
            this.rbTC = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpEntradaMT_Lunes = new System.Windows.Forms.DateTimePicker();
            this.dtpSalidaMT_Lunes = new System.Windows.Forms.DateTimePicker();
            this.dtpEntradaMT_Martes = new System.Windows.Forms.DateTimePicker();
            this.dtpSalidaMT_Martes = new System.Windows.Forms.DateTimePicker();
            this.dtpEntradaMT_Miercoles = new System.Windows.Forms.DateTimePicker();
            this.dtpSalidaMT_Miercoles = new System.Windows.Forms.DateTimePicker();
            this.dtpEntradaMT_Jueves = new System.Windows.Forms.DateTimePicker();
            this.dtpSalidaMT_Jueves = new System.Windows.Forms.DateTimePicker();
            this.dtpEntradaMT_Viernes = new System.Windows.Forms.DateTimePicker();
            this.dtpSalidaMT_Viernes = new System.Windows.Forms.DateTimePicker();
            this.dtpEntradaMT_Sabado = new System.Windows.Forms.DateTimePicker();
            this.dtpSalidaMT_Sabado = new System.Windows.Forms.DateTimePicker();
            this.dtpEntradaMT_Domingo = new System.Windows.Forms.DateTimePicker();
            this.cbLunes = new System.Windows.Forms.CheckBox();
            this.cbMartes = new System.Windows.Forms.CheckBox();
            this.cbMiercoles = new System.Windows.Forms.CheckBox();
            this.cbJueves = new System.Windows.Forms.CheckBox();
            this.cbViernes = new System.Windows.Forms.CheckBox();
            this.cbSabado = new System.Windows.Forms.CheckBox();
            this.cbDomingo = new System.Windows.Forms.CheckBox();
            this.dtpSalidaMT_Domingo = new System.Windows.Forms.DateTimePicker();
            this.pnlMedioTiempo = new System.Windows.Forms.Panel();
            this.pnlTiempoCompleto = new System.Windows.Forms.Panel();
            this.dtpEntradaTC_Lunes = new System.Windows.Forms.DateTimePicker();
            this.dtpSalidaTC_Domingo = new System.Windows.Forms.DateTimePicker();
            this.dtpSalidaTC_Lunes = new System.Windows.Forms.DateTimePicker();
            this.dtpEntradaTC_Martes = new System.Windows.Forms.DateTimePicker();
            this.dtpSalidaTC_Martes = new System.Windows.Forms.DateTimePicker();
            this.dtpEntradaTC_Miercoles = new System.Windows.Forms.DateTimePicker();
            this.dtpSalidaTC_Miercoles = new System.Windows.Forms.DateTimePicker();
            this.dtpEntradaTC_Jueves = new System.Windows.Forms.DateTimePicker();
            this.dtpSalidaTC_Jueves = new System.Windows.Forms.DateTimePicker();
            this.dtpEntradaTC_Viernes = new System.Windows.Forms.DateTimePicker();
            this.dtpEntradaTC_Domingo = new System.Windows.Forms.DateTimePicker();
            this.dtpSalidaTC_Viernes = new System.Windows.Forms.DateTimePicker();
            this.dtpSalidaTC_Sabado = new System.Windows.Forms.DateTimePicker();
            this.dtpEntradaTC_Sabado = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.cbTodos = new System.Windows.Forms.CheckBox();
            this.pnlMedioTiempo.SuspendLayout();
            this.pnlTiempoCompleto.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbMT
            // 
            this.rbMT.AutoSize = true;
            this.rbMT.Checked = true;
            this.rbMT.Location = new System.Drawing.Point(217, 12);
            this.rbMT.Name = "rbMT";
            this.rbMT.Size = new System.Drawing.Size(109, 19);
            this.rbMT.TabIndex = 7;
            this.rbMT.TabStop = true;
            this.rbMT.Text = "Medio-Tiempo";
            this.rbMT.UseVisualStyleBackColor = true;
            this.rbMT.CheckedChanged += new System.EventHandler(this.rbMT_CheckedChanged);
            // 
            // rbTC
            // 
            this.rbTC.AutoSize = true;
            this.rbTC.Location = new System.Drawing.Point(462, 12);
            this.rbTC.Name = "rbTC";
            this.rbTC.Size = new System.Drawing.Size(130, 19);
            this.rbTC.TabIndex = 8;
            this.rbTC.Text = "Tiempo-Completo";
            this.rbTC.UseVisualStyleBackColor = true;
            this.rbTC.CheckedChanged += new System.EventHandler(this.rbTC_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(180, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Entrada";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(311, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "Salida";
            // 
            // dtpEntradaMT_Lunes
            // 
            this.dtpEntradaMT_Lunes.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEntradaMT_Lunes.Location = new System.Drawing.Point(3, 5);
            this.dtpEntradaMT_Lunes.Name = "dtpEntradaMT_Lunes";
            this.dtpEntradaMT_Lunes.Size = new System.Drawing.Size(82, 23);
            this.dtpEntradaMT_Lunes.TabIndex = 1;
            // 
            // dtpSalidaMT_Lunes
            // 
            this.dtpSalidaMT_Lunes.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSalidaMT_Lunes.Location = new System.Drawing.Point(131, 5);
            this.dtpSalidaMT_Lunes.Name = "dtpSalidaMT_Lunes";
            this.dtpSalidaMT_Lunes.Size = new System.Drawing.Size(82, 23);
            this.dtpSalidaMT_Lunes.TabIndex = 12;
            this.dtpSalidaMT_Lunes.Tag = "1";
            // 
            // dtpEntradaMT_Martes
            // 
            this.dtpEntradaMT_Martes.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEntradaMT_Martes.Location = new System.Drawing.Point(3, 59);
            this.dtpEntradaMT_Martes.Name = "dtpEntradaMT_Martes";
            this.dtpEntradaMT_Martes.Size = new System.Drawing.Size(82, 23);
            this.dtpEntradaMT_Martes.TabIndex = 13;
            this.dtpEntradaMT_Martes.Tag = "2";
            // 
            // dtpSalidaMT_Martes
            // 
            this.dtpSalidaMT_Martes.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSalidaMT_Martes.Location = new System.Drawing.Point(131, 59);
            this.dtpSalidaMT_Martes.Name = "dtpSalidaMT_Martes";
            this.dtpSalidaMT_Martes.Size = new System.Drawing.Size(82, 23);
            this.dtpSalidaMT_Martes.TabIndex = 14;
            this.dtpSalidaMT_Martes.Tag = "2";
            // 
            // dtpEntradaMT_Miercoles
            // 
            this.dtpEntradaMT_Miercoles.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEntradaMT_Miercoles.Location = new System.Drawing.Point(3, 111);
            this.dtpEntradaMT_Miercoles.Name = "dtpEntradaMT_Miercoles";
            this.dtpEntradaMT_Miercoles.Size = new System.Drawing.Size(82, 23);
            this.dtpEntradaMT_Miercoles.TabIndex = 15;
            this.dtpEntradaMT_Miercoles.Tag = "3";
            // 
            // dtpSalidaMT_Miercoles
            // 
            this.dtpSalidaMT_Miercoles.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSalidaMT_Miercoles.Location = new System.Drawing.Point(131, 111);
            this.dtpSalidaMT_Miercoles.Name = "dtpSalidaMT_Miercoles";
            this.dtpSalidaMT_Miercoles.Size = new System.Drawing.Size(82, 23);
            this.dtpSalidaMT_Miercoles.TabIndex = 16;
            this.dtpSalidaMT_Miercoles.Tag = "3";
            // 
            // dtpEntradaMT_Jueves
            // 
            this.dtpEntradaMT_Jueves.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEntradaMT_Jueves.Location = new System.Drawing.Point(3, 163);
            this.dtpEntradaMT_Jueves.Name = "dtpEntradaMT_Jueves";
            this.dtpEntradaMT_Jueves.Size = new System.Drawing.Size(82, 23);
            this.dtpEntradaMT_Jueves.TabIndex = 17;
            this.dtpEntradaMT_Jueves.Tag = "4";
            // 
            // dtpSalidaMT_Jueves
            // 
            this.dtpSalidaMT_Jueves.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSalidaMT_Jueves.Location = new System.Drawing.Point(131, 163);
            this.dtpSalidaMT_Jueves.Name = "dtpSalidaMT_Jueves";
            this.dtpSalidaMT_Jueves.Size = new System.Drawing.Size(82, 23);
            this.dtpSalidaMT_Jueves.TabIndex = 18;
            this.dtpSalidaMT_Jueves.Tag = "4";
            // 
            // dtpEntradaMT_Viernes
            // 
            this.dtpEntradaMT_Viernes.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEntradaMT_Viernes.Location = new System.Drawing.Point(3, 215);
            this.dtpEntradaMT_Viernes.Name = "dtpEntradaMT_Viernes";
            this.dtpEntradaMT_Viernes.Size = new System.Drawing.Size(82, 23);
            this.dtpEntradaMT_Viernes.TabIndex = 19;
            this.dtpEntradaMT_Viernes.Tag = "5";
            // 
            // dtpSalidaMT_Viernes
            // 
            this.dtpSalidaMT_Viernes.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSalidaMT_Viernes.Location = new System.Drawing.Point(131, 215);
            this.dtpSalidaMT_Viernes.Name = "dtpSalidaMT_Viernes";
            this.dtpSalidaMT_Viernes.Size = new System.Drawing.Size(82, 23);
            this.dtpSalidaMT_Viernes.TabIndex = 20;
            this.dtpSalidaMT_Viernes.Tag = "5";
            // 
            // dtpEntradaMT_Sabado
            // 
            this.dtpEntradaMT_Sabado.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEntradaMT_Sabado.Location = new System.Drawing.Point(3, 267);
            this.dtpEntradaMT_Sabado.Name = "dtpEntradaMT_Sabado";
            this.dtpEntradaMT_Sabado.Size = new System.Drawing.Size(82, 23);
            this.dtpEntradaMT_Sabado.TabIndex = 21;
            this.dtpEntradaMT_Sabado.Tag = "6";
            // 
            // dtpSalidaMT_Sabado
            // 
            this.dtpSalidaMT_Sabado.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSalidaMT_Sabado.Location = new System.Drawing.Point(131, 267);
            this.dtpSalidaMT_Sabado.Name = "dtpSalidaMT_Sabado";
            this.dtpSalidaMT_Sabado.Size = new System.Drawing.Size(82, 23);
            this.dtpSalidaMT_Sabado.TabIndex = 22;
            this.dtpSalidaMT_Sabado.Tag = "6";
            // 
            // dtpEntradaMT_Domingo
            // 
            this.dtpEntradaMT_Domingo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEntradaMT_Domingo.Location = new System.Drawing.Point(3, 319);
            this.dtpEntradaMT_Domingo.Name = "dtpEntradaMT_Domingo";
            this.dtpEntradaMT_Domingo.Size = new System.Drawing.Size(82, 23);
            this.dtpEntradaMT_Domingo.TabIndex = 23;
            this.dtpEntradaMT_Domingo.Tag = "7";
            // 
            // cbLunes
            // 
            this.cbLunes.AutoSize = true;
            this.cbLunes.Checked = true;
            this.cbLunes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLunes.Location = new System.Drawing.Point(28, 98);
            this.cbLunes.Name = "cbLunes";
            this.cbLunes.Size = new System.Drawing.Size(61, 19);
            this.cbLunes.TabIndex = 24;
            this.cbLunes.Tag = "1";
            this.cbLunes.Text = "Lunes";
            this.cbLunes.UseVisualStyleBackColor = true;
            this.cbLunes.CheckedChanged += new System.EventHandler(this.cbLunes_CheckedChanged);
            // 
            // cbMartes
            // 
            this.cbMartes.AutoSize = true;
            this.cbMartes.Checked = true;
            this.cbMartes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMartes.Location = new System.Drawing.Point(28, 152);
            this.cbMartes.Name = "cbMartes";
            this.cbMartes.Size = new System.Drawing.Size(68, 19);
            this.cbMartes.TabIndex = 25;
            this.cbMartes.Tag = "2";
            this.cbMartes.Text = "Martes";
            this.cbMartes.UseVisualStyleBackColor = true;
            this.cbMartes.CheckedChanged += new System.EventHandler(this.cbLunes_CheckedChanged);
            // 
            // cbMiercoles
            // 
            this.cbMiercoles.AutoSize = true;
            this.cbMiercoles.Checked = true;
            this.cbMiercoles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMiercoles.Location = new System.Drawing.Point(28, 204);
            this.cbMiercoles.Name = "cbMiercoles";
            this.cbMiercoles.Size = new System.Drawing.Size(89, 19);
            this.cbMiercoles.TabIndex = 26;
            this.cbMiercoles.Tag = "3";
            this.cbMiercoles.Text = "Miércoles";
            this.cbMiercoles.UseVisualStyleBackColor = true;
            this.cbMiercoles.CheckedChanged += new System.EventHandler(this.cbLunes_CheckedChanged);
            // 
            // cbJueves
            // 
            this.cbJueves.AutoSize = true;
            this.cbJueves.Checked = true;
            this.cbJueves.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbJueves.Location = new System.Drawing.Point(28, 256);
            this.cbJueves.Name = "cbJueves";
            this.cbJueves.Size = new System.Drawing.Size(68, 19);
            this.cbJueves.TabIndex = 27;
            this.cbJueves.Tag = "4";
            this.cbJueves.Text = "Jueves";
            this.cbJueves.UseVisualStyleBackColor = true;
            this.cbJueves.CheckedChanged += new System.EventHandler(this.cbLunes_CheckedChanged);
            // 
            // cbViernes
            // 
            this.cbViernes.AutoSize = true;
            this.cbViernes.Checked = true;
            this.cbViernes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbViernes.Location = new System.Drawing.Point(28, 308);
            this.cbViernes.Name = "cbViernes";
            this.cbViernes.Size = new System.Drawing.Size(75, 19);
            this.cbViernes.TabIndex = 28;
            this.cbViernes.Tag = "5";
            this.cbViernes.Text = "Viernes";
            this.cbViernes.UseVisualStyleBackColor = true;
            this.cbViernes.CheckedChanged += new System.EventHandler(this.cbLunes_CheckedChanged);
            // 
            // cbSabado
            // 
            this.cbSabado.AutoSize = true;
            this.cbSabado.Checked = true;
            this.cbSabado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSabado.Location = new System.Drawing.Point(28, 360);
            this.cbSabado.Name = "cbSabado";
            this.cbSabado.Size = new System.Drawing.Size(68, 19);
            this.cbSabado.TabIndex = 29;
            this.cbSabado.Tag = "6";
            this.cbSabado.Text = "Sábado";
            this.cbSabado.UseVisualStyleBackColor = true;
            this.cbSabado.CheckedChanged += new System.EventHandler(this.cbLunes_CheckedChanged);
            // 
            // cbDomingo
            // 
            this.cbDomingo.AutoSize = true;
            this.cbDomingo.Checked = true;
            this.cbDomingo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDomingo.Location = new System.Drawing.Point(28, 412);
            this.cbDomingo.Name = "cbDomingo";
            this.cbDomingo.Size = new System.Drawing.Size(75, 19);
            this.cbDomingo.TabIndex = 30;
            this.cbDomingo.Tag = "7";
            this.cbDomingo.Text = "Domingo";
            this.cbDomingo.UseVisualStyleBackColor = true;
            this.cbDomingo.CheckedChanged += new System.EventHandler(this.cbLunes_CheckedChanged);
            // 
            // dtpSalidaMT_Domingo
            // 
            this.dtpSalidaMT_Domingo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSalidaMT_Domingo.Location = new System.Drawing.Point(131, 319);
            this.dtpSalidaMT_Domingo.Name = "dtpSalidaMT_Domingo";
            this.dtpSalidaMT_Domingo.Size = new System.Drawing.Size(82, 23);
            this.dtpSalidaMT_Domingo.TabIndex = 31;
            this.dtpSalidaMT_Domingo.Tag = "7";
            // 
            // pnlMedioTiempo
            // 
            this.pnlMedioTiempo.Controls.Add(this.dtpEntradaMT_Lunes);
            this.pnlMedioTiempo.Controls.Add(this.dtpSalidaMT_Domingo);
            this.pnlMedioTiempo.Controls.Add(this.dtpSalidaMT_Lunes);
            this.pnlMedioTiempo.Controls.Add(this.dtpEntradaMT_Martes);
            this.pnlMedioTiempo.Controls.Add(this.dtpSalidaMT_Martes);
            this.pnlMedioTiempo.Controls.Add(this.dtpEntradaMT_Miercoles);
            this.pnlMedioTiempo.Controls.Add(this.dtpSalidaMT_Miercoles);
            this.pnlMedioTiempo.Controls.Add(this.dtpEntradaMT_Jueves);
            this.pnlMedioTiempo.Controls.Add(this.dtpSalidaMT_Jueves);
            this.pnlMedioTiempo.Controls.Add(this.dtpEntradaMT_Viernes);
            this.pnlMedioTiempo.Controls.Add(this.dtpEntradaMT_Domingo);
            this.pnlMedioTiempo.Controls.Add(this.dtpSalidaMT_Viernes);
            this.pnlMedioTiempo.Controls.Add(this.dtpSalidaMT_Sabado);
            this.pnlMedioTiempo.Controls.Add(this.dtpEntradaMT_Sabado);
            this.pnlMedioTiempo.Location = new System.Drawing.Point(164, 89);
            this.pnlMedioTiempo.Name = "pnlMedioTiempo";
            this.pnlMedioTiempo.Size = new System.Drawing.Size(215, 346);
            this.pnlMedioTiempo.TabIndex = 32;
            // 
            // pnlTiempoCompleto
            // 
            this.pnlTiempoCompleto.Controls.Add(this.dtpEntradaTC_Lunes);
            this.pnlTiempoCompleto.Controls.Add(this.dtpSalidaTC_Domingo);
            this.pnlTiempoCompleto.Controls.Add(this.dtpSalidaTC_Lunes);
            this.pnlTiempoCompleto.Controls.Add(this.dtpEntradaTC_Martes);
            this.pnlTiempoCompleto.Controls.Add(this.dtpSalidaTC_Martes);
            this.pnlTiempoCompleto.Controls.Add(this.dtpEntradaTC_Miercoles);
            this.pnlTiempoCompleto.Controls.Add(this.dtpSalidaTC_Miercoles);
            this.pnlTiempoCompleto.Controls.Add(this.dtpEntradaTC_Jueves);
            this.pnlTiempoCompleto.Controls.Add(this.dtpSalidaTC_Jueves);
            this.pnlTiempoCompleto.Controls.Add(this.dtpEntradaTC_Viernes);
            this.pnlTiempoCompleto.Controls.Add(this.dtpEntradaTC_Domingo);
            this.pnlTiempoCompleto.Controls.Add(this.dtpSalidaTC_Viernes);
            this.pnlTiempoCompleto.Controls.Add(this.dtpSalidaTC_Sabado);
            this.pnlTiempoCompleto.Controls.Add(this.dtpEntradaTC_Sabado);
            this.pnlTiempoCompleto.Location = new System.Drawing.Point(420, 89);
            this.pnlTiempoCompleto.Name = "pnlTiempoCompleto";
            this.pnlTiempoCompleto.Size = new System.Drawing.Size(215, 346);
            this.pnlTiempoCompleto.TabIndex = 33;
            this.pnlTiempoCompleto.Visible = false;
            // 
            // dtpEntradaTC_Lunes
            // 
            this.dtpEntradaTC_Lunes.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEntradaTC_Lunes.Location = new System.Drawing.Point(3, 5);
            this.dtpEntradaTC_Lunes.Name = "dtpEntradaTC_Lunes";
            this.dtpEntradaTC_Lunes.Size = new System.Drawing.Size(82, 23);
            this.dtpEntradaTC_Lunes.TabIndex = 11;
            this.dtpEntradaTC_Lunes.Tag = "1";
            // 
            // dtpSalidaTC_Domingo
            // 
            this.dtpSalidaTC_Domingo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSalidaTC_Domingo.Location = new System.Drawing.Point(131, 319);
            this.dtpSalidaTC_Domingo.Name = "dtpSalidaTC_Domingo";
            this.dtpSalidaTC_Domingo.Size = new System.Drawing.Size(82, 23);
            this.dtpSalidaTC_Domingo.TabIndex = 31;
            this.dtpSalidaTC_Domingo.Tag = "7";
            // 
            // dtpSalidaTC_Lunes
            // 
            this.dtpSalidaTC_Lunes.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSalidaTC_Lunes.Location = new System.Drawing.Point(131, 5);
            this.dtpSalidaTC_Lunes.Name = "dtpSalidaTC_Lunes";
            this.dtpSalidaTC_Lunes.Size = new System.Drawing.Size(82, 23);
            this.dtpSalidaTC_Lunes.TabIndex = 12;
            this.dtpSalidaTC_Lunes.Tag = "1";
            // 
            // dtpEntradaTC_Martes
            // 
            this.dtpEntradaTC_Martes.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEntradaTC_Martes.Location = new System.Drawing.Point(3, 59);
            this.dtpEntradaTC_Martes.Name = "dtpEntradaTC_Martes";
            this.dtpEntradaTC_Martes.Size = new System.Drawing.Size(82, 23);
            this.dtpEntradaTC_Martes.TabIndex = 13;
            this.dtpEntradaTC_Martes.Tag = "2";
            // 
            // dtpSalidaTC_Martes
            // 
            this.dtpSalidaTC_Martes.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSalidaTC_Martes.Location = new System.Drawing.Point(131, 59);
            this.dtpSalidaTC_Martes.Name = "dtpSalidaTC_Martes";
            this.dtpSalidaTC_Martes.Size = new System.Drawing.Size(82, 23);
            this.dtpSalidaTC_Martes.TabIndex = 14;
            this.dtpSalidaTC_Martes.Tag = "2";
            // 
            // dtpEntradaTC_Miercoles
            // 
            this.dtpEntradaTC_Miercoles.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEntradaTC_Miercoles.Location = new System.Drawing.Point(3, 111);
            this.dtpEntradaTC_Miercoles.Name = "dtpEntradaTC_Miercoles";
            this.dtpEntradaTC_Miercoles.Size = new System.Drawing.Size(82, 23);
            this.dtpEntradaTC_Miercoles.TabIndex = 15;
            this.dtpEntradaTC_Miercoles.Tag = "3";
            // 
            // dtpSalidaTC_Miercoles
            // 
            this.dtpSalidaTC_Miercoles.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSalidaTC_Miercoles.Location = new System.Drawing.Point(131, 111);
            this.dtpSalidaTC_Miercoles.Name = "dtpSalidaTC_Miercoles";
            this.dtpSalidaTC_Miercoles.Size = new System.Drawing.Size(82, 23);
            this.dtpSalidaTC_Miercoles.TabIndex = 16;
            this.dtpSalidaTC_Miercoles.Tag = "3";
            // 
            // dtpEntradaTC_Jueves
            // 
            this.dtpEntradaTC_Jueves.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEntradaTC_Jueves.Location = new System.Drawing.Point(3, 163);
            this.dtpEntradaTC_Jueves.Name = "dtpEntradaTC_Jueves";
            this.dtpEntradaTC_Jueves.Size = new System.Drawing.Size(82, 23);
            this.dtpEntradaTC_Jueves.TabIndex = 17;
            this.dtpEntradaTC_Jueves.Tag = "4";
            // 
            // dtpSalidaTC_Jueves
            // 
            this.dtpSalidaTC_Jueves.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSalidaTC_Jueves.Location = new System.Drawing.Point(131, 163);
            this.dtpSalidaTC_Jueves.Name = "dtpSalidaTC_Jueves";
            this.dtpSalidaTC_Jueves.Size = new System.Drawing.Size(82, 23);
            this.dtpSalidaTC_Jueves.TabIndex = 18;
            this.dtpSalidaTC_Jueves.Tag = "4";
            // 
            // dtpEntradaTC_Viernes
            // 
            this.dtpEntradaTC_Viernes.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEntradaTC_Viernes.Location = new System.Drawing.Point(3, 215);
            this.dtpEntradaTC_Viernes.Name = "dtpEntradaTC_Viernes";
            this.dtpEntradaTC_Viernes.Size = new System.Drawing.Size(82, 23);
            this.dtpEntradaTC_Viernes.TabIndex = 19;
            this.dtpEntradaTC_Viernes.Tag = "5";
            // 
            // dtpEntradaTC_Domingo
            // 
            this.dtpEntradaTC_Domingo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEntradaTC_Domingo.Location = new System.Drawing.Point(3, 319);
            this.dtpEntradaTC_Domingo.Name = "dtpEntradaTC_Domingo";
            this.dtpEntradaTC_Domingo.Size = new System.Drawing.Size(82, 23);
            this.dtpEntradaTC_Domingo.TabIndex = 23;
            this.dtpEntradaTC_Domingo.Tag = "7";
            // 
            // dtpSalidaTC_Viernes
            // 
            this.dtpSalidaTC_Viernes.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSalidaTC_Viernes.Location = new System.Drawing.Point(131, 215);
            this.dtpSalidaTC_Viernes.Name = "dtpSalidaTC_Viernes";
            this.dtpSalidaTC_Viernes.Size = new System.Drawing.Size(82, 23);
            this.dtpSalidaTC_Viernes.TabIndex = 20;
            this.dtpSalidaTC_Viernes.Tag = "5";
            // 
            // dtpSalidaTC_Sabado
            // 
            this.dtpSalidaTC_Sabado.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSalidaTC_Sabado.Location = new System.Drawing.Point(131, 267);
            this.dtpSalidaTC_Sabado.Name = "dtpSalidaTC_Sabado";
            this.dtpSalidaTC_Sabado.Size = new System.Drawing.Size(82, 23);
            this.dtpSalidaTC_Sabado.TabIndex = 22;
            this.dtpSalidaTC_Sabado.Tag = "6";
            // 
            // dtpEntradaTC_Sabado
            // 
            this.dtpEntradaTC_Sabado.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEntradaTC_Sabado.Location = new System.Drawing.Point(3, 267);
            this.dtpEntradaTC_Sabado.Name = "dtpEntradaTC_Sabado";
            this.dtpEntradaTC_Sabado.Size = new System.Drawing.Size(82, 23);
            this.dtpEntradaTC_Sabado.TabIndex = 21;
            this.dtpEntradaTC_Sabado.Tag = "6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(563, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 35;
            this.label1.Text = "Salida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 34;
            this.label2.Text = "Entrada";
            // 
            // btnTerminar
            // 
            this.btnTerminar.Location = new System.Drawing.Point(361, 452);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(75, 23);
            this.btnTerminar.TabIndex = 36;
            this.btnTerminar.Text = "Terminar";
            this.btnTerminar.UseVisualStyleBackColor = true;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // cbTodos
            // 
            this.cbTodos.AutoSize = true;
            this.cbTodos.Location = new System.Drawing.Point(28, 56);
            this.cbTodos.Name = "cbTodos";
            this.cbTodos.Size = new System.Drawing.Size(61, 19);
            this.cbTodos.TabIndex = 37;
            this.cbTodos.Tag = "10";
            this.cbTodos.Text = "Lunes";
            this.cbTodos.UseVisualStyleBackColor = true;
            this.cbTodos.CheckedChanged += new System.EventHandler(this.cbLunes_CheckedChanged);
            // 
            // frmHorariosMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 478);
            this.Controls.Add(this.cbTodos);
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlTiempoCompleto);
            this.Controls.Add(this.pnlMedioTiempo);
            this.Controls.Add(this.cbDomingo);
            this.Controls.Add(this.cbSabado);
            this.Controls.Add(this.cbViernes);
            this.Controls.Add(this.cbJueves);
            this.Controls.Add(this.cbMiercoles);
            this.Controls.Add(this.cbMartes);
            this.Controls.Add(this.cbLunes);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rbTC);
            this.Controls.Add(this.rbMT);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.Name = "frmHorariosMedico";
            this.Text = "frmHorariosMedico";
            this.pnlMedioTiempo.ResumeLayout(false);
            this.pnlTiempoCompleto.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbMT;
        private System.Windows.Forms.RadioButton rbTC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpEntradaMT_Lunes;
        private System.Windows.Forms.DateTimePicker dtpSalidaMT_Lunes;
        private System.Windows.Forms.DateTimePicker dtpEntradaMT_Martes;
        private System.Windows.Forms.DateTimePicker dtpSalidaMT_Martes;
        private System.Windows.Forms.DateTimePicker dtpEntradaMT_Miercoles;
        private System.Windows.Forms.DateTimePicker dtpSalidaMT_Miercoles;
        private System.Windows.Forms.DateTimePicker dtpEntradaMT_Jueves;
        private System.Windows.Forms.DateTimePicker dtpSalidaMT_Jueves;
        private System.Windows.Forms.DateTimePicker dtpEntradaMT_Viernes;
        private System.Windows.Forms.DateTimePicker dtpSalidaMT_Viernes;
        private System.Windows.Forms.DateTimePicker dtpEntradaMT_Sabado;
        private System.Windows.Forms.DateTimePicker dtpSalidaMT_Sabado;
        private System.Windows.Forms.DateTimePicker dtpEntradaMT_Domingo;
        private System.Windows.Forms.CheckBox cbLunes;
        private System.Windows.Forms.CheckBox cbMartes;
        private System.Windows.Forms.CheckBox cbMiercoles;
        private System.Windows.Forms.CheckBox cbJueves;
        private System.Windows.Forms.CheckBox cbViernes;
        private System.Windows.Forms.CheckBox cbSabado;
        private System.Windows.Forms.CheckBox cbDomingo;
        private System.Windows.Forms.DateTimePicker dtpSalidaMT_Domingo;
        private System.Windows.Forms.Panel pnlMedioTiempo;
        private System.Windows.Forms.Panel pnlTiempoCompleto;
        private System.Windows.Forms.DateTimePicker dtpEntradaTC_Lunes;
        private System.Windows.Forms.DateTimePicker dtpSalidaTC_Domingo;
        private System.Windows.Forms.DateTimePicker dtpSalidaTC_Lunes;
        private System.Windows.Forms.DateTimePicker dtpEntradaTC_Martes;
        private System.Windows.Forms.DateTimePicker dtpSalidaTC_Martes;
        private System.Windows.Forms.DateTimePicker dtpEntradaTC_Miercoles;
        private System.Windows.Forms.DateTimePicker dtpSalidaTC_Miercoles;
        private System.Windows.Forms.DateTimePicker dtpEntradaTC_Jueves;
        private System.Windows.Forms.DateTimePicker dtpSalidaTC_Jueves;
        private System.Windows.Forms.DateTimePicker dtpEntradaTC_Viernes;
        private System.Windows.Forms.DateTimePicker dtpEntradaTC_Domingo;
        private System.Windows.Forms.DateTimePicker dtpSalidaTC_Viernes;
        private System.Windows.Forms.DateTimePicker dtpSalidaTC_Sabado;
        private System.Windows.Forms.DateTimePicker dtpEntradaTC_Sabado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTerminar;
        private System.Windows.Forms.CheckBox cbTodos;

    }
}