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
using logica;
using System.Web;


namespace Fenix1._0
{
    public partial class frmABMME : Form
    {

        clsHorario HorariosMT = new clsHorario();
        clsHorario HorariosTC = new clsHorario();
        int horaTrabajo = 0;       //Si es 1 trabaja solo mañana, si es 2 trabaja solo tarde, si es 3 ambos.
        int pagina = 0;
        List<clsObraXMedico> obraXmed = new List<clsObraXMedico>();
        List<clsEspecialidad> listaEspecialidades = new List<clsEspecialidad>();
        List<clsMedico> medicos = new List<clsMedico>();
        List<clsObraSocial> listaObraSocial = new List<clsObraSocial>();
        RepositorioObraPorMedico repoObraPorMed = new RepositorioObraPorMedico();
        RepositorioObraSocial reposObraSocial = new RepositorioObraSocial();
        RepositorioEspecialidad reposEspecialidad = new RepositorioEspecialidad();
        RepositorioMedico reposMedico = new RepositorioMedico();
        RepositorioHorario reposHorario = new RepositorioHorario();

        public frmABMME()
        {
            InitializeComponent();  
        }

        public void CargarHorarios(clsHorario horariomt, int horita)        //Constructor que solo recibe horarios de MedioTiempo.
        {
            HorariosMT = horariomt;
            horaTrabajo = horita;
            MessageBox.Show("Horarios cargados");
        }

        public void CargarHorarios(clsHorario horariomt, clsHorario horariotc)      //Contructor que recibe los dos horarios.
        {
            HorariosMT = horariomt;
            HorariosTC = horariotc;
            horaTrabajo = 3;
            MessageBox.Show("Horarios cargados");

        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {

                if (verificarMedico())       //Se puede dar de alta.
                {
                    clsMedico medico = new clsMedico();

                    medico.Matricula = int.Parse(tbMatriculaAlta.Text);
                    medico.Dni = long.Parse(tbDniAlta.Text);
                    medico.Nombre = tbNombreAlta.Text;
                    medico.Apellido = tbApellidoAlta.Text;
                    medico.Especialidad = cbEspecialidades.Text;
                    reposMedico.Alta(medico);

                    //CREO LA RELACION HORARIO POR MEDICO.
                    long dni = medico.Dni;
                    medico = reposMedico.BuscarPorDni(dni);     //NECESITO ESTE METODO PARA PODER CONSEGUIR EL ID DEL MEDICO.....

                    if (horaTrabajo == 3)    //QUE TRABAJA MAÑANA Y TARDE.
                    {
                        HorariosMT.IdMedico = medico.Id;
                        HorariosTC.IdMedico = medico.Id;
                        reposHorario.Alta(HorariosMT, HorariosTC);
                    }
                    else
                    {
                        if (horaTrabajo == 1)       //QUE TRABAJA MAÑANA.
                        {
                            HorariosMT.IdMedico = medico.Id;
                            reposHorario.Alta(HorariosMT, 1);
                        }
                        else                        //QUE TRABAJA TARDE.
                        {
                            if (horaTrabajo == 2)
                            {
                                HorariosMT.IdMedico = medico.Id;
                                reposHorario.Alta(HorariosMT, 2);
                            }
                        }
                    }

                    //CREO LA RELACION HORARIO OBRA POR MEDICO.
                    List<string> listaNombresObra = new List<string>();

                    foreach (Object item in clbObraSocial.CheckedItems)      //CARGO TODAS LAS OBRAS SOCIALES SELECCIONADAS.
                    {
                        listaNombresObra.Add(item.ToString());
                    }

                    List<clsObraSocial> obr = new List<clsObraSocial>();        //Variable con todas mis obras

                    obr = reposObraSocial.Todo(0);          //le doy todas las obras

                    foreach (clsObraSocial obrita in obr)        //por cada obra existente
                    {
                        foreach (string obra in listaNombresObra)        //por cada obra seleccionada
                        {
                            if (obrita.Nombre == obra)           //si el nombre es igual obtengo el id y creo la relacion
                            {
                                clsObraXMedico obraPormed = new clsObraXMedico();
                                obraPormed.IdMedico = medico.Id;
                                obraPormed.IdObra = obrita.Id;

                                repoObraPorMed.Alta(obraPormed);
                            }
                        }
                    }
                    MessageBox.Show("Médico dado de alta","Exito",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    LimpiarControles();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Se ha producido el Sgte. error al cargar al médico: "+ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        public bool verificarMedico()       //Chekea todo menos horarios.
        {
            if (string.IsNullOrWhiteSpace(tbMatriculaAlta.Text.ToString()) == true || string.IsNullOrWhiteSpace(tbDniAlta.Text.ToString()) == true || string.IsNullOrWhiteSpace(tbNombreAlta.Text) == true || string.IsNullOrWhiteSpace(tbApellidoAlta.Text) == true || string.IsNullOrWhiteSpace(cbEspecialidades.Text) == true)
            {               
                MessageBox.Show("Debe completar todos los campos para continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;               
            }
            if (horaTrabajo == 0)
            {
                MessageBox.Show("Horarios de trabajo no establecidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if(tbDniAlta.Text.Length != 8)
                {
                    MessageBox.Show("DNI incorrencto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public void Actualizar()
        {
            try
            {
                if(dgvMedicosAlta.Rows.Count > 0)
                {
                    dgvMedicosAlta.Rows.Clear();

                }

                if(dgvMedicosBaja.Rows.Count > 0)
                {
                    dgvMedicosBaja.Columns.Remove("idTurno");
                    dgvMedicosBaja.Columns.Remove("Matricula");
                    dgvMedicosBaja.Columns.Remove("Apellido");

                    foreach (DataGridViewRow row in dgvMedicosBaja.Rows)
                    {
                        dgvMedicosBaja.Rows.Remove(row);
                    }
                }

                if(dgvMedicosModi.Rows.Count > 0)
                {
                    dgvMedicosModi.Columns.Remove("idTurno");
                    dgvMedicosModi.Columns.Remove("Matricula");
                    dgvMedicosModi.Columns.Remove("Apellido");

                    foreach (DataGridViewRow row in dgvMedicosModi.Rows)
                    {
                        dgvMedicosModi.Rows.Remove(row);
                    }
                }

                tbEspecialidadAlta.Clear();
                tbEspecialidadBaja.Clear();
                tbEspecialidadModi.Clear();

                if (dgvObrasSocialesAlta.Rows.Count > 0)     //PREGUNTO PARAQUE ELIMINE LA COLUMNA, SOLO SI SE AH CREANDO ATNES.
                {
                    dgvObrasSocialesAlta.Columns.Remove("Nombre");

                    foreach (DataGridViewRow row in dgvObrasSocialesAlta.Rows)
                    {
                        dgvObrasSocialesAlta.Rows.Remove(row);
                    }
                }

                if (dgvObrasSocialesBaja.Rows.Count > 0)     //PREGUNTO PARAQUE ELIMINE LA COLUMNA, SOLO SI SE AH CREANDO ATNES.
                {
                    dgvObrasSocialesBaja.Columns.Remove("Nombre");

                    foreach (DataGridViewRow row in dgvObrasSocialesBaja.Rows)
                    {
                        dgvObrasSocialesBaja.Rows.Remove(row);
                    }
                }

                if (dgvObrasSocialesModi.Rows.Count > 0)     //PREGUNTO PARAQUE ELIMINE LA COLUMNA, SOLO SI SE AH CREANDO ATNES.
                {
                    dgvObrasSocialesModi.Columns.Remove("Nombre");

                    foreach (DataGridViewRow row in dgvObrasSocialesModi.Rows)
                    {
                        dgvObrasSocialesModi.Rows.Remove(row);
                    }
                }
                
                medicos.Clear();        
                medicos = reposMedico.Todo(pagina);

                //Muesto solamente matricula y apellido de cada médico en cada dgv y escondo ID.

                dgvMedicosAlta.Columns.Add("idTurno", "idTurno");
                dgvMedicosAlta.Columns["idTurno"].Visible = false;
                dgvMedicosAlta.Columns.Add("Matricula", "Matricula");
                dgvMedicosAlta.Columns.Add("Apellido", "Apellido");

                dgvMedicosBaja.Columns.Add("idTurno", "idTurno");
                dgvMedicosBaja.Columns["idTurno"].Visible = false;
                dgvMedicosBaja.Columns.Add("Matricula", "Matricula");
                dgvMedicosBaja.Columns.Add("Apellido", "Apellido");

                dgvMedicosModi.Columns.Add("idTurno", "idTurno");
                dgvMedicosModi.Columns["idTurno"].Visible = false;
                dgvMedicosModi.Columns.Add("Matricula", "Matricula");
                dgvMedicosModi.Columns.Add("Apellido", "Apellido");

                foreach (clsMedico med in medicos)
                {                    
                    dgvMedicosAlta.Rows.Add(med.Id, med.Matricula, med.Apellido);
                    dgvMedicosBaja.Rows.Add(med.Id, med.Matricula, med.Apellido);
                    dgvMedicosModi.Rows.Add(med.Id, med.Matricula, med.Apellido);
                }

                //Cargo obras sociales y especialidades.
                clbObraSocial.Items.Clear();
                cbEspecialidades.Items.Clear();

                // CARGO ESPECIALIDADES.
                listaEspecialidades = reposEspecialidad.Todo();

                foreach (clsEspecialidad es in listaEspecialidades)
                {
                    cbEspecialidades.Items.Add(es.Descripcion);
                }

                //CARGO OBRAS SOCIALES
                listaObraSocial = reposObraSocial.Todo(0);

                foreach (clsObraSocial obr in listaObraSocial)
                {
                    if (!obr.Nombre.Equals("NINGUNA"))
                    {
                        clbObraSocial.Items.Add(obr.Nombre);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Test"+ex.Message);
            }
        }

        private void frmABMME_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnHorarios_Click(object sender, EventArgs e)
        {

            frmHorariosMedico frmHorarios = new frmHorariosMedico(this);
            frmHorarios.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            clsMedico medico = new clsMedico();
           
            //TOMO EL ID DEL MEDICO SELECCIONADO Y TRAIGO SUS DATOS CON METODO BUSCAR POR ID
            int id = int.Parse(dgvMedicosModi.Rows[dgvMedicosModi.CurrentRow.Index].Cells[0].Value.ToString());

            medico = reposMedico.buscarPorId(id);

            //LLAMO AL FORMULARIO QUE EDITA EL MEDICO, CON TODOS LOS DATOS ACTUALES DE EL MEDICO A EDITAR.

            frmEditarMedico editarMedico = new frmEditarMedico(medico);
            editarMedico.ShowDialog();
            Actualizar();
        }

        private void btnAnteriorAlta_Click(object sender, EventArgs e)
        {

            if (pagina == 0)
            {
                MessageBox.Show("No hay registros anteriores para mostrar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                pagina--;

                //LIMPIO TODO DEL DGVMEDICOSALTA.
                dgvMedicosAlta.Rows.Clear();
                dgvMedicosAlta.Columns.Clear();

                //LIMPIO EL TBESPECIALIDAD
                tbEspecialidadAlta.Clear();

                //LIMPIO TODO DEL DGVOBRASSOCIALES
                if (dgvObrasSocialesAlta.Rows.Count > 0)     //PREGUNTO PARAQUE ELIMINE LA COLUMNA, SOLO SI SE AH CREANDO ATNES.
                {
                    dgvObrasSocialesAlta.Columns.Remove("Nombre");
                    dgvObrasSocialesAlta.Rows.Clear();
                    }

                medicos.Clear();

                medicos = reposMedico.Todo(pagina);

                //Muesto solamente matricula y apellido de cada médico en cada dgv y escondo ID.
                dgvMedicosAlta.Columns.Add("idTurno", "idTurno");
                dgvMedicosAlta.Columns["idTurno"].Visible = false;
                dgvMedicosAlta.Columns.Add("Matricula", "Matricula");
                dgvMedicosAlta.Columns.Add("Apellido", "Apellido");

                foreach (clsMedico med in medicos)
                {
                    dgvMedicosAlta.Rows.Add(med.Id, med.Matricula, med.Apellido);
                }
            }
        }

        private void btnSiguientesAlta_Click(object sender, EventArgs e)
        {
            pagina++;            

            //LIMPIO TODO DEL DGVMEDICOSALTA.
            dgvMedicosAlta.Rows.Clear();
            dgvMedicosAlta.Columns.Clear();

            //LIMPIO EL TBESPECIALIDAD
            tbEspecialidadAlta.Clear();

            //LIMPIO TODO DEL DGVOBRASSOCIALES
            if(dgvObrasSocialesAlta.Rows.Count > 0)     //PREGUNTO PARAQUE ELIMINE LA COLUMNA, SOLO SI SE AH CREANDO ATNES.
            {
                dgvObrasSocialesAlta.Columns.Remove("Nombre");
                dgvObrasSocialesAlta.Rows.Clear();
                }

            medicos.Clear();
            medicos = reposMedico.Todo(pagina);

            //Muesto solamente matricula y apellido de cada médico en cada dgv y escondo ID.

            dgvMedicosAlta.Columns.Add("idTurno", "idTurno");
            dgvMedicosAlta.Columns["idTurno"].Visible = false;
            dgvMedicosAlta.Columns.Add("Matricula", "Matricula");
            dgvMedicosAlta.Columns.Add("Apellido", "Apellido");

            foreach (clsMedico med in medicos)
            {
                dgvMedicosAlta.Rows.Add(med.Id, med.Matricula, med.Apellido);
            }
        }

        private void btnAnteriorBaja_Click(object sender, EventArgs e)
        {
            if (pagina == 0)
            {
                MessageBox.Show("No hay registros anteriores para mostrar", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            else
            {
                pagina--;

                //LIMPIO TODO DEL DGVMEDICOSBAJA.
                dgvMedicosBaja.Rows.Clear();
                dgvMedicosBaja.Columns.Clear();

                //LIMPIO EL TBESPECIALIDAD
                tbEspecialidadBaja.Clear();

                //LIMPIO TODO DEL DGVOBRASSOCIALES
                if (dgvObrasSocialesBaja.Rows.Count > 0)     //PREGUNTO PARAQUE ELIMINE LA COLUMNA, SOLO SI SE AH CREANDO ATNES.
                {
                    dgvObrasSocialesBaja.Columns.Remove("Nombre");
                    dgvObrasSocialesBaja.Rows.Clear();
                }

                medicos.Clear();

                medicos = reposMedico.Todo(pagina);

                //Muesto solamente matricula y apellido de cada médico en cada dgv y escondo ID.

                dgvMedicosBaja.Columns.Add("idTurno", "idTurno");
                dgvMedicosBaja.Columns["idTurno"].Visible = false;
                dgvMedicosBaja.Columns.Add("Matricula", "Matricula");
                dgvMedicosBaja.Columns.Add("Apellido", "Apellido");

                foreach (clsMedico med in medicos)
                {
                    dgvMedicosBaja.Rows.Add(med.Id, med.Matricula, med.Apellido);
                }
            }
        }

        private void btnSiguienteBaja_Click(object sender, EventArgs e)
        {
            pagina++;

            //LIMPIO TODO DEL DGVMEDICOSBAJA.
            dgvMedicosBaja.Rows.Clear();
            dgvMedicosBaja.Columns.Clear();

            //LIMPIO EL TBESPECIALIDAD
            tbEspecialidadBaja.Clear();

            if (dgvObrasSocialesBaja.Rows.Count > 0)     //PREGUNTO PARAQUE ELIMINE LA COLUMNA, SOLO SI SE AH CREANDO ATNES.
            {
                dgvObrasSocialesBaja.Columns.Remove("Nombre");
                dgvObrasSocialesBaja.Rows.Clear();
            }

            medicos.Clear();

            medicos = reposMedico.Todo(pagina);

            //Muesto solamente matricula y apellido de cada médico en cada dgv y escondo ID.

            dgvMedicosBaja.Columns.Add("idTurno", "idTurno");
            dgvMedicosBaja.Columns["idTurno"].Visible = false;
            dgvMedicosBaja.Columns.Add("Matricula", "Matricula");
            dgvMedicosBaja.Columns.Add("Apellido", "Apellido");

            foreach (clsMedico med in medicos)
            {
                dgvMedicosBaja.Rows.Add(med.Id, med.Matricula, med.Apellido);
            }
        }

        private void btnAnteriorModi_Click(object sender, EventArgs e)
        {
            if (pagina == 0)
            {
                MessageBox.Show("No hay registros anteriores para mostrar", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }         
            else
            {
                pagina--;

                //LIMPIO TODO DEL DGVMEDICOSBAJA.
                dgvMedicosModi.Rows.Clear();
                dgvMedicosModi.Columns.Clear();

                //LIMPIO EL TBESPECIALIDAD
                tbEspecialidadModi.Clear();
                    
                //LIMPIO TODO DEL DGVOBRASSOCIALES
                if (dgvObrasSocialesModi.Rows.Count > 0)     //PREGUNTO PARAQUE ELIMINE LA COLUMNA, SOLO SI SE AH CREANDO ATNES.
                {
                    dgvObrasSocialesModi.Columns.Remove("Nombre");
                    dgvObrasSocialesModi.Rows.Clear();
                }

                medicos.Clear();
                medicos = reposMedico.Todo(pagina);

                //Muesto solamente matricula y apellido de cada médico en cada dgv y escondo ID.
                dgvMedicosModi.Columns.Add("idTurno", "idTurno");
                dgvMedicosModi.Columns["idTurno"].Visible = false;
                dgvMedicosModi.Columns.Add("Matricula", "Matricula");
                dgvMedicosModi.Columns.Add("Apellido", "Apellido");

                foreach (clsMedico med in medicos)
                {
                    dgvMedicosModi.Rows.Add(med.Id, med.Matricula, med.Apellido);
                }
            }
        }

        private void btnSiguienteModi_Click(object sender, EventArgs e)
        {
            pagina++;

            //LIMPIO TODO DEL DGVMEDICOSMODI.
            dgvMedicosModi.Rows.Clear();
            dgvMedicosModi.Columns.Clear();

            //LIMPIO EL TBESPECIALIDAD
            tbEspecialidadModi.Clear();

            if (dgvObrasSocialesModi.Rows.Count > 0)     //PREGUNTO PARAQUE ELIMINE LA COLUMNA, SOLO SI SE AH CREANDO ATNES.
            {
                dgvObrasSocialesModi.Columns.Remove("Nombre");
                dgvObrasSocialesModi.Rows.Clear();
            }

            medicos.Clear();
            medicos = reposMedico.Todo(pagina);

            //Muesto solamente matricula y apellido de cada médico en cada dgv y escondo ID.
            dgvMedicosModi.Columns.Add("idTurno", "idTurno");
            dgvMedicosModi.Columns["idTurno"].Visible = false;
            dgvMedicosModi.Columns.Add("Matricula", "Matricula");
            dgvMedicosModi.Columns.Add("Apellido", "Apellido");

            foreach (clsMedico med in medicos)
            {
                dgvMedicosModi.Rows.Add(med.Id, med.Matricula, med.Apellido);
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {

            clsMedico med = new clsMedico();

            int id = int.Parse(dgvMedicosBaja.Rows[dgvMedicosBaja.CurrentRow.Index].Cells[0].Value.ToString());

            med = reposMedico.buscarPorId(id);

            reposMedico.Baja(med);

            MessageBox.Show("Médico dado de baja");

            Actualizar();
        }

        private void dgvMedicosAlta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvObrasSocialesAlta.Columns.Count > 0)     //PREGUNTO PARAQUE ELIMINE LA COLUMNA, SOLO SI SE AH CREANDO ATNES.
            {
                dgvObrasSocialesAlta.Columns.Remove("Nombre");
                foreach (DataGridViewRow row in dgvObrasSocialesAlta.Rows)
                {
                    dgvObrasSocialesAlta.Rows.Remove(row);
                }
            }

            tbEspecialidadAlta.Clear();

            //CARGO OBRAS SOCIALES
            dgvObrasSocialesAlta.Columns.Add("Nombre", "Nombre");

            int idMed = int.Parse(dgvMedicosAlta.Rows[dgvMedicosAlta.CurrentRow.Index].Cells[0].Value.ToString());            
            obraXmed = repoObraPorMed.TodasObras(idMed); 
            clsObraSocial obraSocial;
            foreach(clsObraXMedico obramed in obraXmed)
            {
                obraSocial = reposObraSocial.buscarPorId(obramed.IdObra);
                dgvObrasSocialesAlta.Rows.Add(obraSocial.Nombre);
            }

            clsMedico med;
            med = reposMedico.buscarPorId(idMed);
            tbEspecialidadAlta.Text = med.Especialidad; 
        }

        private void dgvMedicosBaja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvObrasSocialesBaja.Columns.Count > 0)     //PREGUNTO PARAQUE ELIMINE LA COLUMNA, SOLO SI SE HA CREANDO ATNES.
            {
                dgvObrasSocialesBaja.Columns.Remove("Nombre");
                dgvObrasSocialesBaja.Rows.Clear();
            }

            tbEspecialidadBaja.Clear();
            dgvObrasSocialesBaja.Columns.Add("Nombre", "Nombre");

            //CARGO OBRAS SOCIALES
            int idMed = int.Parse(dgvMedicosBaja.Rows[dgvMedicosBaja.CurrentRow.Index].Cells[0].Value.ToString());

            obraXmed = repoObraPorMed.TodasObras(idMed);

            clsObraSocial obraSocial;

            foreach(clsObraXMedico obramed in obraXmed)
            {
                obraSocial = reposObraSocial.buscarPorId(obramed.IdObra);
                dgvObrasSocialesBaja.Rows.Add(obraSocial.Nombre);
            }

            clsMedico med;

            med = reposMedico.buscarPorId(idMed);

            tbEspecialidadBaja.Text = med.Especialidad; 

        }

        private void dgvMedicosModi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (dgvObrasSocialesModi.Columns.Count > 0)     //PREGUNTO PARAQUE ELIMINE LA COLUMNA, SOLO SI SE HA CREANDO ATNES.
            {
                dgvObrasSocialesModi.Columns.Remove("Nombre");
                dgvObrasSocialesModi.Rows.Clear();
            }

            tbEspecialidadModi.Clear();

            dgvObrasSocialesModi.Columns.Add("Nombre", "Nombre");

            //CARGO OBRAS SOCIALES
            int idMed = int.Parse(dgvMedicosModi.Rows[dgvMedicosModi.CurrentRow.Index].Cells[0].Value.ToString());

            obraXmed = repoObraPorMed.TodasObras(idMed);

            clsObraSocial obraSocial;

            foreach (clsObraXMedico obramed in obraXmed)
            {
                obraSocial = reposObraSocial.buscarPorId(obramed.IdObra);
                dgvObrasSocialesModi.Rows.Add(obraSocial.Nombre);
            }

            clsMedico med;

            med = reposMedico.buscarPorId(idMed);

            tbEspecialidadModi.Text = med.Especialidad; 
            
        }

        private void tpAlta_Click(object sender, EventArgs e)
        {

        }

        private void btnAdministrarEspe_Click(object sender, EventArgs e)
        {
            frmABMES frmes = new frmABMES();
            frmes.ShowDialog();
            ActualizarObrasSociales();
        }

        public void LimpiarControles()
        {
            tbNombreAlta.Clear();
            tbApellidoAlta.Clear();
            tbDniAlta.Clear();
            tbMatriculaAlta.Clear();
            tbNombreAlta.Focus();
            Actualizar();
        }
        
        public void ActualizarObrasSociales()
        {
            cbEspecialidades.Items.Clear();
            listaEspecialidades = reposEspecialidad.Todo();
            foreach (clsEspecialidad es in listaEspecialidades)
            {
                cbEspecialidades.Items.Add(es.Descripcion);
            }
        }

    }
}
