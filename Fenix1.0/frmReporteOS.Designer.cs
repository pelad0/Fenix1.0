namespace Fenix1._0
{
    partial class frmReporteOS
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
            this.cbOS = new System.Windows.Forms.ComboBox();
            this.btnRep = new System.Windows.Forms.Button();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cbOS
            // 
            this.cbOS.FormattingEnabled = true;
            this.cbOS.Location = new System.Drawing.Point(250, 117);
            this.cbOS.Margin = new System.Windows.Forms.Padding(4);
            this.cbOS.Name = "cbOS";
            this.cbOS.Size = new System.Drawing.Size(317, 26);
            this.cbOS.TabIndex = 0;
            // 
            // btnRep
            // 
            this.btnRep.Location = new System.Drawing.Point(338, 350);
            this.btnRep.Margin = new System.Windows.Forms.Padding(4);
            this.btnRep.Name = "btnRep";
            this.btnRep.Size = new System.Drawing.Size(141, 87);
            this.btnRep.TabIndex = 1;
            this.btnRep.Text = "Generar Reporte";
            this.btnRep.UseVisualStyleBackColor = true;
            this.btnRep.Click += new System.EventHandler(this.btnRep_Click);
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(66, 282);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(331, 25);
            this.dtpDesde.TabIndex = 2;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(420, 282);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(331, 25);
            this.dtpHasta.TabIndex = 2;
            // 
            // frmReporteOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::frmABMME.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(816, 480);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.btnRep);
            this.Controls.Add(this.cbOS);
            this.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmReporteOS";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes Obras Sociales";
            this.Load += new System.EventHandler(this.frmReporteOS_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbOS;
        private System.Windows.Forms.Button btnRep;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
    }
}