using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using logica;
using entidades;

namespace Fenix1._0
{
    public partial class frmReporteOS : Form
    {
        RepositorioObraSocial ros = new RepositorioObraSocial();
        RepositorioTurno rt = new RepositorioTurno();
        RepositorioSobreturno rst = new RepositorioSobreturno();
        List<clsObraSocial> obras = new List<clsObraSocial>();
        List<clsTurnoVista> turnos = new List<clsTurnoVista>();

        public frmReporteOS()
        {
            InitializeComponent();
        }

        private void frmReporteOS_Load(object sender, EventArgs e)
        {
            iniciar();
        }

        private void iniciar()
        {
            try
            {
                obras.Clear();
                obras = ros.Todo(0);
                cbOS.DataSource = obras;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido el Sgte. error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRep_Click(object sender, EventArgs e)
        {
            turnos.Clear();
            //turnos=rt.turnoxobra(cbOS.SelectedItem.ToString(), dtpDesde, dtpHasta);
            //generar reporte...
        }
    }
}
