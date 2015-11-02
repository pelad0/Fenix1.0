namespace Fenix1._0
{
    partial class frmEditarMedico
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
            this.clbObraSocial = new System.Windows.Forms.CheckedListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbDniModi = new controles.TextBoxNumeros();
            this.tbMatriculaModi = new controles.TextBoxNumeros();
            this.tbApellidoModi = new controles.TextBoxLetras();
            this.tbNombreModi = new controles.TextBoxLetras();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditarHorarios = new System.Windows.Forms.Button();
            this.tbEspecialidadModi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // clbObraSocial
            // 
            this.clbObraSocial.FormattingEnabled = true;
            this.clbObraSocial.Location = new System.Drawing.Point(416, 222);
            this.clbObraSocial.Name = "clbObraSocial";
            this.clbObraSocial.Size = new System.Drawing.Size(159, 94);
            this.clbObraSocial.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(305, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Obras Sociales";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(197, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(261, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "Ingrese los datos del médico\r\n";
            // 
            // tbDniModi
            // 
            this.tbDniModi.Location = new System.Drawing.Point(113, 160);
            this.tbDniModi.Name = "tbDniModi";
            this.tbDniModi.Size = new System.Drawing.Size(163, 23);
            this.tbDniModi.TabIndex = 14;
            // 
            // tbMatriculaModi
            // 
            this.tbMatriculaModi.Location = new System.Drawing.Point(416, 160);
            this.tbMatriculaModi.Name = "tbMatriculaModi";
            this.tbMatriculaModi.Size = new System.Drawing.Size(159, 23);
            this.tbMatriculaModi.TabIndex = 16;
            // 
            // tbApellidoModi
            // 
            this.tbApellidoModi.Location = new System.Drawing.Point(416, 86);
            this.tbApellidoModi.Name = "tbApellidoModi";
            this.tbApellidoModi.Size = new System.Drawing.Size(159, 23);
            this.tbApellidoModi.TabIndex = 12;
            // 
            // tbNombreModi
            // 
            this.tbNombreModi.Location = new System.Drawing.Point(113, 89);
            this.tbNombreModi.Name = "tbNombreModi";
            this.tbNombreModi.Size = new System.Drawing.Size(163, 23);
            this.tbNombreModi.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Especialidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Matricula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(282, 417);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEditarHorarios
            // 
            this.btnEditarHorarios.Location = new System.Drawing.Point(255, 337);
            this.btnEditarHorarios.Name = "btnEditarHorarios";
            this.btnEditarHorarios.Size = new System.Drawing.Size(127, 29);
            this.btnEditarHorarios.TabIndex = 24;
            this.btnEditarHorarios.Text = "EditarHorarios";
            this.btnEditarHorarios.UseVisualStyleBackColor = true;
            this.btnEditarHorarios.Click += new System.EventHandler(this.btnEditarHorarios_Click);
            // 
            // tbEspecialidadModi
            // 
            this.tbEspecialidadModi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEspecialidadModi.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic);
            this.tbEspecialidadModi.Location = new System.Drawing.Point(113, 258);
            this.tbEspecialidadModi.Name = "tbEspecialidadModi";
            this.tbEspecialidadModi.ReadOnly = true;
            this.tbEspecialidadModi.Size = new System.Drawing.Size(151, 19);
            this.tbEspecialidadModi.TabIndex = 25;
            this.tbEspecialidadModi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmEditarMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(644, 452);
            this.Controls.Add(this.tbEspecialidadModi);
            this.Controls.Add(this.btnEditarHorarios);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.clbObraSocial);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbDniModi);
            this.Controls.Add(this.tbMatriculaModi);
            this.Controls.Add(this.tbApellidoModi);
            this.Controls.Add(this.tbNombreModi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.Name = "frmEditarMedico";
            this.Text = "frmEditarMedico";
            this.Load += new System.EventHandler(this.frmEditarMedico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbObraSocial;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private controles.TextBoxNumeros tbDniModi;
        private controles.TextBoxNumeros tbMatriculaModi;
        private controles.TextBoxLetras tbApellidoModi;
        private controles.TextBoxLetras tbNombreModi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditarHorarios;
        private System.Windows.Forms.TextBox tbEspecialidadModi;
    }
}