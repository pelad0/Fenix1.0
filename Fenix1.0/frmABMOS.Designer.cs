namespace Fenix1._0
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
            this.btnSig = new System.Windows.Forms.Button();
            this.btnAnt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBaja = new System.Windows.Forms.Button();
            this.tpMod = new System.Windows.Forms.TabPage();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dgbOS = new System.Windows.Forms.DataGridView();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSgte = new System.Windows.Forms.Button();
            this.tcABM.SuspendLayout();
            this.tpAlta.SuspendLayout();
            this.tpBaja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tpMod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbOS)).BeginInit();
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
            this.tpAlta.Controls.Add(this.btnSgte);
            this.tpAlta.Controls.Add(this.btnAnterior);
            this.tpAlta.Controls.Add(this.dgbOS);
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
            this.label1.Location = new System.Drawing.Point(276, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Obra Social";
            // 
            // tbOS
            // 
            this.tbOS.Location = new System.Drawing.Point(220, 42);
            this.tbOS.MaxLength = 40;
            this.tbOS.Name = "tbOS";
            this.tbOS.Size = new System.Drawing.Size(197, 23);
            this.tbOS.TabIndex = 1;
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(281, 409);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(75, 23);
            this.btnAlta.TabIndex = 0;
            this.btnAlta.Text = "Cargar";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // tpBaja
            // 
            this.tpBaja.Controls.Add(this.btnSig);
            this.tpBaja.Controls.Add(this.btnAnt);
            this.tpBaja.Controls.Add(this.dataGridView1);
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
            // btnSig
            // 
            this.btnSig.Location = new System.Drawing.Point(467, 411);
            this.btnSig.Name = "btnSig";
            this.btnSig.Size = new System.Drawing.Size(93, 23);
            this.btnSig.TabIndex = 3;
            this.btnSig.Text = "Siguiente>>";
            this.btnSig.UseVisualStyleBackColor = true;
            // 
            // btnAnt
            // 
            this.btnAnt.Location = new System.Drawing.Point(76, 411);
            this.btnAnt.Name = "btnAnt";
            this.btnAnt.Size = new System.Drawing.Size(90, 23);
            this.btnAnt.TabIndex = 2;
            this.btnAnt.Text = "<<Anterior";
            this.btnAnt.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(630, 380);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(279, 411);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(75, 23);
            this.btnBaja.TabIndex = 0;
            this.btnBaja.Text = "Eliminar";
            this.btnBaja.UseVisualStyleBackColor = true;
            // 
            // tpMod
            // 
            this.tpMod.Controls.Add(this.btnModificar);
            this.tpMod.Location = new System.Drawing.Point(4, 34);
            this.tpMod.Name = "tpMod";
            this.tpMod.Size = new System.Drawing.Size(636, 447);
            this.tpMod.TabIndex = 2;
            this.tpMod.Text = "Modificación";
            this.tpMod.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(281, 408);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 0;
            this.btnModificar.Text = "Editar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // dgbOS
            // 
            this.dgbOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbOS.Location = new System.Drawing.Point(198, 71);
            this.dgbOS.Name = "dgbOS";
            this.dgbOS.Size = new System.Drawing.Size(240, 270);
            this.dgbOS.TabIndex = 3;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(162, 361);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(105, 23);
            this.btnAnterior.TabIndex = 4;
            this.btnAnterior.Text = "<< Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSgte
            // 
            this.btnSgte.Location = new System.Drawing.Point(369, 361);
            this.btnSgte.Name = "btnSgte";
            this.btnSgte.Size = new System.Drawing.Size(105, 23);
            this.btnSgte.TabIndex = 5;
            this.btnSgte.Text = "Siguiente >>";
            this.btnSgte.UseVisualStyleBackColor = true;
            this.btnSgte.Click += new System.EventHandler(this.btnSgte_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tpMod.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgbOS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcABM;
        private System.Windows.Forms.TabPage tpAlta;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.TabPage tpBaja;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.TabPage tpMod;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnSig;
        private System.Windows.Forms.Button btnAnt;
        private System.Windows.Forms.Label label1;
        private controles.TextBoxLetras tbOS;
        private System.Windows.Forms.Button btnSgte;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.DataGridView dgbOS;
    }
}