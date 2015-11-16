using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controles
{
    public class TextBoxNumeros : TextBox
    {
        private TextBoxLetras textBoxLetras1;
    
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void InitializeComponent()
        {
            this.textBoxLetras1 = new controles.TextBoxLetras();
            this.SuspendLayout();
            // 
            // textBoxLetras1
            // 
            this.textBoxLetras1.Location = new System.Drawing.Point(0, 0);
            this.textBoxLetras1.Name = "textBoxLetras1";
            this.textBoxLetras1.Size = new System.Drawing.Size(100, 20);
            this.textBoxLetras1.TabIndex = 0;
            this.textBoxLetras1.TextChanged += new System.EventHandler(this.textBoxLetras1_TextChanged);
            this.ResumeLayout(false);

        }

        private void textBoxLetras1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
