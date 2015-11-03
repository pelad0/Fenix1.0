using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using entidades;
using interfaces;

namespace controles
{
    public partial class ctrlTurnos : UserControl
    {

        public ctrlTurnos()
        {
            InitializeComponent();
        }

        public void mañana(bool estado)
        {
            if (estado)
            {
                foreach (Button btn in this.Controls)
                {
                    if (btn.Tag.ToString() == "mañana")
                    {
                        btn.Enabled = true;
                        btn.BackColor = Color.LimeGreen;
                    }
                    else
                    {
                        btn.Enabled = false;
                        btn.BackColor = Color.Gray;
                    }
                }
            }
        }

        public void tarde(bool estado)
        {
            if (estado)
            {
                foreach (Button btn in this.Controls)
                {
                    if (btn.Tag.ToString() == "tarde")
                    {
                        btn.Enabled = true;
                        btn.BackColor = Color.LimeGreen;
                    }
                    else
                    {
                        btn.Enabled = false;
                        btn.BackColor = Color.Gray;
                    }
                }
            }
        }

        public void turnosDados(List<clsTurno> turnos)
        {
            foreach (clsTurno turno in turnos)
            {
                foreach (Button btn in this.Controls)
                {
                    if (turno.Fecha.ToShortTimeString().Contains(btn.Text))
                    {
                        btn.BackColor = Color.Gold;
                    }
                }
            }
        }

        public void sobreTurnosDados(List<clsSobreturno> sobreTurnos)
        {
            foreach (clsSobreturno sturno in sobreTurnos)
            {
                foreach (Button btn in this.Controls)
                {
                    if (sturno.Fecha.ToShortTimeString().Contains(btn.Text))
                    {
                        btn.BackColor = Color.Red;
                        btn.Enabled = false;
                    }
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if ((sender as Button).BackColor == Color.LimeGreen)
            {
                clsTurno t = new clsTurno();
            }
            else if ((sender as Button).BackColor == Color.Gold)
	        {
                clsSobreturno st = new clsSobreturno();
	        }
        }
    }
}
