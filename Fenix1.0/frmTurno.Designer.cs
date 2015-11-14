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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTurnos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rbPacientes = new System.Windows.Forms.RadioButton();
            this.rbMedicos = new System.Windows.Forms.RadioButton();
            this.cbAlfa = new System.Windows.Forms.ComboBox();
            this.cbPacientes = new System.Windows.Forms.ComboBox();
            this.cbEspecialidades = new System.Windows.Forms.ComboBox();
            this.cbMedicos = new System.Windows.Forms.ComboBox();
            this.dgvSobreturnos = new System.Windows.Forms.DataGridView();
            this.btnRepTurn = new System.Windows.Forms.Button();
            this.btnRepSobreTur = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSobreturnos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTurnos
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvTurnos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTurnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTurnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTurnos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTurnos.Location = new System.Drawing.Point(1, 95);
            this.dgvTurnos.MultiSelect = false;
            this.dgvTurnos.Name = "dgvTurnos";
            this.dgvTurnos.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTurnos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTurnos.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvTurnos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTurnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTurnos.Size = new System.Drawing.Size(526, 192);
            this.dgvTurnos.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rbPacientes);
            this.panel1.Controls.Add(this.rbMedicos);
            this.panel1.Controls.Add(this.cbAlfa);
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
            // cbAlfa
            // 
            this.cbAlfa.Enabled = false;
            this.cbAlfa.FormattingEnabled = true;
            this.cbAlfa.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "Ñ",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.cbAlfa.Location = new System.Drawing.Point(418, 50);
            this.cbAlfa.Name = "cbAlfa";
            this.cbAlfa.Size = new System.Drawing.Size(47, 21);
            this.cbAlfa.TabIndex = 1;
            this.cbAlfa.SelectedIndexChanged += new System.EventHandler(this.cbAlfa_SelectedIndexChanged);
            // 
            // cbPacientes
            // 
            this.cbPacientes.Enabled = false;
            this.cbPacientes.FormattingEnabled = true;
            this.cbPacientes.Location = new System.Drawing.Point(475, 50);
            this.cbPacientes.Name = "cbPacientes";
            this.cbPacientes.Size = new System.Drawing.Size(154, 21);
            this.cbPacientes.TabIndex = 1;
            this.cbPacientes.SelectedIndexChanged += new System.EventHandler(this.cbPacientes_SelectedIndexChanged);
            // 
            // cbEspecialidades
            // 
            this.cbEspecialidades.Enabled = false;
            this.cbEspecialidades.FormattingEnabled = true;
            this.cbEspecialidades.Location = new System.Drawing.Point(10, 50);
            this.cbEspecialidades.Name = "cbEspecialidades";
            this.cbEspecialidades.Size = new System.Drawing.Size(194, 21);
            this.cbEspecialidades.TabIndex = 1;
            this.cbEspecialidades.SelectedIndexChanged += new System.EventHandler(this.cbEspecialidades_SelectedIndexChanged);
            // 
            // cbMedicos
            // 
            this.cbMedicos.Enabled = false;
            this.cbMedicos.FormattingEnabled = true;
            this.cbMedicos.Location = new System.Drawing.Point(214, 50);
            this.cbMedicos.Name = "cbMedicos";
            this.cbMedicos.Size = new System.Drawing.Size(194, 21);
            this.cbMedicos.TabIndex = 1;
            this.cbMedicos.SelectedIndexChanged += new System.EventHandler(this.cbMedicos_SelectedIndexChanged);
            // 
            // dgvSobreturnos
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvSobreturnos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSobreturnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSobreturnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvSobreturnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSobreturnos.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvSobreturnos.Location = new System.Drawing.Point(1, 293);
            this.dgvSobreturnos.MultiSelect = false;
            this.dgvSobreturnos.Name = "dgvSobreturnos";
            this.dgvSobreturnos.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSobreturnos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvSobreturnos.RowHeadersVisible = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvSobreturnos.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvSobreturnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSobreturnos.Size = new System.Drawing.Size(526, 192);
            this.dgvSobreturnos.TabIndex = 0;
            // 
            // btnRepTurn
            // 
            this.btnRepTurn.Location = new System.Drawing.Point(546, 152);
            this.btnRepTurn.Name = "btnRepTurn";
            this.btnRepTurn.Size = new System.Drawing.Size(84, 87);
            this.btnRepTurn.TabIndex = 2;
            this.btnRepTurn.Text = "Generar Reporte Turnos";
            this.btnRepTurn.UseVisualStyleBackColor = true;
            this.btnRepTurn.Click += new System.EventHandler(this.btnRepTurn_Click);
            // 
            // btnRepSobreTur
            // 
            this.btnRepSobreTur.Location = new System.Drawing.Point(546, 353);
            this.btnRepSobreTur.Name = "btnRepSobreTur";
            this.btnRepSobreTur.Size = new System.Drawing.Size(84, 87);
            this.btnRepSobreTur.TabIndex = 2;
            this.btnRepSobreTur.Text = "Generar Reporte Sobre Turnos";
            this.btnRepSobreTur.UseVisualStyleBackColor = true;
            this.btnRepSobreTur.Click += new System.EventHandler(this.btnRepSobreTur_Click);
            // 
            // frmTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 485);
            this.Controls.Add(this.btnRepSobreTur);
            this.Controls.Add(this.btnRepTurn);
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
        private System.Windows.Forms.ComboBox cbAlfa;
        private System.Windows.Forms.Button btnRepTurn;
        private System.Windows.Forms.Button btnRepSobreTur;

    }
}