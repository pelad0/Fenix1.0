﻿namespace Fenix1._0
{
    partial class frmABMOS
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbOS = new controles.TextBoxLetras();
            this.btnAlta = new System.Windows.Forms.Button();
            this.tpBaja = new System.Windows.Forms.TabPage();
            this.dgvOSBaja = new System.Windows.Forms.DataGridView();
            this.btnBaja = new System.Windows.Forms.Button();
            this.tpMod = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tbModifOS = new controles.TextBoxLetras();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dgvOSAlta = new System.Windows.Forms.DataGridView();
            this.dgvOSModif = new System.Windows.Forms.DataGridView();
            this.tcABM.SuspendLayout();
            this.tpAlta.SuspendLayout();
            this.tpBaja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOSBaja)).BeginInit();
            this.tpMod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOSAlta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOSModif)).BeginInit();
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
            this.tcABM.Size = new System.Drawing.Size(644, 485);
            this.tcABM.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcABM.TabIndex = 0;
            // 
            // tpAlta
            // 
            this.tpAlta.Controls.Add(this.dgvOSAlta);
            this.tpAlta.Controls.Add(this.label1);
            this.tpAlta.Controls.Add(this.tbOS);
            this.tpAlta.Controls.Add(this.btnAlta);
            this.tpAlta.Location = new System.Drawing.Point(4, 34);
            this.tpAlta.Name = "tpAlta";
            this.tpAlta.Padding = new System.Windows.Forms.Padding(3);
            this.tpAlta.Size = new System.Drawing.Size(636, 447);
            this.tpAlta.TabIndex = 0;
            this.tpAlta.Text = "Alta";
            this.tpAlta.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Obra Social";
            // 
            // tbOS
            // 
            this.tbOS.Location = new System.Drawing.Point(220, 41);
            this.tbOS.MaxLength = 40;
            this.tbOS.Name = "tbOS";
            this.tbOS.Size = new System.Drawing.Size(197, 23);
            this.tbOS.TabIndex = 1;
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(281, 400);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(75, 23);
            this.btnAlta.TabIndex = 0;
            this.btnAlta.Text = "Cargar";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // tpBaja
            // 
            this.tpBaja.Controls.Add(this.dgvOSBaja);
            this.tpBaja.Controls.Add(this.btnBaja);
            this.tpBaja.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpBaja.Location = new System.Drawing.Point(4, 34);
            this.tpBaja.Name = "tpBaja";
            this.tpBaja.Padding = new System.Windows.Forms.Padding(3);
            this.tpBaja.Size = new System.Drawing.Size(636, 447);
            this.tpBaja.TabIndex = 1;
            this.tpBaja.Text = "Baja";
            this.tpBaja.UseVisualStyleBackColor = true;
            // 
            // dgvOSBaja
            // 
            this.dgvOSBaja.AllowUserToAddRows = false;
            this.dgvOSBaja.AllowUserToDeleteRows = false;
            this.dgvOSBaja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvOSBaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOSBaja.Location = new System.Drawing.Point(198, 72);
            this.dgvOSBaja.MultiSelect = false;
            this.dgvOSBaja.Name = "dgvOSBaja";
            this.dgvOSBaja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOSBaja.Size = new System.Drawing.Size(240, 320);
            this.dgvOSBaja.TabIndex = 1;
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(279, 400);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(75, 23);
            this.btnBaja.TabIndex = 0;
            this.btnBaja.Text = "Eliminar";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // tpMod
            // 
            this.tpMod.Controls.Add(this.dgvOSModif);
            this.tpMod.Controls.Add(this.label2);
            this.tpMod.Controls.Add(this.tbModifOS);
            this.tpMod.Controls.Add(this.btnModificar);
            this.tpMod.Location = new System.Drawing.Point(4, 34);
            this.tpMod.Name = "tpMod";
            this.tpMod.Size = new System.Drawing.Size(636, 447);
            this.tpMod.TabIndex = 2;
            this.tpMod.Text = "Modificación";
            this.tpMod.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Obra Social";
            // 
            // tbModifOS
            // 
            this.tbModifOS.Location = new System.Drawing.Point(220, 43);
            this.tbModifOS.MaxLength = 40;
            this.tbModifOS.Name = "tbModifOS";
            this.tbModifOS.Size = new System.Drawing.Size(197, 23);
            this.tbModifOS.TabIndex = 3;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(281, 400);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 0;
            this.btnModificar.Text = "Editar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dgvOSAlta
            // 
            this.dgvOSAlta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOSAlta.Location = new System.Drawing.Point(198, 72);
            this.dgvOSAlta.Name = "dgvOSAlta";
            this.dgvOSAlta.Size = new System.Drawing.Size(240, 320);
            this.dgvOSAlta.TabIndex = 3;
            // 
            // dgvOSModif
            // 
            this.dgvOSModif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOSModif.Location = new System.Drawing.Point(198, 72);
            this.dgvOSModif.Name = "dgvOSModif";
            this.dgvOSModif.Size = new System.Drawing.Size(240, 320);
            this.dgvOSModif.TabIndex = 5;
            // 
            // frmABMOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 485);
            this.Controls.Add(this.tcABM);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmABMOS";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Obra Social";
            this.Load += new System.EventHandler(this.frmABMOS_Load);
            this.tcABM.ResumeLayout(false);
            this.tpAlta.ResumeLayout(false);
            this.tpAlta.PerformLayout();
            this.tpBaja.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOSBaja)).EndInit();
            this.tpMod.ResumeLayout(false);
            this.tpMod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOSAlta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOSModif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcABM;
        private System.Windows.Forms.TabPage tpAlta;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.TabPage tpBaja;
        private System.Windows.Forms.DataGridView dgvOSBaja;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.TabPage tpMod;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label1;
        private controles.TextBoxLetras tbOS;
        private System.Windows.Forms.Label label2;
        private controles.TextBoxLetras tbModifOS;
        private System.Windows.Forms.DataGridView dgvOSAlta;
        private System.Windows.Forms.DataGridView dgvOSModif;
    }
}