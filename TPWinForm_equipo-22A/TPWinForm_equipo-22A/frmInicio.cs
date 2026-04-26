using Conexion_BDD;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_equipo_22A
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.MinimumSize = new Size(900, 600);
            this.StartPosition = FormStartPosition.CenterScreen;



            InitializeComponent();
            pnlMain.Dock = DockStyle.Fill;
            ConfigurarFiltros();
            ActualizarEstadoFiltros();
            ActualizarBotonesPorPestana();
            ActualizarVisibilidadBarraBusqueda();
        }

        private string ObtenerPestanaActual()
        {
            return tcMenu.SelectedTab != null ? tcMenu.SelectedTab.Name : string.Empty;
        }

        private void ActualizarVisibilidadBarraBusqueda()
        {
            grBBarraBusqueda.Visible = (ObtenerPestanaActual() == "Articulos");
        }

        private void LimpiarPanelUniversal()
        {
            while (pnlUniversal.Controls.Count > 0)
            {
                Control control = pnlUniversal.Controls[0];
                pnlUniversal.Controls.RemoveAt(0);
                control.Dispose();
            }
        }

        private void MostrarFormularioEnPanel(Form formulario)
        {
            LimpiarPanelUniversal();

            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill;

            pnlUniversal.Controls.Add(formulario);
            formulario.Show();
        }

        private void ActualizarBotonesPorPestana()
        {
            string pestana = ObtenerPestanaActual();

            btnNuevoArticulo.Visible = true;
            btnModificarArticulo.Visible = true;
            btnEliminarArticulo.Visible = true;
            btnDetallesArticulo.Visible = (pestana == "Articulos");
        }

        // Asocia los RadioButton de filtro a un mismo evento,
        // para actualizar qué controles quedan habilitados.
        private void ConfigurarFiltros()
        {
            rdBFiltroXMarca.CheckedChanged += ActualizarEstadoFiltrosAlCambiar;
            rdBFiltroXCategoria.CheckedChanged += ActualizarEstadoFiltrosAlCambiar;
            rdBFiltroXPrecio.CheckedChanged += ActualizarEstadoFiltrosAlCambiar;
        }

        //Detecta qué filtro quedó activo y actualiza la interfaz.
        private void ActualizarEstadoFiltrosAlCambiar(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb != null && rb.Checked)
            {
                ActualizarEstadoFiltros();
            }
        }

        private void MostrarTextoGuiaPrecio()
        {
            if (string.IsNullOrWhiteSpace(txtBPrecioDesde.Text))
                txtBPrecioDesde.Text = "Desde:";

            if (string.IsNullOrWhiteSpace(txtBPrecioHasta.Text))
                txtBPrecioHasta.Text = "Hasta:";
        }

        //Método que decide qué controles se pueden usar y cuáles se limpian según el filtro seleccionado.
        private void ActualizarEstadoFiltros()
        {
            bool filtroMarca = rdBFiltroXMarca.Checked;
            bool filtroCategoria = rdBFiltroXCategoria.Checked;
            bool filtroPrecio = rdBFiltroXPrecio.Checked;

            cboMarca.Enabled = filtroMarca;
            cboCategoria.Enabled = filtroCategoria;
            txtBPrecioDesde.Enabled = filtroPrecio;
            txtBPrecioHasta.Enabled = filtroPrecio;

            if (!filtroMarca)
                cboMarca.SelectedIndex = -1;

            if (!filtroCategoria)
                cboCategoria.SelectedIndex = -1;

            if (filtroPrecio)
            {
                MostrarTextoGuiaPrecio();
            }
            else
            {
                txtBPrecioDesde.Clear();
                txtBPrecioHasta.Clear();
            }
        }

        private void btnNuevoArticulo_Click(object sender, EventArgs e)
        {
            string pestana = ObtenerPestanaActual();

            switch (pestana)
            {
                case "Articulos":
                    MostrarFormularioEnPanel(new frmNuevoArticulo());
                    break;
                case "Marcas":
                    MostrarFormularioEnPanel(new frmNuevaMarca(this));
                    break;
                case "Categorias":
                    MostrarFormularioEnPanel(new frmNuevaCategoria(this));
                    break;
            }
        }

        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {
            string pestana = ObtenerPestanaActual();

            switch (pestana)
            {
                case "Articulos":
                    MostrarFormularioEnPanel(new frmModificarArticulo());
                    break;
                case "Categorias":
                    MostrarFormularioEnPanel(new frmModificarCategoria());
                    break;
                case "Marcas":
                    MostrarFormularioEnPanel(new frmModificarMarca());
                    break;
            }
        }
        private void btnDetallesArticulo_Click(object sender, EventArgs e)
        {
            MostrarFormularioEnPanel(new frmDetalleArticulo());
        }

        //Metodo que modifica atributos del Form inicio depende en que pestaña estemos situados
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimpiarPanelUniversal();
            ActualizarBotonesPorPestana();
            ActualizarVisibilidadBarraBusqueda();
        }

        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            string pestana = ObtenerPestanaActual();

            if (pestana == "Articulos" && dgvArticulos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un artículo para eliminar.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (pestana == "Marcas" && dgvMarcas.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una marca para eliminar.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (pestana == "Categorias" && dgvCategorias.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una categoria para eliminar.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (pestana == "Articulos")
            {
                MessageBox.Show("¿Está seguro que desea eliminar el artículo seleccionado?", "Mensaje de Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }
            else if (pestana == "Marcas")
            {
                MessageBox.Show("¿Está seguro que desea eliminar la marca seleccionada?", "Mensaje de Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }
            else if (pestana == "Categorias")
            {
                MessageBox.Show("¿Está seguro que desea eliminar la categoria seleccionada?", "Mensaje de Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }

            // Lógica para eliminar
        }

        //Limpia el TextBox de Precio Desde al hacer click
        private void txtBPrecioDesde_Click(object sender, EventArgs e)
        {
            if (txtBPrecioDesde.Text == "Desde:")
            {
                txtBPrecioDesde.Clear();
            }
        }

        //Limpia el TextBox de Precio Hasta al hacer click
        private void txtBPrecioHasta_Click(object sender, EventArgs e)
        {
            if (txtBPrecioHasta.Text == "Hasta:")
            {
                txtBPrecioHasta.Clear();
            }
        }


        private void frmInicio_Load(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = splitContainer1.Width / 2;
            cargarListadoMarcas();
            cargarListadoCategorias();
           
        }

        public void cargarListadoMarcas()
        {
            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                dgvMarcas.DataSource = negocio.listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void cargarListadoCategorias()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                dgvCategorias.DataSource = negocio.listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmInicio_Resize(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = splitContainer1.Width / 2;
        }
    }
}
