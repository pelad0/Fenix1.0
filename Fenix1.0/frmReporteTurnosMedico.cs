using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using entidades;

namespace frmABMME
{
    public partial class frmReporteTurnosMedico : Form
    {
        List<clsTurnoVista> turnos = new List<clsTurnoVista>();
        public frmReporteTurnosMedico(List<clsTurnoVista> turnos)
        {
            InitializeComponent();
            this.turnos = turnos;
            
        }
    }
}
