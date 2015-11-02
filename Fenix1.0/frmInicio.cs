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

namespace frmABMME
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

                                    break;

                                case "Recepcion":

                                    break;
                                
                                case "Medico":
                                
                                    break;
                            }
                        }
                    }
                }
            }
        }
    }
}
