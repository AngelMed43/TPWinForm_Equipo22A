using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_equipo_22A
{
    public partial class frmDetalleArticulo : Form
    {
        private Articulo articulo;
        private readonly string carpetaImagenes;

        public frmDetalleArticulo(Articulo art)
        {
            InitializeComponent();
            this.articulo = art;
            string baseDocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            carpetaImagenes = Path.Combine(baseDocs, "Imagenes_APPGestion");
        }

        private void frmDetalleArticulo_Load(object sender, EventArgs e)
        {
            // Datos del artículo
            txtbCodigo.Text = articulo.Codigo;
            txtbNombre.Text = articulo.Nombre;
            txtbDescripcion.Text = articulo.Descripcion;
            txtbMarca.Text = articulo.Marca?.Descripcion ?? "SIN MARCA";
            txtbCategoria.Text = articulo.Categoria?.Descripcion ?? "SIN CATEGORÍA";
            txtbPrecio.Text = articulo.Precio.ToString("0.00");

            
            lbxImagenesLocales.Items.Clear();
            lbxImagenesUrl.Items.Clear();

            if (articulo.Imagenes != null)
            {
                foreach (Imagen img in articulo.Imagenes)
                {
                    if (img.UrlImagen.StartsWith("http"))
                        lbxImagenesUrl.Items.Add(img.UrlImagen);
                    else
                        lbxImagenesLocales.Items.Add(img.UrlImagen);
                }
            }
        }

        private void lbxImagenesLocales_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valor;
            string carpeta = carpetaImagenes;
            string rutaCompleta;

            if (lbxImagenesLocales.SelectedItem != null)
            {
                valor = lbxImagenesLocales.SelectedItem.ToString();

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

        private void lbxImagenesUrl_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valor;
            string carpeta = carpetaImagenes;
            string rutaCompleta;

            if (lbxImagenesUrl.SelectedItem != null)
            {
                valor = lbxImagenesUrl.SelectedItem.ToString();

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
            MessageBox.Show("Buscando en: " + ruta + "\nExiste: " + File.Exists(ruta));
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

        private void btnCerrarDetalle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
