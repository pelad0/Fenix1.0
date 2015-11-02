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
using entidades;
using logica;


namespace Fenix1._0
{
    public partial class frmABMES : Form
    {

        List<clsEspecialidad> especialidades;
        RepositorioEspecialidad reposEspe = new RepositorioEspecialidad();

        clsEspecialidad esEditar;

        Boolean editar = false;
    



        public frmABMES()
        {
            InitializeComponent();
        }

        private void btnAltaEspecialidad_Click(object sender, EventArgs e)
        {
            
            if(!string.IsNullOrWhiteSpace(tbEspecialidadAlta.Text))
            {

                try
                {
                    clsEspecialidad es = new clsEspecialidad(tbEspecialidadAlta.Text);
                    reposEspe.Alta(es);
                    Actualizar();
                    tbEspecialidadAlta.Clear();
                    tbEspecialidadAlta.Focus();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos para continuar", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            
            

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {



            int id = int.Parse(dgvEspecialidadesModificar.Rows[dgvEspecialidadesModificar.CurrentRow.Index].Cells[0].Value.ToString());
             
            esEditar = reposEspe.buscarPorId(id);

            tbEspecialidaModi.Text = esEditar.Descripcion;

            editar = true;


        }

        private void frmABMES_Load(object sender, EventArgs e)
        {
            Actualizar();
     
        }


        public void Actualizar()
        {
            if (dgvEspecialidadesAlta.Rows.Count > 0)
            {
                dgvEspecialidadesAlta.Columns.Remove("idEspecialidad");
                dgvEspecialidadesAlta.Columns.Remove("Descripcion");

                foreach (DataGridViewRow row in dgvEspecialidadesAlta.Rows)
                {
                    dgvEspecialidadesAlta.Rows.Remove(row);
                }

            }


            if (dgvEspecialidadesBaja.Rows.Count > 0)
            {
                dgvEspecialidadesBaja.Columns.Remove("idEspecialidad");
                dgvEspecialidadesBaja.Columns.Remove("Descripcion");

                foreach (DataGridViewRow row in dgvEspecialidadesBaja.Rows)
                {
                    dgvEspecialidadesBaja.Rows.Remove(row);
                }

            }

            if (dgvEspecialidadesModificar.Rows.Count > 0)
            {
                dgvEspecialidadesModificar.Columns.Remove("idEspecialidad");
                dgvEspecialidadesModificar.Columns.Remove("Descripcion");

                foreach (DataGridViewRow row in dgvEspecialidadesModificar.Rows)
                {
                    dgvEspecialidadesModificar.Rows.Remove(row);
                }

            }

           


            especialidades = reposEspe.Todo();      //LE ASIGNO A MI LISTA DE ESPE TODAS LAS ESPE.


            dgvEspecialidadesAlta.Columns.Add("idEspecialidad", "idEspecialidad");
            dgvEspecialidadesAlta.Columns["idEspecialidad"].Visible = false;
            dgvEspecialidadesAlta.Columns.Add("Descripcion", "Descripcion");

            
            dgvEspecialidadesBaja.Columns.Add("idEspecialidad", "idEspecialidad");
            dgvEspecialidadesBaja.Columns["idEspecialidad"].Visible = false;
            dgvEspecialidadesBaja.Columns.Add("Descripcion", "Descripcion");

            dgvEspecialidadesModificar.Columns.Add("idEspecialidad", "idEspecialidad");
            dgvEspecialidadesModificar.Columns["idEspecialidad"].Visible = false;
            dgvEspecialidadesModificar.Columns.Add("Descripcion", "Descripcion");


            foreach (clsEspecialidad espe in especialidades)
            {
                dgvEspecialidadesAlta.Rows.Add(espe.Id, espe.Descripcion);
                dgvEspecialidadesBaja.Rows.Add(espe.Id, espe.Descripcion);
                dgvEspecialidadesModificar.Rows.Add(espe.Id, espe.Descripcion);

            }

           


        }

        

        private void btnBaja_Click(object sender, EventArgs e)
        {         
            
            clsEspecialidad esBaja = new clsEspecialidad();

            int id = int.Parse(dgvEspecialidadesBaja.Rows[dgvEspecialidadesBaja.CurrentRow.Index].Cells[0].Value.ToString());

            esBaja = reposEspe.buscarPorId(id);

            reposEspe.Baja(esBaja);

            MessageBox.Show("Especialidad dada de baja");

            Actualizar();
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(editar == true)
            {
                if (!string.IsNullOrWhiteSpace(tbEspecialidaModi.Text))
                {
                    esEditar.Descripcion = tbEspecialidaModi.Text;
                    reposEspe.Modificacion(esEditar);
                    MessageBox.Show("Especialidad modificada");
                    tbEspecialidaModi.Clear();
                    Actualizar();

                }
                else
                {
                    MessageBox.Show("Debe llenar todos los campos para continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
                MessageBox.Show("Debe seleccionar una especialidad para editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void tpBaja_Click(object sender, EventArgs e)
        {
           
        }

        private void tcABM_Click(object sender, EventArgs e)
        {
            dgvEspecialidadesAlta.Rows[0].Selected = false;
            dgvEspecialidadesBaja.Rows[0].Selected = false;
            dgvEspecialidadesModificar.Rows[0].Selected = false;
        }

   

     


        

        
    }
}
