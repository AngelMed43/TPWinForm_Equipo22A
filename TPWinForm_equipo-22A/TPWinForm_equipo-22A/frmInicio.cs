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
using dominio;


namespace TPWinForm_equipo_22A
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            this.AutoScaleMode = AutoScaleMode.Font;
            this.MinimumSize = new Size(900, 600);
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterScreen;



            InitializeComponent();
            dgvArticulos.AutoGenerateColumns = false;
            pnlMain.Dock = DockStyle.Fill;
            ConfigurarFiltros();
            rdBFiltroXBuscar.Checked = true;
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
            bool esPestanaArticulos = (ObtenerPestanaActual() == "Articulos");

            grBBarraBusqueda.Visible = true;
            grBBarraBusqueda.Enabled = esPestanaArticulos;
            grBBarraBusqueda.BackColor = esPestanaArticulos
                ? SystemColors.Control
                : SystemColors.ControlLight;
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
            rdBFiltroXBuscar.CheckedChanged += ActualizarEstadoFiltrosAlCambiar;
            cboMarca.SelectedIndexChanged += cboMarca_SelectedIndexChanged;
            cboCategoria.SelectedIndexChanged += cboCategoria_SelectedIndexChanged;
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

        //Método que decide qué controles se pueden usar y cuáles se limpian según el filtro seleccionado.
        private void ActualizarEstadoFiltros()
        {
            bool filtroMarca = rdBFiltroXMarca.Checked;
            bool filtroCategoria = rdBFiltroXCategoria.Checked;
            bool filtroBuscar = rdBFiltroXBuscar.Checked;

            cboMarca.Enabled = filtroMarca;
            cboCategoria.Enabled = filtroCategoria;
            txtBBuscarSuperior.Enabled = filtroBuscar;

            if (!filtroMarca && cboMarca.SelectedIndex > 0)
                cboMarca.SelectedIndex = 0;

            if (!filtroCategoria && cboCategoria.SelectedIndex > 0)
                cboCategoria.SelectedIndex = 0;

            if (!filtroBuscar)
                txtBBuscarSuperior.Clear();

            AplicarFiltroSuperior();
        }

        private void btnNuevoArticulo_Click(object sender, EventArgs e)
        {
            string pestana = ObtenerPestanaActual();

            switch (pestana)
            {
                case "Articulos":
                    frmNuevoArticulo frmN = new frmNuevoArticulo();
                    frmN.FormClosed += (s,args) => cargarArticulos();
                    MostrarFormularioEnPanel(frmN);
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
                    if (dgvArticulos.CurrentRow == null)
                    {
                        MessageBox.Show("Debe seleccionar un articulo para modificar.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    Articulo artS = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    MostrarFormularioEnPanel(new frmModificarArticulo(this,artS));
                    break;
                case "Categorias":
                    MostrarFormularioEnPanel(new frmModificarCategoria());
                    break;
                case "Marcas":
                    if (dgvMarcas.CurrentRow == null)
                    {
                        MessageBox.Show("Debe seleccionar una marca para modificar.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    Marca seleccionada = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                    MostrarFormularioEnPanel(new frmNuevaMarca(this, seleccionada));
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

            DialogResult respuesta;

            if (pestana == "Articulos")
            {
                respuesta = MessageBox.Show("¿Está seguro que desea eliminar el artículo seleccionado?","Confirmar",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            }
            else if (pestana == "Marcas")
            {
                respuesta = MessageBox.Show("¿Está seguro que desea eliminar la marca seleccionada?","Confirmar",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            }
            else
            {
                respuesta = MessageBox.Show("¿Está seguro que desea eliminar la categoría seleccionada?","Confirmar",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            }

            if (respuesta != DialogResult.Yes)
                return;

            try
            {
                if (pestana == "Articulos")
                {
                    Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                    ArticuloNegocio artN = new ArticuloNegocio();
                    //Para chequear el guardado
                    //MessageBox.Show(seleccionado.Id.ToString());
                    artN.eliminarArticulo(seleccionado.Id);

                    cargarArticulos();
                }
                else if (pestana == "Marcas")
                {
                    MarcaNegocio negocio = new MarcaNegocio();
                    Marca seleccionada = (Marca)dgvMarcas.CurrentRow.DataBoundItem;

                    negocio.eliminar(seleccionada.IdMarca);

                    cargarListadoMarcas();
                }
                else if (pestana == "Categorias")
                {
                    // pendiente
                }

                MessageBox.Show("Eliminado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Limpia el TextBox de Precio Desde al hacer click
        private void txtBPrecioDesde_Click(object sender, EventArgs e)
        {
        }

        //Limpia el TextBox de Precio Hasta al hacer click
        private void txtBPrecioHasta_Click(object sender, EventArgs e)
        {
        }


        private void frmInicio_Load(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = splitContainer1.Width / 2;
            cargarListadoMarcas();
            cargarListadoCategorias();

            cargarArticulos();

            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Descripcion");
            cboCampo.Items.Add("Precio");

            CargarCombosFiltroSuperior();
        }

        private void CargarCombosFiltroSuperior()
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            List<Marca> marcas = marcaNegocio.listar();
            marcas.Insert(0, new Marca { IdMarca = 0, Descripcion = "Todas" });

            cboMarca.DataSource = marcas;
            cboMarca.DisplayMember = "Descripcion";
            cboMarca.ValueMember = "IdMarca";
            cboMarca.SelectedIndex = 0;

            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            List<Categoria> categorias = categoriaNegocio.listar();
            categorias.Insert(0, new Categoria { IdCategoria = 0, Descripcion = "Todas" });

            cboCategoria.DataSource = categorias;
            cboCategoria.DisplayMember = "Descripcion";
            cboCategoria.ValueMember = "IdCategoria";
            cboCategoria.SelectedIndex = 0;
        }

        public void cargarListadoMarcas()
        {
            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                dgvMarcas.AutoGenerateColumns = true;
                dgvMarcas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvMarcas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvMarcas.RowHeadersVisible = false;
                dgvMarcas.ReadOnly = true;
                dgvMarcas.AllowUserToAddRows = false;
                dgvMarcas.AllowUserToDeleteRows = false;
                dgvMarcas.BackgroundColor = SystemColors.AppWorkspace;
                dgvMarcas.DataSource = negocio.listar();

                if (dgvMarcas.Columns["IdMarca"] != null)
                    dgvMarcas.Columns["IdMarca"].Visible = false;
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

        private void cargarArticulos()
        {
            ArticuloNegocio artN = new ArticuloNegocio();

            try
            {
                dgvArticulos.AutoGenerateColumns = false;
                dgvArticulos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvArticulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvArticulos.RowHeadersVisible = false;
                dgvArticulos.ReadOnly = true;
                dgvArticulos.DataSource = artN.listarArticulos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtBBuscarSuperior_TextChanged(object sender, EventArgs e)
        {
            if (rdBFiltroXBuscar.Checked)
                AplicarFiltroSuperior();
        }

        private void cboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rdBFiltroXMarca.Checked)
                AplicarFiltroSuperior();
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rdBFiltroXCategoria.Checked)
                AplicarFiltroSuperior();
        }

        private void AplicarFiltroSuperior()
        {
            if (ObtenerPestanaActual() != "Articulos")
                return;

            dgvArticulos.AutoGenerateColumns = false;

            ArticuloNegocio artN = new ArticuloNegocio();
            List<Articulo> listaArticulos = artN.listarArticulos();
            List<Articulo> listaFiltrada = listaArticulos;

            if (rdBFiltroXMarca.Checked)
            {
                Marca marcaSeleccionada = cboMarca.SelectedItem as Marca;
                if (marcaSeleccionada != null && marcaSeleccionada.IdMarca > 0)
                    listaFiltrada = listaArticulos.FindAll(x => x.Marca != null && x.Marca.IdMarca == marcaSeleccionada.IdMarca);
            }
            else if (rdBFiltroXCategoria.Checked)
            {
                Categoria categoriaSeleccionada = cboCategoria.SelectedItem as Categoria;
                if (categoriaSeleccionada != null && categoriaSeleccionada.IdCategoria > 0)
                    listaFiltrada = listaArticulos.FindAll(x => x.Categoria != null && x.Categoria.IdCategoria == categoriaSeleccionada.IdCategoria);
            }
            else if (rdBFiltroXBuscar.Checked)
            {
                string filtro = txtBBuscarSuperior.Text;
                if (!string.IsNullOrWhiteSpace(filtro))
                {
                    listaFiltrada = listaArticulos.FindAll(x =>
                        x.Nombre.ToUpper().Contains(filtro.ToUpper()) ||
                        x.Descripcion.ToUpper().Contains(filtro.ToUpper()));
                }
            }

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
        }

        private bool ValidarBusquedaAvanzada()
        {
            if (cboCampo.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un campo para buscar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboCampo.Focus();
                return false;
            }

            if (cboCriterio.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un criterio para buscar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboCriterio.Focus();
                return false;
            }

            string filtro = txtBFiltro.Text.Trim();

            if (cboCampo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrWhiteSpace(filtro))
                {
                    MessageBox.Show("Debe completar el valor de filtro para Precio.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtBFiltro.Focus();
                    return false;
                }

                decimal valor;
                if (!decimal.TryParse(filtro, out valor))
                {
                    MessageBox.Show("Si el campo es Precio, el filtro debe ser numérico.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtBFiltro.Focus();
                    return false;
                }
            }

            return true;
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            if(opcion == "Precio")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }

            cboCriterio.SelectedIndex = -1;
        }

        private void btnBuscarArticulos_Click(object sender, EventArgs e)
        {
            if (!ValidarBusquedaAvanzada())
                return;

            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtBFiltro.Text.Trim();
                dgvArticulos.DataSource = negocio.filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
