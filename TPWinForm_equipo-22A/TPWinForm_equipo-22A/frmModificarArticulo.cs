using Conexion_BDD;
using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_equipo_22A
{
    public partial class frmModificarArticulo : Form
    {
        private frmInicio frmInicio;
        private Articulo articulo = null;
        public frmModificarArticulo(frmInicio formInicio, Articulo art)
        {
            InitializeComponent();
            frmInicio = formInicio;
            this.articulo = art;
        }
        public frmModificarArticulo(frmInicio formInicio)
        {
            InitializeComponent();
            frmInicio = formInicio;
        }
        private void frmModificarArticulo_Load(object sender, EventArgs e)
        {
            //rbPorPC.Checked = true;
            //txtUrlImagen.Enabled = false;


            MarcaNegocio marca = new MarcaNegocio();
            CategoriaNegocio categoria = new CategoriaNegocio();
            try
            {
                txtBCódigo.Text = articulo.Codigo;
                txtbCódigoActual.Text = articulo.Codigo;
                txtBNombre.Text = articulo.Nombre;
                txtbNombreActual.Text = articulo.Nombre;
                txtBDescripción.Text = articulo.Descripcion;
                txtbDescripciónActual.Text = articulo.Descripcion;
                if (articulo.Marca == null || articulo.Marca.IdMarca== 0)
                {
                    txtbMarcaActual.Text = "SIN MARCA";
                }
                else { txtbMarcaActual.Text = articulo.Marca.Descripcion; }

                if (articulo.Categoria == null || articulo.Categoria.IdCategoria == 0)
                {
                    txtbCategoriaActual.Text = "SIN CATEGORIA";
                }
                else { txtbCategoriaActual.Text = articulo.Categoria.Descripcion; }
                
                txtBPrecio.Text = articulo.Precio.ToString("0.00");
                txtbPrecioActual.Text = articulo.Precio.ToString("0.00");
                cbMarca.DataSource = marca.listar();
                cbMarca.DisplayMember = "Descripcion";
                cbMarca.ValueMember = "IdMarca";

                if (articulo.Marca != null)
                    cbMarca.SelectedValue = articulo.Marca.IdMarca;

                // 🔹 CATEGORIAS
                cbCategoría.DataSource = categoria.listar();
                cbCategoría.DisplayMember = "Descripcion";
                cbCategoría.ValueMember = "IdCategoria";

                if (articulo.Categoria != null)
                    cbCategoría.SelectedValue = articulo.Categoria.IdCategoria;
            }
            catch (Exception ex)
            {
                // Por el momento
                // Por el momento
                // Por el momento
                MessageBox.Show(ex.ToString());
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

    }
}

