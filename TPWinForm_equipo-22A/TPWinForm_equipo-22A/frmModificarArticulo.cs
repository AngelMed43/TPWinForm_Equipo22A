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
            rbPorPC.Checked = true;
            txtUrlImagen.Enabled = false;
            

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
                    lbxImagenes_SelectedIndexChanged(null, null);
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

        private void rbPorUrl_CheckedChanged(object sender, EventArgs e)
        {
            txtUrlImagen.Enabled = rbPorUrl.Checked;
        }

        private void rbPorPC_CheckedChanged(object sender, EventArgs e)
        {
            txtUrlImagen.Enabled = false;
        }

        private void btnAddImagen_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(carpetaImagenes))
                Directory.CreateDirectory(carpetaImagenes);

            string ruta = "";
            string nombreArchivo;
            string destinoImagen;

            try
            {
                if (rbPorUrl.Checked)
                {
                    if (string.IsNullOrWhiteSpace(txtUrlImagen.Text))
                    {
                        MessageBox.Show("Ingrese una URL!", "Validación",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    //Trim elimina espacios en blanco al principio y al final de un txt
                    //Trim elimina espacios en blanco al principio y al final de un txt
                    if (!txtUrlImagen.Text.Trim().StartsWith("http"))
                    {
                        MessageBox.Show("La URL no es válida. Debe comenzar con http:// o https://",
                            "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    ruta = txtUrlImagen.Text.Trim();
                    articulo.Imagenes.Add(new Imagen { UrlImagen = ruta });
                    lbxImagenes.Items.Add(ruta);
                    pbxImagen.Image = null;
                    pbxImagen.Load(ruta);
                    txtUrlImagen.Clear();
                }
                else
                {
                    OpenFileDialog archivo = new OpenFileDialog();
                    archivo.Title = "Selecciona una Imagen";
                    archivo.Filter = "Imagenes|*.jpg;*.png;*.jpeg";

                    if (archivo.ShowDialog() != DialogResult.OK) return;

                    ruta = archivo.FileName;
                    nombreArchivo = Path.GetFileName(ruta);
                    destinoImagen = Path.Combine(carpetaImagenes, nombreArchivo);

                    File.Copy(ruta, destinoImagen, true);

                    articulo.Imagenes.Add(new Imagen { UrlImagen = nombreArchivo });
                    lbxImagenes.Items.Add(nombreArchivo);
                    mostrarImagenLocal(ruta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteImagen_Click(object sender, EventArgs e)
        {
            if (lbxImagenes.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione una imagen para eliminar.", "Aviso",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult r = MessageBox.Show("¿Seguro que desea eliminar la imagen seleccionada?","Confirmar eliminación",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                int index = lbxImagenes.SelectedIndex;
                lbxImagenes.Items.RemoveAt(index);
                articulo.Imagenes.RemoveAt(index);
                pbxImagen.Image = null;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool marcaSelected = cbMarca.SelectedItem != null;
            bool categoriaSelected = cbCategoría.SelectedItem != null;

            bool valido = Validaciones.ValidarArticulo(txtBCódigo.Text, txtBNombre.Text, marcaSelected, categoriaSelected, txtBPrecio.Text, string.Empty);

            if (!valido) return;

            ArticuloNegocio artN = new ArticuloNegocio();
            try
            {
                articulo.Codigo = txtBCódigo.Text.Trim();
                articulo.Nombre = txtBNombre.Text.Trim();
                articulo.Descripcion = txtBDescripción.Text.Trim();
                articulo.Marca = (Marca)cbMarca.SelectedItem;
                articulo.Categoria = (Categoria)cbCategoría.SelectedItem;
                articulo.Precio = Validaciones.ParsearPrecio(txtBPrecio.Text);

                artN.modificarArticulo(articulo);
                //Elimino las de la lista y actualizo con las que se guardaron en la lista
                artN.eliminarImagenesDeArticulo(articulo.Id);

                // Insertar las imágenes actuales de la lista
                foreach (Imagen img in articulo.Imagenes)
                    artN.agregarImagen(img, articulo.Id);
                MessageBox.Show("Artículo modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Close();
            }
        }

        

        private void btnAddImagen_MouseEnter(object sender, EventArgs e)
        {
            btnAddImagen.BackColor = Color.LightGreen;
        }

        private void btnDeleteImagen_MouseEnter(object sender, EventArgs e)
        {
            btnDeleteImagen.BackColor = Color.LightCoral;
        }

        private void btnAddImagen_MouseLeave(object sender, EventArgs e)
        {
            btnAddImagen.BackColor = Color.Transparent;
        }

        private void btnDeleteImagen_MouseLeave(object sender, EventArgs e)
        {
            btnDeleteImagen.BackColor = Color.Transparent;
        }
    }
}

