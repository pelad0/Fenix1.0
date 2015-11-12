using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using controles;
using logica;
using entidades;

namespace Fenix1._0
{
    public partial class frmTurno : Form
    {
        RepositorioTurno rt = new RepositorioTurno();
        RepositorioSobreturno rst = new RepositorioSobreturno();
        RepositorioMedico rm = new RepositorioMedico();
        RepositorioPaciente rp = new RepositorioPaciente();
        RepositorioEspecialidad re = new RepositorioEspecialidad();
        List<clsMedico> medicos = new List<clsMedico>();
        List<clsPaciente> pacientes = new List<clsPaciente>();
        List<clsTurnoVista> turnos = new List<clsTurnoVista>();
        List<clsSobreTurnoVista> sobreTurnos = new List<clsSobreTurnoVista>();
        List<clsEspecialidad> especialidades = new List<clsEspecialidad>();
        clsMedico m = new clsMedico();
        clsPaciente p = new clsPaciente();
        clsUsuario u = new clsUsuario();
        int pagina = 0;

        public frmTurno(clsUsuario u)
        {
            InitializeComponent();
            this.u = u;
            
        }

        private void frmTurno_Load(object sender, EventArgs e)
        {
            cbEspecialidades.DataSource = re.Todo();
            cbPacientes.DataSource = rp.Todo();
        }

        private void rbMedicos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMedicos.Checked == true)
            {
                cbEspecialidades.Enabled = true;
                cbPacientes.Enabled = false;
            }
            else
            {
                cbEspecialidades.Enabled = false;
                cbMedicos.Enabled = false;
            }
        }

        private void rbPacientes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPacientes.Checked == true)
            {
                cbPacientes.Enabled = true;
                cbEspecialidades.Enabled = false;
                cbMedicos.Enabled = false;
            }
            else
            {
                cbPacientes.Enabled = false;
            }
        }

    }
}
