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

            

       

            //CARGO ESPECIALIDADES A CB;

            List<clsEspecialidad> listaEspe = new List<clsEspecialidad>(); 

            listaEspe = reposEspe.Todo();

            foreach(clsEspecialidad es in listaEspe)
            {
                cbEspecialidadModi.Items.Add(es.Descripcion);
            }
            cbEspecialidadModi.Text = med.Especialidad;

            //CARGO OBRAS SOCIALES.

            obraXmed = repoObraPorMed.TodasObras(med.Id);

            clsObraSocial obraSocial;           

            listaObras = reposObraSocial.Todo(0);


            //CARGO TODAS LAS OBRAS SOCIALES Y TAMBIEN ME FIJO SI ESTAN EN EL MEDICO A EDITAR, SI ESO PASA, LAS CHECKEO EN TRUE.


            int i = 0;
            foreach(clsObraSocial obr in listaObras)        //POR CADA OBRA EXISTENTE
            {

                clbObraSocial.Items.Add(obr.Nombre);
                obrasBajas.Add(obr);

                foreach(clsObraXMedico obramed in obraXmed)
                {
                    obraSocial = reposObraSocial.buscarPorId(obramed.IdObra);
             
                    if(obr.Nombre == obraSocial.Nombre)
                    {
                        clbObraSocial.SetItemChecked(i, true);
                    }
                }
                i++;

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

                    //PRIMERO DOY DE BAJA LAS RELACIONES DE HORARIOS

                    bool mañana = false;
                    bool tarde = false;

                    clsHorario horariosMañana = new clsHorario();
                    clsHorario horariosTarde = new clsHorario();

                    try
                    {
                        horariosMañana = reposHorario.buscarPorId(med.Id, 1);
                        mañana = true;
                    }
                    catch (Exception ex)
                    {
                    }

                    try
                    {
                        horariosTarde = reposHorario.buscarPorId(med.Id, 2);
                        tarde = true;
                    }
                    catch (Exception ex)
                    {
                    }


                    if(mañana && tarde)
                    {
                        reposHorario.Baja(horariosMañana, horariosTarde);
                    }
                    else
                    {
                        if(mañana)
                        {
                            reposHorario.Baja(horariosMañana, 1);

                        }
                        if(tarde)
                        {
                            reposHorario.Baja(horariosTarde, 2);
                        }
                    }



                    if(modifi == 0)         //ACTUALIZO MAÑANA Y TARDE
                    {
                        horarioMT.IdMedico = med.Id;
                        horarioTC.IdMedico = med.Id;
                        reposHorario.Alta(horarioMT, horarioTC);
                    }
                    else
                    {
                        if(modifi == 1)             //ACTUALIZO MAÑANA
                        {
                            horarioMT.IdMedico = med.Id;
                            reposHorario.Alta(horarioMT, 1);
                        }
                        if(modifi == 2)             //ACTUALIZO TARDE
                        {
                            horarioMT.IdMedico = med.Id;
                            reposHorario.Alta(horarioMT, 2);
                        }
                    }
                    
                    //CREO RELACION NUEVA ENTRE OBRAS Y MEDICO
                         

                    List<string> listaNombresObra = new List<string>();

                    foreach (Object item in clbObraSocial.CheckedItems)      //CARGO TODAS LAS OBRAS SOCIALES SELECCIONADAS.
                    {
                        listaNombresObra.Add(item.ToString());
                    }

                    List<clsObraSocial> obr = new List<clsObraSocial>();        //Variable con todas mis obras

                    obr = reposObraSocial.Todo(0);          //le doy todas las obras

                    foreach (clsObraSocial obrita in obr)        //por cada obra existente
                    {
                        foreach (string obra in listaNombresObra)        //por cada obra seleccionada
                        {
                            if (obrita.Nombre == obra)           //si el nombre es igual obtengo el id y creo la relacion
                            {
                                clsObraXMedico obraPormed = new clsObraXMedico();
                                obraPormed.IdMedico = med.Id;
                                obraPormed.IdObra = obrita.Id;

                                repoObraPorMed.Alta(obraPormed);
                            }
                        }


                    }

                    MessageBox.Show("Médico modificado con éxito");
                




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
            if (string.IsNullOrWhiteSpace(tbNombreModi.Text)    || string.IsNullOrWhiteSpace(tbApellidoModi.Text))
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
