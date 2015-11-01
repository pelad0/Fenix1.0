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

        clsHorario HorariosMT;
        clsHorario HorariosTC;
   
      
        int pagina = 0;


        List<clsObraXMedico> obraXmed = new List<clsObraXMedico>();
        List<clsEspecialidad> listaEspecialidades = new List<clsEspecialidad>();
        List<clsMedico> medicos;
        List<clsObraSocial> listaObraSocial = new List<clsObraSocial>();


        RepositorioObraPorMedico repoObraPorMed = new RepositorioObraPorMedico();
        RepositorioObraSocial reposObraSocial = new RepositorioObraSocial();
        RepositorioEspecialidad reposEspecialidad = new RepositorioEspecialidad();
        RepositorioMedico reposMedico = new RepositorioMedico();

        public frmABMME()
        {
            InitializeComponent();  
        }

        public frmABMME(clsHorario horariomt)       //Constructor que solo recibe horarios de MedioTiempo.
        {
            InitializeComponent();
            HorariosMT = horariomt;

        }
        
        public frmABMME(clsHorario horariomt, clsHorario horariotc)     //Contructor que recibe los dos horarios.
        {
            InitializeComponent();
            HorariosMT = horariomt;
            HorariosTC = horariotc;
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            //Falta verificar horarios de medico.

            if(verificarMedico())       //Se puede dar de alta.
            {
                List<string> obra = new List<string>();             
   
                //cargo obras sociales
                foreach (string index in clbObraSocial.CheckedItems)
                {
                    obra.Add(index);
                }

                clsMedico medico = new clsMedico();

                medico.Matricula = int.Parse(tbMatriculaAlta.Text);
                medico.Dni = long.Parse(tbDniAlta.Text);
                medico.Nombre = tbNombreAlta.Text;
                medico.Apellido = tbApellidoAlta.Text;
                medico.Especialidad = cbEspecialidades.Text; 
                medico.ObraSocial = obra;
                reposMedico.Alta(medico);


                //ACA TENGO QUE PASAR HORARIOS.
                
            }

            

            
        }

        public bool verificarMedico()       //Chekea todo menos horarios.
        {
            if (string.IsNullOrWhiteSpace(tbMatriculaAlta.Text.ToString()) == true || string.IsNullOrWhiteSpace(tbDniAlta.Text.ToString()) == true || string.IsNullOrWhiteSpace(tbNombreAlta.Text) == true || string.IsNullOrWhiteSpace(tbApellidoAlta.Text) == true || string.IsNullOrWhiteSpace(cbEspecialidades.Text) == true)
            {

                MessageBox.Show("Debe completar todos los campos para continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            dgvMedicosAlta.DataSource = null;
            dgvMedicosBaja.DataSource = null;
            dgvMedicosModi.DataSource = null;
            tbEspecialidadAlta.Clear();
            tbEspecialidadBaja.Clear();
            tbEspecialidadModi.Clear(); 
            dgvObrasSocialesAlta.DataSource = null;
            dgvObrasSocialesBaja.DataSource = null;
            dgvObrasSocialesModi.DataSource = null;                      

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

            foreach(clsEspecialidad es in listaEspecialidades)
            {
                cbEspecialidades.Items.Add(es.Descripcion);
            }


            listaObraSocial = reposObraSocial.Todo(0);

            foreach(clsObraSocial obr in listaObraSocial)
            {
                clbObraSocial.Items.Add(obr.Nombre);
            }




            


        }



        private void frmABMME_Load(object sender, EventArgs e)
        {
            //Actualizar();
        }

        private void btnHorarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHorariosMedico frmHorarios = new frmHorariosMedico();
            frmHorarios.ShowDialog();
            this.Close();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            clsMedico medico = new clsMedico();
           
            //List<string> obra = new List<string>();


            //TOMO EL ID DEL MEDICO SELECCIONADO Y TRAIGO SUS DATOS CON METODO BUSCAR POR ID
            int id = int.Parse(dgvMedicosModi.Rows[dgvMedicosModi.CurrentRow.Index].Cells[0].Value.ToString());

            medico = reposMedico.buscarPorId(id);


            //LLAMO AL FORMULARIO QUE EDITA EL MEDICO, CON TODOS LOS DATOS ACTUALES DE EL MEDICO A EDITAR.

            frmEditarMedico editarMedico = new frmEditarMedico(medico);




            //CARGO LISTA DE OBRAS SOCIALES DEL DATA GRID VIEW.
           
            //CARGO OBRAS SOCIALES.



            //foreach (DataGridViewRow row in dgvObrasSocialesModi.Rows)
            //{
            //    obra.Add(row.Cells[0].Value.ToString());
            //}
              
            //medico.ObraSocial = obra;







        }

        private void btnAnteriorAlta_Click(object sender, EventArgs e)
        {

            if (pagina == 0)
            {
                MessageBox.Show("No hay registros anteriores para mostrar", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            }

            else
            {
                pagina--;


                dgvMedicosAlta.DataSource = null;
                tbEspecialidadAlta.Clear();
                dgvObrasSocialesAlta.DataSource = null;



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


            dgvMedicosAlta.DataSource = null;
            tbEspecialidadAlta.Clear();
            dgvObrasSocialesAlta.DataSource = null;

            

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
               
                dgvMedicosBaja.DataSource = null;
                tbEspecialidadBaja.Clear();  
                dgvObrasSocialesBaja.DataSource = null;
     


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

            dgvMedicosBaja.DataSource = null;
            tbEspecialidadBaja.Clear();
            dgvObrasSocialesBaja.DataSource = null;



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

                dgvMedicosModi.DataSource = null;
                tbEspecialidadModi.Clear();           
                dgvObrasSocialesModi.DataSource = null;


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

            dgvMedicosModi.DataSource = null;
            tbEspecialidadModi.Clear();
            dgvObrasSocialesModi.DataSource = null;


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

            MessageBox.Show("Médico dado de alta");

        }

        private void dgvMedicosAlta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvObrasSocialesAlta.DataSource = null;
            tbEspecialidadAlta.Clear();


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

            dgvObrasSocialesBaja.DataSource = null;
            tbEspecialidadBaja.Clear();

            dgvObrasSocialesBaja.Columns.Add("Nombre", "Nombre");

            int idMed = int.Parse(dgvObrasSocialesBaja.Rows[dgvObrasSocialesBaja.CurrentRow.Index].Cells[0].Value.ToString());

            obraXmed = repoObraPorMed.TodasObras(idMed);

            clsObraSocial obraSocial;

            foreach(clsObraXMedico obramed in obraXmed)
            {
                obraSocial = reposObraSocial.buscarPorId(obramed.IdObra);
                dgvObrasSocialesBaja.Rows.Add(obraSocial.Nombre);
            }

            clsMedico med;

            med = reposMedico.buscarPorId(idMed);

            tbEspecialidadAlta.Text = med.Especialidad; 




        }

        private void dgvMedicosModi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {          
            dgvObrasSocialesModi.DataSource = null;
            tbEspecialidadModi.Clear();

            dgvObrasSocialesModi.Columns.Add("Nombre", "Nombre");

            int idMed = int.Parse(dgvObrasSocialesModi.Rows[dgvObrasSocialesModi.CurrentRow.Index].Cells[0].Value.ToString());

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

        
        

        
        
    }
}
