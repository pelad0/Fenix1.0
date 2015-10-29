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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clbEspecialidad
            // 
            this.clbEspecialidad.FormattingEnabled = true;
            this.clbEspecialidad.Location = new System.Drawing.Point(113, 222);
            this.clbEspecialidad.Name = "clbEspecialidad";
            this.clbEspecialidad.Size = new System.Drawing.Size(163, 94);
            this.clbEspecialidad.TabIndex = 22;
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
            this.label9.Location = new System.Drawing.Point(294, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Obras Sociales";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(215, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Ingrese los datos del médico\r\n";
            // 
            // tbDniAlta
            // 
            this.tbDniAlta.Location = new System.Drawing.Point(113, 160);
            this.tbDniAlta.Name = "tbDniAlta";
            this.tbDniAlta.Size = new System.Drawing.Size(163, 23);
            this.tbDniAlta.TabIndex = 14;
            // 
            // tbMatriculaAlta
            // 
            this.tbMatriculaAlta.Location = new System.Drawing.Point(416, 160);
            this.tbMatriculaAlta.Name = "tbMatriculaAlta";
            this.tbMatriculaAlta.Size = new System.Drawing.Size(159, 23);
            this.tbMatriculaAlta.TabIndex = 16;
            // 
            // tbApellidoAlta
            // 
            this.tbApellidoAlta.Location = new System.Drawing.Point(416, 86);
            this.tbApellidoAlta.Name = "tbApellidoAlta";
            this.tbApellidoAlta.Size = new System.Drawing.Size(159, 23);
            this.tbApellidoAlta.TabIndex = 12;
            // 
            // tbNombreAlta
            // 
            this.tbNombreAlta.Location = new System.Drawing.Point(113, 89);
            this.tbNombreAlta.Name = "tbNombreAlta";
            this.tbNombreAlta.Size = new System.Drawing.Size(163, 23);
            this.tbNombreAlta.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Especialidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Matricula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(302, 408);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // frmEditarMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 494);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.clbEspecialidad);
            this.Controls.Add(this.clbObraSocial);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbDniAlta);
            this.Controls.Add(this.tbMatriculaAlta);
            this.Controls.Add(this.tbApellidoAlta);
            this.Controls.Add(this.tbNombreAlta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.Name = "frmEditarMedico";
            this.Text = "frmEditarMedico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbEspecialidad;
        private System.Windows.Forms.CheckedListBox clbObraSocial;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private controles.TextBoxNumeros tbDniAlta;
        private controles.TextBoxNumeros tbMatriculaAlta;
        private controles.TextBoxLetras tbApellidoAlta;
        private controles.TextBoxLetras tbNombreAlta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
    }
}