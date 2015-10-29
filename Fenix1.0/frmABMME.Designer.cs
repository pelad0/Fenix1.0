namespace Fenix1._0
{
    partial class frmABMME
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
            this.btnSiguientesAlta = new System.Windows.Forms.Button();
            this.btnAnteriorAlta = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvMedicosActuales = new System.Windows.Forms.DataGridView();
            this.clbEspecialidad = new System.Windows.Forms.CheckedListBox();
            this.clbObraSocial = new System.Windows.Forms.CheckedListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbDniAlta = new controles.TextBoxNumeros();
            this.tbMatriculaAlta = new controles.TextBoxNumeros();
            this.tbApellidoAlta = new controles.TextBoxLetras();
            this.tbNombreAlta = new controles.TextBoxLetras();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAlta = new System.Windows.Forms.Button();
            this.tpBaja = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvMedicosBaja = new System.Windows.Forms.DataGridView();
            this.btnBaja = new System.Windows.Forms.Button();
            this.tpMod = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvMedicosModi = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnSiguienteBaja = new System.Windows.Forms.Button();
            this.btnAnteriorBaja = new System.Windows.Forms.Button();
            this.btnSiguienteModi = new System.Windows.Forms.Button();
            this.btnAnteriorModi = new System.Windows.Forms.Button();
            this.tcABM.SuspendLayout();
            this.tpAlta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicosActuales)).BeginInit();
            this.tpBaja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicosBaja)).BeginInit();
            this.tpMod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicosModi)).BeginInit();
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
            this.tcABM.Size = new System.Drawing.Size(644, 606);
            this.tcABM.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcABM.TabIndex = 0;
            // 
            // tpAlta
            // 
            this.tpAlta.Controls.Add(this.btnSiguientesAlta);
            this.tpAlta.Controls.Add(this.btnAnteriorAlta);
            this.tpAlta.Controls.Add(this.label10);
            this.tpAlta.Controls.Add(this.dgvMedicosActuales);
            this.tpAlta.Controls.Add(this.clbEspecialidad);
            this.tpAlta.Controls.Add(this.clbObraSocial);
            this.tpAlta.Controls.Add(this.label9);
            this.tpAlta.Controls.Add(this.label8);
            this.tpAlta.Controls.Add(this.tbDniAlta);
            this.tpAlta.Controls.Add(this.tbMatriculaAlta);
            this.tpAlta.Controls.Add(this.tbApellidoAlta);
            this.tpAlta.Controls.Add(this.tbNombreAlta);
            this.tpAlta.Controls.Add(this.label5);
            this.tpAlta.Controls.Add(this.label4);
            this.tpAlta.Controls.Add(this.label3);
            this.tpAlta.Controls.Add(this.label2);
            this.tpAlta.Controls.Add(this.label1);
            this.tpAlta.Controls.Add(this.btnAlta);
            this.tpAlta.Location = new System.Drawing.Point(4, 34);
            this.tpAlta.Name = "tpAlta";
            this.tpAlta.Padding = new System.Windows.Forms.Padding(3);
            this.tpAlta.Size = new System.Drawing.Size(636, 568);
            this.tpAlta.TabIndex = 0;
            this.tpAlta.Text = "Alta";
            this.tpAlta.UseVisualStyleBackColor = true;
            // 
            // btnSiguientesAlta
            // 
            this.btnSiguientesAlta.Location = new System.Drawing.Point(358, 540);
            this.btnSiguientesAlta.Name = "btnSiguientesAlta";
            this.btnSiguientesAlta.Size = new System.Drawing.Size(111, 23);
            this.btnSiguientesAlta.TabIndex = 13;
            this.btnSiguientesAlta.Text = "Siguiente ->";
            this.btnSiguientesAlta.UseVisualStyleBackColor = true;
            // 
            // btnAnteriorAlta
            // 
            this.btnAnteriorAlta.Location = new System.Drawing.Point(165, 539);
            this.btnAnteriorAlta.Name = "btnAnteriorAlta";
            this.btnAnteriorAlta.Size = new System.Drawing.Size(106, 23);
            this.btnAnteriorAlta.TabIndex = 12;
            this.btnAnteriorAlta.Text = "<- Anterior";
            this.btnAnteriorAlta.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(257, 320);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "Médicos actuales";
            // 
            // dgvMedicosActuales
            // 
            this.dgvMedicosActuales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicosActuales.Location = new System.Drawing.Point(6, 338);
            this.dgvMedicosActuales.Name = "dgvMedicosActuales";
            this.dgvMedicosActuales.Size = new System.Drawing.Size(622, 196);
            this.dgvMedicosActuales.TabIndex = 10;
            // 
            // clbEspecialidad
            // 
            this.clbEspecialidad.FormattingEnabled = true;
            this.clbEspecialidad.Location = new System.Drawing.Point(128, 166);
            this.clbEspecialidad.Name = "clbEspecialidad";
            this.clbEspecialidad.Size = new System.Drawing.Size(154, 94);
            this.clbEspecialidad.TabIndex = 9;
            // 
            // clbObraSocial
            // 
            this.clbObraSocial.FormattingEnabled = true;
            this.clbObraSocial.Location = new System.Drawing.Point(424, 169);
            this.clbObraSocial.Name = "clbObraSocial";
            this.clbObraSocial.Size = new System.Drawing.Size(154, 94);
            this.clbObraSocial.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(313, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 15);
            this.label9.TabIndex = 7;
            this.label9.Text = "Obras Sociales";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(215, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Ingrese los datos del médico\r\n";
            // 
            // tbDniAlta
            // 
            this.tbDniAlta.Location = new System.Drawing.Point(128, 112);
            this.tbDniAlta.Name = "tbDniAlta";
            this.tbDniAlta.Size = new System.Drawing.Size(154, 23);
            this.tbDniAlta.TabIndex = 3;
            // 
            // tbMatriculaAlta
            // 
            this.tbMatriculaAlta.Location = new System.Drawing.Point(424, 107);
            this.tbMatriculaAlta.Name = "tbMatriculaAlta";
            this.tbMatriculaAlta.Size = new System.Drawing.Size(154, 23);
            this.tbMatriculaAlta.TabIndex = 4;
            // 
            // tbApellidoAlta
            // 
            this.tbApellidoAlta.Location = new System.Drawing.Point(424, 51);
            this.tbApellidoAlta.Name = "tbApellidoAlta";
            this.tbApellidoAlta.Size = new System.Drawing.Size(154, 23);
            this.tbApellidoAlta.TabIndex = 2;
            // 
            // tbNombreAlta
            // 
            this.tbNombreAlta.Location = new System.Drawing.Point(128, 51);
            this.tbNombreAlta.Name = "tbNombreAlta";
            this.tbNombreAlta.Size = new System.Drawing.Size(154, 23);
            this.tbNombreAlta.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Especialidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Matricula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(266, 280);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(98, 23);
            this.btnAlta.TabIndex = 0;
            this.btnAlta.Text = "Cargar";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // tpBaja
            // 
            this.tpBaja.Controls.Add(this.btnSiguienteBaja);
            this.tpBaja.Controls.Add(this.btnAnteriorBaja);
            this.tpBaja.Controls.Add(this.label6);
            this.tpBaja.Controls.Add(this.dgvMedicosBaja);
            this.tpBaja.Controls.Add(this.btnBaja);
            this.tpBaja.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpBaja.Location = new System.Drawing.Point(4, 34);
            this.tpBaja.Name = "tpBaja";
            this.tpBaja.Padding = new System.Windows.Forms.Padding(3);
            this.tpBaja.Size = new System.Drawing.Size(636, 568);
            this.tpBaja.TabIndex = 1;
            this.tpBaja.Text = "Baja";
            this.tpBaja.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(162, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(301, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Seleccione el médico que desea dar de baja";
            // 
            // dgvMedicosBaja
            // 
            this.dgvMedicosBaja.AllowUserToAddRows = false;
            this.dgvMedicosBaja.AllowUserToDeleteRows = false;
            this.dgvMedicosBaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicosBaja.Location = new System.Drawing.Point(3, 69);
            this.dgvMedicosBaja.Name = "dgvMedicosBaja";
            this.dgvMedicosBaja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicosBaja.Size = new System.Drawing.Size(630, 317);
            this.dgvMedicosBaja.TabIndex = 1;
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(284, 405);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(75, 23);
            this.btnBaja.TabIndex = 0;
            this.btnBaja.Text = "Eliminar";
            this.btnBaja.UseVisualStyleBackColor = true;
            // 
            // tpMod
            // 
            this.tpMod.Controls.Add(this.btnSiguienteModi);
            this.tpMod.Controls.Add(this.btnAnteriorModi);
            this.tpMod.Controls.Add(this.label7);
            this.tpMod.Controls.Add(this.dgvMedicosModi);
            this.tpMod.Controls.Add(this.btnModificar);
            this.tpMod.Location = new System.Drawing.Point(4, 34);
            this.tpMod.Name = "tpMod";
            this.tpMod.Size = new System.Drawing.Size(636, 568);
            this.tpMod.TabIndex = 2;
            this.tpMod.Text = "Modificación";
            this.tpMod.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(173, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(287, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Seleccione el médico que desea modificar";
            // 
            // dgvMedicosModi
            // 
            this.dgvMedicosModi.AllowUserToAddRows = false;
            this.dgvMedicosModi.AllowUserToDeleteRows = false;
            this.dgvMedicosModi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicosModi.Location = new System.Drawing.Point(3, 69);
            this.dgvMedicosModi.Name = "dgvMedicosModi";
            this.dgvMedicosModi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicosModi.Size = new System.Drawing.Size(630, 317);
            this.dgvMedicosModi.TabIndex = 2;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(273, 408);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 0;
            this.btnModificar.Text = "Editar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnSiguienteBaja
            // 
            this.btnSiguienteBaja.Location = new System.Drawing.Point(439, 405);
            this.btnSiguienteBaja.Name = "btnSiguienteBaja";
            this.btnSiguienteBaja.Size = new System.Drawing.Size(111, 23);
            this.btnSiguienteBaja.TabIndex = 15;
            this.btnSiguienteBaja.Text = "Siguiente ->";
            this.btnSiguienteBaja.UseVisualStyleBackColor = true;
            // 
            // btnAnteriorBaja
            // 
            this.btnAnteriorBaja.Location = new System.Drawing.Point(89, 405);
            this.btnAnteriorBaja.Name = "btnAnteriorBaja";
            this.btnAnteriorBaja.Size = new System.Drawing.Size(106, 23);
            this.btnAnteriorBaja.TabIndex = 14;
            this.btnAnteriorBaja.Text = "<- Anterior";
            this.btnAnteriorBaja.UseVisualStyleBackColor = true;
            // 
            // btnSiguienteModi
            // 
            this.btnSiguienteModi.Location = new System.Drawing.Point(436, 408);
            this.btnSiguienteModi.Name = "btnSiguienteModi";
            this.btnSiguienteModi.Size = new System.Drawing.Size(111, 23);
            this.btnSiguienteModi.TabIndex = 17;
            this.btnSiguienteModi.Text = "Siguiente ->";
            this.btnSiguienteModi.UseVisualStyleBackColor = true;
            // 
            // btnAnteriorModi
            // 
            this.btnAnteriorModi.Location = new System.Drawing.Point(86, 408);
            this.btnAnteriorModi.Name = "btnAnteriorModi";
            this.btnAnteriorModi.Size = new System.Drawing.Size(106, 23);
            this.btnAnteriorModi.TabIndex = 16;
            this.btnAnteriorModi.Text = "<- Anterior";
            this.btnAnteriorModi.UseVisualStyleBackColor = true;
            // 
            // frmABMME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 606);
            this.Controls.Add(this.tcABM);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmABMME";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tcABM.ResumeLayout(false);
            this.tpAlta.ResumeLayout(false);
            this.tpAlta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicosActuales)).EndInit();
            this.tpBaja.ResumeLayout(false);
            this.tpBaja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicosBaja)).EndInit();
            this.tpMod.ResumeLayout(false);
            this.tpMod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicosModi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcABM;
        private System.Windows.Forms.TabPage tpAlta;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.TabPage tpBaja;
        private System.Windows.Forms.DataGridView dgvMedicosBaja;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.TabPage tpMod;
        private System.Windows.Forms.Button btnModificar;
        private controles.TextBoxNumeros tbDniAlta;
        private controles.TextBoxNumeros tbMatriculaAlta;
        private controles.TextBoxLetras tbApellidoAlta;
        private controles.TextBoxLetras tbNombreAlta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvMedicosModi;
        private System.Windows.Forms.CheckedListBox clbEspecialidad;
        private System.Windows.Forms.CheckedListBox clbObraSocial;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSiguientesAlta;
        private System.Windows.Forms.Button btnAnteriorAlta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvMedicosActuales;
        private System.Windows.Forms.Button btnSiguienteBaja;
        private System.Windows.Forms.Button btnAnteriorBaja;
        private System.Windows.Forms.Button btnSiguienteModi;
        private System.Windows.Forms.Button btnAnteriorModi;
    }
}