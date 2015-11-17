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
            this.crvForm = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvForm
            // 
            this.crvForm.ActiveViewIndex = -1;
            this.crvForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvForm.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvForm.Location = new System.Drawing.Point(0, 0);
            this.crvForm.Name = "crvForm";
            this.crvForm.ShowGotoPageButton = false;
            this.crvForm.ShowGroupTreeButton = false;
            this.crvForm.ShowLogo = false;
            this.crvForm.ShowParameterPanelButton = false;
            this.crvForm.ShowRefreshButton = false;
            this.crvForm.ShowTextSearchButton = false;
            this.crvForm.Size = new System.Drawing.Size(644, 485);
            this.crvForm.TabIndex = 0;
            // 
            // frmReporteTurnosMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::frmABMME.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(644, 485);
            this.Controls.Add(this.crvForm);
            this.Name = "frmReporteTurnosMedico";
            this.ShowIcon = false;
            this.Text = "Informe por Medico";
            this.Load += new System.EventHandler(this.frmReporteTurnosMedico_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvForm;

    }
}