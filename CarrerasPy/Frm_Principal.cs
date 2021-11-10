using CarrerasPy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarrerasFrontend
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {

        }

        private void cargarMateriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Cargar_Materias frmNuevo = new Frm_Cargar_Materias();
            frmNuevo.ShowDialog();
        }

        private void consultaCarrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Consultar_Carreras frm = new Frm_Consultar_Carreras();
            frm.ShowDialog();
        }
    }
}