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
        clsMedico med = new clsMedico();
        DateTime fecha = new DateTime();
        RepositorioEspecialidad re = new RepositorioEspecialidad();
        RepositorioMedico rm = new RepositorioMedico();
        RepositorioTurno rt = new RepositorioTurno();
        RepositorioSobreturno rst = new RepositorioSobreturno();
        List<clsMedico> medicos = new List<clsMedico>();
        List<clsTurno> turnos = new List<clsTurno>();
        List<clsSobreturno> sobreTurno = new List<clsSobreturno>();
        List<string> especialidades = new List<string>();
        clsHorario mañana = new clsHorario();
        clsHorario tarde = new clsHorario();

        public frmABMTurnos( clsUsuario usu, clsPaciente pac)
        {
            InitializeComponent();
            this.u = usu;
            this.pac = pac;
            this.Text = pac.nomCompleto();
        }

        private void frmABM_Load(object sender, EventArgs e)
        {
            iniciar();            
        }

        private void cbEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> m = new List<string>();
            medicos.Clear();
            medicos = rm.Busca(cbEspecialidades.SelectedItem.ToString());
            foreach (clsMedico med in medicos)
            {
		        m.Add(med.Apellido+" "+med.Nombre);
            }
            cbMedicos.DataSource= m;
            if (cbMedicos.Items.Count>0)
            {
                cbMedicos.SelectedIndex = 0;
            }
        }

        private void btnTurnoXDia_Click(object sender, EventArgs e)
        {
            med = medicos[cbMedicos.SelectedIndex];
            fecha = dtpFecha.Value.Date;
            
            turnos.Clear();
            sobreTurno.Clear();
            turnos = rt.obtenerTurno(med.Id, dtpFecha.Value);//no tocar
            sobreTurno = rst.obtenerSobreturno(med.Id, dtpFecha.Value);

            mañana = rm.BuscarHorarioMañana(med.Id);
            tarde = rm.BuscarHorarioTarde(med.Id);

            botonesDisponibles();

            pnlBotones.Enabled = true;


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

        private void botonesDisponibles()
        {
            if (string.IsNullOrWhiteSpace(mañana.IdMedico.ToString()))
            {
                horariosMañana(false);
            }
            else if (string.IsNullOrWhiteSpace(tarde.IdMedico.ToString()))
            {
                horariosTarde(false);
            }
            else
            {
                horariosMañana(true);
                horariosTarde(true);
            }
            foreach (clsTurno tur in turnos)
            {
                foreach (Button btn in pnlBotones.Controls)
                {
                    if (tur.Fecha.TimeOfDay.ToString().Contains(btn.Text))
                    {
                        btn.BackColor = Color.Gold;
                        btn.Tag = "sobreTurno";
                    }
                    else
                    {
                        btn.Tag = "turno";
                    }
                }
            }
            foreach (clsSobreturno sobTur in sobreTurno)
            {
                foreach (Button btn in pnlBotones.Controls)
                {
                    if (sobTur.Fecha.TimeOfDay.ToString().Contains(btn.Text))
                    {
                        btn.BackColor = Color.Red;
                        btn.Enabled = false;
                    }
                }
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
            cbEspecialidades.SelectedIndex = 0;
            medicos.Clear();
            medicos = rm.Busca(cbEspecialidades.SelectedItem.ToString());
            dgvEliminar.DataSource = null;
            dgvEliminar.DataSource = rt.Todo(pagina);
        }

        private void dgvEliminar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void horariosMañana(bool estado)
        {
            if (estado)
            {
                foreach (Button btn in pnlBotones.Controls)
                {
                    if (btn.Tag.ToString() == "mañana")
                    {
                        btn.Enabled = true;
                        btn.BackColor = Color.LimeGreen;
                    }
                    else
                    {
                        btn.Enabled = false;
                        btn.BackColor = Color.Gray;
                    }
                }
            }
        }

        public void horariosTarde(bool estado)
        {
            if (estado)
            {
                foreach (Button btn in pnlBotones.Controls)
                {
                    if (btn.Tag.ToString() == "tarde")
                    {
                        btn.Enabled = true;
                        btn.BackColor = Color.LimeGreen;
                    }
                    else
                    {
                        btn.Enabled = false;
                        btn.BackColor = Color.Gray;
                    }
                }
            }
        }

        public void turnosDados(List<clsTurno> turnos)
        {
            foreach (clsTurno turno in turnos)
            {
                foreach (Button btn in this.Controls)
                {
                    if (turno.Fecha.ToShortTimeString().Contains(btn.Text))
                    {
                        btn.BackColor = Color.Gold;
                    }
                }
            }
        }

        public void sobreTurnosDados(List<clsSobreturno> sobreTurnos)
        {
            foreach (clsSobreturno sturno in sobreTurnos)
            {
                foreach (Button btn in this.Controls)
                {
                    if (sturno.Fecha.ToShortTimeString().Contains(btn.Text))
                    {
                        btn.BackColor = Color.Red;
                        btn.Enabled = false;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((sender as Button).Tag.ToString() == "turno")
            {
                Button btn = (sender as Button);
                darTurno(btn);
            }
        }

        private void darTurno(Button btn)
        {
            DialogResult res = MessageBox.Show("Confirme turno: Medico "+med.Apellido+" paciente, "+pac.nomCompleto()+" "+fecha.ToLongDateString()+" "+btn.Text, "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                DateTime d = new DateTime(fecha.Year, fecha.Month, fecha.Day, Convert.ToInt32(btn.Text.Substring(0,2)), Convert.ToInt32(btn.Text.Substring(3,2)),0);
                clsTurno t = new clsTurno(med.Id, pac.Id, d, )
            }
        }

    }
}
