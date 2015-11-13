namespace Fenix1._0
{
    partial class frmReporteTurnosMedico
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
            this.crReporteMedico = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crTurnoMedico1 = new frmABMME.crTurnoMedico();
            this.SuspendLayout();
            // 
            // crReporteMedico
            // 
            this.crReporteMedico.ActiveViewIndex = -1;
            this.crReporteMedico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crReporteMedico.Cursor = System.Windows.Forms.Cursors.Default;
            this.crReporteMedico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crReporteMedico.Location = new System.Drawing.Point(0, 0);
            this.crReporteMedico.Name = "crReporteMedico";
            this.crReporteMedico.Size = new System.Drawing.Size(644, 485);
            this.crReporteMedico.TabIndex = 0;
            // 
            // frmReporteTurnosMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 485);
            this.Controls.Add(this.crReporteMedico);
            this.Name = "frmReporteTurnosMedico";
            this.ShowIcon = false;
            this.Text = "Informe por Medico";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crReporteMedico;
        private crTurnoMedico crTurnoMedico1;
    }
}