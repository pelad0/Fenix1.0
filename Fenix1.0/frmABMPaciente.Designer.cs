namespace Fenix1._0
{
    partial class frmABMPaciente
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
            this.tcABM = new System.Windows.Forms.TabControl();
            this.tpAlta = new System.Windows.Forms.TabPage();
            this.cbOSAlta = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTelALta = new controles.TextBoxNumeros();
            this.tbDniAlta = new controles.TextBoxNumeros();
            this.tbApellidoAlta = new controles.TextBoxLetras();
            this.tbNombreAlta = new controles.TextBoxLetras();
            this.btnAlta = new System.Windows.Forms.Button();
            this.tpBaja = new System.Windows.Forms.TabPage();
            this.btnSig = new System.Windows.Forms.Button();
            this.btnAnt = new System.Windows.Forms.Button();
            this.dgvEliminar = new System.Windows.Forms.DataGridView();
            this.btnBaja = new System.Windows.Forms.Button();
            this.tpMod = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvPacMod = new System.Windows.Forms.DataGridView();
            this.cbOSMod = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.tbTelMod = new controles.TextBoxNumeros();
            this.tbDniMod = new controles.TextBoxNumeros();
            this.tbApellidoMod = new controles.TextBoxLetras();
            this.tbNombreMod = new controles.TextBoxLetras();
            this.tcABM.SuspendLayout();
            this.tpAlta.SuspendLayout();
            this.tpBaja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminar)).BeginInit();
            this.tpMod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacMod)).BeginInit();
            this.SuspendLayout();
            // 
            // tcABM
            // 
            this.tcABM.Controls.Add(this.tpAlta);
            this.tcABM.Controls.Add(this.tpBaja);
            this.tcABM.Controls.Add(this.tpMod);
            this.tcABM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcABM.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcABM.ItemSize = new System.Drawing.Size(213, 30);
            this.tcABM.Location = new System.Drawing.Point(0, 0);
            this.tcABM.Name = "tcABM";
            this.tcABM.SelectedIndex = 0;
            this.tcABM.Size = new System.Drawing.Size(644, 485);
            this.tcABM.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcABM.TabIndex = 0;
            // 
            // tpAlta
            // 
            this.tpAlta.Controls.Add(this.cbOSAlta);
            this.tpAlta.Controls.Add(this.label5);
            this.tpAlta.Controls.Add(this.label4);
            this.tpAlta.Controls.Add(this.label3);
            this.tpAlta.Controls.Add(this.label2);
            this.tpAlta.Controls.Add(this.label1);
            this.tpAlta.Controls.Add(this.tbTelALta);
            this.tpAlta.Controls.Add(this.tbDniAlta);
            this.tpAlta.Controls.Add(this.tbApellidoAlta);
            this.tpAlta.Controls.Add(this.tbNombreAlta);
            this.tpAlta.Controls.Add(this.btnAlta);
            this.tpAlta.Location = new System.Drawing.Point(4, 34);
            this.tpAlta.Name = "tpAlta";
            this.tpAlta.Padding = new System.Windows.Forms.Padding(3);
            this.tpAlta.Size = new System.Drawing.Size(636, 447);
            this.tpAlta.TabIndex = 0;
            this.tpAlta.Text = "Alta";
            this.tpAlta.UseVisualStyleBackColor = true;
            // 
            // cbOSAlta
            // 
            this.cbOSAlta.FormattingEnabled = true;
            this.cbOSAlta.Location = new System.Drawing.Point(237, 308);
            this.cbOSAlta.Name = "cbOSAlta";
            this.cbOSAlta.Size = new System.Drawing.Size(162, 23);
            this.cbOSAlta.TabIndex = 9;
            this.cbOSAlta.Tag = "Obra Social";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Obra Social";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // tbTelALta
            // 
            this.tbTelALta.Location = new System.Drawing.Point(237, 244);
            this.tbTelALta.Name = "tbTelALta";
            this.tbTelALta.Size = new System.Drawing.Size(162, 23);
            this.tbTelALta.TabIndex = 4;
            this.tbTelALta.Tag = "Telefono";
            // 
            // tbDniAlta
            // 
            this.tbDniAlta.Location = new System.Drawing.Point(237, 180);
            this.tbDniAlta.Name = "tbDniAlta";
            this.tbDniAlta.Size = new System.Drawing.Size(162, 23);
            this.tbDniAlta.TabIndex = 3;
            this.tbDniAlta.Tag = "Documento";
            // 
            // tbApellidoAlta
            // 
            this.tbApellidoAlta.Location = new System.Drawing.Point(237, 116);
            this.tbApellidoAlta.Name = "tbApellidoAlta";
            this.tbApellidoAlta.Size = new System.Drawing.Size(162, 23);
            this.tbApellidoAlta.TabIndex = 2;
            this.tbApellidoAlta.Tag = "Apellido";
            // 
            // tbNombreAlta
            // 
            this.tbNombreAlta.Location = new System.Drawing.Point(237, 52);
            this.tbNombreAlta.Name = "tbNombreAlta";
            this.tbNombreAlta.Size = new System.Drawing.Size(162, 23);
            this.tbNombreAlta.TabIndex = 1;
            this.tbNombreAlta.Tag = "Nombre";
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(281, 409);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(75, 23);
            this.btnAlta.TabIndex = 0;
            this.btnAlta.Text = "Cargar";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // tpBaja
            // 
            this.tpBaja.Controls.Add(this.btnSig);
            this.tpBaja.Controls.Add(this.btnAnt);
            this.tpBaja.Controls.Add(this.dgvEliminar);
            this.tpBaja.Controls.Add(this.btnBaja);
            this.tpBaja.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpBaja.Location = new System.Drawing.Point(4, 34);
            this.tpBaja.Name = "tpBaja";
            this.tpBaja.Padding = new System.Windows.Forms.Padding(3);
            this.tpBaja.Size = new System.Drawing.Size(636, 447);
            this.tpBaja.TabIndex = 1;
            this.tpBaja.Text = "Baja";
            this.tpBaja.UseVisualStyleBackColor = true;
            // 
            // btnSig
            // 
            this.btnSig.Location = new System.Drawing.Point(467, 409);
            this.btnSig.Name = "btnSig";
            this.btnSig.Size = new System.Drawing.Size(93, 23);
            this.btnSig.TabIndex = 6;
            this.btnSig.Text = "Siguiente>>";
            this.btnSig.UseVisualStyleBackColor = true;
            this.btnSig.Click += new System.EventHandler(this.btnSig_Click);
            // 
            // btnAnt
            // 
            this.btnAnt.Location = new System.Drawing.Point(76, 409);
            this.btnAnt.Name = "btnAnt";
            this.btnAnt.Size = new System.Drawing.Size(90, 23);
            this.btnAnt.TabIndex = 5;
            this.btnAnt.Text = "<<Anterior";
            this.btnAnt.UseVisualStyleBackColor = true;
            this.btnAnt.Click += new System.EventHandler(this.btnAnt_Click);
            // 
            // dgvEliminar
            // 
            this.dgvEliminar.AllowUserToAddRows = false;
            this.dgvEliminar.AllowUserToDeleteRows = false;
            this.dgvEliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEliminar.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvEliminar.Location = new System.Drawing.Point(3, 3);
            this.dgvEliminar.MultiSelect = false;
            this.dgvEliminar.Name = "dgvEliminar";
            this.dgvEliminar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvEliminar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEliminar.ShowEditingIcon = false;
            this.dgvEliminar.Size = new System.Drawing.Size(630, 380);
            this.dgvEliminar.TabIndex = 1;
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(279, 409);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(75, 23);
            this.btnBaja.TabIndex = 0;
            this.btnBaja.Text = "Eliminar";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // tpMod
            // 
            this.tpMod.Controls.Add(this.button1);
            this.tpMod.Controls.Add(this.button2);
            this.tpMod.Controls.Add(this.dgvPacMod);
            this.tpMod.Controls.Add(this.cbOSMod);
            this.tpMod.Controls.Add(this.label6);
            this.tpMod.Controls.Add(this.label7);
            this.tpMod.Controls.Add(this.label8);
            this.tpMod.Controls.Add(this.label9);
            this.tpMod.Controls.Add(this.label10);
            this.tpMod.Controls.Add(this.btnModificar);
            this.tpMod.Controls.Add(this.tbTelMod);
            this.tpMod.Controls.Add(this.tbDniMod);
            this.tpMod.Controls.Add(this.tbApellidoMod);
            this.tpMod.Controls.Add(this.tbNombreMod);
            this.tpMod.Location = new System.Drawing.Point(4, 34);
            this.tpMod.Name = "tpMod";
            this.tpMod.Size = new System.Drawing.Size(636, 447);
            this.tpMod.TabIndex = 2;
            this.tpMod.Text = "Modificación";
            this.tpMod.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(322, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Siguiente>>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSig_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(19, 379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "<<Anterior";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnAnt_Click);
            // 
            // dgvPacMod
            // 
            this.dgvPacMod.AllowUserToAddRows = false;
            this.dgvPacMod.AllowUserToDeleteRows = false;
            this.dgvPacMod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvPacMod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacMod.Location = new System.Drawing.Point(19, 29);
            this.dgvPacMod.MultiSelect = false;
            this.dgvPacMod.Name = "dgvPacMod";
            this.dgvPacMod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPacMod.Size = new System.Drawing.Size(397, 334);
            this.dgvPacMod.TabIndex = 20;
            this.dgvPacMod.SelectionChanged += new System.EventHandler(this.dgvPacMod_SelectionChanged);
            // 
            // cbOSMod
            // 
            this.cbOSMod.FormattingEnabled = true;
            this.cbOSMod.Location = new System.Drawing.Point(455, 322);
            this.cbOSMod.Name = "cbOSMod";
            this.cbOSMod.Size = new System.Drawing.Size(162, 23);
            this.cbOSMod.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(494, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Obra Social";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(505, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Telefono";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(501, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Documento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(505, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "Apellido";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(512, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 15);
            this.label10.TabIndex = 14;
            this.label10.Text = "Nombre";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(180, 403);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 0;
            this.btnModificar.Text = "Editar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // tbTelMod
            // 
            this.tbTelMod.Location = new System.Drawing.Point(455, 258);
            this.tbTelMod.Name = "tbTelMod";
            this.tbTelMod.Size = new System.Drawing.Size(162, 23);
            this.tbTelMod.TabIndex = 13;
            // 
            // tbDniMod
            // 
            this.tbDniMod.Location = new System.Drawing.Point(455, 194);
            this.tbDniMod.Name = "tbDniMod";
            this.tbDniMod.Size = new System.Drawing.Size(162, 23);
            this.tbDniMod.TabIndex = 12;
            // 
            // tbApellidoMod
            // 
            this.tbApellidoMod.Location = new System.Drawing.Point(455, 130);
            this.tbApellidoMod.Name = "tbApellidoMod";
            this.tbApellidoMod.Size = new System.Drawing.Size(162, 23);
            this.tbApellidoMod.TabIndex = 11;
            // 
            // tbNombreMod
            // 
            this.tbNombreMod.Location = new System.Drawing.Point(455, 66);
            this.tbNombreMod.Name = "tbNombreMod";
            this.tbNombreMod.Size = new System.Drawing.Size(162, 23);
            this.tbNombreMod.TabIndex = 10;
            // 
            // frmABMPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 485);
            this.Controls.Add(this.tcABM);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmABMPaciente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pacientes";
            this.Load += new System.EventHandler(this.frmABMPaciente_Load);
            this.tcABM.ResumeLayout(false);
            this.tpAlta.ResumeLayout(false);
            this.tpAlta.PerformLayout();
            this.tpBaja.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminar)).EndInit();
            this.tpMod.ResumeLayout(false);
            this.tpMod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacMod)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcABM;
        private System.Windows.Forms.TabPage tpAlta;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.TabPage tpBaja;
        private System.Windows.Forms.DataGridView dgvEliminar;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.TabPage tpMod;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnSig;
        private System.Windows.Forms.Button btnAnt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private controles.TextBoxNumeros tbTelALta;
        private controles.TextBoxNumeros tbDniAlta;
        private controles.TextBoxLetras tbApellidoAlta;
        private controles.TextBoxLetras tbNombreAlta;
        private System.Windows.Forms.ComboBox cbOSAlta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvPacMod;
        private System.Windows.Forms.ComboBox cbOSMod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private controles.TextBoxNumeros tbTelMod;
        private controles.TextBoxNumeros tbDniMod;
        private controles.TextBoxLetras tbApellidoMod;
        private controles.TextBoxLetras tbNombreMod;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}