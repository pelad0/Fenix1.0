﻿namespace Fenix1._0
{
    partial class frmRecepcion
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
            this.btnMedicos = new System.Windows.Forms.Button();
            this.btnObraSocial = new System.Windows.Forms.Button();
            this.btnPacientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMedicos
            // 
            this.btnMedicos.Location = new System.Drawing.Point(188, 22);
            this.btnMedicos.Name = "btnMedicos";
            this.btnMedicos.Size = new System.Drawing.Size(168, 27);
            this.btnMedicos.TabIndex = 1;
            this.btnMedicos.Text = "Medicos";
            this.btnMedicos.UseVisualStyleBackColor = true;
            this.btnMedicos.Click += new System.EventHandler(this.btnMedicos_Click);
            // 
            // btnObraSocial
            // 
            this.btnObraSocial.Location = new System.Drawing.Point(356, 22);
            this.btnObraSocial.Name = "btnObraSocial";
            this.btnObraSocial.Size = new System.Drawing.Size(168, 27);
            this.btnObraSocial.TabIndex = 2;
            this.btnObraSocial.Text = "Obras Sociales";
            this.btnObraSocial.UseVisualStyleBackColor = true;
            this.btnObraSocial.Click += new System.EventHandler(this.btnObraSocial_Click);
            // 
            // btnPacientes
            // 
            this.btnPacientes.Location = new System.Drawing.Point(20, 22);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(168, 27);
            this.btnPacientes.TabIndex = 3;
            this.btnPacientes.Text = "Pacientes";
            this.btnPacientes.UseVisualStyleBackColor = true;
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // frmRecepcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 70);
            this.Controls.Add(this.btnMedicos);
            this.Controls.Add(this.btnObraSocial);
            this.Controls.Add(this.btnPacientes);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRecepcion";
            this.ShowIcon = false;
            this.Text = "Recepcion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmRecepcion_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMedicos;
        private System.Windows.Forms.Button btnObraSocial;
        private System.Windows.Forms.Button btnPacientes;
    }
}