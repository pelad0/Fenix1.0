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
            this.rbAmbos = new System.Windows.Forms.RadioButton();
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
            this.label3 = new System.Windows.Forms.Label();
            this.cbRepetirMT = new System.Windows.Forms.CheckBox();
            this.pnlTiempoCompleto = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpEntradaTC_Lunes = new System.Windows.Forms.DateTimePicker();
            this.cbRepetirTC = new System.Windows.Forms.CheckBox();
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
            this.label5 = new System.Windows.Forms.Label();
            this.rbTarde = new System.Windows.Forms.RadioButton();
            this.pnlMedioTiempo.SuspendLayout();
            this.pnlTiempoCompleto.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbMT
            // 
            this.rbMT.AutoSize = true;
            this.rbMT.Checked = true;
            this.rbMT.Location = new System.Drawing.Point(217, 27);
            this.rbMT.Name = "rbMT";
            this.rbMT.Size = new System.Drawing.Size(67, 19);
            this.rbMT.TabIndex = 7;
            this.rbMT.TabStop = true;
            this.rbMT.Text = "Mañana";
            this.rbMT.UseVisualStyleBackColor = true;
            this.rbMT.CheckedChanged += new System.EventHandler(this.rbMT_CheckedChanged);
            // 
            // rbAmbos
            // 
            this.rbAmbos.AutoSize = true;
            this.rbAmbos.Location = new System.Drawing.Point(620, 27);
            this.rbAmbos.Name = "rbAmbos";
            this.rbAmbos.Size = new System.Drawing.Size(60, 19);
            this.rbAmbos.TabIndex = 8;
            this.rbAmbos.Text = "Ambos";
            this.rbAmbos.UseVisualStyleBackColor = true;
            this.rbAmbos.CheckedChanged += new System.EventHandler(this.rbTC_CheckedChanged);
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
            this.label9.Location = new System.Drawing.Point(305, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "Salida";
            // 
            // dtpEntradaMT_Lunes
            // 
            this.dtpEntradaMT_Lunes.CustomFormat = "HH:mm";
            this.dtpEntradaMT_Lunes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEntradaMT_Lunes.Location = new System.Drawing.Point(5, 5);
            this.dtpEntradaMT_Lunes.MaxDate = new System.DateTime(2015, 11, 1, 13, 0, 0, 0);
            this.dtpEntradaMT_Lunes.MinDate = new System.DateTime(2015, 11, 1, 8, 0, 0, 0);
            this.dtpEntradaMT_Lunes.Name = "dtpEntradaMT_Lunes";
            this.dtpEntradaMT_Lunes.ShowUpDown = true;
            this.dtpEntradaMT_Lunes.Size = new System.Drawing.Size(66, 23);
            this.dtpEntradaMT_Lunes.TabIndex = 1;
            this.dtpEntradaMT_Lunes.Tag = "1";
            this.dtpEntradaMT_Lunes.Value = new System.DateTime(2015, 11, 1, 13, 0, 0, 0);
            // 
            // dtpSalidaMT_Lunes
            // 
            this.dtpSalidaMT_Lunes.CustomFormat = "HH:mm";
            this.dtpSalidaMT_Lunes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSalidaMT_Lunes.Location = new System.Drawing.Point(132, 5);
            this.dtpSalidaMT_Lunes.MaxDate = new System.DateTime(2015, 11, 1, 13, 0, 0, 0);
            this.dtpSalidaMT_Lunes.MinDate = new System.DateTime(2015, 11, 1, 8, 0, 0, 0);
            this.dtpSalidaMT_Lunes.Name = "dtpSalidaMT_Lunes";
            this.dtpSalidaMT_Lunes.ShowUpDown = true;
            this.dtpSalidaMT_Lunes.Size = new System.Drawing.Size(66, 23);
            this.dtpSalidaMT_Lunes.TabIndex = 12;
            this.dtpSalidaMT_Lunes.Tag = "1";
            this.dtpSalidaMT_Lunes.Value = new System.DateTime(2015, 11, 1, 13, 0, 0, 0);
            // 
            // dtpEntradaMT_Martes
            // 
            this.dtpEntradaMT_Martes.CustomFormat = "HH:mm";
            this.dtpEntradaMT_Martes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEntradaMT_Martes.Location = new System.Drawing.Point(5, 59);
            this.dtpEntradaMT_Martes.MaxDate = new System.DateTime(2015, 11, 1, 13, 0, 0, 0);
            this.dtpEntradaMT_Martes.MinDate = new System.DateTime(2015, 11, 1, 8, 0, 0, 0);
            this.dtpEntradaMT_Martes.Name = "dtpEntradaMT_Martes";
            this.dtpEntradaMT_Martes.ShowUpDown = true;
            this.dtpEntradaMT_Martes.Size = new System.Drawing.Size(66, 23);
            this.dtpEntradaMT_Martes.TabIndex = 1;
            this.dtpEntradaMT_Martes.Tag = "2";
            this.dtpEntradaMT_Martes.Value = new System.DateTime(2015, 11, 1, 13, 0, 0, 0);
            // 
            // dtpSalidaMT_Martes
            // 
            this.dtpSalidaMT_Martes.CustomFormat = "HH:mm";
            this.dtpSalidaMT_Martes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSalidaMT_Martes.Location = new System.Drawing.Point(133, 59);
            this.dtpSalidaMT_Martes.MaxDate = new System.DateTime(2015, 11, 1, 13, 0, 0, 0);
            this.dtpSalidaMT_Martes.MinDate = new System.DateTime(2015, 11, 1, 8, 0, 0, 0);
            this.dtpSalidaMT_Martes.Name = "dtpSalidaMT_Martes";
            this.dtpSalidaMT_Martes.ShowUpDown = true;
            this.dtpSalidaMT_Martes.Size = new System.Drawing.Size(66, 23);
            this.dtpSalidaMT_Martes.TabIndex = 2;
            this.dtpSalidaMT_Martes.Tag = "2";
            this.dtpSalidaMT_Martes.Value = new System.DateTime(2015, 11, 1, 13, 0, 0, 0);
            // 
            // dtpEntradaMT_Miercoles
            // 
            this.dtpEntradaMT_Miercoles.CustomFormat = "HH:mm";
            this.dtpEntradaMT_Miercoles.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEntradaMT_Miercoles.Location = new System.Drawing.Point(5, 111);
            this.dtpEntradaMT_Miercoles.MaxDate = new System.DateTime(2015, 11, 1, 13, 0, 0, 0);
            this.dtpEntradaMT_Miercoles.MinDate = new System.DateTime(2015, 11, 1, 8, 0, 0, 0);
            this.dtpEntradaMT_Miercoles.Name = "dtpEntradaMT_Miercoles";
            this.dtpEntradaMT_Miercoles.ShowUpDown = true;
            this.dtpEntradaMT_Miercoles.Size = new System.Drawing.Size(66, 23);
            this.dtpEntradaMT_Miercoles.TabIndex = 1;
            this.dtpEntradaMT_Miercoles.Tag = "3";
            this.dtpEntradaMT_Miercoles.Value = new System.DateTime(2015, 11, 1, 13, 0, 0, 0);
            // 
            // dtpSalidaMT_Miercoles
            // 
            this.dtpSalidaMT_Miercoles.CustomFormat = "HH:mm";
            this.dtpSalidaMT_Miercoles.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSalidaMT_Miercoles.Location = new System.Drawing.Point(133, 111);
            this.dtpSalidaMT_Miercoles.MaxDate = new System.DateTime(2015, 11, 1, 13, 0, 0, 0);
            this.dtpSalidaMT_Miercoles.MinDate = new System.DateTime(2015, 11, 1, 8, 0, 0, 0);
            this.dtpSalidaMT_Miercoles.Name = "dtpSalidaMT_Miercoles";
            this.dtpSalidaMT_Miercoles.ShowUpDown = true;
            this.dtpSalidaMT_Miercoles.Size = new System.Drawing.Size(66, 23);
            this.dtpSalidaMT_Miercoles.TabIndex = 2;
            this.dtpSalidaMT_Miercoles.Tag = "3";
            this.dtpSalidaMT_Miercoles.Value = new System.DateTime(2015, 11, 1, 13, 0, 0, 0);
            // 
            // dtpEntradaMT_Jueves
            // 
            this.dtpEntradaMT_Jueves.CustomFormat = "HH:mm";
            this.dtpEntradaMT_Jueves.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEntradaMT_Jueves.Location = new System.Drawing.Point(5, 163);
            this.dtpEntradaMT_Jueves.MaxDate = new System.DateTime(2015, 11, 1, 13, 0, 0, 0);
            this.dtpEntradaMT_Jueves.MinDate = new System.DateTime(2015, 11, 1, 8, 0, 0, 0);
            this.dtpEntradaMT_Jueves.Name = "dtpEntradaMT_Jueves";
            this.dtpEntradaMT_Jueves.ShowUpDown = true;
            this.dtpEntradaMT_Jueves.Size = new System.Drawing.Size(66, 23);
            this.dtpEntradaMT_Jueves.TabIndex = 1;
            this.dtpEntradaMT_Jueves.Tag = "4";
            this.dtpEntradaMT_Jueves.Value = new System.DateTime(2015, 11, 1, 13, 0, 0, 0);
            // 
            // dtpSalidaMT_Jueves
            // 
            this.dtpSalidaMT_Jueves.CustomFormat = "HH:mm";
            this.dtpSalidaMT_Jueves.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSalidaMT_Jueves.Location = new System.Drawing.Point(133, 163);
            this.dtpSalidaMT_Jueves.MaxDate = new System.DateTime(2015, 11, 1, 13, 0, 0, 0);
            this.dtpSalidaMT_Jueves.MinDate = new System.DateTime(2015, 11, 1, 8, 0, 0, 0);
            this.dtpSalidaMT_Jueves.Name = "dtpSalidaMT_Jueves";
            this.dtpSalidaMT_Jueves.ShowUpDown = true;
            this.dtpSalidaMT_Jueves.Size = new System.Drawing.Size(66, 23);
            this.dtpSalidaMT_Jueves.TabIndex = 2;
            this.dtpSalidaMT_Jueves.Tag = "4";
            this.dtpSalidaMT_Jueves.Value = new System.DateTime(2015, 11, 1, 13, 0, 0, 0);
            // 
            // dtpEntradaMT_Viernes
            // 
            this.dtpEntradaMT_Viernes.CustomFormat = "HH:mm";
            this.dtpEntradaMT_Viernes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEntradaMT_Viernes.Location = new System.Drawing.Point(5, 215);
            this.dtpEntradaMT_Viernes.MaxDate = new System.DateTime(2015, 11, 1, 13, 0, 0, 0);
            this.dtpEntradaMT_Viernes.MinDate = new System.DateTime(2015, 11, 1, 8, 0, 0, 0);
            this.dtpEntradaMT_Viernes.Name = "dtpEntradaMT_Viernes";
            this.dtpEntradaMT_Viernes.ShowUpDown = true;
            this.dtpEntradaMT_Viernes.Size = new System.Drawing.Size(66, 23);
            this.dtpEntradaMT_Viernes.TabIndex = 1;
            this.dtpEntradaMT_Viernes.Tag = "5";
            this.dtpEntradaMT_Viernes.Value = new System.DateTime(2015, 11, 1, 13, 0, 0, 0);
            // 
            // dtpSalidaMT_Viernes
            // 
            this.dtpSalidaMT_Viernes.CustomFormat = "HH:mm";
            this.dtpSalidaMT_Viernes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSalidaMT_Viernes.Location = new System.Drawing.Point(133, 215);
            this.dtpSalidaMT_Viernes.MaxDate = new System.DateTime(2015, 11, 1, 13, 0, 0, 0);
            this.dtpSalidaMT_Viernes.MinDate = new System.DateTime(2015, 11, 1, 8, 0, 0, 0);
            this.dtpSalidaMT_Viernes.Name = "dtpSalidaMT_Viernes";
            this.dtpSalidaMT_Viernes.ShowUpDown = true;
            this.dtpSalidaMT_Viernes.Size = new System.Drawing.Size(66, 23);
            this.dtpSalidaMT_Viernes.TabIndex = 2;
            this.dtpSalidaMT_Viernes.Tag = "5";
            this.dtpSalidaMT_Viernes.Value = new System.DateTime(2015, 11, 1, 13, 0, 0, 0);
            // 
            // dtpEntradaMT_Sabado
            // 
            this.dtpEntradaMT_Sabado.CustomFormat = "HH:mm";
            this.dtpEntradaMT_Sabado.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEntradaMT_Sabado.Location = new System.Drawing.Point(5, 267);
            this.dtpEntradaMT_Sabado.MaxDate = new System.DateTime(2015, 11, 1, 13, 0, 0, 0);
            this.dtpEntradaMT_Sabado.MinDate = new System.DateTime(2015, 11, 1, 8, 0, 0, 0);
            this.dtpEntradaMT_Sabado.Name = "dtpEntradaMT_Sabado";
            this.dtpEntradaMT_Sabado.ShowUpDown = true;
            this.dtpEntradaMT_Sabado.Size = new System.Drawing.Size(66, 23);
            this.dtpEntradaMT_Sabado.TabIndex = 1;
            this.dtpEntradaMT_Sabado.Tag = "6";
            this.dtpEntradaMT_Sabado.Value = new System.DateTime(2015, 11, 1, 13, 0, 0, 0);
            // 
            // dtpSalidaMT_Sabado
            // 
            this.dtpSalidaMT_Sabado.CustomFormat = "HH:mm";
            this.dtpSalidaMT_Sabado.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSalidaMT_Sabado.Location = new System.Drawing.Point(133, 267);
            this.dtpSalidaMT_Sabado.MaxDate = new System.DateTime(2015, 11, 1, 13, 0, 0, 0);
            this.dtpSalidaMT_Sabado.MinDate = new System.DateTime(2015, 11, 1, 8, 0, 0, 0);
            this.dtpSalidaMT_Sabado.Name = "dtpSalidaMT_Sabado";
            this.dtpSalidaMT_Sabado.ShowUpDown = true;
            this.dtpSalidaMT_Sabado.Size = new System.Drawing.Size(66, 23);
            this.dtpSalidaMT_Sabado.TabIndex = 2;
            this.dtpSalidaMT_Sabado.Tag = "6";
            this.dtpSalidaMT_Sabado.Value = new System.DateTime(2015, 11, 1, 13, 0, 0, 0);
            // 
            // dtpEntradaMT_Domingo
            // 
            this.dtpEntradaMT_Domingo.CustomFormat = "HH:mm";
            this.dtpEntradaMT_Domingo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEntradaMT_Domingo.Location = new System.Drawing.Point(5, 319);
            this.dtpEntradaMT_Domingo.MaxDate = new System.DateTime(2015, 11, 1, 13, 0, 0, 0);
            this.dtpEntradaMT_Domingo.MinDate = new System.DateTime(2015, 11, 1, 8, 0, 0, 0);
            this.dtpEntradaMT_Domingo.Name = "dtpEntradaMT_Domingo";
            this.dtpEntradaMT_Domingo.ShowUpDown = true;
            this.dtpEntradaMT_Domingo.Size = new System.Drawing.Size(66, 23);
            this.dtpEntradaMT_Domingo.TabIndex = 1;
            this.dtpEntradaMT_Domingo.Tag = "7";
            this.dtpEntradaMT_Domingo.Value = new System.DateTime(2015, 11, 1, 13, 0, 0, 0);
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
            this.dtpSalidaMT_Domingo.CustomFormat = "HH:mm";
            this.dtpSalidaMT_Domingo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSalidaMT_Domingo.Location = new System.Drawing.Point(133, 319);
            this.dtpSalidaMT_Domingo.MaxDate = new System.DateTime(2015, 11, 1, 13, 0, 0, 0);
            this.dtpSalidaMT_Domingo.MinDate = new System.DateTime(2015, 11, 1, 8, 0, 0, 0);
            this.dtpSalidaMT_Domingo.Name = "dtpSalidaMT_Domingo";
            this.dtpSalidaMT_Domingo.ShowUpDown = true;
            this.dtpSalidaMT_Domingo.Size = new System.Drawing.Size(66, 23);
            this.dtpSalidaMT_Domingo.TabIndex = 2;
            this.dtpSalidaMT_Domingo.Tag = "7";
            this.dtpSalidaMT_Domingo.Value = new System.DateTime(2015, 11, 1, 13, 0, 0, 0);
            // 
            // pnlMedioTiempo
            // 
            this.pnlMedioTiempo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMedioTiempo.Controls.Add(this.label3);
            this.pnlMedioTiempo.Controls.Add(this.cbRepetirMT);
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
            this.pnlMedioTiempo.Location = new System.Drawing.Point(165, 89);
            this.pnlMedioTiempo.Name = "pnlMedioTiempo";
            this.pnlMedioTiempo.Size = new System.Drawing.Size(203, 346);
            this.pnlMedioTiempo.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 38;
            this.label3.Tag = "1";
            this.label3.Text = "Repetir";
            // 
            // cbRepetirMT
            // 
            this.cbRepetirMT.AutoSize = true;
            this.cbRepetirMT.Location = new System.Drawing.Point(95, 12);
            this.cbRepetirMT.Name = "cbRepetirMT";
            this.cbRepetirMT.Size = new System.Drawing.Size(15, 14);
            this.cbRepetirMT.TabIndex = 38;
            this.cbRepetirMT.Tag = "1";
            this.cbRepetirMT.UseVisualStyleBackColor = true;
            this.cbRepetirMT.CheckedChanged += new System.EventHandler(this.cbRepetirMT_CheckedChanged);
            // 
            // pnlTiempoCompleto
            // 
            this.pnlTiempoCompleto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTiempoCompleto.Controls.Add(this.label4);
            this.pnlTiempoCompleto.Controls.Add(this.dtpEntradaTC_Lunes);
            this.pnlTiempoCompleto.Controls.Add(this.cbRepetirTC);
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
            this.pnlTiempoCompleto.Size = new System.Drawing.Size(200, 346);
            this.pnlTiempoCompleto.TabIndex = 33;
            this.pnlTiempoCompleto.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 39;
            this.label4.Tag = "1";
            this.label4.Text = "Repetir";
            // 
            // dtpEntradaTC_Lunes
            // 
            this.dtpEntradaTC_Lunes.CustomFormat = "HH:mm";
            this.dtpEntradaTC_Lunes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEntradaTC_Lunes.Location = new System.Drawing.Point(3, 5);
            this.dtpEntradaTC_Lunes.MaxDate = new System.DateTime(2015, 11, 1, 21, 0, 0, 0);
            this.dtpEntradaTC_Lunes.MinDate = new System.DateTime(2015, 11, 1, 14, 0, 0, 0);
            this.dtpEntradaTC_Lunes.Name = "dtpEntradaTC_Lunes";
            this.dtpEntradaTC_Lunes.ShowUpDown = true;
            this.dtpEntradaTC_Lunes.Size = new System.Drawing.Size(65, 23);
            this.dtpEntradaTC_Lunes.TabIndex = 11;
            this.dtpEntradaTC_Lunes.Tag = "1";
            // 
            // cbRepetirTC
            // 
            this.cbRepetirTC.AutoSize = true;
            this.cbRepetirTC.Location = new System.Drawing.Point(93, 14);
            this.cbRepetirTC.Name = "cbRepetirTC";
            this.cbRepetirTC.Size = new System.Drawing.Size(15, 14);
            this.cbRepetirTC.TabIndex = 40;
            this.cbRepetirTC.Tag = "1";
            this.cbRepetirTC.UseVisualStyleBackColor = true;
            this.cbRepetirTC.CheckedChanged += new System.EventHandler(this.cbRepetirMT_CheckedChanged);
            // 
            // dtpSalidaTC_Domingo
            // 
            this.dtpSalidaTC_Domingo.CustomFormat = "HH:mm";
            this.dtpSalidaTC_Domingo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSalidaTC_Domingo.Location = new System.Drawing.Point(131, 319);
            this.dtpSalidaTC_Domingo.MaxDate = new System.DateTime(2015, 11, 1, 21, 0, 0, 0);
            this.dtpSalidaTC_Domingo.MinDate = new System.DateTime(2015, 11, 1, 14, 0, 0, 0);
            this.dtpSalidaTC_Domingo.Name = "dtpSalidaTC_Domingo";
            this.dtpSalidaTC_Domingo.ShowUpDown = true;
            this.dtpSalidaTC_Domingo.Size = new System.Drawing.Size(65, 23);
            this.dtpSalidaTC_Domingo.TabIndex = 2;
            this.dtpSalidaTC_Domingo.Tag = "7";
            // 
            // dtpSalidaTC_Lunes
            // 
            this.dtpSalidaTC_Lunes.CustomFormat = "HH:mm";
            this.dtpSalidaTC_Lunes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSalidaTC_Lunes.Location = new System.Drawing.Point(131, 5);
            this.dtpSalidaTC_Lunes.MaxDate = new System.DateTime(2015, 11, 1, 21, 0, 0, 0);
            this.dtpSalidaTC_Lunes.MinDate = new System.DateTime(2015, 11, 1, 14, 0, 0, 0);
            this.dtpSalidaTC_Lunes.Name = "dtpSalidaTC_Lunes";
            this.dtpSalidaTC_Lunes.ShowUpDown = true;
            this.dtpSalidaTC_Lunes.Size = new System.Drawing.Size(65, 23);
            this.dtpSalidaTC_Lunes.TabIndex = 12;
            this.dtpSalidaTC_Lunes.Tag = "1";
            // 
            // dtpEntradaTC_Martes
            // 
            this.dtpEntradaTC_Martes.CustomFormat = "HH:mm";
            this.dtpEntradaTC_Martes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEntradaTC_Martes.Location = new System.Drawing.Point(3, 59);
            this.dtpEntradaTC_Martes.MaxDate = new System.DateTime(2015, 11, 1, 21, 0, 0, 0);
            this.dtpEntradaTC_Martes.MinDate = new System.DateTime(2015, 11, 1, 14, 0, 0, 0);
            this.dtpEntradaTC_Martes.Name = "dtpEntradaTC_Martes";
            this.dtpEntradaTC_Martes.ShowUpDown = true;
            this.dtpEntradaTC_Martes.Size = new System.Drawing.Size(65, 23);
            this.dtpEntradaTC_Martes.TabIndex = 1;
            this.dtpEntradaTC_Martes.Tag = "2";
            // 
            // dtpSalidaTC_Martes
            // 
            this.dtpSalidaTC_Martes.CustomFormat = "HH:mm";
            this.dtpSalidaTC_Martes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSalidaTC_Martes.Location = new System.Drawing.Point(131, 59);
            this.dtpSalidaTC_Martes.MaxDate = new System.DateTime(2015, 11, 1, 21, 0, 0, 0);
            this.dtpSalidaTC_Martes.MinDate = new System.DateTime(2015, 11, 1, 14, 0, 0, 0);
            this.dtpSalidaTC_Martes.Name = "dtpSalidaTC_Martes";
            this.dtpSalidaTC_Martes.ShowUpDown = true;
            this.dtpSalidaTC_Martes.Size = new System.Drawing.Size(65, 23);
            this.dtpSalidaTC_Martes.TabIndex = 2;
            this.dtpSalidaTC_Martes.Tag = "2";
            // 
            // dtpEntradaTC_Miercoles
            // 
            this.dtpEntradaTC_Miercoles.CustomFormat = "HH:mm";
            this.dtpEntradaTC_Miercoles.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEntradaTC_Miercoles.Location = new System.Drawing.Point(3, 111);
            this.dtpEntradaTC_Miercoles.MaxDate = new System.DateTime(2015, 11, 1, 21, 0, 0, 0);
            this.dtpEntradaTC_Miercoles.MinDate = new System.DateTime(2015, 11, 1, 14, 0, 0, 0);
            this.dtpEntradaTC_Miercoles.Name = "dtpEntradaTC_Miercoles";
            this.dtpEntradaTC_Miercoles.ShowUpDown = true;
            this.dtpEntradaTC_Miercoles.Size = new System.Drawing.Size(65, 23);
            this.dtpEntradaTC_Miercoles.TabIndex = 1;
            this.dtpEntradaTC_Miercoles.Tag = "3";
            // 
            // dtpSalidaTC_Miercoles
            // 
            this.dtpSalidaTC_Miercoles.CustomFormat = "HH:mm";
            this.dtpSalidaTC_Miercoles.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSalidaTC_Miercoles.Location = new System.Drawing.Point(131, 111);
            this.dtpSalidaTC_Miercoles.MaxDate = new System.DateTime(2015, 11, 1, 21, 0, 0, 0);
            this.dtpSalidaTC_Miercoles.MinDate = new System.DateTime(2015, 11, 1, 14, 0, 0, 0);
            this.dtpSalidaTC_Miercoles.Name = "dtpSalidaTC_Miercoles";
            this.dtpSalidaTC_Miercoles.ShowUpDown = true;
            this.dtpSalidaTC_Miercoles.Size = new System.Drawing.Size(65, 23);
            this.dtpSalidaTC_Miercoles.TabIndex = 2;
            this.dtpSalidaTC_Miercoles.Tag = "3";
            // 
            // dtpEntradaTC_Jueves
            // 
            this.dtpEntradaTC_Jueves.CustomFormat = "HH:mm";
            this.dtpEntradaTC_Jueves.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEntradaTC_Jueves.Location = new System.Drawing.Point(3, 163);
            this.dtpEntradaTC_Jueves.MaxDate = new System.DateTime(2015, 11, 1, 21, 0, 0, 0);
            this.dtpEntradaTC_Jueves.MinDate = new System.DateTime(2015, 11, 1, 14, 0, 0, 0);
            this.dtpEntradaTC_Jueves.Name = "dtpEntradaTC_Jueves";
            this.dtpEntradaTC_Jueves.ShowUpDown = true;
            this.dtpEntradaTC_Jueves.Size = new System.Drawing.Size(65, 23);
            this.dtpEntradaTC_Jueves.TabIndex = 1;
            this.dtpEntradaTC_Jueves.Tag = "4";
            // 
            // dtpSalidaTC_Jueves
            // 
            this.dtpSalidaTC_Jueves.CustomFormat = "HH:mm";
            this.dtpSalidaTC_Jueves.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSalidaTC_Jueves.Location = new System.Drawing.Point(131, 163);
            this.dtpSalidaTC_Jueves.MaxDate = new System.DateTime(2015, 11, 1, 21, 0, 0, 0);
            this.dtpSalidaTC_Jueves.MinDate = new System.DateTime(2015, 11, 1, 14, 0, 0, 0);
            this.dtpSalidaTC_Jueves.Name = "dtpSalidaTC_Jueves";
            this.dtpSalidaTC_Jueves.ShowUpDown = true;
            this.dtpSalidaTC_Jueves.Size = new System.Drawing.Size(65, 23);
            this.dtpSalidaTC_Jueves.TabIndex = 2;
            this.dtpSalidaTC_Jueves.Tag = "4";
            // 
            // dtpEntradaTC_Viernes
            // 
            this.dtpEntradaTC_Viernes.CustomFormat = "HH:mm";
            this.dtpEntradaTC_Viernes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEntradaTC_Viernes.Location = new System.Drawing.Point(3, 215);
            this.dtpEntradaTC_Viernes.MaxDate = new System.DateTime(2015, 11, 1, 21, 0, 0, 0);
            this.dtpEntradaTC_Viernes.MinDate = new System.DateTime(2015, 11, 1, 14, 0, 0, 0);
            this.dtpEntradaTC_Viernes.Name = "dtpEntradaTC_Viernes";
            this.dtpEntradaTC_Viernes.ShowUpDown = true;
            this.dtpEntradaTC_Viernes.Size = new System.Drawing.Size(65, 23);
            this.dtpEntradaTC_Viernes.TabIndex = 1;
            this.dtpEntradaTC_Viernes.Tag = "5";
            // 
            // dtpEntradaTC_Domingo
            // 
            this.dtpEntradaTC_Domingo.CustomFormat = "HH:mm";
            this.dtpEntradaTC_Domingo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEntradaTC_Domingo.Location = new System.Drawing.Point(3, 319);
            this.dtpEntradaTC_Domingo.MaxDate = new System.DateTime(2015, 11, 1, 21, 0, 0, 0);
            this.dtpEntradaTC_Domingo.MinDate = new System.DateTime(2015, 11, 1, 14, 0, 0, 0);
            this.dtpEntradaTC_Domingo.Name = "dtpEntradaTC_Domingo";
            this.dtpEntradaTC_Domingo.ShowUpDown = true;
            this.dtpEntradaTC_Domingo.Size = new System.Drawing.Size(65, 23);
            this.dtpEntradaTC_Domingo.TabIndex = 1;
            this.dtpEntradaTC_Domingo.Tag = "7";
            // 
            // dtpSalidaTC_Viernes
            // 
            this.dtpSalidaTC_Viernes.CustomFormat = "HH:mm";
            this.dtpSalidaTC_Viernes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSalidaTC_Viernes.Location = new System.Drawing.Point(131, 215);
            this.dtpSalidaTC_Viernes.MaxDate = new System.DateTime(2015, 11, 1, 21, 0, 0, 0);
            this.dtpSalidaTC_Viernes.MinDate = new System.DateTime(2015, 11, 1, 14, 0, 0, 0);
            this.dtpSalidaTC_Viernes.Name = "dtpSalidaTC_Viernes";
            this.dtpSalidaTC_Viernes.ShowUpDown = true;
            this.dtpSalidaTC_Viernes.Size = new System.Drawing.Size(65, 23);
            this.dtpSalidaTC_Viernes.TabIndex = 2;
            this.dtpSalidaTC_Viernes.Tag = "5";
            // 
            // dtpSalidaTC_Sabado
            // 
            this.dtpSalidaTC_Sabado.CustomFormat = "HH:mm";
            this.dtpSalidaTC_Sabado.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSalidaTC_Sabado.Location = new System.Drawing.Point(131, 267);
            this.dtpSalidaTC_Sabado.MaxDate = new System.DateTime(2015, 11, 1, 21, 0, 0, 0);
            this.dtpSalidaTC_Sabado.MinDate = new System.DateTime(2015, 11, 1, 14, 0, 0, 0);
            this.dtpSalidaTC_Sabado.Name = "dtpSalidaTC_Sabado";
            this.dtpSalidaTC_Sabado.ShowUpDown = true;
            this.dtpSalidaTC_Sabado.Size = new System.Drawing.Size(65, 23);
            this.dtpSalidaTC_Sabado.TabIndex = 2;
            this.dtpSalidaTC_Sabado.Tag = "6";
            // 
            // dtpEntradaTC_Sabado
            // 
            this.dtpEntradaTC_Sabado.CustomFormat = "HH:mm";
            this.dtpEntradaTC_Sabado.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEntradaTC_Sabado.Location = new System.Drawing.Point(3, 267);
            this.dtpEntradaTC_Sabado.MaxDate = new System.DateTime(2015, 11, 1, 21, 0, 0, 0);
            this.dtpEntradaTC_Sabado.MinDate = new System.DateTime(2015, 11, 1, 14, 0, 0, 0);
            this.dtpEntradaTC_Sabado.Name = "dtpEntradaTC_Sabado";
            this.dtpEntradaTC_Sabado.ShowUpDown = true;
            this.dtpEntradaTC_Sabado.Size = new System.Drawing.Size(65, 23);
            this.dtpEntradaTC_Sabado.TabIndex = 1;
            this.dtpEntradaTC_Sabado.Tag = "6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(558, 57);
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
            this.cbTodos.Checked = true;
            this.cbTodos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTodos.Location = new System.Drawing.Point(28, 56);
            this.cbTodos.Name = "cbTodos";
            this.cbTodos.Size = new System.Drawing.Size(61, 19);
            this.cbTodos.TabIndex = 37;
            this.cbTodos.Tag = "10";
            this.cbTodos.Text = "Todos";
            this.cbTodos.UseVisualStyleBackColor = true;
            this.cbTodos.CheckedChanged += new System.EventHandler(this.cbLunes_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 15);
            this.label5.TabIndex = 38;
            this.label5.Text = "Formato: 0hs - 24hs";
            // 
            // rbTarde
            // 
            this.rbTarde.AutoSize = true;
            this.rbTarde.Location = new System.Drawing.Point(491, 27);
            this.rbTarde.Name = "rbTarde";
            this.rbTarde.Size = new System.Drawing.Size(60, 19);
            this.rbTarde.TabIndex = 39;
            this.rbTarde.Text = "Tarde";
            this.rbTarde.UseVisualStyleBackColor = true;
            this.rbTarde.CheckedChanged += new System.EventHandler(this.rbTarde_CheckedChanged);
            // 
            // frmHorariosMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 478);
            this.Controls.Add(this.rbTarde);
            this.Controls.Add(this.label5);
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
            this.Controls.Add(this.rbAmbos);
            this.Controls.Add(this.rbMT);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.Name = "frmHorariosMedico";
            this.Text = "frmHorariosMedico";
            this.Load += new System.EventHandler(this.frmHorariosMedico_Load);
            this.pnlMedioTiempo.ResumeLayout(false);
            this.pnlMedioTiempo.PerformLayout();
            this.pnlTiempoCompleto.ResumeLayout(false);
            this.pnlTiempoCompleto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbMT;
        private System.Windows.Forms.RadioButton rbAmbos;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbRepetirMT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbRepetirTC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbTarde;

    }
}