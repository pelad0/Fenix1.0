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
using frmABMME;

namespace Fenix1._0
{
   
    public partial class frmRegistroDePago : Form
    {
        

        clsUsuario usuario = new clsUsuario();
        DataSet1 dataSetDatos = new DataSet1();
     


        RepositorioRecibo reposRecibo = new RepositorioRecibo(); 
        RepositorioMedico reposMedico = new RepositorioMedico();
        RepositorioTurno reposTurno = new RepositorioTurno();
        RepositorioPaciente reposPaciente = new RepositorioPaciente();
        RepositorioSobreturno reposSobreTurno = new RepositorioSobreturno();
        RepositorioFactura reposFac = new RepositorioFactura();
        RepositorioObraSocial reposObra = new RepositorioObraSocial();
        RepositorioEspecialidad reposEspe = new RepositorioEspecialidad();
        RepositorioClinica reposClinica = new RepositorioClinica();
        RepositorioObraPorMedico reposObraPorMed = new RepositorioObraPorMedico();
       

        bool columnasTurno = false;
        bool columnasTurnosAPagar = false;
        int pagina = 0;
        clsPaciente PacienteActual = new clsPaciente();
        clsFactura Factura = new clsFactura();

        float total = 0;
        float totalDescuento = 0;




        public frmRegistroDePago(clsUsuario u)
        {
            InitializeComponent();
            usuario = u;
        }     

        
        private void dgvPacientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
           
            if (!columnasTurno)     //Si todavia no tengo columnas en losturnos sin pagar las creo.
            {
                CrearColumnasTurno();
            }

            if (dgvTurnos.Rows.Count > 0)           //Si tengo algunas cargadas en los turnos sin pagar, las borro.
            {
                dgvTurnos.Rows.Clear();
            }

            if(dgvTurnosAPagar.Rows.Count > 0)      //Borro todos los posibles turnos a pagar previamente seleccionados.
            {
                dgvTurnosAPagar.Rows.Clear();
            }



            //TOMO EL ID DEL PACIENTE SELECCIONADO
            int idPas = int.Parse(dgvPacientes.Rows[dgvPacientes.CurrentRow.Index].Cells[0].Value.ToString());


            PacienteActual = reposPaciente.buscarPorId(idPas);


            List<clsTurnoVista> ListaTurnos = reposTurno.obtenerTurnoPaciente(idPas);
            List<clsSobreTurnoVista> ListaSobreTurnos = reposSobreTurno.obtenerSobreturnoPaciente(idPas);

            foreach (clsTurnoVista turn in ListaTurnos)
            {
                if(turn.Estado == false)
                {
                    dgvTurnos.Rows.Add(turn.Id, turn.Fecha, turn.Costo, "Turno");       //LO AGREGO SI NO HAN SIDO PAGADOS AÚN
                }
           
            }

            foreach (clsSobreTurnoVista sobr in ListaSobreTurnos)
            {
                if(sobr.Estado == false)
                {
                    dgvTurnos.Rows.Add(sobr.Id, sobr.Fecha, sobr.Costo, "SobreTurno");  //LO AGREGO SI NO HAN SIDO PAGADOS AÚN
                }

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
                lblNumeroPagina.Text = (pagina +1 ).ToString();

                List<clsPaciente> listPas = new List<clsPaciente>();

                listPas = reposPaciente.Todo(pagina);

                foreach (clsPaciente pas in listPas)
                {
                    dgvPacientes.Rows.Add(pas.Id, pas.Nombre, pas.Apellido, pas.Dni, pas.ObraSocial, pas.Telefono);
                }

            }
        }





        

        private void frmRegistroDePago_Load(object sender, EventArgs e)
        {
            ArmarColumnas();
            pnlTurno.Enabled = false;
            List<clsPaciente> listPas = new List<clsPaciente>();

            listPas = reposPaciente.Todo(pagina);

            foreach (clsPaciente pas in listPas)
            {
                dgvPacientes.Rows.Add(pas.Id,pas.Nombre, pas.Apellido, pas.Dni, pas.ObraSocial, pas.Telefono);
            }

            lblNumeroPagina.Text = (pagina + 1).ToString();

            
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
            lblNumeroPagina.Text = (pagina + 1).ToString();

            List<clsPaciente> listPas = new List<clsPaciente>();

            listPas = reposPaciente.Todo(pagina);

            foreach (clsPaciente pas in listPas)
            {
                dgvPacientes.Rows.Add(pas.Id, pas.Nombre, pas.Apellido, pas.Dni, pas.ObraSocial, pas.Telefono);
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
                return;
            }

            if (dgvTurnos.Rows[dgvTurnos.CurrentRow.Index].Cells[3].Value.ToString() == "Turno") //Si quiere pasar un turno
            {

                dgvTurnos.Rows.Remove(dgvTurnos.CurrentRow);        //Elimino la seleccionada

                clsTurno turn = reposTurno.buscarPorId(idTurn);     //Busco sus datos 

                dgvTurnosAPagar.Rows.Add(turn.Id, turn.Fecha, turn.Costo, "Turno");      //La paso al otro dgv

                ActualizarPrecio();
            }
            else
            {
                if (dgvTurnos.Rows[dgvTurnos.CurrentRow.Index].Cells[3].Value.ToString() == "SobreTurno") //Si quiere pasar un sobreTurno
                {
                    dgvTurnos.Rows.Remove(dgvTurnos.CurrentRow);

                    clsSobreturno Sobrturn = reposSobreTurno.buscarPorId(idTurn);

                    dgvTurnosAPagar.Rows.Add(Sobrturn.Id, Sobrturn.Fecha, Sobrturn.Costo, "SobreTurno");

                    ActualizarPrecio();
                }

            }

            if (dgvTurnosAPagar.Rows.Count > 0)
            {
                btnPagar.Enabled = true;
                cbTipoFactura.Enabled = true;
                label8.Enabled = true;
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
                if (string.IsNullOrWhiteSpace(cbTipoFactura.Text) == false && string.IsNullOrWhiteSpace(tbCliente.Text) == false && string.IsNullOrWhiteSpace(tbCuit.Text) == false && string.IsNullOrWhiteSpace(tbDireccion.Text) == false && tbCuit.Text.Length == 11)
                {
                    if (cbTipoFactura.Text == "A")
                    {
                        //LISTA DE RECIBOS A DAR DE ALTA.
                        List<clsRecibo> listaRecibosAInsertar = new List<clsRecibo>();

                        //LISTA DE ID'S DE TURNOS A SER ACTUALIZADOS.
                        List<int> idsDeTurnosAActualizar = new List<int>();

                        //LISTA DE ID'S DE SOBRETURNOS A SER ACTUALIZADOS.
                        List<int> idsDeSobreTurnosAActualizar = new List<int>();


                        if(string.IsNullOrWhiteSpace(tbCantidadEfectivo.Text))
                        {
                            tbCantidadEfectivo.Text = "0";
                        }                                 
                        
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
                            recibo.IdFactura = reposFac.ultimoId().Id +1;    //METODO QUE ME TRAE EL ULTIMO ID DE FACTURA    
                            recibo.IdTurno = turnito.Id;
                            recibo.IdSobreTurno = null;                    //SI TIENE TURNO, SOBRE TURNO ES NULL.
                            recibo.Fecha = turnito.Fecha;

                            List<clsObraXMedico> obrasDelMed = new List<clsObraXMedico>();

                            obrasDelMed = reposObraPorMed.TodasObras(turnito.IdMedico);     //TRAIGO TODAS LAS OBRAS DEL MEDICO.

                            foreach(clsObraXMedico obritaDelMedico in obrasDelMed)
                            {
                                if(PacienteActual.ObraSocial != null)   //PREGUNTO SI EL PACIENTE TIENE OBRA SOCIAL.
                                {
                                    if (reposObra.buscarPorId(obritaDelMedico.IdObra).Nombre == PacienteActual.ObraSocial)
                                    {
                                        obrita = reposObra.BuscarPorNombre(PacienteActual.ObraSocial);   //METODO QUE ME RETORNA LA OBRA POR EL NOMBRE.
                                        recibo.Cobertura += obrita.Monto;
                                        totalDescuento += obrita.Monto;
                                    }
                                }
                                else
                                {
                                    recibo.Cobertura = null;                //SI NO TIENE OBRA SOCIAL, NO TIENE COBERTURA.
                                }
                            }                    
                            

                            //CARGO EL MONTO DE LA CONSULTA.

                            clsTurno t = new clsTurno();                //Variable auxiliar de turno, es el turno en el que estoy ahora.

                            t = reposTurno.buscarPorId(turnito.Id);       //Le asigno todos sus valores propios.                            

                            string es = reposMedico.buscarPorId(t.IdMedico).Especialidad;   //le asigno a "es" la especialidad del medico de este turno

                            especiali = reposEspe.BuscarPorNombre(es);          //busco todos los datos de esa especialidad por su nombre

                            recibo.Importe = especiali.Canon;               //Cargo el importe con el valor de la especialidad.

                            recibo.Detalle = es;



                            listaRecibosAInsertar.Add(recibo);          //Lista de recibos para ser dados de alta
                            idsDeTurnosAActualizar.Add(turnito.Id);     //Lista de turnos para ser actualizadps.



                        }

                        //Creo la lista de recibos para sobreturnos

                        foreach (clsSobreturno sobrTurnito in sobreTurnosReporte)
                        {
                            recibo.IdFactura = reposFac.ultimoId().Id + 1;    //METODO QUE ME TRAE EL ULTIMO ID DE FACTURA    
                            recibo.IdTurno = null;                          //SI TIENE SOBRETURNO, TURNO ES NULL.
                            recibo.IdSobreTurno = sobrTurnito.Id;
                            recibo.Fecha = sobrTurnito.Fecha;

                            List<clsObraXMedico> obrasDelMed = new List<clsObraXMedico>();

                            obrasDelMed = reposObraPorMed.TodasObras(sobrTurnito.IdMedico);     //TRAIGO TODAS LAS OBRAS DEL MEDICO.

                            foreach (clsObraXMedico obritaDelMedico in obrasDelMed)
                            {
                                if (PacienteActual.ObraSocial != null)   //PREGUNTO SI EL PACIENTE TIENE OBRA SOCIAL.
                                {
                                    if (reposObra.buscarPorId(obritaDelMedico.IdObra).Nombre == PacienteActual.ObraSocial)
                                    {
                                        obrita = reposObra.BuscarPorNombre(PacienteActual.ObraSocial);   //METODO QUE ME RETORNA LA OBRA POR EL NOMBRE.
                                        recibo.Cobertura += obrita.Monto;
                                        totalDescuento += obrita.Monto;
                                    }
                                }
                                else
                                {
                                    recibo.Cobertura = null;                //SI NO TIENE OBRA SOCIAL, NO TIENE COBERTURA.
                                }
                            }

                            //CARGO EL MONTO DE LA CONSULTA.

                            clsSobreturno t = new clsSobreturno();                //Variable auxiliar de turno, es el turno en el que estoy ahora.

                            t = reposSobreTurno.buscarPorId(sobrTurnito.IdMedico);       //Le asigno todos sus valores propios.

                            string es = reposMedico.buscarPorId(t.Id).Especialidad;   //le asigno a "es" la especialidad del medico de este turno

                            especiali = reposEspe.BuscarPorNombre(es);          //busco todos los datos de esa especialidad por su nombre

                            recibo.Importe = especiali.Canon;               //Cargo el importe con el valor de la especialidad.

                            recibo.Detalle = es;


                            listaRecibosAInsertar.Add(recibo);              //Lista de recibos para ser dados de alta
                            reposSobreTurno.ActualizarAsistencia(sobrTurnito.Id);       //Lista de id de sobre turnos a ser actualizado.

                        }

                        clsClinica clini = new clsClinica();

                   
                        Factura.Cuitcliente = tbCuit.Text;
                        Factura.NumeroFactura = reposFac.ultimoId().Id + 1;
                        Factura.TipoFactura = "A";

                        //Traigo los datos de mi clinica para signarle los datos.
                        clini = reposClinica.Todo(1);

                        Factura.RazonSocial = clini.RazonSocial;
                        Factura.Terminal = usuario.Id;
                        Factura.Total = total;
                        Factura.Fecha = DateTime.Now;
                        Factura.IdUsuario = usuario.Id;
                        Factura.Cliente = tbCliente.Text;
                        Factura.PagoEfectivo = float.Parse(tbCantidadEfectivo.Text);
                        Factura.PagoTarjeta = float.Parse(tbCantidadTarjeta.Text);

                        reposFac.Alta(Factura);


                        //INSERTO TODOS LOS RECIBOS
                        foreach(clsRecibo re in listaRecibosAInsertar)
                        {
                            reposRecibo.Alta(re);
                        }

                        //ACTUALIZO TODOS LOS TURNOS A TRUE
                        foreach(int idT in idsDeTurnosAActualizar)
                        {
                            reposTurno.ActualizarAsistencia(idT);
                        }
                            
                          
                        //ACTUALIZO TODOS LOS SOBRETURNOS A TRUE
                        foreach(int idST in idsDeSobreTurnosAActualizar)
                        {
                            reposSobreTurno.ActualizarAsistencia(idST);
                        }

                        MessageBox.Show("La Factura fue creada con éxito junto con los Recibos");

                        if (dgvTurnosAPagar.Rows.Count > 0)
                            dgvTurnosAPagar.Rows.Clear();

                        tbCuit.Clear();
                        tbCliente.Clear();
                        tbDireccion.Clear();
                        tbCantidadTarjeta.Text = "0";
                        tbCantidadEfectivo.Text = "0";
                        total = 0;
                        totalDescuento = 0;
                        lblTotal.Text = "0";
                        lblDescuento.Text = "0";



                        /*
                        crPagos pago = new crPagos();

                        pago.SetDataSource(dataSetDatos.Tables[0]);

                        pago.SetParameterValue("Fecha", DateTime.Now);
                        pago.SetParameterValue("Cliente", tbCliente.Text);
                        pago.SetParameterValue("Domicilio", tbDireccion.Text);
                        pago.SetParameterValue("CUIT", tbCuit.Text);

                        frmView frmV = new frmView(pago);
                        frmV.ShowDialog();
                        */







                    }
                    else if (cbTipoFactura.Text == "B")
                    {
                        //ACA VA TODO PARA LA FACTURA B
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar un tipo de factura.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                }
                else
                {
                    MessageBox.Show("Complete los campos para continuar.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
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
                return;
            }


            if (dgvTurnosAPagar.Rows[dgvTurnosAPagar.CurrentRow.Index].Cells[3].Value.ToString() == "Turno") //Si quiere pasar un turno
            {
                dgvTurnosAPagar.Rows.Remove(dgvTurnosAPagar.CurrentRow);

                clsTurno turn = reposTurno.buscarPorId(idTurn);

                dgvTurnos.Rows.Add(turn.Id, turn.Fecha, turn.Costo, "Turno");

                ActualizarPrecio();
            
            }
            else
            {
                if(dgvTurnosAPagar.Rows[dgvTurnosAPagar.CurrentRow.Index].Cells[3].Value.ToString() == "SobreTurno") //Si quiere pasar un sobreTurno
                {
                    dgvTurnosAPagar.Rows.Remove(dgvTurnosAPagar.CurrentRow);

                    clsSobreturno Sobrturn = reposSobreTurno.buscarPorId(idTurn);

                    dgvTurnos.Rows.Add(Sobrturn.Id, Sobrturn.Fecha, Sobrturn.Costo, "SobreTurno");

                    ActualizarPrecio();
                   
                }
                
            }
        }


        public void ArmarColumnasTurnoAPagar()
        {

            dgvTurnosAPagar.Columns.Add("id", "id");
            dgvTurnosAPagar.Columns["id"].Visible = false;
            dgvTurnosAPagar.Columns.Add("Fecha", "Fecha");
            dgvTurnosAPagar.Columns.Add("Costo", "Costo");
            dgvTurnosAPagar.Columns["Costo"].DefaultCellStyle.Format = "c";
            dgvTurnosAPagar.Columns.Add("Tipo", "Tipo");
            dgvTurnosAPagar.Columns["Tipo"].Visible = false;


            columnasTurnosAPagar = true;  
        }

        public void BorrarColumnasPacientes()
        {
            if (dgvPacientes.Rows.Count > 0)
            {
                dgvPacientes.Rows.Clear();
            }
        }

        public void CrearColumnasTurno()
        {
            dgvTurnos.Columns.Add("id", "id");
            dgvTurnos.Columns["id"].Visible = false;
            dgvTurnos.Columns.Add("Fecha", "Fecha"); 
            dgvTurnos.Columns.Add("Costo", "Costo");
            dgvTurnos.Columns["Costo"].DefaultCellStyle.Format = "c";
            dgvTurnos.Columns.Add("Tipo", "Tipo");
            dgvTurnos.Columns["Tipo"].Visible = false;


            columnasTurno = true;

        }        

        private void button5_Click(object sender, EventArgs e)
        {
          
        }

        private void cbTipoFactura_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cbTipoFactura.Text))
            {
                pnlPago.Enabled = true;
            }
            else
            {
                pnlPago.Enabled = false;
                tbCantidadEfectivo.Clear();
                tbCantidadTarjeta.Clear();
                tbCuit.Clear();
                tbCliente.Clear();

            }
            

        }
        
      
        public void ActualizarPrecio()
        {
            total = 0;
            totalDescuento = 0;

            List<clsTurno> turnoReporte = new List<clsTurno>();
            List<clsSobreturno> sobreTurnosReporte = new List<clsSobreturno>();

            clsTurno turn = new clsTurno();
            clsSobreturno sobreTarna = new clsSobreturno();


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
                    turn = reposTurno.buscarPorId(turn.Id);
                    turnoReporte.Add(turn);     //Cargo una lista con los turnos a pagar.
                }
                else
                {
                    if (dgvTurnosAPagar.Rows[row.Index].Cells[3].Value.ToString() == "SobreTurno")
                    {
                        sobreTarna = reposSobreTurno.buscarPorId(sobreTarna.Id);
                        sobreTurnosReporte.Add(sobreTarna);
                    }
                }
            }

            clsEspecialidad especiali = new clsEspecialidad();
            
            clsObraSocial obrita = reposObra.BuscarPorNombre(PacienteActual.ObraSocial);

            foreach(clsTurno turnito in turnoReporte)
            {
                                
                clsTurno t = new clsTurno();                //Variable auxiliar de turno, es el turno en el que estoy ahora.

                t = reposTurno.buscarPorId(turnito.IdMedico);       //Le asigno todos sus valores propios.

                string es = reposMedico.buscarPorId(t.IdMedico).Especialidad;   //le asigno a "es" la especialidad del medico de este turno

                especiali = reposEspe.BuscarPorNombre(es);          //busco todos los datos de esa especialidad por su nombre



                
                List<clsObraXMedico> obrasDelMed = new List<clsObraXMedico>();

                obrasDelMed = reposObraPorMed.TodasObras(turnito.IdMedico);     //TRAIGO TODAS LAS OBRAS DEL MEDICO.

                foreach (clsObraXMedico obritaDelMedico in obrasDelMed)
                {

                    if (reposObra.buscarPorId(obritaDelMedico.IdObra).Nombre == obrita.Nombre)
                    {
                        if ((especiali.Canon - obrita.Monto) > 0)
                        {
                            total += (especiali.Canon - obrita.Monto);               //Cargo el importe con el valor de la especialidad.
                        }
                        else
                        {
                            total += 0;
                        }

                        totalDescuento += obrita.Monto;
                    }

                }
                    
                        
                



                          
            }


            foreach (clsSobreturno sobrTurnito in sobreTurnosReporte)
            {
                clsSobreturno t = new clsSobreturno();                //Variable auxiliar de turno, es el turno en el que estoy ahora.

                t = reposSobreTurno.buscarPorId(sobrTurnito.IdMedico);       //Le asigno todos sus valores propios.

                string es = reposMedico.buscarPorId(t.Id).Especialidad;   //le asigno a "es" la especialidad del medico de este turno

                especiali = reposEspe.BuscarPorNombre(es);          //busco todos los datos de esa especialidad por su nombre

                List<clsObraXMedico> obrasDelMed = new List<clsObraXMedico>();

                obrasDelMed = reposObraPorMed.TodasObras(sobrTurnito.IdMedico);     //TRAIGO TODAS LAS OBRAS DEL MEDICO.

                foreach (clsObraXMedico obritaDelMedico in obrasDelMed)
                {

                    if (reposObra.buscarPorId(obritaDelMedico.IdObra).Nombre == obrita.Nombre)
                    {
                        if ((especiali.Canon - obrita.Monto) > 0)
                        {
                            total += (especiali.Canon - obrita.Monto);               //Cargo el importe con el valor de la especialidad.
                        }
                        else
                        {
                            total += 0;
                        }

                        totalDescuento += obrita.Monto;
                    }

                }

             
            }


            lblTotal.Text = total.ToString();
            lblDescuento.Text = totalDescuento.ToString();
            tbCantidadTarjeta.Text = total.ToString();
        }

      

        private void tbCantidadEfectivo_TextChanged(object sender, EventArgs e)
        {

            float valorE = 0;
            float valorT = float.Parse(tbCantidadTarjeta.Text);
            if(string.IsNullOrEmpty(tbCantidadEfectivo.Text) == false && string.IsNullOrWhiteSpace(tbCantidadEfectivo.Text) == false )
            {
                valorE = float.Parse(tbCantidadEfectivo.Text);

            }

            tbCantidadTarjeta.Text = (total - valorE).ToString();
        }

        private void tbCantidadEfectivo_MouseClick(object sender, MouseEventArgs e)
        {
            if(tbCantidadEfectivo.Text == "0" )
            {
                tbCantidadEfectivo.Clear();
            }
        }

      
       
        

        






    }


}
