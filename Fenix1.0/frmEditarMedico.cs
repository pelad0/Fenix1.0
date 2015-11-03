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
    public partial class frmEditarMedico : Form
    {

        clsMedico med = new clsMedico();
        List<clsObraXMedico> obraXmed = new List<clsObraXMedico>();
        List<clsObraSocial> listaObras = new List<clsObraSocial>();
        RepositorioObraPorMedico repoObraPorMed = new RepositorioObraPorMedico();
        RepositorioObraSocial reposObraSocial = new RepositorioObraSocial();
        RepositorioEspecialidad reposEspe = new RepositorioEspecialidad();

        public frmEditarMedico(clsMedico med)
        {
            InitializeComponent();
            this.med = med;
        }

        private void frmEditarMedico_Load(object sender, EventArgs e)
        {
            tbNombreModi.Text = med.Nombre;
            tbApellidoModi.Text = med.Apellido;
            tbDniModi.Text = med.Dni.ToString();
            tbMatriculaModi.Text = med.Matricula.ToString();
            cbEspecialidadModi.Text = med.Especialidad;
            

       

            //CARGO ESPECIALIDADES A CB;

            List<clsEspecialidad> listaEspe = new List<clsEspecialidad>(); 

            listaEspe = reposEspe.Todo();

            foreach(clsEspecialidad es in listaEspe)
            {
                cbEspecialidadModi.Items.Add(es.Descripcion);
            }


            //CARGO OBRAS SOCIALES.

            obraXmed = repoObraPorMed.TodasObras(med.Id);

            clsObraSocial obraSocial;           

            listaObras = reposObraSocial.Todo(0);


            //CARGO TODAS LAS OBRAS SOCIALES Y TAMBIEN ME FIJO SI ESTAN EN EL MEDICO A EDITAR, SI ESO PASA, LAS CHECKEO EN TRUE.

            foreach (clsObraXMedico obramed in obraXmed)        //POR CADA OBRA DEL MEDICO
            {
                obraSocial = reposObraSocial.buscarPorId(obramed.IdObra);

                foreach(clsObraSocial obr in listaObras)            //POR CADA OBRA EXISTENTE
                {                   

                    if(obraSocial.Nombre == obr.Nombre)             //SI LOS NOMBRES SON IGUALES
                    {
                        clbObraSocial.Items.Add(obr.Nombre);

                        for (int i = 0; i < clbObraSocial.Items.Count; i++)
                        {
                            if(clbObraSocial.Items[i].ToString() == obraSocial.Nombre)
                            {
                                clbObraSocial.SetItemChecked(i, true);
                            }
                        }

                    }
                    
                }

              
            }



            


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditarHorarios_Click(object sender, EventArgs e)
        {
            frmHorariosMedico horariosMed = new frmHorariosMedico(med, this);
            horariosMed.ShowDialog();
        }
    }
}
