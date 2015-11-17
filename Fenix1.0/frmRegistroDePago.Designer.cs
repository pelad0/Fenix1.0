namespace Fenix1._0
{
    partial class frmRegistroDePago
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroDePago));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNumeroPagina = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.dgvTurnos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlTurno = new System.Windows.Forms.Panel();
            this.pnlPago = new System.Windows.Forms.Panel();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.tbCantidadTarjeta = new controles.TextBoxNumeros();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbCuit = new controles.TextBoxNumeros();
            this.tbCantidadEfectivo = new controles.TextBoxNumeros();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.tbCliente = new controles.TextBoxLetras();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbTipoFactura = new System.Windows.Forms.ComboBox();
            this.btnTraer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPasar = new System.Windows.Forms.Button();
            this.dgvTurnosAPagar = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).BeginInit();
            this.pnlTurno.SuspendLayout();
            this.pnlPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnosAPagar)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 26.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(236, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 41);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pago de consultas";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblNumeroPagina);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSiguiente);
            this.panel1.Controls.Add(this.btnAnterior);
            this.panel1.Controls.Add(this.dgvPacientes);
            this.panel1.Location = new System.Drawing.Point(-2, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 224);
            this.panel1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(645, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 30);
            this.label5.TabIndex = 25;
            this.label5.Text = "*Doble click \r\npara ver sus turnos.\r\n";
            // 
            // lblNumeroPagina
            // 
            this.lblNumeroPagina.AutoSize = true;
            this.lblNumeroPagina.Location = new System.Drawing.Point(421, 196);
            this.lblNumeroPagina.Name = "lblNumeroPagina";
            this.lblNumeroPagina.Size = new System.Drawing.Size(0, 15);
            this.lblNumeroPagina.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Pag";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Seleccione paciente";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(533, 193);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(106, 23);
            this.btnSiguiente.TabIndex = 22;
            this.btnSiguiente.Text = "Sig -->";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(130, 192);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(106, 23);
            this.btnAnterior.TabIndex = 21;
            this.btnAnterior.Text = "<-- Ant";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.AllowUserToAddRows = false;
            this.dgvPacientes.AllowUserToDeleteRows = false;
            this.dgvPacientes.AllowUserToResizeRows = false;
            this.dgvPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPacientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPacientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPacientes.Location = new System.Drawing.Point(46, 35);
            this.dgvPacientes.MultiSelect = false;
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.ReadOnly = true;
            this.dgvPacientes.RowHeadersVisible = false;
            this.dgvPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPacientes.Size = new System.Drawing.Size(727, 151);
            this.dgvPacientes.TabIndex = 20;
            this.dgvPacientes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPacientes_CellContentDoubleClick);
            // 
            // dgvTurnos
            // 
            this.dgvTurnos.AllowUserToAddRows = false;
            this.dgvTurnos.AllowUserToDeleteRows = false;
            this.dgvTurnos.AllowUserToResizeRows = false;
            this.dgvTurnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTurnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurnos.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTurnos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTurnos.Location = new System.Drawing.Point(46, 47);
            this.dgvTurnos.MultiSelect = false;
            this.dgvTurnos.Name = "dgvTurnos";
            this.dgvTurnos.ReadOnly = true;
            this.dgvTurnos.RowHeadersVisible = false;
            this.dgvTurnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTurnos.Size = new System.Drawing.Size(302, 151);
            this.dgvTurnos.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(110, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 22);
            this.label4.TabIndex = 26;
            this.label4.Text = "Turnos en deuda";
            // 
            // pnlTurno
            // 
            this.pnlTurno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTurno.Controls.Add(this.pnlPago);
            this.pnlTurno.Controls.Add(this.label8);
            this.pnlTurno.Controls.Add(this.cbTipoFactura);
            this.pnlTurno.Controls.Add(this.btnTraer);
            this.pnlTurno.Controls.Add(this.label6);
            this.pnlTurno.Controls.Add(this.btnPasar);
            this.pnlTurno.Controls.Add(this.dgvTurnosAPagar);
            this.pnlTurno.Controls.Add(this.dgvTurnos);
            this.pnlTurno.Controls.Add(this.label4);
            this.pnlTurno.Location = new System.Drawing.Point(-2, 310);
            this.pnlTurno.Name = "pnlTurno";
            this.pnlTurno.Size = new System.Drawing.Size(832, 447);
            this.pnlTurno.TabIndex = 27;
            // 
            // pnlPago
            // 
            this.pnlPago.Controls.Add(this.tbDireccion);
            this.pnlPago.Controls.Add(this.label19);
            this.pnlPago.Controls.Add(this.lblDescuento);
            this.pnlPago.Controls.Add(this.label18);
            this.pnlPago.Controls.Add(this.label16);
            this.pnlPago.Controls.Add(this.label15);
            this.pnlPago.Controls.Add(this.label14);
            this.pnlPago.Controls.Add(this.btnPagar);
            this.pnlPago.Controls.Add(this.tbCantidadTarjeta);
            this.pnlPago.Controls.Add(this.label7);
            this.pnlPago.Controls.Add(this.label13);
            this.pnlPago.Controls.Add(this.tbCuit);
            this.pnlPago.Controls.Add(this.tbCantidadEfectivo);
            this.pnlPago.Controls.Add(this.label9);
            this.pnlPago.Controls.Add(this.lblTotal);
            this.pnlPago.Controls.Add(this.tbCliente);
            this.pnlPago.Controls.Add(this.label12);
            this.pnlPago.Controls.Add(this.label10);
            this.pnlPago.Controls.Add(this.label11);
            this.pnlPago.Enabled = false;
            this.pnlPago.Location = new System.Drawing.Point(-1, 275);
            this.pnlPago.Name = "pnlPago";
            this.pnlPago.Size = new System.Drawing.Size(815, 171);
            this.pnlPago.TabIndex = 44;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(36, 131);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(175, 23);
            this.tbDireccion.TabIndex = 3;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(87, 109);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(90, 19);
            this.label19.TabIndex = 50;
            this.label19.Text = "Direccion";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.Location = new System.Drawing.Point(656, 46);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(18, 19);
            this.lblDescuento.TabIndex = 48;
            this.lblDescuento.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(632, 46);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(18, 19);
            this.label18.TabIndex = 47;
            this.label18.Text = "€";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(589, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(135, 19);
            this.label16.TabIndex = 46;
            this.label16.Text = "Descuento obra";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(291, 111);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(18, 19);
            this.label15.TabIndex = 45;
            this.label15.Text = "€";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(290, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 19);
            this.label14.TabIndex = 44;
            this.label14.Text = "€";
            // 
            // btnPagar
            // 
            this.btnPagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagar.Enabled = false;
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPagar.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.Location = new System.Drawing.Point(510, 90);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(130, 26);
            this.btnPagar.TabIndex = 26;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // tbCantidadTarjeta
            // 
            this.tbCantidadTarjeta.Enabled = false;
            this.tbCantidadTarjeta.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCantidadTarjeta.Location = new System.Drawing.Point(284, 46);
            this.tbCantidadTarjeta.Name = "tbCantidadTarjeta";
            this.tbCantidadTarjeta.Size = new System.Drawing.Size(123, 26);
            this.tbCantidadTarjeta.TabIndex = 43;
            this.tbCantidadTarjeta.Text = "0";
            this.tbCantidadTarjeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(308, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 19);
            this.label7.TabIndex = 26;
            this.label7.Text = "Efectivo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(312, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 19);
            this.label13.TabIndex = 42;
            this.label13.Text = "Tarjeta";
            // 
            // tbCuit
            // 
            this.tbCuit.Location = new System.Drawing.Point(36, 83);
            this.tbCuit.MaxLength = 11;
            this.tbCuit.Name = "tbCuit";
            this.tbCuit.Size = new System.Drawing.Size(175, 23);
            this.tbCuit.TabIndex = 2;
            // 
            // tbCantidadEfectivo
            // 
            this.tbCantidadEfectivo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCantidadEfectivo.Location = new System.Drawing.Point(284, 109);
            this.tbCantidadEfectivo.Name = "tbCantidadEfectivo";
            this.tbCantidadEfectivo.Size = new System.Drawing.Size(123, 26);
            this.tbCantidadEfectivo.TabIndex = 4;
            this.tbCantidadEfectivo.Text = "0";
            this.tbCantidadEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbCantidadEfectivo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbCantidadEfectivo_MouseClick);
            this.tbCantidadEfectivo.TextChanged += new System.EventHandler(this.tbCantidadEfectivo_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(101, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 19);
            this.label9.TabIndex = 35;
            this.label9.Text = "Cuit";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(506, 46);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(18, 19);
            this.lblTotal.TabIndex = 40;
            this.lblTotal.Text = "0";
            // 
            // tbCliente
            // 
            this.tbCliente.Location = new System.Drawing.Point(36, 32);
            this.tbCliente.Name = "tbCliente";
            this.tbCliente.Size = new System.Drawing.Size(175, 23);
            this.tbCliente.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(482, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 19);
            this.label12.TabIndex = 39;
            this.label12.Text = "€";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(87, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 19);
            this.label10.TabIndex = 37;
            this.label10.Text = "Cliente";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(475, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 19);
            this.label11.TabIndex = 38;
            this.label11.Text = "Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(350, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 19);
            this.label8.TabIndex = 33;
            this.label8.Text = "Factura tipo";
            // 
            // cbTipoFactura
            // 
            this.cbTipoFactura.Enabled = false;
            this.cbTipoFactura.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoFactura.FormattingEnabled = true;
            this.cbTipoFactura.Items.AddRange(new object[] {
            "A",
            "B"});
            this.cbTipoFactura.Location = new System.Drawing.Point(390, 242);
            this.cbTipoFactura.Name = "cbTipoFactura";
            this.cbTipoFactura.Size = new System.Drawing.Size(45, 27);
            this.cbTipoFactura.TabIndex = 32;
            this.cbTipoFactura.SelectedIndexChanged += new System.EventHandler(this.cbTipoFactura_SelectedIndexChanged);
            // 
            // btnTraer
            // 
            this.btnTraer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTraer.BackgroundImage")));
            this.btnTraer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTraer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTraer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTraer.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraer.Location = new System.Drawing.Point(380, 144);
            this.btnTraer.Name = "btnTraer";
            this.btnTraer.Size = new System.Drawing.Size(68, 34);
            this.btnTraer.TabIndex = 30;
            this.btnTraer.UseVisualStyleBackColor = true;
            this.btnTraer.Click += new System.EventHandler(this.btnTraer_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(550, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 22);
            this.label6.TabIndex = 29;
            this.label6.Text = "Turnos a pagar";
            // 
            // btnPasar
            // 
            this.btnPasar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPasar.BackgroundImage")));
            this.btnPasar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPasar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPasar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPasar.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasar.Location = new System.Drawing.Point(380, 63);
            this.btnPasar.Name = "btnPasar";
            this.btnPasar.Size = new System.Drawing.Size(68, 34);
            this.btnPasar.TabIndex = 28;
            this.btnPasar.UseVisualStyleBackColor = true;
            this.btnPasar.Click += new System.EventHandler(this.btnPasar_Click);
            // 
            // dgvTurnosAPagar
            // 
            this.dgvTurnosAPagar.AllowUserToAddRows = false;
            this.dgvTurnosAPagar.AllowUserToDeleteRows = false;
            this.dgvTurnosAPagar.AllowUserToResizeRows = false;
            this.dgvTurnosAPagar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTurnosAPagar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTurnosAPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurnosAPagar.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTurnosAPagar.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTurnosAPagar.Location = new System.Drawing.Point(471, 47);
            this.dgvTurnosAPagar.MultiSelect = false;
            this.dgvTurnosAPagar.Name = "dgvTurnosAPagar";
            this.dgvTurnosAPagar.ReadOnly = true;
            this.dgvTurnosAPagar.RowHeadersVisible = false;
            this.dgvTurnosAPagar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTurnosAPagar.Size = new System.Drawing.Size(302, 151);
            this.dgvTurnosAPagar.TabIndex = 27;
            // 
            // frmRegistroDePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 741);
            this.Controls.Add(this.pnlTurno);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.Name = "frmRegistroDePago";
            this.Text = "frmRegistroDePago";
            this.Load += new System.EventHandler(this.frmRegistroDePago_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).EndInit();
            this.pnlTurno.ResumeLayout(false);
            this.pnlTurno.PerformLayout();
            this.pnlPago.ResumeLayout(false);
            this.pnlPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnosAPagar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNumeroPagina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.DataGridView dgvTurnos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlTurno;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnPasar;
        private System.Windows.Forms.DataGridView dgvTurnosAPagar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTraer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbTipoFactura;
        private System.Windows.Forms.Label label9;
        private controles.TextBoxNumeros tbCuit;
        private System.Windows.Forms.Label label10;
        private controles.TextBoxLetras tbCliente;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private controles.TextBoxNumeros tbCantidadEfectivo;
        private System.Windows.Forms.Panel pnlPago;
        private controles.TextBoxNumeros tbCantidadTarjeta;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbDireccion;

    }
}