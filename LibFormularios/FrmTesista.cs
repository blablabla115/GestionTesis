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
    public partial class FrmTesista : LibFormularios.FrmPadre
    {
        public FrmTesista()
        {
            InitializeComponent();
            IniciarEntidad(new CTesista());
            ListarRegistros();
        }
        //============= REDEFINICION DE LOS METODOS VIRTUALES ====================
        //-- Establecer los valores que iran a la tabla
        public override string[] AsignarValoresAtributos()
        {
            return new string[] { CodTesista.Text, Nombre.Text, ApellidoPaterno.Text, ApellidoMaterno.Text, DNI.Text, CarreraProfesional.Text, FechaNacimiento.Text };

        }
        //-----------------------------------------------------------
        //-- Mostrar los datos de un registro
        public override void MostrarDatos()
        { //-- muestra la informacion contenida en el dataset de CLibro
            CodTesista.Text = aEntidad.ValorAtributo("CodTesista");
            Nombre.Text = aEntidad.ValorAtributo("Nombre");
            ApellidoPaterno.Text = aEntidad.ValorAtributo("ApellidoPaterno");
            ApellidoMaterno.Text = aEntidad.ValorAtributo("ApellidoMaterno");
            DNI.Text = aEntidad.ValorAtributo("DNI");
            CarreraProfesional.Text = aEntidad.ValorAtributo("CarreraProfesional");
            FechaNacimiento.Text = aEntidad.ValorAtributo("FechaNacimiento");
            CodTesista.Enabled = false;
        }
        //-----------------------------------------------------------
        //-- Iniciar los atributos clave y no clave en blanco
        public override void InicializarAtributoClave()
        {
            CodTesista.Text = "";
            CodTesista.Enabled = true;
        }
        public override void InicializarAtributosNoClave()
        {
            Nombre.Text = "";
            ApellidoPaterno.Text = "";
            ApellidoMaterno.Text = "";
            DNI.Text = "";
            CarreraProfesional.Text = "";
            FechaNacimiento.Text = "";
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
            if (CodTesista.Text.Trim() != "" && Nombre.Text.Trim() != "" && ApellidoPaterno.Text.Trim() != "" && ApellidoMaterno.Text.Trim() != "" && FechaNacimiento.Text.Trim() != "")
            { 
                return true;
            }
            else
                return false;
        }
        // ================= EVENTOS ==============================
        private void CodTesista_Leave(object sender, EventArgs e)
        {
            ProcesarClave();
        }
        private void FrmLibro_Load(object sender, EventArgs e)
        {
            ListarRegistros();
        }

    }
}
