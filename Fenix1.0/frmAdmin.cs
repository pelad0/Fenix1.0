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

namespace Fenix1._0
{
    public partial class frmAdmin : Form
    {
        clsUsuario u = new clsUsuario();
        frmInicio i;
        public frmAdmin(clsUsuario u, frmInicio i)
        {
            InitializeComponent();
            this.u = u;
            this.i = i;
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            frmABMPaciente p = new frmABMPaciente(u);
            p.ShowDialog();
        }

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            frmABMME m = new frmABMME();
            m.ShowDialog();
        }

        private void btnObraSocial_Click(object sender, EventArgs e)
        {
            frmABMOS o = new frmABMOS();
            o.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmABMUsuario u = new frmABMUsuario();
            u.ShowDialog();
        }

        private void frmAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            i.limpiar();
            i.iniciar();
            i.Show();
        }

        private void btnTurnos_Click(object sender, EventArgs e)
        {
            frmTurno frmT = new frmTurno(u);
            frmT.ShowDialog();
        }

        private void btnInformesOS_Click(object sender, EventArgs e)
        {
            frmReporteOS ros = new frmReporteOS();
            ros.ShowDialog();
        }

        private void btnMedicos_MouseEnter(object sender, EventArgs e)
        {
            if ((sender as Button).Tag.ToString() == "1")
            {
                lblAccion.Text = "*Administración de Pacientes y Turnos.";
            }
            if ((sender as Button).Tag.ToString() == "2")
            {
                lblAccion.Text = "*Administración Médicos y Especialidades.";
            }
            if ((sender as Button).Tag.ToString() == "3")
            {
                lblAccion.Text = "*Visualización de Turnos actuales, filtrados por paciente y Médico.";
            }
            if ((sender as Button).Tag.ToString() == "4")
            {
                lblAccion.Text = "*Visualización de Turnos ya Atendidos.";
            }
            if ((sender as Button).Tag.ToString() == "5")
            {
                lblAccion.Text = "*Administración de Obras Sociales en la Clínica.";
            }
            if ((sender as Button).Tag.ToString() == "6")
            {
                lblAccion.Text = "*Generación de reportes para Obras Sociales.";
            }

            
        }

        private void btnMedicos_MouseLeave(object sender, EventArgs e)
        {
            lblAccion.Text = "";
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            lblNombreUsuario.Text = u.Usuario;
        }

    }
}
