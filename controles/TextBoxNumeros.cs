using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controles
{
    class TextBoxNumeros : TextBox
    {
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
