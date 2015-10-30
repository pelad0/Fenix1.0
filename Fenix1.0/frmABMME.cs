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
    public partial class frmABMME : Form
    {
        public frmABMME()
        {
            InitializeComponent();
        }


        List<clsMedico> medicos;

        private void btnAlta_Click(object sender, EventArgs e)
        {
            //Falta verificar horarios de medico.

            if(verificarMedico())       //Se puede dar de alta.
            {
                List<string> espe = new List<string>();
                List<string> obra = new List<string>();

                //cargo especialidades
                foreach (int indexChecked in clbEspecialidad.CheckedIndices)
                {
                    espe.Add(clbEspecialidad.GetItemCheckState(indexChecked).ToString());
                }

                //cargo obras sociales
                foreach (int indexChecked in clbObraSocial.CheckedIndices)
                {
                    obra.Add(clbObraSocial.GetItemCheckState(indexChecked).ToString());
                }

                clsMedico medico = new clsMedico();

                medico.Matricula = int.Parse(tbMatriculaAlta.Text);
                medico.Dni = long.Parse(tbDniAlta.Text);
                medico.Nombre = tbNombreAlta.Text;
                medico.Apellido = tbApellidoAlta.Text;
                medico.Especialidad = espe;
                medico.ObraSocial = obra;

                //Aca llamo al metodo del monje.
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


            /*
             
            foreach (IEntidad ent in metodosMedicos.Todo())
            {
                medicos.Add((clsMedico)ent);
            }
             
             */

            dgvMedicosAlta.DataSource = null;
            dgvMedicosAlta.DataSource = medicos;
            dgvMedicosAlta.Columns[0].Visible = false;
            dgvMedicosAlta.Columns[2].Visible = false;
            dgvMedicosAlta.Columns[3].Visible = false;
            //Como hago para ocultar las columnas de especialidad y obra social???????

            dgvMedicosBaja.DataSource = null;
            dgvMedicosBaja.DataSource = medicos;

            dgvMedicosModi.DataSource = null;
            dgvMedicosModi.DataSource = medicos;



        }



        private void frmABMME_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        
        
    }
}
