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
                List<string> espe = new List<string>();
                List<string> obra = new List<string>();

                
                //cargo especialidades

                foreach (string index in clbEspecialidad.CheckedItems)
                {
                    espe.Add(index);

                }


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
                medico.Especialidad = espe;
                medico.ObraSocial = obra;


                reposMedico.Alta(medico);
                
            }

            

            
        }

        public bool verificarMedico()       //Chekea todo menos horarios.
        {
            if(string.IsNullOrEmpty(tbMatriculaAlta.Text.ToString()) != true  || string.IsNullOrEmpty(tbDniAlta.Text.ToString()) != true || string.IsNullOrEmpty(tbNombreAlta.Text) != true || string.IsNullOrEmpty(tbApellidoAlta.Text) != true)
            {
                if (clbEspecialidad.CheckedItems.Count > 0 )
                {
                    return true;
                }
                else
                {                    
                    MessageBox.Show("Debe seleccionar al menos una especialidad para el médico.");
                    return false;
                }

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

            List<string> espe = new List<string>();
            List<string> obra = new List<string>();


            //CARGO LOS DATOS DEL MEDICO SELECCIONADO
            medico.Id = int.Parse(dgvMedicosModi.Rows[dgvMedicosModi.CurrentRow.Index].Cells[0].Value.ToString());
            medico.Matricula = int.Parse(dgvMedicosModi.Rows[dgvMedicosModi.CurrentRow.Index].Cells[1].Value.ToString());
            medico.Dni = long.Parse(dgvMedicosModi.Rows[dgvMedicosModi.CurrentRow.Index].Cells[2].Value.ToString());
            medico.Nombre = dgvMedicosModi.Rows[dgvMedicosModi.CurrentRow.Index].Cells[3].Value.ToString();
            medico.Apellido = dgvMedicosModi.Rows[dgvMedicosModi.CurrentRow.Index].Cells[4].Value.ToString();

            //CARGO LISTAS DE OBRAS SOCIALES Y ESPECIALIDADES CON VALORES DEL DATA GRID VIEW.
            //CARGO ESPECIALIDADES.

            foreach (DataGridViewRow row in dgvEspecialidadesModi.Rows)
            {                
                espe.Add(row.Cells[0].Value.ToString());
            }

            //CARGO OBRAS SOCIALES.

            foreach (DataGridViewRow row in dgvObrasSocialesModi.Rows)
            {
                obra.Add(row.Cells[0].Value.ToString());
            }

            medico.Especialidad = espe;
            medico.ObraSocial = obra;







        }

        

        
        
    }
}
