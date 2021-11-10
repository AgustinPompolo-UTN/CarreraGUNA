using CarrerasBackend.dominio;
using CarrerasBackend.servicios;

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
    public partial class Frm_Cargar_Materias : Form
    {
        private IService servicio;
        Carrera oCarrera = new Carrera();
        public int xClick = 0, yClick = 0; //para arrastrar la ventana
        public Frm_Cargar_Materias()
        {
            InitializeComponent();
            servicio = new ServiceFactoryImp().CrearService();
        }

        private void CargarCombo()
        {
            List<Asignatura> lst = servicio.ConsultarMaterias();

            //source es una lista de objetos
            cbAsignatura.DataSource = lst;
            //valueMember y DisplayMember serán las properties de los objetos
            cbAsignatura.ValueMember = "idAsignatura";
            cbAsignatura.DisplayMember = "Nombre";


        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            if (cbAnio.SelectedIndex < 0 || cbAsignatura.SelectedIndex < 0 || cbCuatrimestre.SelectedIndex < 0 || tbCarrera.TextLength < 1 || tbTitulo.TextLength < 1)
            {
                MessageBox.Show("Complete todos los campos!");
                return;
            }

            if (ExisteMateriaEnGrilla(cbAsignatura.Text))
            {
                MessageBox.Show("Producto ya agregado como detalle", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DetalleCarrera item = new DetalleCarrera();

                Asignatura oAsignatura = (Asignatura)cbAsignatura.SelectedItem;
                item.Materia = oAsignatura;
                item.AnioCursado = cbAnio.SelectedItem.ToString();
                item.Cuatrimestre = cbCuatrimestre.SelectedItem.ToString();
                oCarrera.Nombre = tbCarrera.Text;
                oCarrera.Titulo = tbTitulo.Text;

                oCarrera.AgregarMateria(item);

                dgvDetalles.Rows.Add(new object[] { "", oAsignatura.idAsignatura, oAsignatura.Nombre, item.Cuatrimestre, item.AnioCursado }); ;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Producto ya agregado como detalle" + ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        private bool ExisteMateriaEnGrilla(string text)
        {

            foreach (DataGridViewRow fila in dgvDetalles.Rows)
            {
                if (fila.Cells["Nombre"].Value is null)
                {
                    return false;
                }
                if (fila.Cells["Nombre"].Value.Equals(text))
                {
                    return true;
                }

            }
            return false;
        }


        private void Frm_Cargar_Materias_Load(object sender, EventArgs e)
        {
            CargarCombo();
        }

        private void btCarrera_Click(object sender, EventArgs e)
        {
            if (tbCarrera.TextLength < 1 || tbTitulo.TextLength < 1)
            {
                MessageBox.Show("Complete todos los campos!");
                return;
            }

            pCarrera.Enabled = false;
        }

        private void cbAsignatura_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cancelar el registro?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Dispose();
            }
        }


        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Frm_Cargar_Materias_MouseMove(object sender, MouseEventArgs e)
        {
            //Permite mover la ventana agarrando del panel superior
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            {
                this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick);
            }
        }

       
    }
}