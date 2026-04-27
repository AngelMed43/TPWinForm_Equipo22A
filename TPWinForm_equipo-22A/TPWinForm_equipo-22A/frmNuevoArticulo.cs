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
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_equipo_22A
{
    public partial class frmNuevoArticulo : Form
    {

        public Articulo articulo;
        private readonly string carpetaImagenes;
        public frmNuevoArticulo()
        {
            InitializeComponent();

            articulo = new Articulo();
            articulo.Imagenes = new List<Imagen>();
            string baseDocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            carpetaImagenes = Path.Combine(baseDocs, "Imagenes_APPGestion");
        }

        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool marcaSelected = cbMarca.SelectedItem != null;
            bool categoriaSelected = cbCategoria.SelectedItem != null;

            bool valido = Validaciones.ValidarArticulo(txtBCodigo.Text, txtBNombre.Text, marcaSelected, categoriaSelected, txtBPrecio.Text, string.Empty);

            if (!valido) return;

            ArticuloNegocio artN = new ArticuloNegocio();
            try
            {
                articulo.Codigo = txtBCodigo.Text.Trim();
                articulo.Nombre = txtBNombre.Text.Trim();
                articulo.Descripcion = txtBDescripcion.Text.Trim();
                articulo.Marca = (Marca)cbMarca.SelectedItem;
                articulo.Categoria = (Categoria)cbCategoria.SelectedItem;
                articulo.Precio = Validaciones.ParsearPrecio(txtBPrecio.Text);

                int idArticuloGenerado = artN.insertArticulo(articulo);

                foreach (Imagen img in articulo.Imagenes)
                    artN.agregarImagen(img, idArticuloGenerado);

                MessageBox.Show("Artículo guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void frmNuevoArticulo_Load(object sender, EventArgs e)
        {
            rbPorPC.Checked = true;
            txtUrlImagen.Enabled = false;


            MarcaNegocio marca = new MarcaNegocio();
            CategoriaNegocio categoria = new CategoriaNegocio();
            try
            {
                cbMarca.DataSource = marca.listar();
                // Lo que muestra en el Desplegable
                cbMarca.DisplayMember = "Descripcion";
                //Valor clave
                cbMarca.ValueMember = "IdMarca";
                // Para que no se seleccione alguna marca por defecto
                cbMarca.SelectedIndex = -1;

                cbCategoria.DataSource = categoria.listar();
                cbCategoria.DisplayMember = "Descripcion";
                cbCategoria.ValueMember = "IdCategoria";
                cbCategoria.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                // Por el momento
                // Por el momento
                // Por el momento
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnAddImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog archivo = new OpenFileDialog();
            archivo.Title = "Selecciona una Imagen";
            archivo.Filter = "Imagenes|*.jpg;*.png;*.jpeg";

            string ruta = "";
            string nombreArchivo;
            string destinoImagen;
            string baseDocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string carpeta = Path.Combine(baseDocs, "Imagenes_APPGestion");
            
            // SALTA ERROR por mas que cree una carpeta
            if (!Directory.Exists(carpeta))
                Directory.CreateDirectory(carpeta);
            try
            {
                if (rbPorUrl.Checked)
                {
                    if (string.IsNullOrWhiteSpace(txtUrlImagen.Text))
                    {
                        MessageBox.Show("Ingrese una URL!");
                        return;
                    }
                    

                    ruta = txtUrlImagen.Text;
                    //GUARDO la url de la imagen
                    articulo.Imagenes.Add(new Imagen { UrlImagen = ruta });
                    //AÑADO el archivo a la lista del frm
                    lbxImagenes.Items.Add(ruta);
                    //PREVISUALIZO
                    pbxImagen.LoadAsync(ruta);
                }
                else
                {
                    // CREO el filtro al abri la ventana de dialogo
                    

                    if (archivo.ShowDialog() != DialogResult.OK)
                        return;

                    ruta = archivo.FileName;
                    // PARA GUARDAR el nombre del archivo y no la ruta completa
                    nombreArchivo = Path.GetFileName(ruta);

                    // DONDE se guarda la imagen (admite portabilidad)
                    destinoImagen = Path.Combine(carpeta, nombreArchivo);
                    // COPIA la imagen en la carpeta
                    File.Copy(ruta, destinoImagen,true);
                    articulo.Imagenes.Add(new Imagen { UrlImagen = nombreArchivo });

                    lbxImagenes.Items.Add(nombreArchivo);
                    pbxImagen.ImageLocation = ruta;
                    //pbxImagen.Load(destinoImagen);
                }
                txtUrlImagen.Clear();
            }catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        private void lbxImagenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxImagenes.SelectedItem == null) return;


            string valor = lbxImagenes.SelectedItem.ToString();
            try
            {
                if (valor.StartsWith("http"))
                    pbxImagen.LoadAsync(valor);
                else
                    mostrarImagenLocal(Path.Combine(carpetaImagenes, valor));
            }
            catch
            {
                pbxImagen.Image = null;
            }
        }

        private void btnDeleteImagen_Click(object sender, EventArgs e)
        {
            if (lbxImagenes.SelectedIndex >= 0)
            {
                DialogResult resultado = MessageBox.Show("¿Seguro que desea eliminar la imagen seleccionada?","Confirmar eliminación",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    int index = lbxImagenes.SelectedIndex;
                    
                    lbxImagenes.Items.RemoveAt(index);
                    articulo.Imagenes.RemoveAt(index);
                    pbxImagen.Image = null;
                }
            }else{
                MessageBox.Show("Seleccione una imagen para eliminar.");
            }
        }

        private void rbPorUrl_CheckedChanged(object sender, EventArgs e)
        {
            txtUrlImagen.Enabled = rbPorUrl.Checked;
        }

        private void rbPorPC_CheckedChanged(object sender, EventArgs e)
        {
            txtUrlImagen.Enabled = false;
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
    }
}

