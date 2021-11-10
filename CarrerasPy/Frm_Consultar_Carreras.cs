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

namespace CarrerasPy
{
    public partial class Frm_Consultar_Carreras : Form
    {
        private IService servicio;
        
        public Frm_Consultar_Carreras()
        {
            InitializeComponent();
            servicio = new ServiceFactoryImp().CrearService();
        }

        private void Frm_Consultar_Carreras_Load(object sender, EventArgs e)
        {
            CargarComboConsulta();
        }

        private void CargarComboConsulta()
        {
            List<Carrera> lst = servicio.ConsultarCarreras();

            //source es una lista de objetos
            cbFiltroConsulta.DataSource = lst;
            //valueMember y DisplayMember serán las properties de los objetos
            cbFiltroConsulta.ValueMember = "idCarrera";
            cbFiltroConsulta.DisplayMember = "Nombre";
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                List<DetalleCarrera> lst = new List<DetalleCarrera>();


                if (cbFiltroConsulta.SelectedIndex > -1)
                {
                    DetalleCarrera item = new DetalleCarrera();
                    id = Convert.ToInt32(cbFiltroConsulta.ValueMember);

                    lst = servicio.DetalleCarrerasById(id);
                    dgvDetalles.DataSource = lst;

                }

            }
            catch (Exception ex)
            {

            }
        }

        private void cbFiltroConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

    }
}
