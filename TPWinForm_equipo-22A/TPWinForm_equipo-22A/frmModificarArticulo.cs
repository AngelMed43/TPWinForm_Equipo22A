using Conexion_BDD;
using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private string carpetaImagenes;
        public frmModificarArticulo(frmInicio formInicio, Articulo art)
        {
            InitializeComponent();
            frmInicio = formInicio;
            this.articulo = art;
            //Me pisaba la lista --- No va
            //articulo.Imagenes = new List<Imagen>();
            string baseDocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            carpetaImagenes = Path.Combine(baseDocs, "Imagenes_APPGestion");
        }
        public frmModificarArticulo(frmInicio formInicio)
        {
            InitializeComponent();
            frmInicio = formInicio;
            string baseDocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            carpetaImagenes = Path.Combine(baseDocs, "Imagenes_APPGestion");
        }
        private void frmModificarArticulo_Load(object sender, EventArgs e)
        {    
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

                
                cbCategoría.DataSource = categoria.listar();
                cbCategoría.DisplayMember = "Descripcion";
                cbCategoría.ValueMember = "IdCategoria";

                if (articulo.Categoria != null)
                    cbCategoría.SelectedValue = articulo.Categoria.IdCategoria;
                lbxImagenes.Items.Clear();
                if (articulo.Imagenes != null && articulo.Imagenes.Count > 0)
                {
                    foreach (Imagen img in articulo.Imagenes)
                    {
                        lbxImagenes.Items.Add(img.UrlImagen);
                    }

                    lbxImagenes.SelectedIndex = 0;
                }
                
            }
            catch (Exception ex)
            {
                // Por el momento
                // Por el momento
                // Por el momento
                MessageBox.Show(ex.ToString());
            }
        }

        private void lbxImagenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valor;
            string carpeta = carpetaImagenes;
            string rutaCompleta;

            if (lbxImagenes.SelectedItem != null)
            {
                valor = lbxImagenes.SelectedItem.ToString();

                try
                {
                    if (valor.StartsWith("http"))
                    {
                        pbxImagen.Image = null;
                        pbxImagen.LoadAsync(valor);
                    }
                    else
                    {
                        // HAGO ESTO porque sino,no me visualiza las fotos, ya que las listo con otro nombre
                        rutaCompleta = Path.Combine(carpeta, valor);
                        mostrarImagenLocal(rutaCompleta);
                    }
                }
                catch (Exception ex)
                {
                    pbxImagen.Image = null;
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void mostrarImagenLocal(string ruta)
        {
            if (File.Exists(ruta))
            {
                pbxImagen.ImageLocation = ruta;
                pbxImagen.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                pbxImagen.Image = null;
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

    }
}

