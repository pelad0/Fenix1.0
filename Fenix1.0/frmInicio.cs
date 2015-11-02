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
        public frmInicio()
        {
            InitializeComponent();
            usuarios = ru.Todo(0);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbUsuario.Text) && !string.IsNullOrWhiteSpace(tbClave.Text))
            {
                foreach (clsUsuario u in usuarios)
                {
                    if (u.Usuario == tbUsuario.Text)
                    {
                        if (u.Clave == tbClave.Text)
                        {
                            string seg = u.Seguridad;
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
                    }
                }
            }
        }
    }
}
