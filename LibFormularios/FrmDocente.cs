using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibClases;

namespace LibFormularios
{
    public partial class FrmDocente : LibFormularios.FrmPadre
    {
        public FrmDocente()
        {
            InitializeComponent();
            IniciarEntidad(new CDocentes());
            ListarRegistros();
        }
        //============= REDEFINICION DE LOS METODOS VIRTUALES ====================
        //-- Establecer los valores que iran a la tabla
        public override string[] AsignarValoresAtributos()
        {
            return new string[] {CodDocente.Text, Nombre.Text, ApellidoPaterno.Text, ApellidoMaterno.Text, DNI.Text,Telefono.Text, Categoria.Text, depAcademico.Text, disponibilidad.Text};

        }
        //-----------------------------------------------------------
        //-- Mostrar los datos de un registro
        public override void MostrarDatos()
        { //-- muestra la informacion contenida en el dataset de CLibro
            CodDocente.Text = aEntidad.ValorAtributo("CodDocente");
            Nombre.Text = aEntidad.ValorAtributo("Nombre");
            ApellidoPaterno.Text = aEntidad.ValorAtributo("ApellidoPaterno");
            ApellidoMaterno.Text = aEntidad.ValorAtributo("ApellidoMaterno");
            DNI.Text = aEntidad.ValorAtributo("DNI");
            Telefono.Text = aEntidad.ValorAtributo("telefono");
            Categoria.Text = aEntidad.ValorAtributo("Categoria");
            depAcademico.Text = aEntidad.ValorAtributo("DepAcademico");
            disponibilidad.Text = aEntidad.ValorAtributo("Disponibilidad");
        }
        //-----------------------------------------------------------
        //-- Iniciar los atributos clave y no clave en blanco
        public override void InicializarAtributoClave()
        {
            CodDocente.Text = "";
            CodDocente.Enabled = true;
        }
        public override void InicializarAtributosNoClave()
        {
            Nombre.Text = "";
            ApellidoPaterno.Text = "";
            ApellidoMaterno.Text = "";
            DNI.Text = "";
            Telefono.Text = "";
            Categoria.Text = "";
            depAcademico.Text = "";
            disponibilidad.Text = "";
        }
        //-----------------------------------------------------------
        //-- Listar los registros y mostrarlos en el datagrid
        public override void ListarRegistros()
        { //-- Mostrar todos los libros de la tabla en el grid
            Table.DataSource = aEntidad.ListaGeneral();
        }
        //-----------------------------------------------------------
        //-- verificar los campos obligatorios(codigo y titulo) estén llenos
        public override bool EsRegistroValido()
        {
            if (CodDocente.Text.Trim() != "" && Nombre.Text.Trim() != "" && ApellidoPaterno.Text.Trim() != "" && ApellidoMaterno.Text.Trim() != "")
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
