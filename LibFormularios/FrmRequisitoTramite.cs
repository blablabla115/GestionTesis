using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LibClases;

namespace LibFormularios
{
    public partial class FrmRequisitoTramite : LibFormularios.FrmPadre
    {
        private CTramite aTramite;
        private CRequisitos aRequisitos;
        //================== CONSTRUCTORES =======================
        public FrmRequisitoTramite()
        {
            InitializeComponent();
            IniciarEntidad(new CRequisitosTramite());
            //IniciarEntidad(new CRequisitos());
            aTramite = new CTramite();
            aRequisitos = new CRequisitos();
            IniciarTablaRequisitos();
            dgvRequisitosSolicitud.DataSource = aEntidad.ListaGeneral();
        }
        public void IniciarTablaRequisitos()
        {
            //-- Recupera la informacion de un registro
            dgvRequisitos.DataSource = aRequisitos.ListaGeneral();
        }
        //============= REDEFINICION DE LOS METODOS VIRTUALES ====================
        //-- Establecer los valores que iran a la tabla
        public override string[] AsignarValoresAtributos()
        {
            //-- recuperar el codigo del requisito (de la fila seleccionada en el grid)
            
            return new string[] {CodSolicitud.Text, CodRequisito.Text};

        }
        //----------------------------------------------------------
        public override void InicializarAtributosNoClave()
        {
            Solicitud.Text = "";
        }
        //-----------------------------------------------------------
        public override void ListarRegistros()
        { //-- Mostrar los ejemplares relacionados con el libro seleccionado
          // dgvRequisitosSolicitud.DataSource =(aEntidad as CTramite).ListaTramites(CodSolicitud.Text);
            dgvRequisitosSolicitud.DataSource = aEntidad.ListaGeneral();
        }
        //-----------------------------------------------------------
        public override bool EsRegistroValido()
        {
            if (CodSolicitud.Text != "" && Solicitud.Text != "")
                return true;
            else
                return false;
        }
        //-----------------------------------------------------------
        public override void Grabar()
        { //-- al grabar un nuevo ejemplar, el formulario queda listo para

            //-- INSERTAR el siguiente registro

            try
            {
                if (EsRegistroValido())
                { //-- Recuperar atributos, el primer atributo es la clave
                    string[] Atributos = AsignarValoresAtributos();

                    //-- Se realiza la inserciòn sin verificar si existe la clave
                    //-- primaria, ya que en este caso la clave es autonumerica.
                    aEntidad.Insertar(Atributos);
                    //-- Inicializar el formulario

                    MessageBox.Show("OPERACION REALIZADA EXITOSAMENTE", "CONFIRMACION");
                    InicializarAtributos();
                    ListarRegistros();

                }
                else
                    MessageBox.Show("DEBE COMPLETAR EL LLENADO DEL FORMULARIO",
                    "ALERTA");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR AL REALIZAR LA OPERACION");
            }
        }
        // ===== METODOS PARA MANEJAR LA INFORMACION DEL LIBRO ==========
        public void LlenarListaLibros()
        { //-- muestra la lista de tramites en el combo
            Solicitud.DataSource = aTramite.ListaGeneral();
            Solicitud.DisplayMember = "Nombre";
            Solicitud.ValueMember = "CodTramite";
            //-- dejar el combo sin libro seleccionado
            Solicitud.SelectedIndex = -1;
        }
        // --------------------------------------------------------------------
        public void MostrarDatosLibro()
        { //-- al seleccionar un tramite en el combo, mostrar el resto de datos
          //-- recuperar el codigo del tramite seleccionado
            string CodTramite = (Solicitud.SelectedValue == null ? "" :Solicitud.SelectedValue.ToString());

            //-- solicitar a la base de datos la informacion del libro
            aTramite.Registro(new string[] { CodTramite });
            //-- mostrar el resto de informacion
            CodSolicitud.Text = aTramite.ValorAtributo("CodTramite");
            //LblAutor.Text = aTramite.ValorAtributo("Nombre");
        }
        // =========================== EVENTOS ==============================
        private void FrmEjemplar_Load(object sender, EventArgs e)
        {
            LlenarListaLibros();
        }
        //---------------------------------------------------------------------
        private void CboLibro_SelectedIndexChanged(object sender, EventArgs e)
        { //-- mostrar informacion del libro seleccionado y de ejemplarese relacionados
            MostrarDatosLibro();
            ListarRegistros();
        }
    }
}
