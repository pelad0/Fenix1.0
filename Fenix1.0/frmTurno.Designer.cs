namespace Fenix1._0
{
    partial class frmTurno
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
            this.dgvTurnos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rbPacientes = new System.Windows.Forms.RadioButton();
            this.rbMedicos = new System.Windows.Forms.RadioButton();
            this.cbPacientes = new System.Windows.Forms.ComboBox();
            this.cbEspecialidades = new System.Windows.Forms.ComboBox();
            this.cbMedicos = new System.Windows.Forms.ComboBox();
            this.dgvSobreturnos = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSobreturnos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTurnos
            // 
            this.dgvTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurnos.Location = new System.Drawing.Point(1, 95);
            this.dgvTurnos.Name = "dgvTurnos";
            this.dgvTurnos.Size = new System.Drawing.Size(642, 192);
            this.dgvTurnos.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rbPacientes);
            this.panel1.Controls.Add(this.rbMedicos);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.cbPacientes);
            this.panel1.Controls.Add(this.cbEspecialidades);
            this.panel1.Controls.Add(this.cbMedicos);
            this.panel1.Location = new System.Drawing.Point(1, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(641, 84);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Especialidades";
            // 
            // rbPacientes
            // 
            this.rbPacientes.AutoSize = true;
            this.rbPacientes.Location = new System.Drawing.Point(489, 16);
            this.rbPacientes.Name = "rbPacientes";
            this.rbPacientes.Size = new System.Drawing.Size(72, 17);
            this.rbPacientes.TabIndex = 2;
            this.rbPacientes.Text = "Pacientes";
            this.rbPacientes.UseVisualStyleBackColor = true;
            this.rbPacientes.CheckedChanged += new System.EventHandler(this.rbPacientes_CheckedChanged);
            // 
            // rbMedicos
            // 
            this.rbMedicos.AutoSize = true;
            this.rbMedicos.Location = new System.Drawing.Point(288, 16);
            this.rbMedicos.Name = "rbMedicos";
            this.rbMedicos.Size = new System.Drawing.Size(65, 17);
            this.rbMedicos.TabIndex = 2;
            this.rbMedicos.Text = "Medicos";
            this.rbMedicos.UseVisualStyleBackColor = true;
            this.rbMedicos.CheckedChanged += new System.EventHandler(this.rbMedicos_CheckedChanged);
            // 
            // cbPacientes
            // 
            this.cbPacientes.Enabled = false;
            this.cbPacientes.FormattingEnabled = true;
            this.cbPacientes.Location = new System.Drawing.Point(476, 50);
            this.cbPacientes.Name = "cbPacientes";
            this.cbPacientes.Size = new System.Drawing.Size(154, 21);
            this.cbPacientes.TabIndex = 1;
            // 
            // cbEspecialidades
            // 
            this.cbEspecialidades.Enabled = false;
            this.cbEspecialidades.FormattingEnabled = true;
            this.cbEspecialidades.Location = new System.Drawing.Point(10, 50);
            this.cbEspecialidades.Name = "cbEspecialidades";
            this.cbEspecialidades.Size = new System.Drawing.Size(194, 21);
            this.cbEspecialidades.TabIndex = 1;
            // 
            // cbMedicos
            // 
            this.cbMedicos.Enabled = false;
            this.cbMedicos.FormattingEnabled = true;
            this.cbMedicos.Location = new System.Drawing.Point(223, 50);
            this.cbMedicos.Name = "cbMedicos";
            this.cbMedicos.Size = new System.Drawing.Size(194, 21);
            this.cbMedicos.TabIndex = 1;
            // 
            // dgvSobreturnos
            // 
            this.dgvSobreturnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSobreturnos.Location = new System.Drawing.Point(1, 293);
            this.dgvSobreturnos.Name = "dgvSobreturnos";
            this.dgvSobreturnos.Size = new System.Drawing.Size(642, 192);
            this.dgvSobreturnos.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(423, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(47, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // frmTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 485);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvSobreturnos);
            this.Controls.Add(this.dgvTurnos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTurno";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turnos";
            this.Load += new System.EventHandler(this.frmTurno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSobreturnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTurnos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbPacientes;
        private System.Windows.Forms.RadioButton rbMedicos;
        private System.Windows.Forms.ComboBox cbPacientes;
        private System.Windows.Forms.ComboBox cbMedicos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEspecialidades;
        private System.Windows.Forms.DataGridView dgvSobreturnos;
        private System.Windows.Forms.ComboBox comboBox1;

    }
}