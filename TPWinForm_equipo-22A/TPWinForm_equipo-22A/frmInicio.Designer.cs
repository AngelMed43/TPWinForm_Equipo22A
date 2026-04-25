namespace TPWinForm_equipo_22A
{
    partial class frmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.stsInferior = new System.Windows.Forms.StatusStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsSuperior = new System.Windows.Forms.ToolStrip();
            this.txtBBuscarSuperior = new System.Windows.Forms.TextBox();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.txtBPrecioDesde = new System.Windows.Forms.TextBox();
            this.lblFiltroMarca = new System.Windows.Forms.Label();
            this.rdBFiltroXMarca = new System.Windows.Forms.RadioButton();
            this.lblFiltroEstado = new System.Windows.Forms.Label();
            this.rdBFiltroXCategoria = new System.Windows.Forms.RadioButton();
            this.rdBFiltroXPrecio = new System.Windows.Forms.RadioButton();
            this.rdBFiltroXBuscar = new System.Windows.Forms.RadioButton();
            this.txtBPrecioHasta = new System.Windows.Forms.TextBox();
            this.grBBarraBusqueda = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tcMenu = new System.Windows.Forms.TabControl();
            this.Articulos = new System.Windows.Forms.TabPage();
            this.grpBListaArticulo = new System.Windows.Forms.GroupBox();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marcas = new System.Windows.Forms.TabPage();
            this.grpBListaMarcas = new System.Windows.Forms.GroupBox();
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.Categorias = new System.Windows.Forms.TabPage();
            this.grpCategorias = new System.Windows.Forms.GroupBox();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grpBUniversal = new System.Windows.Forms.GroupBox();
            this.pnlUniversal = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnNuevoArticulo = new System.Windows.Forms.Button();
            this.btnEliminarArticulo = new System.Windows.Forms.Button();
            this.btnModificarArticulo = new System.Windows.Forms.Button();
            this.btnDetallesArticulo = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tlsSuperior.SuspendLayout();
            this.grBBarraBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tcMenu.SuspendLayout();
            this.Articulos.SuspendLayout();
            this.grpBListaArticulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.Marcas.SuspendLayout();
            this.grpBListaMarcas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.Categorias.SuspendLayout();
            this.grpCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.panel2.SuspendLayout();
            this.grpBUniversal.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // stsInferior
            // 
            this.stsInferior.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.stsInferior.Location = new System.Drawing.Point(0, 659);
            this.stsInferior.Name = "stsInferior";
            this.stsInferior.Padding = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.stsInferior.Size = new System.Drawing.Size(1264, 22);
            this.stsInferior.TabIndex = 6;
            this.stsInferior.Text = "statusStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tlsSuperior
            // 
            this.tlsSuperior.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tlsSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripSeparator2});
            this.tlsSuperior.Location = new System.Drawing.Point(0, 0);
            this.tlsSuperior.Name = "tlsSuperior";
            this.tlsSuperior.Padding = new System.Windows.Forms.Padding(0);
            this.tlsSuperior.Size = new System.Drawing.Size(1264, 25);
            this.tlsSuperior.TabIndex = 2;
            this.tlsSuperior.Text = "toolStrip1";
            // 
            // txtBBuscarSuperior
            // 
            this.txtBBuscarSuperior.Location = new System.Drawing.Point(497, 37);
            this.txtBBuscarSuperior.Margin = new System.Windows.Forms.Padding(2);
            this.txtBBuscarSuperior.Name = "txtBBuscarSuperior";
            this.txtBBuscarSuperior.Size = new System.Drawing.Size(141, 20);
            this.txtBBuscarSuperior.TabIndex = 4;
            // 
            // cboMarca
            // 
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(9, 35);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(121, 21);
            this.cboMarca.TabIndex = 0;
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(153, 35);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(121, 21);
            this.cboCategoria.TabIndex = 1;
            // 
            // txtBPrecioDesde
            // 
            this.txtBPrecioDesde.Location = new System.Drawing.Point(299, 36);
            this.txtBPrecioDesde.Name = "txtBPrecioDesde";
            this.txtBPrecioDesde.Size = new System.Drawing.Size(82, 20);
            this.txtBPrecioDesde.TabIndex = 2;
            this.txtBPrecioDesde.Text = "Desde:";
            this.txtBPrecioDesde.Click += new System.EventHandler(this.txtBPrecioDesde_Click);
            // 
            // lblFiltroMarca
            // 
            this.lblFiltroMarca.AutoSize = true;
            this.lblFiltroMarca.Location = new System.Drawing.Point(29, 16);
            this.lblFiltroMarca.Name = "lblFiltroMarca";
            this.lblFiltroMarca.Size = new System.Drawing.Size(0, 13);
            this.lblFiltroMarca.TabIndex = 3;
            // 
            // rdBFiltroXMarca
            // 
            this.rdBFiltroXMarca.AutoSize = true;
            this.rdBFiltroXMarca.Location = new System.Drawing.Point(9, 16);
            this.rdBFiltroXMarca.Name = "rdBFiltroXMarca";
            this.rdBFiltroXMarca.Size = new System.Drawing.Size(55, 17);
            this.rdBFiltroXMarca.TabIndex = 6;
            this.rdBFiltroXMarca.TabStop = true;
            this.rdBFiltroXMarca.Text = "Marca";
            this.rdBFiltroXMarca.UseVisualStyleBackColor = true;
            // 
            // lblFiltroEstado
            // 
            this.lblFiltroEstado.AutoSize = true;
            this.lblFiltroEstado.Location = new System.Drawing.Point(438, 16);
            this.lblFiltroEstado.Name = "lblFiltroEstado";
            this.lblFiltroEstado.Size = new System.Drawing.Size(0, 13);
            this.lblFiltroEstado.TabIndex = 7;
            // 
            // rdBFiltroXCategoria
            // 
            this.rdBFiltroXCategoria.AutoSize = true;
            this.rdBFiltroXCategoria.Location = new System.Drawing.Point(153, 15);
            this.rdBFiltroXCategoria.Name = "rdBFiltroXCategoria";
            this.rdBFiltroXCategoria.Size = new System.Drawing.Size(70, 17);
            this.rdBFiltroXCategoria.TabIndex = 8;
            this.rdBFiltroXCategoria.TabStop = true;
            this.rdBFiltroXCategoria.Text = "Categoria";
            this.rdBFiltroXCategoria.UseVisualStyleBackColor = true;
            // 
            // rdBFiltroXPrecio
            // 
            this.rdBFiltroXPrecio.AutoSize = true;
            this.rdBFiltroXPrecio.Location = new System.Drawing.Point(300, 14);
            this.rdBFiltroXPrecio.Name = "rdBFiltroXPrecio";
            this.rdBFiltroXPrecio.Size = new System.Drawing.Size(55, 17);
            this.rdBFiltroXPrecio.TabIndex = 9;
            this.rdBFiltroXPrecio.TabStop = true;
            this.rdBFiltroXPrecio.Text = "Precio";
            this.rdBFiltroXPrecio.UseVisualStyleBackColor = true;
            // 
            // rdBFiltroXBuscar
            // 
            this.rdBFiltroXBuscar.AutoSize = true;
            this.rdBFiltroXBuscar.Location = new System.Drawing.Point(497, 14);
            this.rdBFiltroXBuscar.Name = "rdBFiltroXBuscar";
            this.rdBFiltroXBuscar.Size = new System.Drawing.Size(58, 17);
            this.rdBFiltroXBuscar.TabIndex = 11;
            this.rdBFiltroXBuscar.TabStop = true;
            this.rdBFiltroXBuscar.Text = "Buscar";
            this.rdBFiltroXBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBPrecioHasta
            // 
            this.txtBPrecioHasta.Location = new System.Drawing.Point(389, 36);
            this.txtBPrecioHasta.Name = "txtBPrecioHasta";
            this.txtBPrecioHasta.Size = new System.Drawing.Size(82, 20);
            this.txtBPrecioHasta.TabIndex = 10;
            this.txtBPrecioHasta.Text = "Hasta:";
            this.txtBPrecioHasta.Click += new System.EventHandler(this.txtBPrecioHasta_Click);
            // 
            // grBBarraBusqueda
            // 
            this.grBBarraBusqueda.Controls.Add(this.txtBPrecioHasta);
            this.grBBarraBusqueda.Controls.Add(this.rdBFiltroXBuscar);
            this.grBBarraBusqueda.Controls.Add(this.rdBFiltroXPrecio);
            this.grBBarraBusqueda.Controls.Add(this.rdBFiltroXCategoria);
            this.grBBarraBusqueda.Controls.Add(this.lblFiltroEstado);
            this.grBBarraBusqueda.Controls.Add(this.txtBBuscarSuperior);
            this.grBBarraBusqueda.Controls.Add(this.rdBFiltroXMarca);
            this.grBBarraBusqueda.Controls.Add(this.lblFiltroMarca);
            this.grBBarraBusqueda.Controls.Add(this.txtBPrecioDesde);
            this.grBBarraBusqueda.Controls.Add(this.cboCategoria);
            this.grBBarraBusqueda.Controls.Add(this.cboMarca);
            this.grBBarraBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.grBBarraBusqueda.Location = new System.Drawing.Point(0, 25);
            this.grBBarraBusqueda.Name = "grBBarraBusqueda";
            this.grBBarraBusqueda.Size = new System.Drawing.Size(1264, 62);
            this.grBBarraBusqueda.TabIndex = 7;
            this.grBBarraBusqueda.TabStop = false;
            this.grBBarraBusqueda.Text = "Filtrar Articulos";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AccessibleDescription = "scpnl1";
            this.splitContainer1.Panel1.Controls.Add(this.tcMenu);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AccessibleDescription = "scpnl2";
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1264, 572);
            this.splitContainer1.SplitterDistance = 550;
            this.splitContainer1.TabIndex = 13;
            // 
            // tcMenu
            // 
            this.tcMenu.Controls.Add(this.Articulos);
            this.tcMenu.Controls.Add(this.Marcas);
            this.tcMenu.Controls.Add(this.Categorias);
            this.tcMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMenu.Location = new System.Drawing.Point(0, 0);
            this.tcMenu.Margin = new System.Windows.Forms.Padding(2);
            this.tcMenu.Name = "tcMenu";
            this.tcMenu.SelectedIndex = 0;
            this.tcMenu.Size = new System.Drawing.Size(550, 572);
            this.tcMenu.TabIndex = 5;
            this.tcMenu.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Articulos
            // 
            this.Articulos.Controls.Add(this.grpBListaArticulo);
            this.Articulos.Location = new System.Drawing.Point(4, 22);
            this.Articulos.Margin = new System.Windows.Forms.Padding(2);
            this.Articulos.Name = "Articulos";
            this.Articulos.Padding = new System.Windows.Forms.Padding(2);
            this.Articulos.Size = new System.Drawing.Size(542, 546);
            this.Articulos.TabIndex = 0;
            this.Articulos.Text = "Articulos";
            this.Articulos.UseVisualStyleBackColor = true;
            // 
            // grpBListaArticulo
            // 
            this.grpBListaArticulo.Controls.Add(this.dgvArticulos);
            this.grpBListaArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBListaArticulo.Location = new System.Drawing.Point(2, 2);
            this.grpBListaArticulo.Name = "grpBListaArticulo";
            this.grpBListaArticulo.Size = new System.Drawing.Size(538, 542);
            this.grpBListaArticulo.TabIndex = 0;
            this.grpBListaArticulo.TabStop = false;
            this.grpBListaArticulo.Text = "Listado de Articulos";
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToAddRows = false;
            this.dgvArticulos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.NullValue = "0";
            this.dgvArticulos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Nombre,
            this.Descripción,
            this.Precio});
            this.dgvArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvArticulos.Location = new System.Drawing.Point(3, 16);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.RowHeadersWidth = 82;
            this.dgvArticulos.RowTemplate.Height = 33;
            this.dgvArticulos.Size = new System.Drawing.Size(532, 523);
            this.dgvArticulos.TabIndex = 0;
            // 
            // Código
            // 
            this.Código.DataPropertyName = "Codigo";
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            this.Código.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Descripción
            // 
            this.Descripción.DataPropertyName = "Descripcion";
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.Name = "Descripción";
            this.Descripción.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Marcas
            // 
            this.Marcas.Controls.Add(this.grpBListaMarcas);
            this.Marcas.Location = new System.Drawing.Point(4, 22);
            this.Marcas.Margin = new System.Windows.Forms.Padding(2);
            this.Marcas.Name = "Marcas";
            this.Marcas.Padding = new System.Windows.Forms.Padding(2);
            this.Marcas.Size = new System.Drawing.Size(542, 546);
            this.Marcas.TabIndex = 1;
            this.Marcas.Text = "Marcas";
            this.Marcas.UseVisualStyleBackColor = true;
            // 
            // grpBListaMarcas
            // 
            this.grpBListaMarcas.Controls.Add(this.dgvMarcas);
            this.grpBListaMarcas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBListaMarcas.Location = new System.Drawing.Point(2, 2);
            this.grpBListaMarcas.Name = "grpBListaMarcas";
            this.grpBListaMarcas.Size = new System.Drawing.Size(538, 542);
            this.grpBListaMarcas.TabIndex = 0;
            this.grpBListaMarcas.TabStop = false;
            this.grpBListaMarcas.Text = "Listado de Marcas";
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMarcas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMarcas.Location = new System.Drawing.Point(3, 16);
            this.dgvMarcas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.RowHeadersWidth = 82;
            this.dgvMarcas.RowTemplate.Height = 33;
            this.dgvMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarcas.Size = new System.Drawing.Size(532, 523);
            this.dgvMarcas.TabIndex = 1;
            // 
            // Categorias
            // 
            this.Categorias.Controls.Add(this.grpCategorias);
            this.Categorias.Location = new System.Drawing.Point(4, 22);
            this.Categorias.Margin = new System.Windows.Forms.Padding(2);
            this.Categorias.Name = "Categorias";
            this.Categorias.Size = new System.Drawing.Size(542, 546);
            this.Categorias.TabIndex = 2;
            this.Categorias.Text = "Categorias";
            this.Categorias.UseVisualStyleBackColor = true;
            // 
            // grpCategorias
            // 
            this.grpCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCategorias.Controls.Add(this.dgvCategorias);
            this.grpCategorias.Location = new System.Drawing.Point(5, 5);
            this.grpCategorias.Name = "grpCategorias";
            this.grpCategorias.Size = new System.Drawing.Size(284, 494);
            this.grpCategorias.TabIndex = 1;
            this.grpCategorias.TabStop = false;
            this.grpCategorias.Text = "Listado de Categorias";
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Location = new System.Drawing.Point(5, 18);
            this.dgvCategorias.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.RowHeadersWidth = 82;
            this.dgvCategorias.RowTemplate.Height = 33;
            this.dgvCategorias.Size = new System.Drawing.Size(274, 471);
            this.dgvCategorias.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grpBUniversal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(84, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(626, 572);
            this.panel2.TabIndex = 14;
            // 
            // grpBUniversal
            // 
            this.grpBUniversal.Controls.Add(this.pnlUniversal);
            this.grpBUniversal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBUniversal.Location = new System.Drawing.Point(0, 0);
            this.grpBUniversal.Name = "grpBUniversal";
            this.grpBUniversal.Size = new System.Drawing.Size(626, 572);
            this.grpBUniversal.TabIndex = 12;
            this.grpBUniversal.TabStop = false;
            // 
            // pnlUniversal
            // 
            this.pnlUniversal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUniversal.Location = new System.Drawing.Point(3, 16);
            this.pnlUniversal.Name = "pnlUniversal";
            this.pnlUniversal.Size = new System.Drawing.Size(620, 553);
            this.pnlUniversal.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbLogo);
            this.panel1.Controls.Add(this.btnNuevoArticulo);
            this.panel1.Controls.Add(this.btnEliminarArticulo);
            this.panel1.Controls.Add(this.btnModificarArticulo);
            this.panel1.Controls.Add(this.btnDetallesArticulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(84, 572);
            this.panel1.TabIndex = 13;
            // 
            // pbLogo
            // 
            this.pbLogo.AccessibleName = "pbLogo";
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbLogo.Image = global::TPWinForm_equipo_22A.Properties.Resources.handle_with_care_100;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(84, 85);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // btnNuevoArticulo
            // 
            this.btnNuevoArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevoArticulo.Location = new System.Drawing.Point(3, 159);
            this.btnNuevoArticulo.Name = "btnNuevoArticulo";
            this.btnNuevoArticulo.Size = new System.Drawing.Size(78, 24);
            this.btnNuevoArticulo.TabIndex = 8;
            this.btnNuevoArticulo.Text = "Nuevo";
            this.btnNuevoArticulo.UseVisualStyleBackColor = true;
            this.btnNuevoArticulo.Click += new System.EventHandler(this.btnNuevoArticulo_Click);
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarArticulo.Location = new System.Drawing.Point(3, 306);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(78, 24);
            this.btnEliminarArticulo.TabIndex = 11;
            this.btnEliminarArticulo.Text = "Eliminar";
            this.btnEliminarArticulo.UseVisualStyleBackColor = true;
            this.btnEliminarArticulo.Click += new System.EventHandler(this.btnEliminarArticulo_Click);
            // 
            // btnModificarArticulo
            // 
            this.btnModificarArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarArticulo.Location = new System.Drawing.Point(3, 213);
            this.btnModificarArticulo.Name = "btnModificarArticulo";
            this.btnModificarArticulo.Size = new System.Drawing.Size(78, 24);
            this.btnModificarArticulo.TabIndex = 9;
            this.btnModificarArticulo.Text = "Modificar";
            this.btnModificarArticulo.UseVisualStyleBackColor = true;
            this.btnModificarArticulo.Click += new System.EventHandler(this.btnModificarArticulo_Click);
            // 
            // btnDetallesArticulo
            // 
            this.btnDetallesArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetallesArticulo.Location = new System.Drawing.Point(3, 252);
            this.btnDetallesArticulo.Name = "btnDetallesArticulo";
            this.btnDetallesArticulo.Size = new System.Drawing.Size(78, 24);
            this.btnDetallesArticulo.TabIndex = 10;
            this.btnDetallesArticulo.Text = "Detalles";
            this.btnDetallesArticulo.UseVisualStyleBackColor = true;
            this.btnDetallesArticulo.Click += new System.EventHandler(this.btnDetallesArticulo_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.splitContainer1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 87);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1264, 572);
            this.pnlMain.TabIndex = 13;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.grBBarraBusqueda);
            this.Controls.Add(this.stsInferior);
            this.Controls.Add(this.tlsSuperior);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(962, 539);
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicacion de gestion";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.tlsSuperior.ResumeLayout(false);
            this.tlsSuperior.PerformLayout();
            this.grBBarraBusqueda.ResumeLayout(false);
            this.grBBarraBusqueda.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tcMenu.ResumeLayout(false);
            this.Articulos.ResumeLayout(false);
            this.grpBListaArticulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.Marcas.ResumeLayout(false);
            this.grpBListaMarcas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.Categorias.ResumeLayout(false);
            this.grpCategorias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.panel2.ResumeLayout(false);
            this.grpBUniversal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip stsInferior;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStrip tlsSuperior;
        private System.Windows.Forms.TextBox txtBBuscarSuperior;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.TextBox txtBPrecioDesde;
        private System.Windows.Forms.Label lblFiltroMarca;
        private System.Windows.Forms.RadioButton rdBFiltroXMarca;
        private System.Windows.Forms.Label lblFiltroEstado;
        private System.Windows.Forms.RadioButton rdBFiltroXCategoria;
        private System.Windows.Forms.RadioButton rdBFiltroXPrecio;
        private System.Windows.Forms.RadioButton rdBFiltroXBuscar;
        private System.Windows.Forms.TextBox txtBPrecioHasta;
        private System.Windows.Forms.GroupBox grBBarraBusqueda;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tcMenu;
        private System.Windows.Forms.TabPage Articulos;
        private System.Windows.Forms.GroupBox grpBListaArticulo;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.TabPage Marcas;
        private System.Windows.Forms.GroupBox grpBListaMarcas;
        private System.Windows.Forms.DataGridView dgvMarcas;
        private System.Windows.Forms.TabPage Categorias;
        private System.Windows.Forms.GroupBox grpCategorias;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox grpBUniversal;
        private System.Windows.Forms.Panel pnlUniversal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNuevoArticulo;
        private System.Windows.Forms.Button btnEliminarArticulo;
        private System.Windows.Forms.Button btnModificarArticulo;
        private System.Windows.Forms.Button btnDetallesArticulo;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}


