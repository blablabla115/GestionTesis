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
    public partial class FrmTramites : LibFormularios.FrmPadre
    {
        public FrmTramites()
        {
            InitializeComponent();
            IniciarEntidad(new CTramite());
            ListarRegistros();
        }
        //============= REDEFINICION DE LOS METODOS VIRTUALES ====================
        //-- Establecer los valores que iran a la tabla
        public override string[] AsignarValoresAtributos()
        {
            return new string[] { CodTramite.Text, Nombre.Text};

        }
        //-----------------------------------------------------------
        //-- Mostrar los datos de un registro
        public override void MostrarDatos()
        { //-- muestra la informacion contenida en el dataset de CLibro
            CodTramite.Text = aEntidad.ValorAtributo("CodTramite");
            Nombre.Text = aEntidad.ValorAtributo("Nombre");
        }
        //-----------------------------------------------------------
        //-- Iniciar los atributos clave y no clave en blanco
        public override void InicializarAtributoClave()
        {
            CodTramite.Text = "";
            CodTramite.Enabled = true;
        }
        public override void InicializarAtributosNoClave()
        {
            Nombre.Text = "";
        }
        //-----------------------------------------------------------
        //-- Listar los registros y mostrarlos en el datagrid
        public override void ListarRegistros()
        { //-- Mostrar todos los libros de la tabla en el grid
            Tramites.DataSource = aEntidad.ListaGeneral();
        }
        //-----------------------------------------------------------
        //-- verificar los campos obligatorios(codigo y titulo) estén llenos
        public override bool EsRegistroValido()
        {
            if (CodTramite.Text.Trim() != "" && Nombre.Text.Trim() != "")
                return true;
            else
                return false;
        }
        // ================= EVENTOS ==============================
        private void CodDocente_Leave(object sender, EventArgs e)
        {
            ProcesarClave();
        }

        private void FrmDocente_Load(object sender, EventArgs e)
        {
            ListarRegistros();
        }
    }
}

