namespace Fenix1._0
{
    partial class frmABMES
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
            this.tcABM = new System.Windows.Forms.TabControl();
            this.tpAlta = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvEspecialidadesAlta = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEspecialidadAlta = new controles.TextBoxLetras();
            this.btnAltaEspecialidad = new System.Windows.Forms.Button();
            this.tpBaja = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvEspecialidadesBaja = new System.Windows.Forms.DataGridView();
            this.btnBaja = new System.Windows.Forms.Button();
            this.tpMod = new System.Windows.Forms.TabPage();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tbEspecialidaModi = new controles.TextBoxLetras();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvEspecialidadesModificar = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.tcABM.SuspendLayout();
            this.tpAlta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidadesAlta)).BeginInit();
            this.tpBaja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidadesBaja)).BeginInit();
            this.tpMod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidadesModificar)).BeginInit();
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
            this.tcABM.Size = new System.Drawing.Size(644, 471);
            this.tcABM.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcABM.TabIndex = 0;
            this.tcABM.Click += new System.EventHandler(this.tcABM_Click);
            // 
            // tpAlta
            // 
            this.tpAlta.Controls.Add(this.label2);
            this.tpAlta.Controls.Add(this.dgvEspecialidadesAlta);
            this.tpAlta.Controls.Add(this.label1);
            this.tpAlta.Controls.Add(this.tbEspecialidadAlta);
            this.tpAlta.Controls.Add(this.btnAltaEspecialidad);
            this.tpAlta.Location = new System.Drawing.Point(4, 34);
            this.tpAlta.Name = "tpAlta";
            this.tpAlta.Padding = new System.Windows.Forms.Padding(3);
            this.tpAlta.Size = new System.Drawing.Size(636, 433);
            this.tpAlta.TabIndex = 0;
            this.tpAlta.Text = "Alta";
            this.tpAlta.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lista de especialidades";
            // 
            // dgvEspecialidadesAlta
            // 
            this.dgvEspecialidadesAlta.AllowUserToAddRows = false;
            this.dgvEspecialidadesAlta.AllowUserToDeleteRows = false;
            this.dgvEspecialidadesAlta.AllowUserToResizeColumns = false;
            this.dgvEspecialidadesAlta.AllowUserToResizeRows = false;
            this.dgvEspecialidadesAlta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEspecialidadesAlta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEspecialidadesAlta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEspecialidadesAlta.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEspecialidadesAlta.Location = new System.Drawing.Point(208, 114);
            this.dgvEspecialidadesAlta.MultiSelect = false;
            this.dgvEspecialidadesAlta.Name = "dgvEspecialidadesAlta";
            this.dgvEspecialidadesAlta.ReadOnly = true;
            this.dgvEspecialidadesAlta.RowHeadersVisible = false;
            this.dgvEspecialidadesAlta.Size = new System.Drawing.Size(231, 283);
            this.dgvEspecialidadesAlta.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de la especialidad";
            // 
            // tbEspecialidadAlta
            // 
            this.tbEspecialidadAlta.Location = new System.Drawing.Point(221, 31);
            this.tbEspecialidadAlta.Name = "tbEspecialidadAlta";
            this.tbEspecialidadAlta.Size = new System.Drawing.Size(201, 23);
            this.tbEspecialidadAlta.TabIndex = 1;
            // 
            // btnAltaEspecialidad
            // 
            this.btnAltaEspecialidad.Location = new System.Drawing.Point(280, 60);
            this.btnAltaEspecialidad.Name = "btnAltaEspecialidad";
            this.btnAltaEspecialidad.Size = new System.Drawing.Size(75, 23);
            this.btnAltaEspecialidad.TabIndex = 0;
            this.btnAltaEspecialidad.Text = "Cargar";
            this.btnAltaEspecialidad.UseVisualStyleBackColor = true;
            this.btnAltaEspecialidad.Click += new System.EventHandler(this.btnAltaEspecialidad_Click);
            // 
            // tpBaja
            // 
            this.tpBaja.Controls.Add(this.label3);
            this.tpBaja.Controls.Add(this.dgvEspecialidadesBaja);
            this.tpBaja.Controls.Add(this.btnBaja);
            this.tpBaja.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpBaja.Location = new System.Drawing.Point(4, 34);
            this.tpBaja.Name = "tpBaja";
            this.tpBaja.Padding = new System.Windows.Forms.Padding(3);
            this.tpBaja.Size = new System.Drawing.Size(636, 433);
            this.tpBaja.TabIndex = 1;
            this.tpBaja.Text = "Baja";
            this.tpBaja.UseVisualStyleBackColor = true;
            this.tpBaja.Click += new System.EventHandler(this.tpBaja_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lista de especialidades";
            // 
            // dgvEspecialidadesBaja
            // 
            this.dgvEspecialidadesBaja.AllowUserToAddRows = false;
            this.dgvEspecialidadesBaja.AllowUserToDeleteRows = false;
            this.dgvEspecialidadesBaja.AllowUserToOrderColumns = true;
            this.dgvEspecialidadesBaja.AllowUserToResizeColumns = false;
            this.dgvEspecialidadesBaja.AllowUserToResizeRows = false;
            this.dgvEspecialidadesBaja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEspecialidadesBaja.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEspecialidadesBaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEspecialidadesBaja.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEspecialidadesBaja.Location = new System.Drawing.Point(205, 54);
            this.dgvEspecialidadesBaja.MultiSelect = false;
            this.dgvEspecialidadesBaja.Name = "dgvEspecialidadesBaja";
            this.dgvEspecialidadesBaja.ReadOnly = true;
            this.dgvEspecialidadesBaja.RowHeadersVisible = false;
            this.dgvEspecialidadesBaja.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvEspecialidadesBaja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEspecialidadesBaja.Size = new System.Drawing.Size(231, 283);
            this.dgvEspecialidadesBaja.TabIndex = 1;
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(280, 355);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(75, 23);
            this.btnBaja.TabIndex = 0;
            this.btnBaja.Text = "Eliminar";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // tpMod
            // 
            this.tpMod.Controls.Add(this.btnGuardar);
            this.tpMod.Controls.Add(this.tbEspecialidaModi);
            this.tpMod.Controls.Add(this.label4);
            this.tpMod.Controls.Add(this.dgvEspecialidadesModificar);
            this.tpMod.Controls.Add(this.btnModificar);
            this.tpMod.Location = new System.Drawing.Point(4, 34);
            this.tpMod.Name = "tpMod";
            this.tpMod.Size = new System.Drawing.Size(636, 433);
            this.tpMod.TabIndex = 2;
            this.tpMod.Text = "Modificación";
            this.tpMod.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(284, 72);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tbEspecialidaModi
            // 
            this.tbEspecialidaModi.Location = new System.Drawing.Point(244, 43);
            this.tbEspecialidaModi.Name = "tbEspecialidaModi";
            this.tbEspecialidaModi.Size = new System.Drawing.Size(167, 23);
            this.tbEspecialidaModi.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Lista de especialidades";
            // 
            // dgvEspecialidadesModificar
            // 
            this.dgvEspecialidadesModificar.AllowUserToAddRows = false;
            this.dgvEspecialidadesModificar.AllowUserToDeleteRows = false;
            this.dgvEspecialidadesModificar.AllowUserToResizeColumns = false;
            this.dgvEspecialidadesModificar.AllowUserToResizeRows = false;
            this.dgvEspecialidadesModificar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEspecialidadesModificar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvEspecialidadesModificar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEspecialidadesModificar.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvEspecialidadesModificar.Location = new System.Drawing.Point(208, 104);
            this.dgvEspecialidadesModificar.MultiSelect = false;
            this.dgvEspecialidadesModificar.Name = "dgvEspecialidadesModificar";
            this.dgvEspecialidadesModificar.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEspecialidadesModificar.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvEspecialidadesModificar.RowHeadersVisible = false;
            this.dgvEspecialidadesModificar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvEspecialidadesModificar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEspecialidadesModificar.Size = new System.Drawing.Size(231, 283);
            this.dgvEspecialidadesModificar.TabIndex = 2;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(284, 393);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 0;
            this.btnModificar.Text = "Editar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // frmABMES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 471);
            this.Controls.Add(this.tcABM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmABMES";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmABMES_Load);
            this.tcABM.ResumeLayout(false);
            this.tpAlta.ResumeLayout(false);
            this.tpAlta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidadesAlta)).EndInit();
            this.tpBaja.ResumeLayout(false);
            this.tpBaja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidadesBaja)).EndInit();
            this.tpMod.ResumeLayout(false);
            this.tpMod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidadesModificar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcABM;
        private System.Windows.Forms.TabPage tpAlta;
        private System.Windows.Forms.Button btnAltaEspecialidad;
        private System.Windows.Forms.TabPage tpBaja;
        private System.Windows.Forms.DataGridView dgvEspecialidadesBaja;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.TabPage tpMod;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dgvEspecialidadesAlta;
        private System.Windows.Forms.Label label1;
        private controles.TextBoxLetras tbEspecialidadAlta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvEspecialidadesModificar;
        private System.Windows.Forms.Label label4;
        private controles.TextBoxLetras tbEspecialidaModi;
        private System.Windows.Forms.Button btnGuardar;
    }
}