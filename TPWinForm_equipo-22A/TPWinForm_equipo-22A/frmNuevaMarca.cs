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
        private const int MaxDescripcion = 50;
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
            if (!Validaciones.ValidarMarca(txtBDescripcionNuevaMarca.Text, out string descripcionNormalizada, MaxDescripcion))
                return;

            MarcaNegocio negocio = new MarcaNegocio();

            try
            {   
                if (marca == null)
                {
                    marca = new Marca();
                }

                txtBDescripcionNuevaMarca.Text = descripcionNormalizada;
                marca.Descripcion = descripcionNormalizada;

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
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmNuevaMarca_Load(object sender, EventArgs e)
        {
            txtBDescripcionNuevaMarca.MaxLength = MaxDescripcion;

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

