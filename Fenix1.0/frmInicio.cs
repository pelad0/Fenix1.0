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
using frmABMME;
using Fenix1._0;


namespace Fenix1._0
{
    public partial class frmInicio : Form
    {

        RepositorioUsuario ru = new RepositorioUsuario();
        List<clsUsuario> usuarios = new List<clsUsuario>();
        clsUsuario u = new clsUsuario();

        public frmInicio()
        {
            InitializeComponent();
            iniciar();
        }

        public void iniciar()
        {
            try
            {
                usuarios.Clear();
                usuarios = ru.Todo(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido el Sgte. error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            bool paso = false;
            string seg = "";
            if (!string.IsNullOrWhiteSpace(tbUsuario.Text) && !string.IsNullOrWhiteSpace(tbClave.Text))
            {
                foreach (clsUsuario u in usuarios)
                {
                    if (u.Usuario == tbUsuario.Text)
                    {
                        if (u.Clave == tbClave.Text)
                        {
                            seg = u.Seguridad;

                            paso = true;
                        }
                    }
                }
            }
            if (paso)
            {
                ingresar(seg);
            }
        }

        private void ingresar(string seg)
        {
            switch (seg)
            {
                case "Administracion":
                    frmAdmin a = new frmAdmin(u, this);
                    this.Hide();
                    a.ShowDialog();
                    break;

                case "Recepcion":
                    frmRecepcion r = new frmRecepcion(u, this);
                    this.Hide();
                    r.ShowDialog();
                    break;

                case "Medico":
                    frmABMHistorial h = new frmABMHistorial(this);
                    this.Hide();
                    h.ShowDialog();
                    break;
            }
        }


        public void limpiar()
        {
            tbClave.Clear();
            tbUsuario.Clear();
            tbUsuario.Focus();
        }

        public clsUsuario U
        {
            get { return u; }
            set { u = value; }
        }

    }
}
