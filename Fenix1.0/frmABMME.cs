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
        public frmABMME()
        {
            InitializeComponent();  
        }
              

        RepositorioMedico reposMedico=new RepositorioMedico();

        List<clsMedico> medicos;

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
                //medico.Especialidad = cbEspecialidades.Text; ACA NECESITO DALE AL MEDICO EL ID DE LA ESPECIALIDAD
                medico.ObraSocial = obra;


                reposMedico.Alta(medico);
                
            }

            

            
        }

        public bool verificarMedico()       //Chekea todo menos horarios.
        {
            if (string.IsNullOrWhiteSpace(tbMatriculaAlta.Text.ToString()) != true || string.IsNullOrWhiteSpace(tbDniAlta.Text.ToString()) != true || string.IsNullOrWhiteSpace(tbNombreAlta.Text) != true || string.IsNullOrWhiteSpace(tbApellidoAlta.Text) != true || string.IsNullOrWhiteSpace(cbEspecialidades.Text) == false)
            {                   
                                 
                MessageBox.Show("Debe seleccionar al menos una especialidad para el médico.");
                return false;               

            }
            else
            {
                MessageBox.Show("Debe completar todos los campos para continuar");
                return false;
            }


        }

        public void Actualizar()
        {
            medicos.Clear();


            
             
            //foreach (IEntidad ent in metodosMedicos.Todo())
            //{
            //    medicos.Add((clsMedico)ent);
            //}
             
             


            //Muesto solamente matricula y apellido de cada médico en cada dgv.

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

              


        }



        private void frmABMME_Load(object sender, EventArgs e)
        {
            //Actualizar();
        }

        private void btnHorarios_Click(object sender, EventArgs e)
        {
            frmHorariosMedico frmHorarios = new frmHorariosMedico();
            frmHorarios.ShowDialog();

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

        

        
        
    }
}
