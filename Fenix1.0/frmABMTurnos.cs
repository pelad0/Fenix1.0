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
        public frmABMTurnos( clsUsuario usu)
        {
            InitializeComponent();
            u = usu;
        }

        clsUsuario u = new clsUsuario();
        RepositorioEspecialidad re = new RepositorioEspecialidad();
        RepositorioMedico rm = new RepositorioMedico();
        RepositorioTurno rt = new RepositorioTurno();
        List<clsMedico> medicos = new List<clsMedico>();
        List<string> especialidades = new List<string>();

        private void frmABM_Load(object sender, EventArgs e)
        {
            iniciar();            
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            clsTurno t =new clsTurno();
            rt.Alta(t,u.Id);//asi es el alta
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

            //rt.ObtenerTurnos(med.Id, dtpFecha.Value);//no tocar

        }

    }
}
