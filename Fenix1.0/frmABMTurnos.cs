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
        List<clsTurnoVista> turnosVista = new List<clsTurnoVista>();
        List<clsSobreTurnoVista> sobreTurnoVista = new List<clsSobreTurnoVista>();
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
            clsHorario h = new clsHorario();
            RepositorioHorario rh = new RepositorioHorario();
            h = rh.buscarPorId(med.Id, 1);//var 1 es mañana y var=2 es tarde

            if (string.IsNullOrWhiteSpace(mañana.LunesEntrada.ToString()))
            {
                horariosMañana(false);
            }
            else
            {
                horariosMañana(true);
            }

            if (string.IsNullOrWhiteSpace(tarde.LunesEntrada.ToString()))
            {
                horariosTarde(false);
            }
            else
            {
                horariosTarde(true);
            }
            

            turnos = rt.obtenerTurno(med.Id, dtpFecha.Value.Date);

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

            sobreTurno = rst.obtenerSobreturno(med.Id, dtpFecha.Value.Date);

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
            dgvEliminarTurnos.DataSource = null;
            dgvEliminarTurnos.DataSource = rt.Todo(pagina);
            dgvEliminarTurnos.Columns[0].Visible = false;
        }

        private void btnTurnoXDia_Click(object sender, EventArgs e)
        {
//            fecha = dtpFecha.Value.Date;

            //turnosVista.Clear();
            //sobreTurnoVista.Clear();
            //turnosVista = rt.obtenerTurnoVista(med.Id, dtpFecha.Value);
            //sobreTurnoVista = rst.obtenerSobreturnoVista(med.Id, dtpFecha.Value);
            turnos.Clear();
            sobreTurno.Clear();
            turnos = rt.obtenerTurno(med.Id, dtpFecha.Value.Date);
            sobreTurno = rst.obtenerSobreturno(med.Id, dtpFecha.Value.Date);
            turnosDados(turnos);
            sobreTurnosDados(sobreTurno);
            mañana = rm.BuscarHorarioMañana(med.Id);
            tarde = rm.BuscarHorarioTarde(med.Id);

            botonesDisponibles();

            pnlBotones.Enabled = true;

            btnTurnoXDia.Focus();
        }





        public void horariosMañana(bool estado)
        {
            if (estado)
            {
                foreach (Button btn in pnlBotones.Controls)
                {
                    if (btn.Name.Contains("mañ"))
                    {
                        btn.Enabled = true;
                        btn.BackColor = Color.LimeGreen;
                    }
                }
            }
            if (!estado)
            {
                                foreach (Button btn in pnlBotones.Controls)
                {
                    if (btn.Name.Contains("mañ"))
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
                    if (btn.Name.Contains("tar"))
                    {
                        btn.Enabled = true;
                        btn.BackColor = Color.LimeGreen;
                    }
                }
            }
            if (!estado)
            {
                foreach (Button btn in pnlBotones.Controls)
                {
                    if (btn.Name.Contains("tar"))
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
                foreach (Button btn in pnlBotones.Controls)
                {
                    if (turno.Fecha.ToShortTimeString().Contains(btn.Text))
                    {
                        btn.BackColor = Color.Gold;
                        btn.Tag = "sobreTurno";
                    }
                }
            }
        }

        public void sobreTurnosDados(List<clsSobreturno> sobreTurnos)
        {
            foreach (clsSobreturno sturno in sobreTurnos)
            {
                foreach (Button btn in pnlBotones.Controls)
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
                pnlBotones.Enabled = false;
            }
            if ((sender as Button).Tag.ToString() == "sobreTurno")
            {
                Button btn = (sender as Button);
                darSobreTurno(btn);
                pnlBotones.Enabled = false;
            }
            botonesDisponibles();
        }

        private void darTurno(Button btn)
        {
            DialogResult res = MessageBox.Show("Confirme turno: Medico "+med.Apellido+" paciente, "+pac.nomCompleto()+" "+fecha.ToLongDateString()+" "+btn.Text, "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                DateTime d = new DateTime(fecha.Year, fecha.Month, fecha.Day, Convert.ToInt32(btn.Text.Substring(0,2)), Convert.ToInt32(btn.Text.Substring(3,2)),0);        
                clsTurno t = new clsTurno(med.Id, pac.Id, d, u.Id);
                List<clsTurno> lt = rt.obtenerTurno(med.Id, t.Fecha);

                try
                {
                    rt.Alta(t);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se ha pruducido el Sgte. error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void darSobreTurno(Button btn)
        {
            DialogResult res = MessageBox.Show("Confirme SOBRE Turno: Medico " + med.Apellido + " paciente, " + pac.nomCompleto() + " " + fecha.ToLongDateString() + " " + btn.Text, "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                DateTime d = new DateTime(fecha.Year, fecha.Month, fecha.Day, Convert.ToInt32(btn.Text.Substring(0, 2)), Convert.ToInt32(btn.Text.Substring(3, 2)), 0);
                clsSobreturno t = new clsSobreturno(med.Id, pac.Id, d, u.Id);
                List<clsTurno> lt = rt.obtenerTurno(med.Id, t.Fecha);

                try
                {
                    rst.Alta(t);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se ha pruducido el Sgte. error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void dgvEliminar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            rt.obtenerTurno
        }

        private void cbMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            med = medicos[cbMedicos.SelectedIndex];
        }

    }
}
