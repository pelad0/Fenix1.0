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
using CrystalDecisions.CrystalReports.Engine;

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
        List<string> esp = new List<string>();
        List<string> med = new List<string>();
        List<string> pac = new List<string>();
        clsMedico m = new clsMedico();
        clsPaciente p = new clsPaciente();
        clsUsuario u = new clsUsuario();
        

        public frmTurno(clsUsuario u)
        {
            InitializeComponent();
            this.u = u;
        }

        private void frmTurno_Load(object sender, EventArgs e)
        {
            esp.Clear();
            try
            {
                foreach (clsEspecialidad es in re.Todo())
                {
                    esp.Add(es.Descripcion);
                }
                cbEspecialidades.DataSource = esp;
            }
            catch (Exception ex)
            {
                    MessageBox.Show("Se ha pruducido el Sgte. error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbMedicos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMedicos.Checked == true)
            {
                cbEspecialidades.Enabled = true;
                cbAlfa.Enabled = false;
                cbPacientes.Enabled = false;
                cbPacientes.DataSource = null;
                dgvTurnos.DataSource = null;
                dgvSobreturnos.DataSource = null;
            }
            else
            {
                cbEspecialidades.Enabled = false;
                cbMedicos.Enabled = false;
                cbAlfa.Enabled = true;
                cbMedicos.DataSource = null;
                dgvTurnos.DataSource = null;
                dgvSobreturnos.DataSource = null;
            }
        }

        private void cbEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cbEspecialidades.Text) && (rbMedicos.Checked || rbPacientes.Checked))
            {
                try
                {
                    if (rm.BuscaPorEspecialidad(cbEspecialidades.Text).Count > 0)
                    {
                        med.Clear();
                        cbMedicos.DataSource = null;
                        foreach (clsMedico me in rm.BuscaPorEspecialidad(cbEspecialidades.Text))
                        {
                            med.Add(me.nombreCompleto());
                        }
                        cbMedicos.DataSource = med;
                        cbMedicos.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se ha pruducido el Sgte. error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbAlfa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cbAlfa.Text))
            {
                try
                {
                    pacientes.Clear();
                    pacientes = rp.obtenerAlfabeticamente(cbAlfa.Text);
                    if (pacientes.Count > 0)
                    {
                        pac.Clear();
                        cbPacientes.DataSource = null;
                        foreach (clsPaciente pa in pacientes)
                        {
                            pac.Add(pa.nomCompleto());
                        }
                        cbPacientes.DataSource = pac;
                        cbPacientes.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se ha pruducido el Sgte. error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cbMedicos.Text))
            {
                dgvTurnos.DataSource = null;
                dgvSobreturnos.DataSource = null;
                try
                {
                    medicos.Clear();
                    medicos = rm.BuscaPorEspecialidad(cbEspecialidades.Text);
                    if (medicos.Count > 0)
                    {
                        m = medicos[cbMedicos.SelectedIndex];
                        dgvTurnos.DataSource = rt.obtenerTurnoMedico(m.Id);
                        //dgvTurnos.Columns[].Visible = false;
                        //dgvTurnos.Columns[].Visible = false;
                        //dgvTurnos.Columns[].Visible = false;
                        //dgvTurnos.Columns[].Visible = false;
                        dgvSobreturnos.DataSource = rst.obtenerSobreTurnoMedico(m.Id);
                        //dgvSobreturnos.Columns[].Visible = false;
                        //dgvSobreturnos.Columns[].Visible = false;
                        //dgvSobreturnos.Columns[].Visible = false;
                        //dgvSobreturnos.Columns[].Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se ha pruducido el Sgte. error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cbPacientes.Text))
            {
                dgvTurnos.DataSource = null;
                dgvSobreturnos.DataSource = null;
                try
                {
                    p = pacientes[cbPacientes.SelectedIndex];
                    turnos.Clear();
                    turnos = rt.obtenerTurnoPaciente(p.Id);
                    dgvTurnos.DataSource = turnos;
                    //dgvTurnos.Columns[].Visible = false;
                    //dgvTurnos.Columns[].Visible = false;
                    //dgvTurnos.Columns[].Visible = false;
                    //dgvTurnos.Columns[].Visible = false;
                    sobreTurnos.Clear();
                    sobreTurnos = rst.obtenerSobreturnoPaciente(p.Id);
                    dgvSobreturnos.DataSource = sobreTurnos; 
                    //dgvSobreturnos.Columns[].Visible = false;
                    //dgvSobreturnos.Columns[].Visible = false;
                    //dgvSobreturnos.Columns[].Visible = false;
                    //dgvSobreturnos.Columns[].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se ha pruducido el Sgte. error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRepTurn_Click(object sender, EventArgs e)
        {
            rptTurnosMedico rep = new rptTurnosMedico();
            rep.SetDataSource=
            
        }

        private void btnRepSobreTur_Click(object sender, EventArgs e)
        {

        }

    }
}
