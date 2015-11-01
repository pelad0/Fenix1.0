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
    



        public frmABMES()
        {
            InitializeComponent();
        }

        private void btnAltaEspecialidad_Click(object sender, EventArgs e)
        {
            
            if(!string.IsNullOrWhiteSpace(tbEspecialidadAlta.Text))
            {
                clsEspecialidad es = new clsEspecialidad(tbEspecialidadAlta.Text);


                reposEspe.Alta(es);
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos para continuar", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            
            

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvEspecialidadesBaja.Rows[dgvEspecialidadesBaja.CurrentRow.Index].Cells[0].Value.ToString());

            esEditar = reposEspe.buscarPorId(id);


        }

        private void frmABMES_Load(object sender, EventArgs e)
        {
            //Actualizar();
        }


        public void Actualizar()
        {
            dgvEspecialidadesAlta.DataSource = null;
            dgvEspecialidadesBaja.DataSource = null;
            dgvEspecialidadesModificar.DataSource = null;
           


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
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbEspecialidaModi.Text))
            {
                esEditar.Descripcion = tbEspecialidaModi.Text;
                reposEspe.Modificacion(esEditar);

            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos para continuar", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
        }

     


        

        
    }
}
