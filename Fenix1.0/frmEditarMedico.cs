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

        List<clsObraSocial> obrasBajas = new List<clsObraSocial>();     //LISTA QUE CARGO CON OBRAS SOCIALES QUE EL MEDICO YA TIENE PARA LUEGO ELIMINARLAS.


        RepositorioObraPorMedico repoObraPorMed = new RepositorioObraPorMedico();
        
        RepositorioObraSocial reposObraSocial = new RepositorioObraSocial();
        RepositorioEspecialidad reposEspe = new RepositorioEspecialidad();
        RepositorioHorario reposHorario = new RepositorioHorario();


        clsHorario horarioMT = new clsHorario();
        clsHorario horarioTC = new clsHorario();
        int modifi = 0;         //si esta en 1 modifico mañana, si esta en dos tarde. 0 los dos

        public frmEditarMedico(clsMedico med)
        {
            InitializeComponent();
            this.med = med;
        }


        public void sincronizarHorarios(clsHorario horMT, clsHorario horTC)
        {
            horarioMT = horMT;
            horarioTC = horTC;
        }

        public void sincronizarHorarios(clsHorario horMT, int va)
        {
            horarioMT = horMT;
            modifi = va;
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
                        obrasBajas.Add(obr);

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
            try
            {
                if (verificarMedico())
                {
                    clsMedico medNuevo = new clsMedico();

                    medNuevo.Nombre = tbNombreModi.Text;
                    medNuevo.Apellido = tbApellidoModi.Text;
                    medNuevo.Especialidad = cbEspecialidadModi.Text;


                    //ROMPO RELACIONES DE MEDICO CON LAS OBRAS SOCIALES


                    clsObraXMedico obraPorMedBaja = new clsObraXMedico();
                    obraPorMedBaja.IdMedico = med.Id;

                    foreach (clsObraSocial obrita in obrasBajas)
                    {
                        obraPorMedBaja.IdObra = obrita.Id;
                        repoObraPorMed.Baja(obraPorMedBaja);
                    }

                    //RELACION CON OBRAS SOCIALES ROTAS.


                    //CREO LA RELACION HORARIOS POR MEDICO
                    

                    if(modifi == 0)
                    {
                        horarioMT.IdMedico = med.Id;
                        horarioTC.IdMedico = med.Id;
                        reposHorario.Modificacion(horarioMT, horarioTC);
                    }
                    else
                    {
                        if(modifi == 1)
                        {
                            horarioMT.IdMedico = med.Id;
                            reposHorario.Modificacion(horarioMT, 1);
                        }
                        if(modifi == 2)
                        {
                            horarioMT.IdMedico = med.Id;
                            reposHorario.Modificacion(horarioMT, 2);
                        }
                    }




                    ////CREO LA RELACION HORARIO POR MEDICO.

                    //long dni = medico.Dni;

                    //medico = reposMedico.BuscarPorDni(dni);     //NECESITO ESTE METODO PARA PODER CONSEGUIR EL ID DEL MEDICO.....



                    //if (horaTrabajo == 3)    //QUE TRABAJA MAÑANA Y TARDE.
                    //{
                    //    HorariosMT.IdMedico = medico.Id;
                    //    HorariosTC.IdMedico = medico.Id;
                    //    reposHorario.Alta(HorariosMT, HorariosTC);
                    //}
                    //else
                    //{
                    //    if (horaTrabajo == 1)       //QUE TRABAJA MAÑANA.
                    //    {
                    //        HorariosMT.IdMedico = medico.Id;
                    //        reposHorario.Alta(HorariosMT, 1);
                    //    }
                    //    else                        //QUE TRABAJA TARDE.
                    //    {
                    //        if (horaTrabajo == 2)
                    //        {
                    //            HorariosMT.IdMedico = medico.Id;
                    //            reposHorario.Alta(HorariosMT, 2);
                    //        }

                    //    }

                    //}


                    ////CREO LA RELACION HORARIO OBRA POR MEDICO.

                    //List<string> listaNombresObra = new List<string>();

                    //foreach (Object item in clbObraSocial.CheckedItems)      //CARGO TODAS LAS OBRAS SOCIALES SELECCIONADAS.
                    //{
                    //    listaNombresObra.Add(item.ToString());
                    //}

                    //List<clsObraSocial> obr = new List<clsObraSocial>();        //Variable con todas mis obras

                    //obr = reposObraSocial.Todo(0);          //le doy todas las obras

                    //foreach (clsObraSocial obrita in obr)        //por cada obra existente
                    //{
                    //    foreach (string obra in listaNombresObra)        //por cada obra seleccionada
                    //    {
                    //        if (obrita.Nombre == obra)           //si el nombre es igual obtengo el id y creo la relacion
                    //        {
                    //            clsObraXMedico obraPormed = new clsObraXMedico();
                    //            obraPormed.IdMedico = medico.Id;
                    //            obraPormed.IdObra = obrita.Id;

                    //            repoObraPorMed.Alta(obraPormed);
                    //        }
                    //    }


                    //}

                    //MessageBox.Show("Médico dado de alta");
                    //LimpiarControles();




                }
                else
                {
                    MessageBox.Show("Debe completar todos los campos para seleccionar.");
                }
            
            
            
            }catch(Exception ex)
            {
                MessageBox.Show("Error al actualizar el médico: " + ex.Message);
            }
            
            




            
        }

        public bool verificarMedico()
        {
            if (string.IsNullOrWhiteSpace(tbNombreModi.Text) == false || string.IsNullOrWhiteSpace(tbApellidoModi.Text) == false)
            {
                return false;
            }
            else
                return true;
        }





        private void btnEditarHorarios_Click(object sender, EventArgs e)
        {
            frmHorariosMedico horariosMed = new frmHorariosMedico(med, this);
            horariosMed.ShowDialog();
        }
    }
}
