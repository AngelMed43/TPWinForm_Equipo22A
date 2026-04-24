using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;
using dominio;

namespace TPWinForm_equipo_22A
{
    public partial class frmNuevaMarca : Form
    {
        private frmInicio frmInicio;

        public frmNuevaMarca(frmInicio formInicio)
        {
            InitializeComponent();
            frmInicio = formInicio;
        }

        private void btnCancelarMarca_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnGuardarMarca_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                marca.Descripcion = txtBDescripcionNuevaMarca.Text;

                negocio.agregar(marca);
                MessageBox.Show("Agregado exitosamente");

                frmInicio.cargarListadoMarcas();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

