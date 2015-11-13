using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using logica;
using entidades;

namespace frmABMME
{
    public partial class frmRegistroDePago : Form
    {
        public frmRegistroDePago()
        {
            InitializeComponent();
        }
        RepositorioRecibo reposRecibo = new RepositorioRecibo(); 
        RepositorioMedico reposMedico = new RepositorioMedico();
        RepositorioTurno reposTurno = new RepositorioTurno();
        RepositorioPaciente reposPaciente = new RepositorioPaciente();
        RepositorioSobreturno reposSobreTurno = new RepositorioSobreturno();
        RepositorioFactura reposFac = new RepositorioFactura();
        RepositorioObraSocial reposObra = new RepositorioObraSocial();
        RepositorioEspecialidad reposEspe = new RepositorioEspecialidad();
        bool columnasTurno = false;
        bool columnasTurnosAPagar = false;
        int pagina = 0;
        clsPaciente PacienteActual = new clsPaciente();

        float total = 0;


        private void dgvPacientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!columnasTurno)     //Si todavia no tengo columnas en losturnos sin pagar las creo.
            {
                CrearColumnasTurno();
            }

            if (dgvTurnos.Rows.Count > 0)           //Si tengo algunas cargadas en los turnos sin pagar, las borro.
            {
                foreach (DataGridViewRow row in dgvTurnos.Rows)
                {
                    dgvTurnos.Rows.Remove(row);

                }
            }

            if(dgvTurnosAPagar.Rows.Count > 0)      //Borro todos los posibles turnos a pagar previamente seleccionados.
            {
                foreach(DataGridViewRow row in dgvTurnosAPagar.Rows)
                {
                    dgvTurnosAPagar.Rows.Remove(row);
                }
            }



            //TOMO EL ID DEL PACIENTE SELECCIONADO
            int idPas = int.Parse(dgvPacientes.Rows[dgvPacientes.CurrentRow.Index].Cells[0].Value.ToString());


            PacienteActual = reposPaciente.buscarPorId(idPas);


            List<clsTurno> ListaTurnos = reposTurno.obtenerTurnoPaciente(idPas);
            List<clsSobreturno> ListaSobreTurnos = reposSobreTurno.obtenerSobreturnoPaciente(idPas);

            foreach (clsTurno turn in ListaTurnos)
            {
                dgvTurnos.Rows.Add(turn.Id, turn.Fecha, turn.Costo, "Turno");
            }

            foreach(clsSobreturno sobr in ListaSobreTurnos)
            {
                dgvTurnos.Rows.Add(sobr.Id, sobr.Fecha, sobr.Costo, "SobreTurno");
            }



            pnlTurno.Enabled = true;
        
        }





        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (pagina == 0)
            {
                MessageBox.Show("No hay registros anteriores para mostrar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {

                BorrarColumnasPacientes();

                pagina--;
                lblNumeroPagina.Text = pagina.ToString();

                List<clsPaciente> listPas = new List<clsPaciente>();

                listPas = reposPaciente.Todo(pagina);

                foreach (clsPaciente pas in listPas)
                {
                    dgvPacientes.Rows.Add(pas.Id, pas.Apellido, pas.Dni, pas.ObraSocial, pas.Telefono);
                }

            }
        }





        

        private void frmRegistroDePago_Load(object sender, EventArgs e)
        {
            ArmarColumnas();
            pnlTurno.Enabled = false;
        }


        public void ArmarColumnas()
        {
            dgvPacientes.Columns.Add("id", "id");
            dgvPacientes.Columns["id"].Visible = false;
            dgvPacientes.Columns.Add("nombre", "nombre");
            dgvPacientes.Columns.Add("apellido", "apellido");
            dgvPacientes.Columns.Add("dni", "dni");
            dgvPacientes.Columns.Add("obrasocial", "obrasocial");
            dgvPacientes.Columns.Add("telefono", "telefono");
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {

            BorrarColumnasPacientes();

            pagina++;
            lblNumeroPagina.Text = pagina.ToString();

            List<clsPaciente> listPas = new List<clsPaciente>();

            listPas = reposPaciente.Todo(pagina);

            foreach (clsPaciente pas in listPas)
            {
                dgvPacientes.Rows.Add(pas.Id, pas.Apellido, pas.Dni, pas.ObraSocial, pas.Telefono);


            }



        }

        

        private void btnPasar_Click(object sender, EventArgs e)
        {
            int idTurn = 0;


            if (!columnasTurnosAPagar)
            {
                ArmarColumnasTurnoAPagar();
            }


            try
            {
                idTurn = int.Parse(dgvTurnos.Rows[dgvTurnos.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione un turno antes de realizar esta operacion", "¡Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (dgvTurnos.Rows[dgvTurnos.CurrentRow.Index].Cells[3].Value.ToString() == "Turno") //Si quiere pasar un turno
            {

                dgvTurnos.Rows.Remove(dgvTurnos.CurrentRow);        //Elimino la seleccionada

                clsTurno turn = reposTurno.buscarPorId(idTurn);     //Busco sus datos 

                dgvTurnosAPagar.Rows.Add(turn.Id, turn.Fecha, turn.Costo, "Turno");      //La paso al otro dgv




            }
            else
            {
                if (dgvTurnos.Rows[dgvTurnos.CurrentRow.Index].Cells[3].Value.ToString() == "SobreTurno") //Si quiere pasar un sobreTurno
                {
                    dgvTurnos.Rows.Remove(dgvTurnos.CurrentRow);

                    clsSobreturno Sobrturn = reposSobreTurno.buscarPorId(idTurn);

                    dgvTurnosAPagar.Rows.Add(Sobrturn.Id, Sobrturn.Fecha, Sobrturn.Costo, "SobreTurno");
                }

            }

            if (dgvTurnosAPagar.Rows.Count > 0)
            {
                cbMetodoDePago.Visible = true;
                btnPagar.Enabled = true;
            }






        }

  
        

        private void btnPagar_Click(object sender, EventArgs e)
        {
            //creo una lista de turno y otra de sobre para separar a los seleccionados por el usuario
            // y asignarle sus ids al recibo.

            List<clsTurno> turnoReporte = new List<clsTurno>();
            List<clsSobreturno> sobreTurnosReporte = new List<clsSobreturno>();

            clsTurno turn = new clsTurno();
            clsSobreturno sobreTarna = new clsSobreturno();

            if (dgvTurnosAPagar.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvTurnosAPagar.Rows)
                {
                    turn.Id = int.Parse(dgvTurnosAPagar.Rows[row.Index].Cells[0].Value.ToString());
                    sobreTarna.Id = int.Parse(dgvTurnosAPagar.Rows[row.Index].Cells[0].Value.ToString());

                    turn.Fecha = DateTime.Parse(dgvTurnosAPagar.Rows[row.Index].Cells[1].Value.ToString());
                    sobreTarna.Fecha = DateTime.Parse(dgvTurnosAPagar.Rows[row.Index].Cells[1].Value.ToString());

                    turn.Costo = float.Parse(dgvTurnosAPagar.Rows[row.Index].Cells[2].Value.ToString());
                    sobreTarna.Costo = float.Parse(dgvTurnosAPagar.Rows[row.Index].Cells[2].Value.ToString());

                    if (dgvTurnosAPagar.Rows[row.Index].Cells[3].Value.ToString() == "Turno")
                    {
                        turnoReporte.Add(turn);     //Cargo una lista con los turnos a pagar.
                    }
                    else
                    {
                        if (dgvTurnosAPagar.Rows[row.Index].Cells[3].Value.ToString() == "SobreTurno")
                        {
                            sobreTurnosReporte.Add(sobreTarna);
                        }


                    }
                }

                
                List<clsRecibo> listaRecibos = new List<clsRecibo>();
                clsRecibo recibo = new clsRecibo();
                clsObraSocial obrita = new clsObraSocial();
                clsEspecialidad especiali = new clsEspecialidad();
                clsMedico med = new clsMedico();

                //Creo la lista de recibos para turnos
                
                foreach (clsTurno turnito in turnoReporte)
                {
                    recibo.IdFactura = reposFac.ultimoID() + 1;    //METODO QUE ME TRAE EL ULTIMO ID DE FACTURA    
                    recibo.IdTurno = turnito.Id;
                    recibo.IdSobreTurno = null;                    //SI TIENE TURNO, SOBRE TURNO ES NULL.
                    recibo.Fecha = turnito.Fecha;       
                
                    if(PacienteActual.ObraSocial != null)          //PREGUNTO SI EL PACIENTE TIENE O NO OBRA SOCIAL PARA CALCULAR EL MONTO DE COBERTURA.
                    {
                        obrita = reposObra.buscarPorNombre(PacienteActual.ObraSocial);   //METODO QUE ME RETORNA LA OBRA POR EL NOMBRE.
                        recibo.Cobertura = obrita.Monto;
                    }
                    else
                    {
                        recibo.Cobertura = null;                //SI NO TIENE OBRA SOCIAL, NO TIENE COBERTURA.
                    }

                    //CARGO EL MONTO DE LA CONSULTA.

                    clsTurno t = new clsTurno();                //Variable auxiliar de turno, es el turno en el que estoy ahora.

                    t = reposTurno.buscarPorId(turnito.IdMedico);       //Le asigno todos sus valores propios.

                    string es = reposMedico.buscarPorId(t.IdMedico).Especialidad;   //le asigno a "es" la especialidad del medico de este turno
                        
                    especiali = reposEspe.buscarPorNombre(es);          //busco todos los datos de esa especialidad por su nombre

                    recibo.Importe = especiali.Canon;               //Cargo el importe con el valor de la especialidad.

                    recibo.Detalle = es;

                    if(recibo.Importe - recibo.Cobertura > 0)           //Si lo que me cubre la obra social es menor a lo que me sale la consulta entonces agrego esa diferencia al total.
                    {
                        total += (float)recibo.Importe - (float)recibo.Cobertura;
                    }

                    reposRecibo.Alta(recibo);
                    

                }

                //Creo la lista de recibos para turnos

                foreach(clsSobreturno sobrTurnito in sobreTurnosReporte)
                {
                    recibo.IdFactura = reposFac.ultimoID() + 1;    //METODO QUE ME TRAE EL ULTIMO ID DE FACTURA    
                    recibo.IdTurno = null;                          //SI TIENE SOBRETURNO, TURNO ES NULL.
                    recibo.IdSobreTurno = sobrTurnito.Id;
                    recibo.Fecha = sobrTurnito.Fecha;

                    if (PacienteActual.ObraSocial != null)          //PREGUNTO SI EL PACIENTE TIENE O NO OBRA SOCIAL PARA CALCULAR EL MONTO DE COBERTURA.
                    {
                        obrita = reposObra.buscarPorNombre(PacienteActual.ObraSocial);   //METODO QUE ME RETORNA LA OBRA POR EL NOMBRE.
                        recibo.Cobertura = obrita.Monto;
                    }
                    else
                    {
                        recibo.Cobertura = null;                //SI NO TIENE OBRA SOCIAL, NO TIENE COBERTURA.
                    }

                    //CARGO EL MONTO DE LA CONSULTA.

                    clsTurno t = new clsTurno();                //Variable auxiliar de turno, es el turno en el que estoy ahora.

                    t = reposTurno.buscarPorId(sobrTurnito.IdMedico);       //Le asigno todos sus valores propios.

                    string es = reposMedico.buscarPorId(t.IdMedico).Especialidad;   //le asigno a "es" la especialidad del medico de este turno

                    especiali = reposEspe.buscarPorNombre(es);          //busco todos los datos de esa especialidad por su nombre

                    recibo.Importe = especiali.Canon;               //Cargo el importe con el valor de la especialidad.

                    recibo.Detalle = es;

                    if (recibo.Importe - recibo.Cobertura > 0)           //Si lo que me cubre la obra social es menor a lo que me sale la consulta entonces agrego esa diferencia al total.
                    {
                        total += (float)recibo.Importe - (float)recibo.Cobertura;
                    }

                    reposRecibo.Alta(recibo);

                }


                //ACA LE ASIGNO LOS DATOS A LA FACTURA




              




            }


        }

        private void btnTraer_Click(object sender, EventArgs e)
        {
            int idTurn = 0;         

            
            try
            {
                idTurn = int.Parse(dgvTurnosAPagar.Rows[dgvTurnosAPagar.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione un turno antes de realizar esta operacion", "¡Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            if (dgvTurnosAPagar.Rows[dgvTurnosAPagar.CurrentRow.Index].Cells[3].Value.ToString() == "Turno") //Si quiere pasar un turno
            {
                dgvTurnosAPagar.Rows.Remove(dgvTurnosAPagar.CurrentRow);

                clsTurno turn = reposTurno.buscarPorId(idTurn);

                dgvTurnos.Rows.Add(turn.Id, turn.Fecha, turn.Costo, "Turno");
            
            }
            else
            {
                if(dgvTurnosAPagar.Rows[dgvTurnosAPagar.CurrentRow.Index].Cells[3].Value.ToString() == "SobreTurno") //Si quiere pasar un sobreTurno
                {
                    dgvTurnosAPagar.Rows.Remove(dgvTurnosAPagar.CurrentRow);

                    clsSobreturno Sobrturn = reposSobreTurno.buscarPorId(idTurn);

                    dgvTurnos.Rows.Add(Sobrturn.Id, Sobrturn.Fecha, Sobrturn.Costo, "SobreTurno");
                }
                
            }
        }


        public void ArmarColumnasTurnoAPagar()
        {

            dgvTurnosAPagar.Columns.Add("id", "id");
            dgvTurnosAPagar.Columns["id"].Visible = false;
            dgvTurnosAPagar.Columns.Add("Fecha", "Fecha");
            dgvTurnosAPagar.Columns.Add("Costo", "Costo");
            dgvTurnosAPagar.Columns.Add("Tipo", "Tipo");
            dgvTurnosAPagar.Columns["Tipo"].Visible = false;


            columnasTurnosAPagar = true;  
        }

        public void BorrarColumnasPacientes()
        {
            if (dgvPacientes.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvPacientes.Rows)
                {
                    dgvPacientes.Rows.Remove(row);
                }
            }
        }

        public void CrearColumnasTurno()
        {
            dgvTurnos.Columns.Add("id", "id");
            dgvTurnos.Columns["id"].Visible = false;
            dgvTurnos.Columns.Add("Fecha", "Fecha"); 
            dgvTurnos.Columns.Add("Costo", "Costo");
            dgvTurnos.Columns.Add("Tipo", "Tipo");
            dgvTurnos.Columns["Tipo"].Visible = false;


            columnasTurno = true;

        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            cbMetodoDePago.Items.Clear();
        }
        
      


    }


}
