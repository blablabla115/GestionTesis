using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibFormularios;

namespace AppGestionDeTesis
{
    public partial class FrmGestionTesis : Form
    {
        public FrmGestionTesis()
        {
            InitializeComponent();
        }

        private void rEGISTRODETESISTASToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form Formulario = new FrmTesista();
            Formulario.Show();
        }

        private void rEGISTRODEDOCENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Formulario = new FrmDocente();
            Formulario.Show();
        }

        private void rEGISTRODEREQUISITOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Formulario = new FrmRequisitos();
            Formulario.Show();
        }

        private void rEGISTRODETRAMITESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Formulario = new FrmTramites();
            Formulario.Show();
        }

        private void rEQUISITOSPORTRAMITEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Formulario = new FrmRequisitoTramite();
            Formulario.Show();
        }
    }
}
