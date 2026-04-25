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
        public frmNuevoArticulo()
        {
            InitializeComponent();

            articulo = new Articulo();
            articulo.Imagenes = new List<Imagen>();
            //txtBCódigo.Focus(); ----- No funciona.
        }

        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            ArticuloNegocio artN= new ArticuloNegocio();

            try
            {
                articulo.Codigo = txtBCodigo.Text;
                articulo.Nombre = txtBNombre.Text;
                articulo.Descripcion = txtBDescripcion.Text;
                articulo.Marca= (Marca)cbMarca.SelectedItem;
                articulo.Categoria = (Categoria)cbCategoria.SelectedItem;
                articulo.Precio = decimal.Parse(txtBPrecio.Text);


                artN.insertArticulo(articulo);
                foreach (Imagen img in articulo.Imagenes)
                {
                    artN.agregarImagen(img, articulo.Id);
                }

                MessageBox.Show("Artículo guardado correctamente");
                
                this.Close();
            }
            catch (Exception ex)
            {
                // Por el momento
                // Por el momento
                // Por el momento
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmNuevoArticulo_Load(object sender, EventArgs e)
        {
            //NO ES ASI YA QUE QUIERO MOSTRAR MARCAS Y CATEGORIAS
            //NO ES ASI YA QUE QUIERO MOSTRAR MARCAS Y CATEGORIAS
            //NO ES ASI YA QUE QUIERO MOSTRAR MARCAS Y CATEGORIAS
            /*
            ArticuloNegocio artN = new ArticuloNegocio();

            try
            {
                cbMarca.DataSource = artN.listarArticulos();
                cbCategoria.DataSource = artN.listarArticulos();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            */
            rbPorPC.Checked = true;
            txtUrlImagen.Enabled = false;


            MarcaNegocio marca = new MarcaNegocio();

            try
            {
                cbMarca.DataSource = marca.listar();
                cbMarca.DisplayMember = "Descripcion";
                cbMarca.ValueMember = "IdMarca";
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
            
            string ruta = "";
            string nombreArchivo;
            string destinoImagen;
            string carpeta = Path.Combine(Application.StartupPath, "Imagenes");
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
                    archivo.Filter = "Imagenes|*.jpg;*.png;*.jpeg";

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
                    pbxImagen.Load(destinoImagen);
                }
                txtUrlImagen.Clear();
            }catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        private void lbxImagenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valor;
            string carpeta = Path.Combine(Application.StartupPath, "Imagenes");
            string rutaCompleta;

            if (lbxImagenes.SelectedItem != null)
            {
                 valor = lbxImagenes.SelectedItem.ToString();

                try
                {
                    if (valor.StartsWith("http"))
                    {
                        pbxImagen.LoadAsync(valor);
                    }
                    else{
                        // HAGO ESTO porque sino,no me visualiza las fotos, ya que las listo con otro nombre
                        rutaCompleta = Path.Combine(carpeta, valor);
                        pbxImagen.Load(rutaCompleta);
                    }
                }
                catch
                {
                    pbxImagen.Image = null;
                }
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
    }
}

