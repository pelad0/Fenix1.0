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

        clsMedico med;

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

            //CARGO OBRAS SOCUALES. COMPARO CON LAS QUE TRAIGO PARA VER CUALES YA ESTAN CHECKEADAS Y CUALES NO

            


        }
    }
}
