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
    public partial class frmABMTurnos : Form
    {
        int pagina = 0;
        clsUsuario u = new clsUsuario();
        clsPaciente pac = new clsPaciente();
        RepositorioEspecialidad re = new RepositorioEspecialidad();
        RepositorioMedico rm = new RepositorioMedico();
        RepositorioTurno rt = new RepositorioTurno();
        RepositorioSobreturno rst = new RepositorioSobreturno();
        List<clsMedico> medicos = new List<clsMedico>();
        List<clsTurno> turnos = new List<clsTurno>();
        List<string> especialidades = new List<string>();
        clsHorario mañana = new clsHorario();
        clsHorario tarde = new clsHorario();

        public frmABMTurnos( clsUsuario usu, clsPaciente pac)
        {
            InitializeComponent();
            this.u = usu;
            this.pac = pac;
        }

        private void frmABM_Load(object sender, EventArgs e)
        {
            iniciar();            
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            clsTurno t =new clsTurno();
            rt.Alta(t,u.Id);
        }

        private void cbEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> medicos = new List<string>();
            foreach (clsMedico med in rm.Busca(cbEspecialidades.SelectedItem.ToString()))
            {
		        medicos.Add(med.Apellido+" "+med.Nombre);
            }
            cbMedicos.DataSource= medicos;
        }

        private void btnTurnoXDia_Click(object sender, EventArgs e)
        {
            clsMedico med = medicos[cbMedicos.SelectedIndex];
            turnos.Clear();
            turnos = rt.obtenerTurno(med.Id, dtpFecha.Value);//no tocar
            mañana = rm.BuscarHorarioMañana(med.Id);
            tarde = rm.BuscarHorarioTarde(med.Id);

        }

        private void btnAnt_Click(object sender, EventArgs e)
        {
            if (pagina > 0)
            {
                pagina--;
                iniciar();
            }
        }

        private void btnSig_Click(object sender, EventArgs e)
        {
            if (rt.Todo(pagina + 1).Count>0)
            {
                pagina++;
                iniciar();
            }
        }

        private void iniciar()
        {
            foreach (clsEspecialidad esp in re.Todo())
            {
                especialidades.Add(esp.Descripcion);
            }
            cbEspecialidades.DataSource = especialidades;
            cbMedicos.DataSource = null;
            medicos.Clear();
            medicos = rm.Busca(cbEspecialidades.SelectedItem.ToString());
            dgvEliminar.DataSource = null;
            dgvEliminar.DataSource = rt.Todo(pagina);
        }

        private void dgvEliminar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
