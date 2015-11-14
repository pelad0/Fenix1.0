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
        List<clsReporteTurnos> tur = new List<clsReporteTurnos>();
        List<clsReporteTurnos> stur = new List<clsReporteTurnos>();
        List<string> esp = new List<string>();
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
                    MessageBox.Show("Se ha producido el Sgte. error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            dgvTurnos.Columns.Add("Paciente", "Paciente");
            dgvTurnos.Columns.Add("Fecha", "Fecha");
            dgvTurnos.Columns.Add("Asistio", "Asistió");

            dgvSobreturnos.Columns.Add("Paciente", "Paciente");
            dgvSobreturnos.Columns.Add("Fecha", "Fecha");
            dgvSobreturnos.Columns.Add("Asistio", "Asistió");
            
        }

        private void rbMedicos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMedicos.Checked == true)
            {
                cbEspecialidades.Enabled = true;
                cbAlfa.Enabled = false;
                cbPacientes.Enabled = false;
                dgvTurnos.DataSource = null;
                dgvSobreturnos.DataSource = null;
            }
            else
            {
                cbEspecialidades.Enabled = false;
                cbMedicos.Enabled = false;
                cbAlfa.Enabled = true;
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
                    string Espe = cbEspecialidades.SelectedItem.ToString();
                    if (rm.BuscaPorEspecialidad(Espe).Count > 0)
                    {
                        cbMedicos.Items.Clear();
                        foreach (clsMedico me in rm.BuscaPorEspecialidad(Espe))
                        {
                            cbMedicos.Items.Add(me.nombreCompleto());
                        }
                        cbMedicos.Enabled = true;
                        cbMedicos.SelectedIndex = 0;
                        cbMedicos.Focus();
                    }
                    else
                    {
                        cbMedicos.Items.Clear();
                        cbMedicos.SelectedIndex = -1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se ha producido el Sgte. error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        cbPacientes.Items.Clear();

                        foreach (clsPaciente pa in pacientes)
                        {
                            cbPacientes.Items.Add(pa.nomCompleto());
                        }
                        cbPacientes.Enabled = true;
                        cbPacientes.SelectedIndex = 0;
                        cbPacientes.Focus();
                    }
                    else
                    {
                        cbPacientes.Items.Clear();
                        cbPacientes.SelectedIndex = -1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se ha producido el Sgte. error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                medicos.Clear();
                medicos = rm.BuscaPorEspecialidad(cbEspecialidades.Text);
                if (medicos.Count > 0)
                {
                    actualizoXmedico();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido el Sgte. error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void actualizoXmedico()
        {

            m = medicos[cbMedicos.SelectedIndex];
            turnos.Clear();
            tur.Clear();
            turnos = rt.obtenerTurnoMedico(m.Id);
            if (turnos.Count > 0)
            {
                dgvTurnos.Rows.Clear();
                foreach (clsTurnoVista t in turnos)
                {
                    if (t.Estado)
                    {
                        dgvTurnos.Rows.Add(t.Paciente.nomCompleto(), t.Fecha, "SI");
                        tur.Add(new clsReporteTurnos(t.Paciente.nomCompleto(), t.Fecha, "SI"));
                    }
                    else
                    {
                        dgvTurnos.Rows.Add(t.Paciente.nomCompleto(), t.Fecha, "NO");
                        tur.Add(new clsReporteTurnos(t.Paciente.nomCompleto(), t.Fecha, "NO"));
                    }
                }
            }
            else
            {
                dgvTurnos.Rows.Clear();
            }

            sobreTurnos.Clear();
            stur.Clear();
            sobreTurnos = rst.obtenerSobreTurnoMedico(m.Id);
            if (sobreTurnos.Count > 0)
            {
                dgvSobreturnos.Rows.Clear();
                foreach (clsSobreTurnoVista t in sobreTurnos)
                {
                    if (t.Estado)
                    {
                        dgvSobreturnos.Rows.Add(t.Paciente.nomCompleto(), t.Fecha, "SI");
                        stur.Add(new clsReporteTurnos(t.Paciente.nomCompleto(), t.Fecha, "SI"));
                    }
                    else
                    {
                        dgvSobreturnos.Rows.Add(t.Paciente.nomCompleto(), t.Fecha, "NO");
                        stur.Add(new clsReporteTurnos(t.Paciente.nomCompleto(), t.Fecha, "NO"));
                    }
                }
            }
            else
            {
                dgvSobreturnos.Rows.Clear();
            }
        }

        private void cbPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                pacientes.Clear();
                pacientes = rp.obtenerAlfabeticamente(cbAlfa.Text);
                actualizoXpaciente();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido el Sgte. error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void actualizoXpaciente()
        {
            if (pacientes.Count > 0)
            {
                p = pacientes[cbPacientes.SelectedIndex];
                turnos.Clear();
                tur.Clear();
                turnos = rt.obtenerTurnoPaciente(p.Id);
                if (turnos.Count > 0)
                {
                    dgvTurnos.Rows.Clear();
                    foreach (clsTurnoVista t in turnos)
                    {
                        if (t.Estado)
                        {
                            dgvTurnos.Rows.Add(t.Paciente.nomCompleto(), t.Fecha, "SI");
                            tur.Add(new clsReporteTurnos(t.Paciente.nomCompleto(), t.Fecha, "SI"));
                        }
                        else
                        {
                            dgvTurnos.Rows.Add(t.Paciente.nomCompleto(), t.Fecha, "NO");
                            tur.Add(new clsReporteTurnos(t.Paciente.nomCompleto(), t.Fecha, "NO"));
                        }
                    }
                }
                else
                {
                    dgvTurnos.Rows.Clear();
                }

                sobreTurnos.Clear();
                stur.Clear();
                sobreTurnos = rst.obtenerSobreturnoPaciente(p.Id);
                if (sobreTurnos.Count > 0)
                {
                    dgvSobreturnos.Rows.Clear();
                    foreach (clsSobreTurnoVista t in sobreTurnos)
                    {
                        if (t.Estado)
                        {
                            dgvSobreturnos.Rows.Add(t.Paciente.nomCompleto(), t.Fecha, "SI");
                            stur.Add(new clsReporteTurnos(t.Paciente.nomCompleto(), t.Fecha, "SI"));
                        }
                        else
                        {
                            dgvSobreturnos.Rows.Add(t.Paciente.nomCompleto(), t.Fecha, "NO");
                            stur.Add(new clsReporteTurnos(t.Paciente.nomCompleto(), t.Fecha, "NO"));
                        }
                    }
                }
                else
                {
                    dgvSobreturnos.Rows.Clear();
                }
            }
        }

        private void btnRepTurn_Click(object sender, EventArgs e)
        {
            if (tur.Count > 0)
            {
                if (rbMedicos.Checked)
                {
                    crTurnosMedico
                }
            }
            else
            {
                MessageBox.Show("No se registran turnos para realizar el reporte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //rptTurnosMedico rep = new rptTurnosMedico();
            //rep.SetDataSource(turnos);
            //frmReporteTurnosMedico rtm = new frmReporteTurnosMedico(rep);
            //rtm.ShowDialog();
        }

        private void btnRepSobreTur_Click(object sender, EventArgs e)
        {
            if (stur.Count > 0)
            {

            }
            else
            {
                MessageBox.Show("No se registran sobreturnos para realizar el reporte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //rptTurnosMedico rep = new rptTurnosMedico();
            //rep.SetDataSource(sobreTurnos);
            //frmReporteTurnosMedico rtm = new frmReporteTurnosMedico(rep);
            //rtm.ShowDialog();
        }
    }
}
