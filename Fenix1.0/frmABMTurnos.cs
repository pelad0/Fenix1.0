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
        List<clsSobreTurnoVista> sobreTurno = new List<clsSobreTurnoVista>();
        List<clsEspecialidad> espec = new List<clsEspecialidad>();

        List<string> especialidades = new List<string>();
        clsHorario mañana = new clsHorario();
        clsHorario tarde = new clsHorario();
        bool eligio = false;

        public frmABMTurnos(clsUsuario usu, clsPaciente pac)
        {
            InitializeComponent();
            this.u = usu;
            this.pac = pac;
            this.Text = pac.nomCompleto();
        }

        public frmABMTurnos()
        {
            InitializeComponent();
        }

        private void frmABM_Load(object sender, EventArgs e)
        {
            dgvEliminarTurnos.Columns.Add("Fecha", "Fecha");
            dgvEliminarTurnos.Columns.Add("Medico", "Medico");
            dgvEliminarTurnos.Columns.Add("Paciente", "Paciente");
            dgvEliminarTurnos.Columns.Add("Costo", "Costo");

            dgvEliminarSobreTurnos.Columns.Add("Fecha", "Fecha");
            dgvEliminarSobreTurnos.Columns.Add("Medico", "Medico");
            dgvEliminarSobreTurnos.Columns.Add("Paciente", "Paciente");
            dgvEliminarSobreTurnos.Columns.Add("Costo", "Costo");

            iniciar();
        }

        private void cbEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> m = new List<string>();
            medicos.Clear();
            medicos = rm.BuscaPorEspecialidad(cbEspecialidades.SelectedItem.ToString());
            foreach (clsMedico med in medicos)
            {
                m.Add(med.Apellido + " " + med.Nombre);
            }
            cbMedicos.DataSource = m;
            if (cbMedicos.Items.Count > 0)
            {
                cbMedicos.SelectedIndex = 0;
            }
        }

        private void btnAnt_Click(object sender, EventArgs e)
        {
            if (pagina > 0)
            {
                pagina--;
                cargarGrillas();
            }
        }

        private void btnSig_Click(object sender, EventArgs e)
        {
            if (rt.Todo(pagina + 1).Count > 0)
            {
                pagina++;
                cargarGrillas();
            }
        }

        private void botonesDisponibles()
        {
            clsHorario hm = new clsHorario();
            clsHorario ht = new clsHorario();
            RepositorioHorario rh = new RepositorioHorario();
            try
            {
                hm = rh.buscarPorId(med.Id, 1);//var 1 es mañana y var=2 es tarde
                ht = rh.buscarPorId(med.Id, 2);
            }
            catch(Exception ex)
            { 
            }
            
            string dia = dtpFecha.Value.DayOfWeek.ToString();
            horariosMañana(true);
            horariosTarde(true);
            switch (dia)
            {
                case "Monday":
                    if (hm.LunesEntrada == null)
                    {
                        horariosMañana(false);
                    }
                    if (ht.LunesSalida == null)
                    {
                        horariosTarde(false);
                    }
                    else
                    {
                        foreach (Button b in pnlBotones.Controls)
                        {
                            if (hm.LunesEntrada.Value.Hour > Convert.ToInt32(b.Text.Substring(0, 2)))
                            {
                                b.Enabled = false;
                                b.BackColor = Color.Gray;
                            }
                            else if (hm.LunesSalida.Value.Hour <= Convert.ToInt32(b.Text.Substring(0, 2)) && Convert.ToInt32(b.Text.Substring(0, 2)) < 14)
                            {
                                b.Enabled = false;
                                b.BackColor = Color.Gray;
                            }
                            else if (ht.LunesEntrada.Value.Hour > Convert.ToInt32(b.Text.Substring(0, 2)) && Convert.ToInt32(b.Text.Substring(0, 2)) >= 14)
                            {
                                b.Enabled = false;
                                b.BackColor = Color.Gray;
                            }
                            else if (ht.LunesSalida.Value.Hour <= Convert.ToInt32(b.Text.Substring(0, 2)))
                            {
                                b.Enabled = false;
                                b.BackColor = Color.Gray;
                            }
                            else
                            {
                                b.Enabled = true;
                            }

                        }
                    }
                    break;
                case "Tuesday":
                    if (hm.MartesEntrada == null)
                    {
                        horariosMañana(false);
                    }
                    if (ht.MartesSalida == null)
                    {
                        horariosTarde(false);
                    }
                    else
                    {
                        foreach (Button b in pnlBotones.Controls)
                        {
                            if (hm.MartesEntrada.Value.Hour > Convert.ToInt32(b.Text.Substring(0, 2)))
                            {
                                b.Enabled = false;
                                b.BackColor = Color.Gray;
                            }
                            else if (hm.MartesSalida.Value.Hour <= Convert.ToInt32(b.Text.Substring(0, 2)) && Convert.ToInt32(b.Text.Substring(0, 2)) < 14)
                            {
                                b.Enabled = false;
                                b.BackColor = Color.Gray;
                            }
                            else if (ht.MartesEntrada.Value.Hour > Convert.ToInt32(b.Text.Substring(0, 2)) && Convert.ToInt32(b.Text.Substring(0, 2)) >= 14)
                            {
                                b.Enabled = false;
                                b.BackColor = Color.Gray;
                            }
                            else if (ht.MartesSalida.Value.Hour <= Convert.ToInt32(b.Text.Substring(0, 2)))
                            {
                                b.Enabled = false;
                                b.BackColor = Color.Gray;
                            }
                            else
                            {
                                b.Enabled = true;
                            }

                        }
                    }
                    break;
                case "Wednesday":
                    if (hm.MiercolesEntrada == null)
                    {
                        horariosMañana(false);
                    }
                    if (ht.MiercolesSalida == null)
                    {
                        horariosTarde(false);
                    }
                    else
                    {
                        foreach (Button b in pnlBotones.Controls)
                        {
                            if (hm.MiercolesEntrada.Value.Hour > Convert.ToInt32(b.Text.Substring(0, 2)))
                            {
                                b.Enabled = false;
                                b.BackColor = Color.Gray;
                            }
                            else if (hm.MiercolesSalida.Value.Hour <= Convert.ToInt32(b.Text.Substring(0, 2)) && Convert.ToInt32(b.Text.Substring(0, 2)) < 14)
                            {
                                b.Enabled = false;
                                b.BackColor = Color.Gray;
                            }
                            else if (ht.MiercolesEntrada.Value.Hour > Convert.ToInt32(b.Text.Substring(0, 2)) && Convert.ToInt32(b.Text.Substring(0, 2)) >= 14)
                            {
                                b.Enabled = false;
                                b.BackColor = Color.Gray;
                            }
                            else if (ht.MiercolesSalida.Value.Hour <= Convert.ToInt32(b.Text.Substring(0, 2)))
                            {
                                b.Enabled = false;
                                b.BackColor = Color.Gray;
                            }
                            else
                            {
                                b.Enabled = true;
                            }

                        }
                    }
                    break;
                case "Thursday":
                    if (hm.JuevesEntrada == null)
                    {
                        horariosMañana(false);
                    }
                    if (ht.JuevesSalida == null)
                    {
                        horariosTarde(false);
                    }
                    else
                    {
                        foreach (Button b in pnlBotones.Controls)
                        {
                            if (hm.JuevesEntrada.Value.Hour > Convert.ToInt32(b.Text.Substring(0, 2)))
                            {
                                b.Enabled = false;
                                b.BackColor = Color.Gray;
                            }
                            else if (hm.JuevesSalida.Value.Hour <= Convert.ToInt32(b.Text.Substring(0, 2)) && Convert.ToInt32(b.Text.Substring(0, 2)) < 14)
                            {
                                b.Enabled = false;
                                b.BackColor = Color.Gray;
                            }
                            else if (ht.JuevesEntrada.Value.Hour > Convert.ToInt32(b.Text.Substring(0, 2)) && Convert.ToInt32(b.Text.Substring(0, 2)) >= 14)
                            {
                                b.Enabled = false;
                                b.BackColor = Color.Gray;
                            }
                            else if (ht.JuevesSalida.Value.Hour <= Convert.ToInt32(b.Text.Substring(0, 2)))
                            {
                                b.Enabled = false;
                                b.BackColor = Color.Gray;
                            }
                            else
                            {
                                b.Enabled = true;
                            }

                        }
                    }
                    break;
                case "Friday":
                    if (hm.ViernesEntrada == null)
                    {
                        horariosMañana(false);
                    }
                    if (ht.ViernesSalida == null)
                    {
                        horariosTarde(false);
                    }
                    else
                    {
                        foreach (Button b in pnlBotones.Controls)
                        {
                            if (hm.ViernesEntrada.Value.Hour > Convert.ToInt32(b.Text.Substring(0, 2)))
                            {
                                b.Enabled = false;
                                b.BackColor = Color.Gray;
                            }
                            else if (hm.ViernesSalida.Value.Hour <= Convert.ToInt32(b.Text.Substring(0, 2)) && Convert.ToInt32(b.Text.Substring(0, 2)) < 14)
                            {
                                b.Enabled = false;
                                b.BackColor = Color.Gray;
                            }
                            else if (ht.ViernesEntrada.Value.Hour > Convert.ToInt32(b.Text.Substring(0, 2)) && Convert.ToInt32(b.Text.Substring(0, 2)) >= 14)
                            {
                                b.Enabled = false;
                                b.BackColor = Color.Gray;
                            }
                            else if (ht.ViernesSalida.Value.Hour <= Convert.ToInt32(b.Text.Substring(0, 2)))
                            {
                                b.Enabled = false;
                                b.BackColor = Color.Gray;
                            }
                            else
                            {
                                b.Enabled = true;
                            }

                        }
                    }
                    break;
                case "Saturday":
                    if (hm.SabadoEntrada == null)
                    {
                        horariosMañana(false);
                    }
                    if (ht.SabadoSalida == null)
                    {
                        horariosTarde(false);
                    }
                    else
                    {
                        foreach (Button b in pnlBotones.Controls)
                        {
                            if (hm.SabadoEntrada.Value.Hour > Convert.ToInt32(b.Text.Substring(0, 2)))
                            {
                                b.Enabled = false;
                                b.BackColor = Color.Gray;
                            }
                            else if (hm.SabadoSalida.Value.Hour <= Convert.ToInt32(b.Text.Substring(0, 2)) && Convert.ToInt32(b.Text.Substring(0, 2)) < 14)
                            {
                                b.Enabled = false;
                                b.BackColor = Color.Gray;
                            }
                            else if (ht.SabadoEntrada.Value.Hour > Convert.ToInt32(b.Text.Substring(0, 2)) && Convert.ToInt32(b.Text.Substring(0, 2)) >= 14)
                            {
                                b.Enabled = false;
                                b.BackColor = Color.Gray;
                            }
                            else if (ht.SabadoSalida.Value.Hour <= Convert.ToInt32(b.Text.Substring(0, 2)))
                            {
                                b.Enabled = false;
                                b.BackColor = Color.Gray;
                            }
                            else
                            {
                                b.Enabled = true;
                            }

                        }
                    }
                    break;
                case "Sunday":
                    if (hm.DomingoEntrada == null)
                    {
                        horariosMañana(false);
                    }
                    if (ht.DomingoSalida == null)
                    {
                        horariosTarde(false);
                    }
                    else
                    {
                        foreach (Button b in pnlBotones.Controls)
                        {
                            if (hm.DomingoEntrada.Value.Hour > Convert.ToInt32(b.Text.Substring(0, 2)))
                            {
                                b.Enabled = false;
                                b.BackColor = Color.Gray;
                            }
                            else if (hm.DomingoSalida.Value.Hour <= Convert.ToInt32(b.Text.Substring(0, 2)) && Convert.ToInt32(b.Text.Substring(0, 2)) < 14)
                            {
                                b.Enabled = false;
                                b.BackColor = Color.Gray;
                            }
                            else if (ht.DomingoEntrada.Value.Hour > Convert.ToInt32(b.Text.Substring(0, 2)) && Convert.ToInt32(b.Text.Substring(0, 2)) >= 14)
                            {
                                b.Enabled = false;
                                b.BackColor = Color.Gray;
                            }
                            else if (ht.DomingoSalida.Value.Hour <= Convert.ToInt32(b.Text.Substring(0, 2)))
                            {
                                b.Enabled = false;
                                b.BackColor = Color.Gray;
                            }
                            else
                            {
                                b.Enabled = true;
                            }

                        }
                    }
                    break;
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

            sobreTurno = rst.obtenerSobreturnoVista(med.Id, dtpFecha.Value.Date);

            foreach (clsSobreTurnoVista sobTur in sobreTurno)
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
            bool inicio = false;
            try
            {
                foreach (clsEspecialidad esp in re.Todo())
                {
                    especialidades.Add(esp.Descripcion);
                    espec.Add(esp);
                    if(!inicio)
                        inicio = true;
                }
                if (inicio)
                {
                    cbEspecialidades.DataSource = especialidades;
                    cbMedicos.DataSource = null;
                    cbEspecialidades.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Se ha producido un error al iniciar, por favor, cierre la aplicación e iniciela nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha pruducido el Sgte. error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cargarGrillas();
        }

        private void btnTurnoXDia_Click(object sender, EventArgs e)
        {

            if (cbMedicos.SelectedIndex > -1)
            {
                fecha = dtpFecha.Value.Date;

                turnosVista.Clear();
                sobreTurnoVista.Clear();
                turnosVista = rt.obtenerTurnoVista(med.Id, dtpFecha.Value);
                sobreTurnoVista = rst.obtenerSobreturnoVista(med.Id, dtpFecha.Value);
                botonesDisponibles();

                turnosDados(turnos);

                sobreTurnosDados(sobreTurno);

                mañana = rm.BuscarHorarioMañana(med.Id);
                tarde = rm.BuscarHorarioTarde(med.Id);

                pnlBotones.Enabled = true;

                btnTurnoXDia.Focus();
            }
            else
            {
                MessageBox.Show("Seleccione medico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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

        public void sobreTurnosDados(List<clsSobreTurnoVista> sobreTurnos)
        {
            foreach (clsSobreTurnoVista sturno in sobreTurnos)
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
            if ((sender as Button).Tag.ToString() == "turno")
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
            DialogResult res = MessageBox.Show("Confirme turno: Medico " + med.Apellido + " paciente, " + pac.nomCompleto() + " " + fecha.ToLongDateString() + " " + btn.Text, "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                DateTime d = new DateTime(fecha.Year, fecha.Month, fecha.Day, Convert.ToInt32(btn.Text.Substring(0, 2)), Convert.ToInt32(btn.Text.Substring(3, 2)),0 );
                clsTurno t = new clsTurno(med.Id, pac.Id, d, u.Id);
                foreach (clsEspecialidad e in espec)
                {
                    if (e.Descripcion == med.Especialidad)
                    {
                        t.Costo = e.Canon;
                    }
                }
                //List<clsTurno> lt = rt.obtenerTurno(med.Id, t.Fecha);
                try
                {
                    rt.Alta(t);
                    cargarGrillas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se ha producido el Sgte. error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void darSobreTurno(Button btn)
        {
            DialogResult res = MessageBox.Show("Confirme SOBRE Turno: Medico " + med.Apellido + " paciente, " + pac.nomCompleto() + " " + fecha.ToLongDateString() + " " + btn.Text, "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                DateTime d = new DateTime(fecha.Year, fecha.Month, fecha.Day, Convert.ToInt32(btn.Text.Substring(0, 2)), Convert.ToInt32(btn.Text.Substring(3, 2)), 0);
                clsSobreturno t = new clsSobreturno(med.Id, pac.Id, d, espec[cbEspecialidades.SelectedIndex].Canon, u.Id, false);
                foreach (clsEspecialidad e in espec)
                {
                    if (e.Descripcion == med.Especialidad)
                    {
                        t.Costo = e.Canon;
                    }
                }
                //List<clsTurno> lt = rt.obtenerTurno(med.Id, t.Fecha);

                try
                {
                    rst.Alta(t);
                    cargarGrillas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se ha producido el Sgte. error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void cbMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMedicos.SelectedIndex > -1)
            {
                med = medicos[cbMedicos.SelectedIndex];
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (rbTurnos.Checked)
            {
                if (!string.IsNullOrWhiteSpace(turnosVista[dgvEliminarTurnos.CurrentRow.Index].Medico.Id.ToString()))
                {
                    try
                    {

                        rt.Baja(turnosVista[dgvEliminarTurnos.CurrentRow.Index]);
                        MessageBox.Show("El turno se elimino con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Se ha producido el Sgte. error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(sobreTurnoVista[dgvEliminarSobreTurnos.CurrentRow.Index].Medico.Id.ToString()))
                {
                    try
                    {
                        rst.Baja(sobreTurnoVista[dgvEliminarTurnos.CurrentRow.Index]);
                        MessageBox.Show("El turno se elimino con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Se ha producido el Sgte. error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void rbTurnos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTurnos.Checked)
            {
                dgvEliminarTurnos.Enabled = true;
                dgvEliminarSobreTurnos.Enabled = false;
            }
            else
            {
                dgvEliminarTurnos.Enabled = false;
                dgvEliminarSobreTurnos.Enabled = true;
            }
        }

        private void cargarGrillas()
        {
            dgvEliminarTurnos.Rows.Clear();
            dgvEliminarSobreTurnos.Rows.Clear();
            try
            {
                if (rt.Todo(pagina).Count > 0)
                {
                    turnosVista.Clear();
                    turnosVista = rt.TodoVista(pagina);
                    foreach (clsTurnoVista t in turnosVista)
                    {
                        dgvEliminarTurnos.Rows.Add(t.Fecha, t.Medico.nombreCompleto(), t.Paciente.nomCompleto(), t.Costo);
                    }
                }
                if (rst.Todo(pagina).Count > 0)
                {
                    sobreTurnoVista.Clear();
                    sobreTurnoVista = rst.TodoVista(pagina);
                    foreach (clsSobreTurnoVista st in sobreTurnoVista)
                    {
                        dgvEliminarSobreTurnos.Rows.Add(st.Fecha, st.Medico.nombreCompleto(), st.Paciente.nomCompleto(), st.Costo);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido el Sgte. error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

