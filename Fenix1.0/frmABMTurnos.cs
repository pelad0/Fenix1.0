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
        public frmABMTurnos()
        {
            InitializeComponent();
        }

        RepositorioEspecialidad re = new RepositorioEspecialidad();
        RepositorioMedico rm = new RepositorioMedico();
        RepositorioTurno rt = new RepositorioTurno();
        List<string> especialidades = new List<string>();

        private void frmABM_Load(object sender, EventArgs e)
        {
            iniciar();            
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {

        }

        private void iniciar()
        {
            foreach (clsEspecialidad esp in re.Todo())
            {
                especialidades.Add(esp.Descripcion);
            }
            cbEspecialidades.DataSource = especialidades;
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
            
        }

    }
}
