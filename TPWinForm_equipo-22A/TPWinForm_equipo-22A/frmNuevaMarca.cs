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

        private Marca marca = null;

        public frmNuevaMarca(frmInicio formInicio, Marca marca)
        {
            InitializeComponent();
            frmInicio = formInicio;
            this.marca = marca;
        }
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
            MarcaNegocio negocio = new MarcaNegocio();

            try
            {   
                if (marca == null)
                {
                    marca = new Marca();
                }
                marca.Descripcion = txtBDescripcionNuevaMarca.Text;

                if (marca.IdMarca != 0)
                {
                    negocio.modificar(marca);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    negocio.agregar(marca);
                    MessageBox.Show("Agregado exitosamente");
                }
                

                frmInicio.cargarListadoMarcas();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmNuevaMarca_Load(object sender, EventArgs e)
        {
            if (marca != null)
            {
                grpBAgregarMarca.Text = "Modificar Marca";
                txtBDescripcionNuevaMarca.Text = marca.Descripcion;
            }
            else
            {
                grpBAgregarMarca.Text = "Agregar Marca";
                txtBDescripcionNuevaMarca.Clear();
            }
        }
    }
}

