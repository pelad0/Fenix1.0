namespace Fenix1._0
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.btnPacientes = new System.Windows.Forms.Button();
            this.btnMedicos = new System.Windows.Forms.Button();
            this.btnObraSocial = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnTurnos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblAccion = new System.Windows.Forms.Label();
            this.btnInformesOS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPacientes
            // 
            this.btnPacientes.BackColor = System.Drawing.Color.Transparent;
            this.btnPacientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPacientes.Font = new System.Drawing.Font("DejaVu Serif", 14.25F, System.Drawing.FontStyle.Italic);
            this.btnPacientes.Location = new System.Drawing.Point(92, 234);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(175, 37);
            this.btnPacientes.TabIndex = 4;
            this.btnPacientes.Tag = "4";
            this.btnPacientes.Text = "Pacientes";
            this.btnPacientes.UseVisualStyleBackColor = false;
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            this.btnPacientes.MouseEnter += new System.EventHandler(this.btnMedicos_MouseEnter);
            this.btnPacientes.MouseLeave += new System.EventHandler(this.btnMedicos_MouseLeave);
            // 
            // btnMedicos
            // 
            this.btnMedicos.BackColor = System.Drawing.Color.Transparent;
            this.btnMedicos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMedicos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMedicos.Font = new System.Drawing.Font("DejaVu Serif", 14.25F, System.Drawing.FontStyle.Italic);
            this.btnMedicos.Location = new System.Drawing.Point(92, 141);
            this.btnMedicos.Name = "btnMedicos";
            this.btnMedicos.Size = new System.Drawing.Size(175, 37);
            this.btnMedicos.TabIndex = 1;
            this.btnMedicos.Tag = "1";
            this.btnMedicos.Text = "Medicos";
            this.btnMedicos.UseVisualStyleBackColor = false;
            this.btnMedicos.Click += new System.EventHandler(this.btnMedicos_Click);
            this.btnMedicos.MouseEnter += new System.EventHandler(this.btnMedicos_MouseEnter);
            this.btnMedicos.MouseLeave += new System.EventHandler(this.btnMedicos_MouseLeave);
            // 
            // btnObraSocial
            // 
            this.btnObraSocial.BackColor = System.Drawing.Color.Transparent;
            this.btnObraSocial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnObraSocial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnObraSocial.Font = new System.Drawing.Font("DejaVu Serif", 14.25F, System.Drawing.FontStyle.Italic);
            this.btnObraSocial.Location = new System.Drawing.Point(307, 141);
            this.btnObraSocial.Name = "btnObraSocial";
            this.btnObraSocial.Size = new System.Drawing.Size(175, 37);
            this.btnObraSocial.TabIndex = 2;
            this.btnObraSocial.Tag = "2";
            this.btnObraSocial.Text = "Obras Sociales";
            this.btnObraSocial.UseVisualStyleBackColor = false;
            this.btnObraSocial.Click += new System.EventHandler(this.btnObraSocial_Click);
            this.btnObraSocial.MouseEnter += new System.EventHandler(this.btnMedicos_MouseEnter);
            this.btnObraSocial.MouseLeave += new System.EventHandler(this.btnMedicos_MouseLeave);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUsuarios.Font = new System.Drawing.Font("DejaVu Serif", 14.25F, System.Drawing.FontStyle.Italic);
            this.btnUsuarios.Location = new System.Drawing.Point(307, 234);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(175, 37);
            this.btnUsuarios.TabIndex = 5;
            this.btnUsuarios.Tag = "5";
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            this.btnUsuarios.MouseEnter += new System.EventHandler(this.btnMedicos_MouseEnter);
            this.btnUsuarios.MouseLeave += new System.EventHandler(this.btnMedicos_MouseLeave);
            // 
            // btnTurnos
            // 
            this.btnTurnos.BackColor = System.Drawing.Color.Transparent;
            this.btnTurnos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTurnos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTurnos.Font = new System.Drawing.Font("DejaVu Serif", 14.25F, System.Drawing.FontStyle.Italic);
            this.btnTurnos.Location = new System.Drawing.Point(522, 141);
            this.btnTurnos.Name = "btnTurnos";
            this.btnTurnos.Size = new System.Drawing.Size(175, 37);
            this.btnTurnos.TabIndex = 3;
            this.btnTurnos.Tag = "3";
            this.btnTurnos.Text = "Turnos";
            this.btnTurnos.UseVisualStyleBackColor = false;
            this.btnTurnos.Click += new System.EventHandler(this.btnTurnos_Click);
            this.btnTurnos.MouseEnter += new System.EventHandler(this.btnMedicos_MouseEnter);
            this.btnTurnos.MouseLeave += new System.EventHandler(this.btnMedicos_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("DejaVu Serif", 27.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 44);
            this.label1.TabIndex = 11;
            this.label1.Text = "Bienvenido";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreUsuario.Font = new System.Drawing.Font("DejaVu Serif", 27.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(412, 33);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(220, 44);
            this.lblNombreUsuario.TabIndex = 10;
            this.lblNombreUsuario.Text = "NombreU";
            // 
            // lblAccion
            // 
            this.lblAccion.AutoSize = true;
            this.lblAccion.BackColor = System.Drawing.Color.Transparent;
            this.lblAccion.Font = new System.Drawing.Font("DejaVu Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccion.Location = new System.Drawing.Point(81, 318);
            this.lblAccion.Name = "lblAccion";
            this.lblAccion.Size = new System.Drawing.Size(17, 22);
            this.lblAccion.TabIndex = 12;
            this.lblAccion.Text = " ";
            // 
            // btnInformesOS
            // 
            this.btnInformesOS.BackColor = System.Drawing.Color.Transparent;
            this.btnInformesOS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInformesOS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInformesOS.Font = new System.Drawing.Font("DejaVu Serif", 14.25F, System.Drawing.FontStyle.Italic);
            this.btnInformesOS.Location = new System.Drawing.Point(522, 234);
            this.btnInformesOS.Name = "btnInformesOS";
            this.btnInformesOS.Size = new System.Drawing.Size(175, 37);
            this.btnInformesOS.TabIndex = 5;
            this.btnInformesOS.Tag = "6";
            this.btnInformesOS.Text = "Informes OS";
            this.btnInformesOS.UseVisualStyleBackColor = false;
            this.btnInformesOS.Click += new System.EventHandler(this.btnInformesOS_Click);
            this.btnInformesOS.MouseEnter += new System.EventHandler(this.btnMedicos_MouseEnter);
            this.btnInformesOS.MouseLeave += new System.EventHandler(this.btnMedicos_MouseLeave);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(789, 413);
            this.Controls.Add(this.lblAccion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.btnTurnos);
            this.Controls.Add(this.btnInformesOS);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnMedicos);
            this.Controls.Add(this.btnObraSocial);
            this.Controls.Add(this.btnPacientes);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdmin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAdmin_FormClosed);
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPacientes;
        private System.Windows.Forms.Button btnMedicos;
        private System.Windows.Forms.Button btnObraSocial;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnTurnos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblAccion;
        private System.Windows.Forms.Button btnInformesOS;
    }
}