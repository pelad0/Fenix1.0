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
            this.tcABM = new System.Windows.Forms.TabControl();
            this.tpAlta = new System.Windows.Forms.TabPage();
            this.btnSiguienteAlta = new System.Windows.Forms.Button();
            this.btnAnteriorAlta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvEspecialidadesAlta = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombreEsp = new controles.TextBoxLetras();
            this.btnAltaEspecialidad = new System.Windows.Forms.Button();
            this.tpBaja = new System.Windows.Forms.TabPage();
            this.btnSiguienteBaja = new System.Windows.Forms.Button();
            this.btnAnteriorBaja = new System.Windows.Forms.Button();
            this.dgvEliminar = new System.Windows.Forms.DataGridView();
            this.btnBaja = new System.Windows.Forms.Button();
            this.tpMod = new System.Windows.Forms.TabPage();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvModificar = new System.Windows.Forms.DataGridView();
            this.btnSiguienteModi = new System.Windows.Forms.Button();
            this.btnAnteriorModi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tcABM.SuspendLayout();
            this.tpAlta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidadesAlta)).BeginInit();
            this.tpBaja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminar)).BeginInit();
            this.tpMod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificar)).BeginInit();
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
            // 
            // tpAlta
            // 
            this.tpAlta.Controls.Add(this.btnSiguienteAlta);
            this.tpAlta.Controls.Add(this.btnAnteriorAlta);
            this.tpAlta.Controls.Add(this.label2);
            this.tpAlta.Controls.Add(this.dgvEspecialidadesAlta);
            this.tpAlta.Controls.Add(this.label1);
            this.tpAlta.Controls.Add(this.tbNombreEsp);
            this.tpAlta.Controls.Add(this.btnAltaEspecialidad);
            this.tpAlta.Location = new System.Drawing.Point(4, 34);
            this.tpAlta.Name = "tpAlta";
            this.tpAlta.Padding = new System.Windows.Forms.Padding(3);
            this.tpAlta.Size = new System.Drawing.Size(636, 433);
            this.tpAlta.TabIndex = 0;
            this.tpAlta.Text = "Alta";
            this.tpAlta.UseVisualStyleBackColor = true;
            // 
            // btnSiguienteAlta
            // 
            this.btnSiguienteAlta.Location = new System.Drawing.Point(499, 335);
            this.btnSiguienteAlta.Name = "btnSiguienteAlta";
            this.btnSiguienteAlta.Size = new System.Drawing.Size(71, 23);
            this.btnSiguienteAlta.TabIndex = 9;
            this.btnSiguienteAlta.Text = "Sig-->";
            this.btnSiguienteAlta.UseVisualStyleBackColor = true;
            // 
            // btnAnteriorAlta
            // 
            this.btnAnteriorAlta.Location = new System.Drawing.Point(403, 335);
            this.btnAnteriorAlta.Name = "btnAnteriorAlta";
            this.btnAnteriorAlta.Size = new System.Drawing.Size(71, 23);
            this.btnAnteriorAlta.TabIndex = 8;
            this.btnAnteriorAlta.Text = "<--Ant";
            this.btnAnteriorAlta.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lista de especialidades";
            // 
            // dgvEspecialidadesAlta
            // 
            this.dgvEspecialidadesAlta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEspecialidadesAlta.Location = new System.Drawing.Point(403, 46);
            this.dgvEspecialidadesAlta.Name = "dgvEspecialidadesAlta";
            this.dgvEspecialidadesAlta.Size = new System.Drawing.Size(167, 283);
            this.dgvEspecialidadesAlta.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de la especialidad";
            // 
            // tbNombreEsp
            // 
            this.tbNombreEsp.Location = new System.Drawing.Point(116, 162);
            this.tbNombreEsp.Name = "tbNombreEsp";
            this.tbNombreEsp.Size = new System.Drawing.Size(201, 23);
            this.tbNombreEsp.TabIndex = 1;
            // 
            // btnAltaEspecialidad
            // 
            this.btnAltaEspecialidad.Location = new System.Drawing.Point(168, 212);
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
            this.tpBaja.Controls.Add(this.btnSiguienteBaja);
            this.tpBaja.Controls.Add(this.btnAnteriorBaja);
            this.tpBaja.Controls.Add(this.dgvEliminar);
            this.tpBaja.Controls.Add(this.btnBaja);
            this.tpBaja.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpBaja.Location = new System.Drawing.Point(4, 34);
            this.tpBaja.Name = "tpBaja";
            this.tpBaja.Padding = new System.Windows.Forms.Padding(3);
            this.tpBaja.Size = new System.Drawing.Size(636, 433);
            this.tpBaja.TabIndex = 1;
            this.tpBaja.Text = "Baja";
            this.tpBaja.UseVisualStyleBackColor = true;
            // 
            // btnSiguienteBaja
            // 
            this.btnSiguienteBaja.Location = new System.Drawing.Point(376, 355);
            this.btnSiguienteBaja.Name = "btnSiguienteBaja";
            this.btnSiguienteBaja.Size = new System.Drawing.Size(68, 23);
            this.btnSiguienteBaja.TabIndex = 6;
            this.btnSiguienteBaja.Text = "Sig -->";
            this.btnSiguienteBaja.UseVisualStyleBackColor = true;
            // 
            // btnAnteriorBaja
            // 
            this.btnAnteriorBaja.Location = new System.Drawing.Point(206, 355);
            this.btnAnteriorBaja.Name = "btnAnteriorBaja";
            this.btnAnteriorBaja.Size = new System.Drawing.Size(65, 23);
            this.btnAnteriorBaja.TabIndex = 5;
            this.btnAnteriorBaja.Text = "<-- Ant";
            this.btnAnteriorBaja.UseVisualStyleBackColor = true;
            // 
            // dgvEliminar
            // 
            this.dgvEliminar.AllowUserToAddRows = false;
            this.dgvEliminar.AllowUserToDeleteRows = false;
            this.dgvEliminar.AllowUserToOrderColumns = true;
            this.dgvEliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEliminar.Location = new System.Drawing.Point(238, 54);
            this.dgvEliminar.MultiSelect = false;
            this.dgvEliminar.Name = "dgvEliminar";
            this.dgvEliminar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvEliminar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEliminar.Size = new System.Drawing.Size(167, 283);
            this.dgvEliminar.TabIndex = 1;
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(286, 355);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(75, 23);
            this.btnBaja.TabIndex = 0;
            this.btnBaja.Text = "Eliminar";
            this.btnBaja.UseVisualStyleBackColor = true;
            // 
            // tpMod
            // 
            this.tpMod.Controls.Add(this.label4);
            this.tpMod.Controls.Add(this.btnSiguienteModi);
            this.tpMod.Controls.Add(this.btnAnteriorModi);
            this.tpMod.Controls.Add(this.dgvModificar);
            this.tpMod.Controls.Add(this.btnModificar);
            this.tpMod.Location = new System.Drawing.Point(4, 34);
            this.tpMod.Name = "tpMod";
            this.tpMod.Size = new System.Drawing.Size(636, 433);
            this.tpMod.TabIndex = 2;
            this.tpMod.Text = "Modificación";
            this.tpMod.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(289, 341);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 0;
            this.btnModificar.Text = "Editar";
            this.btnModificar.UseVisualStyleBackColor = true;
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
            // dgvModificar
            // 
            this.dgvModificar.AllowUserToAddRows = false;
            this.dgvModificar.AllowUserToDeleteRows = false;
            this.dgvModificar.AllowUserToOrderColumns = true;
            this.dgvModificar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModificar.Location = new System.Drawing.Point(242, 52);
            this.dgvModificar.MultiSelect = false;
            this.dgvModificar.Name = "dgvModificar";
            this.dgvModificar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvModificar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModificar.Size = new System.Drawing.Size(167, 283);
            this.dgvModificar.TabIndex = 2;
            // 
            // btnSiguienteModi
            // 
            this.btnSiguienteModi.Location = new System.Drawing.Point(381, 341);
            this.btnSiguienteModi.Name = "btnSiguienteModi";
            this.btnSiguienteModi.Size = new System.Drawing.Size(68, 23);
            this.btnSiguienteModi.TabIndex = 8;
            this.btnSiguienteModi.Text = "Sig -->";
            this.btnSiguienteModi.UseVisualStyleBackColor = true;
            // 
            // btnAnteriorModi
            // 
            this.btnAnteriorModi.Location = new System.Drawing.Point(211, 341);
            this.btnAnteriorModi.Name = "btnAnteriorModi";
            this.btnAnteriorModi.Size = new System.Drawing.Size(65, 23);
            this.btnAnteriorModi.TabIndex = 7;
            this.btnAnteriorModi.Text = "<-- Ant";
            this.btnAnteriorModi.UseVisualStyleBackColor = true;
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
            // frmABMES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 471);
            this.Controls.Add(this.tcABM);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmABMES";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tcABM.ResumeLayout(false);
            this.tpAlta.ResumeLayout(false);
            this.tpAlta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidadesAlta)).EndInit();
            this.tpBaja.ResumeLayout(false);
            this.tpBaja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminar)).EndInit();
            this.tpMod.ResumeLayout(false);
            this.tpMod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcABM;
        private System.Windows.Forms.TabPage tpAlta;
        private System.Windows.Forms.Button btnAltaEspecialidad;
        private System.Windows.Forms.TabPage tpBaja;
        private System.Windows.Forms.DataGridView dgvEliminar;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.TabPage tpMod;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnSiguienteBaja;
        private System.Windows.Forms.Button btnAnteriorBaja;
        private System.Windows.Forms.DataGridView dgvEspecialidadesAlta;
        private System.Windows.Forms.Label label1;
        private controles.TextBoxLetras tbNombreEsp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSiguienteAlta;
        private System.Windows.Forms.Button btnAnteriorAlta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvModificar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSiguienteModi;
        private System.Windows.Forms.Button btnAnteriorModi;
    }
}