using Conexion_BDD;
using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_equipo_22A
{
    public partial class frmNuevaCategoria : Form
    {
        private const int MaxDescripcion = 50;
        private frmInicio frmInicio;
        private Categoria categoria = null;
        public frmNuevaCategoria(frmInicio formInicio)
        {
            InitializeComponent();
            frmInicio = formInicio;
        }
        public frmNuevaCategoria(frmInicio formInicio, Categoria categoria)
        {
            InitializeComponent();
            frmInicio = formInicio;
            this.categoria = categoria;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*private void frmNuevaCategoria_Load(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                int proximoId = negocio.obtenerProximoId();
                IDGenerado.Text = proximoId.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Al Cargar ID" + ex.ToString());
            }
        }*/

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validaciones.ValidarCategoria(txtBDescripcionNuevaCategoria.Text, out string descripcionNormalizada, MaxDescripcion))
                return;

            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                if (categoria == null)
                {
                    categoria = new Categoria();
                }

                txtBDescripcionNuevaCategoria.Text = descripcionNormalizada;
                categoria.Descripcion = descripcionNormalizada;

                if (categoria.IdCategoria != 0)
                {
                    negocio.modificar(categoria);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    negocio.agregar(categoria);
                    MessageBox.Show("Agregado exitosamente");
                }

                frmInicio.cargarListadoCategorias();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmNuevaCategoria_Load(object sender, EventArgs e)
        {
            txtBDescripcionNuevaCategoria.MaxLength = MaxDescripcion;

            if (categoria != null)
            {
                grpBDetalleCategoria.Text = "Modificar Categoría";
                txtBDescripcionNuevaCategoria.Text = categoria.Descripcion;
            }
            else
            {
                grpBDetalleCategoria.Text = "Agregar Categoría";
                txtBDescripcionNuevaCategoria.Clear();
            }
        }
    }
}

