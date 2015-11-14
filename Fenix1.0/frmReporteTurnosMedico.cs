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
using CrystalDecisions.CrystalReports.Engine;

namespace Fenix1._0
{
    public partial class frmReporteTurnosMedico : Form
    {


        public frmReporteTurnosMedico(ReportDocument rd)
        {
            InitializeComponent();
            crvForm.ReportSource = rd;
        }

        private void frmReporteTurnosMedico_Load(object sender, EventArgs e)
        {

        }
    }
}
