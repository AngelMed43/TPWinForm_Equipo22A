using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace TPWinForm_equipo_22A
{
    public partial class frmNuevoArticulo : Form
    {
        public frmNuevoArticulo()
        {
            InitializeComponent();

            //txtBCódigo.Focus(); ----- No funciona.
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Articulo art = new Articulo();
            ArticuloNegocio artN= new ArticuloNegocio();

            try
            {
                art.Codigo = txtBCódigo.Text;
                art.Nombre = txtBNombre.Text;
                art.Descripcion = txtBDescripción.Text;
                art.Marca.IdMarca = int.Parse(cbMarca.Text);
                art.Categoria.IdCategoria = int.Parse(cbCategoría.Text);
                art.Precio = decimal.Parse(txtBPrecio.Text);


                artN.insertArticulo(art);

                this.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

